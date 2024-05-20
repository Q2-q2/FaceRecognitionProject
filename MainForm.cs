using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Threading.Tasks;

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
        private bool _isProcessingFrame = false; // Для предотвращения обработки кадров, когда один уже обрабатывается

        bool sidebarExpand = true;

        // Structure to store log entries
        private struct LogEntry
        {
            public DateTime Timestamp;
            public string RecognizedPerson;
        }

        // List to store log entries
        private List<LogEntry> _logEntries = new List<LogEntry>();

        public FrmPrincipal()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            InitializeHaarCascades();
            LoadTrainingData();
        }

        private void InitializeHaarCascades()
        {
            _faceCascade = new HaarCascade("haarcascade_frontalface_default.xml");
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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void bunifuFormControlBox1_HelpClicked(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeCapture();
            Application.Idle += FrameGrabber;
            button1.Enabled = false;
        }

        private void InitializeCapture()
        {
            _grabber = new Capture();
            _grabber.QueryFrame();
            _grabber.FlipHorizontal = true;
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
                    RecognizedPerson = _name
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
                    writer.WriteLine(_labels[i] + "%");
                }
            }
        }

        private async void FrameGrabber(object sender, EventArgs e)
        {
            if (_isProcessingFrame)
                return;

            _isProcessingFrame = true;

            await Task.Run(() =>
            {
                ResetNamePersons();
                _currentFrame = _grabber.QueryFrame().Resize(360, 280, INTER.CV_INTER_CUBIC);
                _grayFrame = _currentFrame.Convert<Gray, byte>();

                var facesDetected = _grayFrame.DetectHaarCascade(_faceCascade, 1.2, 10, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

                if (facesDetected.Length > 0 && facesDetected[0].Length > 0)
                {
                    ProcessDetectedFaces(facesDetected);
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
            /*settingsUserControl11.BringToFront();*/
            settingImageButton.ZoomOut();
        }

        private void faceRecImageButton_Click(object sender, EventArgs e)
        {
            facerecBackgroundUserControl.SendToBack();
            /*            settingsUserControl11.SendToBack();
            */
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
            // Log the date and time of the button click along with the recognized face
            LogEntry entry = new LogEntry
            {
                Timestamp = DateTime.Now,
                RecognizedPerson = _name
            };
            _logEntries.Add(entry);

            // Display the log entries
            DisplayLogEntries();
        }

        private void ProcessDetectedFaces(MCvAvgComp[][] facesDetected)
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

        // Method to display log entries
        private void DisplayLogEntries()
        {
            // Access the ListBox through the UserControl's exposed property
            /*journalUserControl1.LogListBox.Items.Clear();*/
            foreach (var entry in _logEntries)
            {
                journalUserControl1.LogListBox.Items.Add($"{entry.Timestamp}: {entry.RecognizedPerson}");
            }
        }

    }
}
