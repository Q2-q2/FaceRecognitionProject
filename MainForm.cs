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

        // Structure to store log entries
        private struct LogEntry
        {
            public DateTime Timestamp;
            public string RecognizedPerson;
            public string ImagePath; // Добавлено поле для пути к изображению
        }

        // List to store log entries
        private List<LogEntry> _logEntries = new List<LogEntry>();

        private string settingsFilePath = Path.Combine(Application.StartupPath, "settings.json");

        public FrmPrincipal()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            InitializeHaarCascades();
            LoadTrainingData();

            // Подключаем событие ValueChanged для DatePicker
            journalUserControl1.DatePicker.ValueChanged += DatePicker_ValueChanged;

            // Обновляем логи для текущей выбранной даты при запуске формы
            FilterLogsByDate();

            // Подключаем обработчик событий SelectedIndexChanged для LogListBox
            journalUserControl1.AddLogListBoxSelectedIndexChangedEventHandler(LogListBox_SelectedIndexChanged);

            // Создаем каталог для текущего дня, если он еще не был создан
            CreateDailyPhotoDirectory();

            LoadSettings();
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
        }

        private void CreateDailyPhotoDirectory()
        {
            string dailyDirPath = Path.Combine(Application.StartupPath, "savedPhotos", DateTime.Now.ToString("yyyy-MM-dd"));
            if (!Directory.Exists(dailyDirPath))
            {
                Directory.CreateDirectory(dailyDirPath);
            }
        }

        private void LoadLogEntries()
        {
            var logFilePath = Path.Combine(Application.StartupPath, "logEntries.txt");
            if (File.Exists(logFilePath))
            {
                _logEntries.Clear(); // Очистка списка перед загрузкой
                var lines = File.ReadAllLines(logFilePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(';'); // Используем точку с запятой в качестве разделителя
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
                    writer.WriteLine($"{entry.Timestamp};{entry.RecognizedPerson.Trim()};{entry.ImagePath.Trim()}"); // Добавлено поле для пути к изображению
                }
            }
        }

        private void CleanTrainedLabelsFile()
        {
            var trainedLabelsPath = Path.Combine(Application.StartupPath, "TrainedFaces", "TrainedLabels.txt");

            // Проверяем, существует ли файл
            if (!File.Exists(trainedLabelsPath))
            {
                return;
            }

            // Читаем все строки из файла
            var lines = File.ReadAllLines(trainedLabelsPath);

            // Фильтруем пустые строки
            var cleanedLines = lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();

            // Перезаписываем файл очищенными строками
            File.WriteAllLines(trainedLabelsPath, cleanedLines);

        }

        private void LoadTrainingData()
        {
            try
            {
                string labelsInfo = File.ReadAllText(Path.Combine(Application.StartupPath, "TrainedFaces", "TrainedLabels.txt"));
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
            }
            else
            {
                // Если камера включена, выключаем ее
                _grabber.Dispose(); // Освобождаем ресурсы камеры
                imageBoxFrameGrabber.Image = null; // Очищаем изображение на форме
                Application.Idle -= FrameGrabber; // Отключаем обработчик события
                _isCameraOn = false;
                cameraOnButton.Text = "Включить камеру"; // Изменяем текст кнопки на "Start Camera"
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

                // Log the date and time of the button click along with the recognized face
                LogEntry entry = new LogEntry
                {
                    Timestamp = DateTime.Now,
                    RecognizedPerson = _name,
                    ImagePath = Path.Combine(Application.StartupPath, "TrainedFaces", $"face{_contTrain}.bmp") // Add this line to store the image path
                };
                _logEntries.Add(entry);

                // Display the log entries
                DisplayLogEntries();
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

            // Log the date and time of the button click along with the recognized face and image path
            LogEntry entry = new LogEntry
            {
                Timestamp = DateTime.Now,
                RecognizedPerson = textBox1.Text,
                ImagePath = faceFilePath
            };
            _logEntries.Add(entry);

            // Display the log entries
            DisplayLogEntries();
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

        private async void FrameGrabber(object sender, EventArgs e)
        {
            var settings = LoadSettings(); // Объявление и инициализация переменной settings
            if (_isProcessingFrame)
                return;

            _isProcessingFrame = true;

            await Task.Run(() =>
            {
                ResetNamePersons();
                _currentFrame = _grabber.QueryFrame().Resize(360, 280, INTER.CV_INTER_CUBIC);
                _grayFrame = _currentFrame.Convert<Gray, byte>();

                double scaleFactor = settings.Sensitivity / 10.0;
                if (scaleFactor <= 1)
                {
                    scaleFactor = 1.1; // Установите минимальный коэффициент масштабирования
                }

                var facesDetected = _grayFrame.DetectHaarCascade(_faceCascade, scaleFactor, 10, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

                if (facesDetected.Length > 0 && facesDetected[0].Length > 0)
                {
                    ProcessDetectedFaces(facesDetected, settings); // Передача settings
                }

                _names = string.Join(", ", _namePersons.ToArray());
                UpdateUI();
                _namePersons.Clear();
            });

            _isProcessingFrame = false;
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
            settingsUserControl1.BringToFront();
            settingImageButton.ZoomOut();
        }

        private void faceRecImageButton_Click(object sender, EventArgs e)
        {
            facerecBackgroundUserControl.SendToBack();
            settingsUserControl1.SendToBack();
            addFaceUserControl1.SendToBack();
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

        private void ProcessDetectedFaces(MCvAvgComp[][] facesDetected, FaceRecognitionSettings settings) // Добавлен параметр settings
        {
            foreach (var face in facesDetected[0])
            {
                _t++;
                _result = _currentFrame.Copy(face.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                _currentFrame.Draw(face.rect, new Bgr(Color.Red), 2);

                if (_trainingImages.Count != 0)
                {
                    RecognizeFace();
                    _currentFrame.Draw(_name, ref _font, new Point(face.rect.X - 2, face.rect.Y - 2), new Bgr(Color.LightGreen));
                }

                _namePersons.Add(_name);
                label3.Text = facesDetected[0].Length.ToString();
            }
        }

        private void RecognizeFace()
        {
            var termCrit = new MCvTermCriteria(_contTrain);
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
            addFaceUserControl1.BringToFront();
        }

        // Method to display log entries
        private void DisplayLogEntries()
        {
            // Очищаем ListBox перед добавлением новых записей
            journalUserControl1.LogListBox.Items.Clear();

            foreach (var entry in _logEntries)
            {
                journalUserControl1.LogListBox.Items.Add($"{entry.Timestamp};{entry.RecognizedPerson}"); // Не добавляем пробел после разделителя
            }

            // Attach the event handler
            journalUserControl1.LogListBox.SelectedIndexChanged += LogListBox_SelectedIndexChanged;
        }

        private void LogListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (journalUserControl1.LogListBox.SelectedIndex == -1)
                return;

            // Get the selected log entry
            var selectedLog = _logEntries[journalUserControl1.LogListBox.SelectedIndex];

            // Load and display the image
            if (File.Exists(selectedLog.ImagePath))
            {
                journalUserControl1.LogImageBox.Image = new Image<Bgr, byte>(selectedLog.ImagePath); // Загрузка изображения в ImageBox
            }
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            FilterLogsByDate();
        }

        private void FilterLogsByDate()
        {
            journalUserControl1.LogListBox.Items.Clear();
            DateTime selectedDate = journalUserControl1.DatePicker.Value.Date;

            foreach (var entry in _logEntries)
            {
                if (entry.Timestamp.Date == selectedDate)
                {
                    journalUserControl1.LogListBox.Items.Add($"{entry.Timestamp};{entry.RecognizedPerson}"); // Используем точку с запятой как разделитель
                }
            }
        }

        private FaceRecognitionSettings LoadSettings()
        {
            if (File.Exists(@settingsFilePath))
            {
                var json = File.ReadAllText(@settingsFilePath);
                return JsonConvert.DeserializeObject<FaceRecognitionSettings>(json);
            }
            return new FaceRecognitionSettings(); // Default settings
        }

        private void PlaySound()
        {
            var setting = LoadSettings();
            if (setting.EnableNotifications == true) 
            {
                string soundirPath = Path.Combine(Application.StartupPath, "assets/sounds");
                string filePath = Path.Combine(soundirPath, setting.Sound);

                SoundPlayer sound = new SoundPlayer(@filePath);
                sound.Play();
            } 
        }
    }
}
