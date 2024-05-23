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

namespace MultiFaceRec
{
    public partial class SettingsUserControl : UserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
            LoadSettings();
            InitializeSounds();
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

        private string settingsFilePath = Path.Combine(Application.StartupPath, "settings.json");
        private string soundFolderPath = Path.Combine(Application.StartupPath, "assets", "sounds");

        private void SaveSettings()
        {
            var settings = new FaceRecognitionSettings
            {
                Sensitivity = trackBar.Value,
                EnableNotifications = notificationsCheckBox.Checked,
                Password = passwordTextBox.Text,
                UseGpu = useGpuCheckBox.Checked,
                VideoQuality = videoQualityComboBox.SelectedItem.ToString(),
                CameraSource = cameraSourceComboBox.SelectedItem.ToString(),
                Brightness = brightnessTrackBar.Value,
                Contrast = contrastTrackBar.Value,
                Saturation = saturationTrackBar.Value,
                Sound = Convert.ToString(soundsComboBox.SelectedItem),
        };
            var json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(settingsFilePath, json);
        }

        private void LoadSettings()
        {
            try
            {
                var json = File.ReadAllText(settingsFilePath);
                var settings = JsonConvert.DeserializeObject<FaceRecognitionSettings>(json);
                trackBar.Value = settings.Sensitivity;
                notificationsCheckBox.Checked = settings.EnableNotifications;
                passwordTextBox.Text = settings.Password;
                useGpuCheckBox.Checked = settings.UseGpu;
                videoQualityComboBox.SelectedItem = settings.VideoQuality;
                cameraSourceComboBox.SelectedItem = settings.CameraSource;
                brightnessTrackBar.Value = settings.Brightness;
                contrastTrackBar.Value = settings.Contrast;
                saturationTrackBar.Value = settings.Saturation;
                soundsComboBox.SelectedItem = settings.Sound;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}");
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InitializeSounds()
        {
            
            // Получаем все файлы .wav из папки
            string[] soundFiles = Directory.GetFiles(soundFolderPath, "*.wav");

            // Очищаем ComboBox
            soundsComboBox.Items.Clear();

            // Добавляем каждый файл .wav в ComboBox
            foreach (string soundFile in soundFiles)
            {
                // Используем только имя файла без расширения в ComboBox
                soundsComboBox.Items.Add(Path.GetFileName(soundFile));
            }

            // Если есть звуковые файлы, выбираем первый файл по умолчанию
            if (soundsComboBox.Items.Count > 0)
            {
                soundsComboBox.SelectedIndex = 0;
            }




        }

        private void TestSound()
        {
            string selectedSound = Convert.ToString(soundsComboBox.SelectedItem);
            string soundfilepath = Path.Combine(soundFolderPath, selectedSound);
            SoundPlayer player = new SoundPlayer(soundfilepath);
            player.Play();
        }


        
    }

    public class FaceRecognitionSettings
    {
        public int Sensitivity { get; set; }
        public bool EnableNotifications { get; set; }
        public string Password { get; set; }
        public bool UseGpu { get; set; }
        public string VideoQuality { get; set; }
        public string CameraSource { get; set; }
        public int Brightness { get; set; }
        public int Contrast { get; set; }
        public int Saturation { get; set; }
        public string Sound {get; set; }
    }
}

