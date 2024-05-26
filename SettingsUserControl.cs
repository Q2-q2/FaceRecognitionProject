using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using Telegram.Bot.Types;
using System.Web;

namespace MultiFaceRec
{
    public partial class SettingsUserControl : UserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            LoadSettings();
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            TestSound();
        }



        string appPath = Application.StartupPath;


        public ComboBox comboboxSounds
        {
            get { return soundsComboBox; }
        }


        private void SaveSettings()
        {
            var settings = new FaceRecognitionSettings
            {
                Sensitivity = trackBar.Value,
                EnableNotifications = notificationsCheckBox.Checked,
                Password = passwordTextBox.Text,
                UseGpu = useGpuCheckBox.Checked,
                CameraSource = cameraSourceComboBox.SelectedItem.ToString(),
                Brightness = brightnessTrackBar.Value,
                Contrast = contrastTrackBar.Value,
                Saturation = saturationTrackBar.Value,
                Sound = Convert.ToString(soundsComboBox.SelectedItem),
                TelegramChatId = telegramChatTextBox.Text
            };
            var json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            System.IO.File.WriteAllText(Path.Combine(appPath, "settings.json"), json);
        }

        private void LoadSettings()
        {
            try
            {
                var json = System.IO.File.ReadAllText(Path.Combine(appPath, "settings.json"));
                var settings = JsonConvert.DeserializeObject<FaceRecognitionSettings>(json);
                trackBar.Value = settings.Sensitivity;
                notificationsCheckBox.Checked = settings.EnableNotifications;
                passwordTextBox.Text = settings.Password;
                useGpuCheckBox.Checked = settings.UseGpu;
                cameraSourceComboBox.SelectedItem = settings.CameraSource;
                brightnessTrackBar.Value = settings.Brightness;
                contrastTrackBar.Value = settings.Contrast;
                saturationTrackBar.Value = settings.Saturation;
                soundsComboBox.SelectedItem = settings.Sound;
                telegramChatTextBox.Text = settings.TelegramChatId;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void TestSound()
        {
            string selectedSound = Convert.ToString(soundsComboBox.SelectedItem);
            string soundfilepath = Path.Combine(Path.Combine(Application.StartupPath, "sounds"), selectedSound);
            SoundPlayer player = new SoundPlayer(soundfilepath);
            player.Play();
        }


        private void bunifuIconButton2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "WAV files (*.wav)|*.wav";
                openFileDialog.Title = "Выберите звуковой файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    string soundsDirPath = Path.Combine(Application.StartupPath, "sounds");

                    if (!Directory.Exists(soundsDirPath))
                    {
                        Directory.CreateDirectory(soundsDirPath);
                    }

                    string fileName = Path.GetFileName(selectedFilePath);
                    string destinationFilePath = Path.Combine(soundsDirPath, fileName);

                    try
                    {
                        System.IO.File.Copy(selectedFilePath, destinationFilePath, true);
                        MessageBox.Show("Звуковой файл успешно добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InitializeSounds(Application.StartupPath);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при добавлении звукового файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public void InitializeSounds(string appPath)
        {
            string SoundFilesPath = Path.Combine(appPath, "sounds");
            // Получаем все файлы .wav из папки
            string[] soundFiles = Directory.EnumerateFiles(SoundFilesPath, "*.wav").ToArray();

            // Очищаем ComboBox
            soundsComboBox.Items.Clear();

            // Добавляем каждый файл .wav в ComboBox
            foreach (string sf in soundFiles)
            {
                // Используем только имя файла без расширения в ComboBox
                soundsComboBox.Items.Add(Path.GetFileName(sf));
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }
    }

    public class FaceRecognitionSettings
    {
        public int Sensitivity { get; set; }
        public bool EnableNotifications { get; set; }
        public string Password { get; set; }
        public bool UseGpu { get; set; }
        public string CameraSource { get; set; }
        public int Brightness { get; set; }
        public int Contrast { get; set; }
        public int Saturation { get; set; }
        public string Sound { get; set; }
        public string TelegramChatId { get; set; }

    }
}
