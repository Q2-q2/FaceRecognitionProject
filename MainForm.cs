using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum; // Ensure this namespace is imported
using System.IO;
using System.Threading.Tasks;
using Bunifu.UI.WinForms;
using System.Linq;
using Newtonsoft.Json;
using System.Media;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using System.Reflection;
using Newtonsoft.Json.Linq;
using Telegram.Bot.Polling;
using System.Threading;
using Telegram.Bot.Exceptions;
using MultiFaceRec.Properties;
using Bunifu.UI.WinForms.BunifuButton;
using Bunifu.UI.WinForms.Renderers.Snackbar;

namespace MultiFaceRec
{
    public partial class FrmPrincipal : Form
    {

        private Image<Bgr, byte> _currentFrame;
        private Capture _grabber;
        private HaarCascade _faceCascade;
        private MCvFont _font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);

        private Image<Gray, byte> _result, _trainedFace;
        private Image<Gray, byte> _grayFrame;

        private List<Image<Gray, byte>> _trainingImages = new List<Image<Gray, byte>>();
        private List<string> _labels = new List<string>();
        private List<string> _namePersons = new List<string>();

        private int _contTrain, _numLabels, _t;
        private string _name, _names;
        private bool _isProcessingFrame = false;
        private bool _isCameraOn = false;

        bool sidebarExpand = true;

        public static string appPath = AppDomain.CurrentDomain.BaseDirectory;

        private struct LogEntry
        {
            public DateTime Timestamp;
            public string RecognizedPerson;
            public string ImagePath;
        }

        private List<LogEntry> _logEntries = new List<LogEntry>();
        private List<LogEntry> _filteredLogEntries = new List<LogEntry>();
        private bool _isFiltered = false;

        private string settingsFilePath = Path.Combine(Application.StartupPath, "settings.json");

        private TelegramBotClient Bot;
        private static readonly string Token = "6834231088:AAFU5qWJfveGrt9DImqGU1DI9rp_JTGrgMo"; // Замените на ваш токен

        public FrmPrincipal()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            InitializeHaarCascades();
            LoadTrainingData();

            // Подключаем событие ValueChanged для DatePicker
            journalUserControl1.DatePicker.ValueChanged += DatePicker_ValueChanged;

            // Подключаем обработчик событий SelectedIndexChanged для LogListBox
            InitializeJournalUserControl();

            // Создаем каталог для текущего дня, если он еще не был создан
            CreateDailyPhotoDirectory();
            LoadSettings();

            InitializeTelegramBot();

        }

        private void InitializeHaarCascades()
        {
            _faceCascade = new HaarCascade("haarcascade_frontalface_default.xml");
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            CleanTrainedLabelsFile();
            SaveLogEntries();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CleanTrainedLabelsFile();
            LoadLogEntries();
            RefreshLogs();
            InitializeSounds(appPath);
            FillComboBoxWithTrainedFaces();
        }

        private void CreateDailyPhotoDirectory()
        {
            string dailyDirPath = Path.Combine(Application.StartupPath, "savedPhotos", DateTime.Now.ToString("yyyy-MM-dd"));
            if (!Directory.Exists(dailyDirPath))
            {
                Directory.CreateDirectory(dailyDirPath);
            }
        }

        private void InitializeJournalUserControl()
        {
            journalUserControl1.AddLogDataGridViewCellClickEventHandler(LogDataGridViewCellClick);
            journalUserControl1.AddDatePickerValueChangedEventHandler(DatePickerValueChanged);
        }
        private void LogDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var logEntriesToUse = _isFiltered ? _filteredLogEntries : _logEntries;
                if (e.RowIndex < logEntriesToUse.Count)
                {
                    var selectedLogEntry = logEntriesToUse[e.RowIndex];
                    if (!string.IsNullOrEmpty(selectedLogEntry.ImagePath))
                    {
                        try
                        {
                            var img = new Emgu.CV.Image<Bgr, Byte>(selectedLogEntry.ImagePath);
                            journalUserControl1.LogImageBox.Image = img;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading image: {ex.Message}");
                        }
                    }
                    else
                    {
                        journalUserControl1.LogImageBox.Image = null;
                    }
                }
            }
        }
        public void RefreshLogs()
        {
            journalUserControl1.LogDataGrid.Rows.Clear();
            foreach (var entry in _logEntries)
            {
                journalUserControl1.LogDataGrid.Rows.Add(entry.Timestamp.ToString("HH:mm:ss"), entry.RecognizedPerson);
            }
            _isFiltered = false;
        }
        private void DatePickerValueChanged(object sender, EventArgs e)
        {
            // Обработка изменения даты в DatePicker в JournalUserControl
            FilterLogsByDate();
        }
        private void LoadLogEntries()
        {
            var logFilePath = Path.Combine(Application.StartupPath, "logEntries.txt");
            if (System.IO.File.Exists(logFilePath))
            {
                _logEntries.Clear(); // Очистка списка перед загрузкой
                var lines = System.IO.File.ReadAllLines(logFilePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(','); // Используем точку с запятой в качестве разделителя
                    if (parts.Length == 3)
                    {
                        var timestamp = DateTime.Parse(parts[0]);
                        var recognizedPerson = parts[1].Trim(); // Убираем лишние пробелы
                        var imagePath = parts[2].Trim(); // Убираем лишние пробелы
                        _logEntries.Add(new LogEntry { Timestamp = timestamp, RecognizedPerson = recognizedPerson, ImagePath = imagePath });
                    }
                }
                // Display the log entries
                DisplayLogEntries();
            }
        }

        private void SaveLogEntries()
        {
            var logFilePath = Path.Combine(Application.StartupPath, "logEntries.txt");

            using (var writer = new StreamWriter(logFilePath))
            {
                foreach (var entry in _logEntries)
                {
                    string logLine = $"{entry.Timestamp:yyyy-MM-dd HH:mm:ss},{entry.RecognizedPerson.Trim()},{entry.ImagePath}";
                    writer.WriteLine(logLine);
                }
            }
        }

        private void CleanTrainedLabelsFile()
        {
            var trainedLabelsPath = Path.Combine(Application.StartupPath, "TrainedFaces", "TrainedLabels.txt");

            // Проверяем, существует ли файл
            if (!System.IO.File.Exists(trainedLabelsPath))
            {
                return;
            }

            // Читаем все строки из файла
            var lines = System.IO.File.ReadAllLines(trainedLabelsPath);

            // Фильтруем пустые строки
            var cleanedLines = lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();

            // Перезаписываем файл очищенными строками
            System.IO.File.WriteAllLines(trainedLabelsPath, cleanedLines);

        }

        private void LoadTrainingData()
        {
            try
            {
                string labelsInfo = System.IO.File.ReadAllText(Path.Combine(Application.StartupPath, "TrainedFaces", "TrainedLabels.txt"));
                string[] labels = labelsInfo.Split('%');
                _numLabels = Convert.ToInt32(labels[0]);
                _contTrain = _numLabels;

                for (int i = 1; i <= _numLabels; i++)
                {
                    string faceFileName = $"face{i}.bmp";
                    _trainingImages.Add(new Image<Gray, byte>(Path.Combine(Application.StartupPath, "TrainedFaces", faceFileName)));
                    _labels.Add(labels[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Лиц в базе данных нет, требуется добавление нового лица", "Лицо загружено", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bunifuFormControlBox1_HelpClicked(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!_isCameraOn)
            {
                // Если камера выключена, включаем ее
                InitializeCapture();
                Application.Idle += FrameGrabber;
                _isCameraOn = true;
                cameraOnButton.Text = "Остановить камеру"; // Изменяем текст кнопки на "Stop Camera"
                bunifuButton2.Enabled = true;
                bunifuButton1.Enabled = true;

            }
            else
            {
                // Если камера включена, выключаем ее
                _grabber.Dispose(); // Освобождаем ресурсы камеры
                imageBoxFrameGrabber.Image = null; // Очищаем изображение на форме
                Application.Idle -= FrameGrabber; // Отключаем обработчик события
                _isCameraOn = false;
                cameraOnButton.Text = "Включить камеру"; // Изменяем текст кнопки на "Start Camera"
                bunifuButton2.Enabled = false;
                bunifuButton1.Enabled = false;
            }
            PlaySound();
        }

        private void InitializeCapture()
        {
            _grabber = new Capture();
            _grabber.QueryFrame();
            _grabber.FlipHorizontal = true;

            var settings = LoadSettings();
            _grabber.SetCaptureProperty(CAP_PROP.CV_CAP_PROP_BRIGHTNESS, (settings.Brightness * 255) / 100);
            _grabber.SetCaptureProperty(CAP_PROP.CV_CAP_PROP_CONTRAST, (settings.Contrast * 255) / 100);
            _grabber.SetCaptureProperty(CAP_PROP.CV_CAP_PROP_SATURATION, (settings.Saturation * 255) / 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TrainNewFace();
                SaveTrainedFaces();
                MessageBox.Show($"{textBox1.Text}'s face detected and added :)", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateComboBoxNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TrainNewFace()
        {
            _contTrain++;
            _grayFrame = _grabber.QueryGrayFrame().Resize(360, 280, INTER.CV_INTER_CUBIC);

            var facesDetected = _grayFrame.DetectHaarCascade(_faceCascade, 1.2, 10, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

            foreach (var face in facesDetected[0])
            {
                _trainedFace = _currentFrame.Copy(face.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                break;
            }

            _trainingImages.Add(_trainedFace);
            _labels.Add(textBox1.Text);
            imageBox1.Image = _trainedFace;

            // Save the image to a file
            var faceFilePath = Path.Combine(Application.StartupPath, "TrainedFaces", $"face{_contTrain}.bmp");
            _trainedFace.Save(faceFilePath);

        }

        private void SaveTrainedFaces()
        {
            var trainedLabelsPath = Path.Combine(Application.StartupPath, "TrainedFaces", "TrainedLabels.txt");
            using (var writer = new StreamWriter(trainedLabelsPath))
            {
                writer.WriteLine($"{_trainingImages.Count}%");

                for (int i = 0; i < _trainingImages.Count; i++)
                {
                    var faceFilePath = Path.Combine(Application.StartupPath, "TrainedFaces", $"face{i + 1}.bmp");
                    _trainingImages[i].Save(faceFilePath);
                    writer.WriteLine($"{_labels[i]}%");
                }
            }
        }
        private void FillComboBoxWithTrainedFaces()
        {
            try
            {
                // Путь к файлу TrainedLabels.txt
                string trainedLabelsFile = Path.Combine(Application.StartupPath, "TrainedFaces", "TrainedLabels.txt");

                // Проверяем, существует ли файл TrainedLabels.txt
                if (System.IO.File.Exists(trainedLabelsFile))
                {
                    // Считываем все строки из файла
                    string[] lines = System.IO.File.ReadAllLines(trainedLabelsFile);

                    // Получаем количество лиц из первой строки
                    int numLabels = int.Parse(lines[0].Trim('%'));

                    // Очищаем ComboBox перед добавлением новых имен
                    comboBoxNames.Items.Clear();

                    // Добавляем каждое имя лица из оставшихся строк в ComboBox
                    for (int i = 1; i <= numLabels; i++)
                    {
                        string label = lines[i].Trim('%');
                        comboBoxNames.Items.Add(label);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при заполнении ComboBox лицами: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteSelectedFace()
        {
            try
            {
                if (comboBoxNames.SelectedItem != null)
                {
                    string selectedName = comboBoxNames.SelectedItem.ToString();

                    // Получаем индекс выбранного имени из ComboBox
                    int selectedIndex = comboBoxNames.SelectedIndex;

                    // Путь к папке с запомненными лицами
                    string trainedFacesDir = Path.Combine(Application.StartupPath, "TrainedFaces");

                    // Путь к файлу TrainedLabels.txt
                    string trainedLabelsFile = Path.Combine(trainedFacesDir, "TrainedLabels.txt");

                    // Объявляем переменную numLabels
                    int numLabels = 0;

                    // Проверяем, существует ли файл TrainedLabels.txt
                    if (System.IO.File.Exists(trainedLabelsFile))
                    {
                        // Читаем все строки из файла TrainedLabels.txt
                        string[] lines = System.IO.File.ReadAllLines(trainedLabelsFile);

                        // Получаем количество лиц из первой строки
                        numLabels = int.Parse(lines[0].Trim('%'));

                        // Обновляем количество лиц в файле TrainedLabels.txt
                        numLabels--;

                        // Удаляем имя из файла TrainedLabels.txt
                        List<string> updatedLines = new List<string>(lines);
                        updatedLines.RemoveAt(selectedIndex + 1); // Смещаемся на 1, потому что первая строка - это количество лиц
                        System.IO.File.WriteAllLines(trainedLabelsFile, updatedLines);

                        // Обновляем количество лиц в первой строке
                        System.IO.File.WriteAllText(trainedLabelsFile, $"{numLabels}%\n" + string.Join("\n", updatedLines.Skip(1)));
                    }

                    // Удаляем файл .bmp, соответствующий выбранному имени
                    string faceFilePath = Path.Combine(trainedFacesDir, $"face{selectedIndex + 1}.bmp");
                    if (System.IO.File.Exists(faceFilePath))
                    {
                        System.IO.File.Delete(faceFilePath);
                    }

                    // Переименовываем оставшиеся файлы .bmp, чтобы индексы соответствовали их положению в списке лиц
                    for (int i = selectedIndex + 1; i <= numLabels; i++)
                    {
                        string currentFaceFilePath = Path.Combine(trainedFacesDir, $"face{i + 1}.bmp");
                        if (System.IO.File.Exists(currentFaceFilePath))
                        {
                            string newFaceFilePath = Path.Combine(trainedFacesDir, $"face{i}.bmp");
                            System.IO.File.Move(currentFaceFilePath, newFaceFilePath);
                        }
                    }

                    MessageBox.Show($"Лицо {selectedName} успешно удалено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Обновляем ComboBox и имена лиц
                    UpdateComboBoxNames();
                    comboBoxNames.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите лицо для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении лица: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void UpdateComboBoxNames()
        {
            comboBoxNames.Items.Clear();
            foreach (var label in _labels)
            {
                comboBoxNames.Items.Add(label);
            }
        }
        private async void FrameGrabber(object sender, EventArgs e)
        {
            var settings = LoadSettings(); // Объявление и инициализация переменной settings
            if (_isProcessingFrame)
                return;

            _isProcessingFrame = true;

            await Task.Run(() =>
            {
                try
                {
                    ResetNamePersons();
                    _currentFrame = _grabber.QueryFrame()?.Resize(360, 280, INTER.CV_INTER_CUBIC);
                    if (_currentFrame == null) return;

                    _grayFrame = _currentFrame.Convert<Gray, byte>();
                    double scaleFactor = settings.Sensitivity / 10.0;
                    if (scaleFactor <= 1)
                    {
                        scaleFactor = 1.1; // Установите минимальный коэффициент масштабирования
                    }

                    var facesDetected = _grayFrame.DetectHaarCascade(_faceCascade, scaleFactor, 10, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
                    if (facesDetected.Length > 0 && facesDetected[0].Length > 0)
                    {
                        ProcessDetectedFaces(facesDetected); // Передача settings
                    }

                    _names = string.Join(", ", _namePersons.ToArray());
                    UpdateUI();
                    _namePersons.Clear();
                }
                catch (AccessViolationException ex)
                {
                    MessageBox.Show("Access Violation Exception: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    _isProcessingFrame = false;
                }
            });
        }

        private void faceRecLabel_MouseEnter(object sender, EventArgs e)
        {
            faceRecImageButton.ZoomIn();
        }

        private void faceRecLabel_MouseLeave(object sender, EventArgs e)
        {
            faceRecImageButton.ZoomOut();
        }

        private void settingsLabel_MouseEnter(object sender, EventArgs e)
        {
            settingImageButton.ZoomIn();
        }

        private void settingsLabel_MouseLeave(object sender, EventArgs e)
        {
            settingImageButton.ZoomOut();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == true)
            {
                sidebar.Width -= 100;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarTimer.Stop();
                    sidebarExpand = false;
                }
            }
            else
            {
                sidebar.Width += 100;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarTimer.Stop();
                    sidebarExpand = true;
                }
            }
        }

        private void settingImageButton_Click(object sender, EventArgs e)
        {
            addFaceButtonOff();
            settingsUserControl2.BringToFront();
            settingImageButton.ZoomOut();
        }

        private void faceRecImageButton_Click(object sender, EventArgs e)
        {
            addFaceButtonOff();
            facerecBackgroundUserControl.SendToBack();
            settingsUserControl2.SendToBack();
            journalUserControl1.SendToBack();
            faceRecImageButton.ZoomOut();
        }

        private void JournalLabel_MouseEnter(object sender, EventArgs e)
        {
            JournalImageButton.ZoomIn();
        }

        private void JournalLabel_MouseLeave(object sender, EventArgs e)
        {
            JournalImageButton.ZoomOut();
        }

        private void JournalImageButton_Click(object sender, EventArgs e)
        {
            addFaceButtonOff();
            journalUserControl1.BringToFront();
            JournalImageButton.ZoomOut();
        }

        private void ResetNamePersons()
        {
            label3.Text = "0";
            _namePersons.Clear();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            SaveCurrentFrame();
            // Log the date and time of the button click along with the recognized face
            LogEntry entry = new LogEntry
            {
                Timestamp = DateTime.Now,
                RecognizedPerson = _name,
                ImagePath = Path.Combine(Application.StartupPath, "savedPhotos", DateTime.Now.ToString("yyyy-MM-dd"), $"{DateTime.Now:yyyyMMddHHmmss}.bmp") // Add this line to store the image path
            };
            _logEntries.Add(entry);

            // Display the log entries
            DisplayLogEntries();

            SendPhotoAsync(entry.ImagePath, entry.RecognizedPerson);
        }

        private void SaveCurrentFrame()
        {
            string dailyDirPath = Path.Combine(Application.StartupPath, "savedPhotos", DateTime.Now.ToString("yyyy-MM-dd"));
            if (!Directory.Exists(dailyDirPath))
            {
                Directory.CreateDirectory(dailyDirPath);
            }

            string filePath = Path.Combine(dailyDirPath, $"{DateTime.Now:yyyyMMddHHmmss}.bmp");
            _currentFrame.Save(filePath);
        }

        private void ProcessDetectedFaces(MCvAvgComp[][] facesDetected) // Добавлен параметр settings
        {
            foreach (var face in facesDetected[0])
            {
                _t++;
                _result = _currentFrame.Copy(face.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                _currentFrame.Draw(face.rect, new Bgr(System.Drawing.Color.Red), 2);

                if (_trainingImages.Count != 0)
                {
                    RecognizeFace();
                    _currentFrame.Draw(_name, ref _font, new Point(face.rect.X - 2, face.rect.Y - 2), new Bgr(System.Drawing.Color.LightGreen));
                }

                _namePersons.Add(_name);
                label3.Text = facesDetected[0].Length.ToString();
            }
        }

        private void RecognizeFace()
        {
            var termCrit = new MCvTermCriteria(_contTrain, 0.001);
            var recognizer = new EigenObjectRecognizer(
                _trainingImages.ToArray(),
                _labels.ToArray(),
                3000,
                ref termCrit);

            _name = recognizer.Recognize(_result);
        }

        private void UpdateUI()
        {
            imageBoxFrameGrabber.Image = _currentFrame;
            label4.Text = _names;
            _names = string.Empty;
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void addFaceLabel_MouseEnter(object sender, EventArgs e)
        {
            addFaceImageButton.ZoomIn();
        }

        private void addFaceLabel_MouseLeave(object sender, EventArgs e)
        {
            addFaceImageButton.ZoomOut();
        }

        private void addFaceImageButton_Click(object sender, EventArgs e)
        {
            addFaceButtonOn();
            facerecBackgroundUserControl.SendToBack();
            settingsUserControl2.SendToBack();
            journalUserControl1.SendToBack();
            faceRecImageButton.ZoomOut();
        }

        // Method to display log entries
        private void DisplayLogEntries()
        {
            // Очищаем DataGridView перед добавлением новых записей
            journalUserControl1.LogDataGrid.Rows.Clear();

            foreach (var entry in _logEntries)
            {
                // Добавляем строку в DataGridView
                journalUserControl1.LogDataGrid.Rows.Add(entry.Timestamp, entry.RecognizedPerson);
            }
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            FilterLogsByDate();
        }

        public void FilterLogsByDate()
        {
            journalUserControl1.LogDataGrid.Rows.Clear();
            DateTime selectedDate = journalUserControl1.DatePicker.Value.Date;
            _filteredLogEntries = _logEntries
                .Where(entry => entry.Timestamp.Date == selectedDate)
                .ToList();
            _isFiltered = true;

            foreach (var entry in _filteredLogEntries)
            {
                journalUserControl1.LogDataGrid.Rows.Add(entry.Timestamp.ToString("HH:mm:ss"), entry.RecognizedPerson);
            }
        }

        private FaceRecognitionSettings LoadSettings()
        {
            if (System.IO.File.Exists(@settingsFilePath))
            {
                var json = System.IO.File.ReadAllText(@settingsFilePath);
                return JsonConvert.DeserializeObject<FaceRecognitionSettings>(json);
            }
            return new FaceRecognitionSettings(); // Default settings
        }

        private void PlaySound()
        {
            var setting = LoadSettings();
            if (setting.EnableNotifications == true)
            {
                string soundirPath = Path.Combine(Application.StartupPath, "sounds");
                string filePath = Path.Combine(soundirPath, setting.Sound);

                SoundPlayer sound = new SoundPlayer(@filePath);
                sound.Play();
            }
        }
        public async Task SendPhotoAsync(string filePath, string person)
        {
            var settings = LoadSettings();
            string ChatId = settings.TelegramChatId;
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {

                var fileToSend = new InputFileStream(stream, Path.GetFileName(filePath));
                await Bot.SendPhotoAsync(ChatId, fileToSend);
                await Bot.SendTextMessageAsync(ChatId, $"Похоже что..." + person + " отметился!");
            }
        }
        public class TelegramService
        {

            // Замените на ваш токен
            private static readonly string ChatId = "YOUR_CHAT_ID"; // Замените на ваш chat id

            private static readonly string Token = "6834231088:AAFU5qWJfveGrt9DImqGU1DI9rp_JTGrgMo";

        }

        private void DeleteFaceButton_Click(object sender, EventArgs e)
        {
            if (comboBoxNames.SelectedItem != null)
            {
                DeleteSelectedFace();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите лицо для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeTelegramBot()
        {

            Bot = new TelegramBotClient(Token);

            var cts = new CancellationTokenSource();
            ReceiverOptions receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // receive all update types
            };

            Bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken: cts.Token);

            var me = Bot.GetMeAsync().Result;
            Console.WriteLine($"Start listening for @{me.Username}");
        }
        private async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Type != UpdateType.Message)
                return;

            var message = update.Message;

            if (message.Type == MessageType.Text && message.Text.StartsWith("/"))
            {
                switch (message.Text.Split(' ')[0])
                {
                    case "/start":
                        await botClient.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: "Привет! Отправь /chatid Для привязки чата к приложению.",
                            cancellationToken: cancellationToken);
                        break;

                    case "/chatid":
                        await botClient.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: $"Ваш id: {message.Chat.Id}.\n" +
                            $"Для привязки зайдите в настроки программы и введите в поле 'Телеграм чат' ваш id",
                            cancellationToken: cancellationToken);
                        break;

                    default:
                        await botClient.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: "Unknown command. Try /start or /chatid.",
                            cancellationToken: cancellationToken);
                        break;
                }
            }
        }
        private Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            string errorMessage;

            if (exception is ApiRequestException apiRequestException)
            {
                errorMessage = $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}";
            }
            else
            {
                errorMessage = exception.ToString();
            }

            Console.WriteLine(errorMessage);
            return Task.CompletedTask;
        }



        public void InitializeSounds(string appPath)
        {
            string SoundFilesPath = Path.Combine(appPath, "sounds");
            // Получаем все файлы .wav из папки
            string[] soundFiles = Directory.EnumerateFiles(SoundFilesPath, "*.wav").ToArray();

            // Очищаем ComboBox
            settingsUserControl2.comboboxSounds.Items.Clear();

            // Добавляем каждый файл .wav в ComboBox
            foreach (string sf in soundFiles)
            {
                // Используем только имя файла без расширения в ComboBox
                settingsUserControl2.comboboxSounds.Items.Add(Path.GetFileName(sf));
            }

            // Если есть звуковые файлы, выбираем первый файл по умолчанию
            if (settingsUserControl2.comboboxSounds.Items.Count > 0)
            {
                settingsUserControl2.comboboxSounds.SelectedIndex = 0;
            }
        }

        public void addFaceButtonOn()
        {
            bunifuButton2.Visible = false;
            saveGroupBox.Visible = true;
            deleteGroupBox.Visible = true;
        }
        public void addFaceButtonOff()
        {
            bunifuButton2.Visible= true;
            saveGroupBox.Visible = false;
            deleteGroupBox.Visible = false;
        }

    }
}

