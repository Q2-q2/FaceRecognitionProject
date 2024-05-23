namespace MultiFaceRec
{
    partial class SettingsUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUserControl));
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.videoQualityComboBox = new System.Windows.Forms.ComboBox();
            this.cameraSourceComboBox = new System.Windows.Forms.ComboBox();
            this.sensetivityLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.notificationLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.passwordLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.optimisationLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.cameraSettingsLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.useGpuLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.soundsComboBox = new System.Windows.Forms.ComboBox();
            this.bunifuIconButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.saturationTrackBar = new Bunifu.UI.WinForms.BunifuHSlider();
            this.contrastTrackBar = new Bunifu.UI.WinForms.BunifuHSlider();
            this.brightnessTrackBar = new Bunifu.UI.WinForms.BunifuHSlider();
            this.useGpuCheckBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.passwordTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.notificationsCheckBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.trackBar = new Bunifu.UI.WinForms.BunifuHSlider();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // videoQualityComboBox
            // 
            this.videoQualityComboBox.FormattingEnabled = true;
            this.videoQualityComboBox.Items.AddRange(new object[] {
            "Низкое",
            "Среднее",
            "Высокое"});
            this.videoQualityComboBox.Location = new System.Drawing.Point(413, 415);
            this.videoQualityComboBox.Name = "videoQualityComboBox";
            this.videoQualityComboBox.Size = new System.Drawing.Size(121, 24);
            this.videoQualityComboBox.TabIndex = 8;
            this.bunifuToolTip1.SetToolTip(this.videoQualityComboBox, "");
            this.bunifuToolTip1.SetToolTipIcon(this.videoQualityComboBox, null);
            this.bunifuToolTip1.SetToolTipTitle(this.videoQualityComboBox, "");
            // 
            // cameraSourceComboBox
            // 
            this.cameraSourceComboBox.FormattingEnabled = true;
            this.cameraSourceComboBox.Items.AddRange(new object[] {
            "Webcam",
            "IP Camera"});
            this.cameraSourceComboBox.Location = new System.Drawing.Point(250, 265);
            this.cameraSourceComboBox.Name = "cameraSourceComboBox";
            this.cameraSourceComboBox.Size = new System.Drawing.Size(121, 24);
            this.cameraSourceComboBox.TabIndex = 9;
            this.bunifuToolTip1.SetToolTip(this.cameraSourceComboBox, "");
            this.bunifuToolTip1.SetToolTipIcon(this.cameraSourceComboBox, null);
            this.bunifuToolTip1.SetToolTipTitle(this.cameraSourceComboBox, "");
            // 
            // sensetivityLabel
            // 
            this.sensetivityLabel.AllowParentOverrides = false;
            this.sensetivityLabel.AutoEllipsis = false;
            this.sensetivityLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.sensetivityLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.sensetivityLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sensetivityLabel.Location = new System.Drawing.Point(30, 47);
            this.sensetivityLabel.Name = "sensetivityLabel";
            this.sensetivityLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sensetivityLabel.Size = new System.Drawing.Size(202, 20);
            this.sensetivityLabel.TabIndex = 13;
            this.sensetivityLabel.Text = "Настройки чувствительности";
            this.sensetivityLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.sensetivityLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.sensetivityLabel, "Настройки чувствительности сильно влияют на работоспособность распознования лиц. " +
        "Рекомендуется не повышать это значение выше 60%.");
            this.bunifuToolTip1.SetToolTipIcon(this.sensetivityLabel, null);
            this.bunifuToolTip1.SetToolTipTitle(this.sensetivityLabel, "");
            // 
            // notificationLabel
            // 
            this.notificationLabel.AllowParentOverrides = false;
            this.notificationLabel.AutoEllipsis = false;
            this.notificationLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.notificationLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.notificationLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.notificationLabel.Location = new System.Drawing.Point(30, 177);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.notificationLabel.Size = new System.Drawing.Size(241, 20);
            this.notificationLabel.TabIndex = 15;
            this.notificationLabel.Text = "Настройки звуковых уведомлений";
            this.notificationLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.notificationLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.notificationLabel, "");
            this.bunifuToolTip1.SetToolTipIcon(this.notificationLabel, null);
            this.bunifuToolTip1.SetToolTipTitle(this.notificationLabel, "");
            // 
            // passwordLabel
            // 
            this.passwordLabel.AllowParentOverrides = false;
            this.passwordLabel.AutoEllipsis = false;
            this.passwordLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.passwordLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordLabel.Location = new System.Drawing.Point(30, 574);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordLabel.Size = new System.Drawing.Size(151, 20);
            this.passwordLabel.TabIndex = 16;
            this.passwordLabel.Text = "Пароль к настройкам";
            this.passwordLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.passwordLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.passwordLabel, "");
            this.bunifuToolTip1.SetToolTipIcon(this.passwordLabel, null);
            this.bunifuToolTip1.SetToolTipTitle(this.passwordLabel, "");
            // 
            // optimisationLabel
            // 
            this.optimisationLabel.AllowParentOverrides = false;
            this.optimisationLabel.AutoEllipsis = false;
            this.optimisationLabel.AutoSize = false;
            this.optimisationLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.optimisationLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.optimisationLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.optimisationLabel.Location = new System.Drawing.Point(30, 415);
            this.optimisationLabel.Name = "optimisationLabel";
            this.optimisationLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optimisationLabel.Size = new System.Drawing.Size(179, 50);
            this.optimisationLabel.TabIndex = 17;
            this.optimisationLabel.Text = "Оптимизация производительности";
            this.optimisationLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.optimisationLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.optimisationLabel, "");
            this.bunifuToolTip1.SetToolTipIcon(this.optimisationLabel, null);
            this.bunifuToolTip1.SetToolTipTitle(this.optimisationLabel, "");
            // 
            // cameraSettingsLabel
            // 
            this.cameraSettingsLabel.AccessibleDescription = "";
            this.cameraSettingsLabel.AllowParentOverrides = false;
            this.cameraSettingsLabel.AutoEllipsis = false;
            this.cameraSettingsLabel.CursorType = null;
            this.cameraSettingsLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cameraSettingsLabel.Location = new System.Drawing.Point(30, 265);
            this.cameraSettingsLabel.Name = "cameraSettingsLabel";
            this.cameraSettingsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cameraSettingsLabel.Size = new System.Drawing.Size(133, 20);
            this.cameraSettingsLabel.TabIndex = 18;
            this.cameraSettingsLabel.Text = "Настройки камеры";
            this.cameraSettingsLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.cameraSettingsLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.cameraSettingsLabel, "");
            this.bunifuToolTip1.SetToolTipIcon(this.cameraSettingsLabel, null);
            this.bunifuToolTip1.SetToolTipTitle(this.cameraSettingsLabel, "");
            // 
            // useGpuLabel
            // 
            this.useGpuLabel.AllowParentOverrides = false;
            this.useGpuLabel.AutoEllipsis = false;
            this.useGpuLabel.CursorType = null;
            this.useGpuLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.useGpuLabel.Location = new System.Drawing.Point(250, 475);
            this.useGpuLabel.Name = "useGpuLabel";
            this.useGpuLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.useGpuLabel.Size = new System.Drawing.Size(130, 20);
            this.useGpuLabel.TabIndex = 19;
            this.useGpuLabel.Text = "Использовать GPU";
            this.useGpuLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.useGpuLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.useGpuLabel, "");
            this.bunifuToolTip1.SetToolTipIcon(this.useGpuLabel, null);
            this.bunifuToolTip1.SetToolTipTitle(this.useGpuLabel, "");
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel1.Location = new System.Drawing.Point(250, 419);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(109, 20);
            this.bunifuLabel1.TabIndex = 20;
            this.bunifuLabel1.Text = "Качество видео";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.bunifuLabel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuLabel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuLabel1, "");
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // soundsComboBox
            // 
            this.soundsComboBox.FormattingEnabled = true;
            this.soundsComboBox.Location = new System.Drawing.Point(402, 177);
            this.soundsComboBox.Name = "soundsComboBox";
            this.soundsComboBox.Size = new System.Drawing.Size(184, 24);
            this.soundsComboBox.TabIndex = 21;
            this.bunifuToolTip1.SetToolTip(this.soundsComboBox, "");
            this.bunifuToolTip1.SetToolTipIcon(this.soundsComboBox, null);
            this.bunifuToolTip1.SetToolTipTitle(this.soundsComboBox, "");
            this.soundsComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bunifuIconButton1
            // 
            this.bunifuIconButton1.AllowAnimations = true;
            this.bunifuIconButton1.AllowBorderColorChanges = true;
            this.bunifuIconButton1.AllowMouseEffects = true;
            this.bunifuIconButton1.AnimationSpeed = 200;
            this.bunifuIconButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton1.BorderRadius = 0;
            this.bunifuIconButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.bunifuIconButton1.BorderThickness = 0;
            this.bunifuIconButton1.ColorContrastOnClick = 30;
            this.bunifuIconButton1.ColorContrastOnHover = 30;
            this.bunifuIconButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuIconButton1.CustomizableEdges = borderEdges1;
            this.bunifuIconButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuIconButton1.Image = global::MultiFaceRec.Properties.Resources.play_button;
            this.bunifuIconButton1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuIconButton1.Location = new System.Drawing.Point(592, 177);
            this.bunifuIconButton1.Name = "bunifuIconButton1";
            this.bunifuIconButton1.RoundBorders = true;
            this.bunifuIconButton1.ShowBorders = true;
            this.bunifuIconButton1.Size = new System.Drawing.Size(26, 26);
            this.bunifuIconButton1.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.bunifuIconButton1.TabIndex = 22;
            this.bunifuToolTip1.SetToolTip(this.bunifuIconButton1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuIconButton1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuIconButton1, "");
            this.bunifuIconButton1.Click += new System.EventHandler(this.bunifuIconButton1_Click);
            // 
            // saturationTrackBar
            // 
            this.saturationTrackBar.AllowCursorChanges = true;
            this.saturationTrackBar.AllowHomeEndKeysDetection = false;
            this.saturationTrackBar.AllowIncrementalClickMoves = true;
            this.saturationTrackBar.AllowMouseDownEffects = false;
            this.saturationTrackBar.AllowMouseHoverEffects = false;
            this.saturationTrackBar.AllowScrollingAnimations = true;
            this.saturationTrackBar.AllowScrollKeysDetection = true;
            this.saturationTrackBar.AllowScrollOptionsMenu = true;
            this.saturationTrackBar.AllowShrinkingOnFocusLost = false;
            this.saturationTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.saturationTrackBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saturationTrackBar.BackgroundImage")));
            this.saturationTrackBar.BindingContainer = null;
            this.saturationTrackBar.BorderRadius = 2;
            this.saturationTrackBar.BorderThickness = 1;
            this.saturationTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saturationTrackBar.DrawThickBorder = false;
            this.saturationTrackBar.DurationBeforeShrink = 2000;
            this.saturationTrackBar.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.saturationTrackBar.LargeChange = 10;
            this.saturationTrackBar.Location = new System.Drawing.Point(434, 332);
            this.saturationTrackBar.Maximum = 100;
            this.saturationTrackBar.Minimum = 1;
            this.saturationTrackBar.MinimumSize = new System.Drawing.Size(0, 31);
            this.saturationTrackBar.MinimumThumbLength = 18;
            this.saturationTrackBar.Name = "saturationTrackBar";
            this.saturationTrackBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.saturationTrackBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.saturationTrackBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.saturationTrackBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.saturationTrackBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.saturationTrackBar.ShrinkSizeLimit = 3;
            this.saturationTrackBar.Size = new System.Drawing.Size(200, 31);
            this.saturationTrackBar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.saturationTrackBar.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.saturationTrackBar.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.saturationTrackBar.SmallChange = 1;
            this.saturationTrackBar.TabIndex = 12;
            this.saturationTrackBar.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.saturationTrackBar.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.saturationTrackBar.ThumbLength = 20;
            this.saturationTrackBar.ThumbMargin = 1;
            this.saturationTrackBar.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.saturationTrackBar.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuToolTip1.SetToolTip(this.saturationTrackBar, "");
            this.bunifuToolTip1.SetToolTipIcon(this.saturationTrackBar, null);
            this.bunifuToolTip1.SetToolTipTitle(this.saturationTrackBar, "");
            this.saturationTrackBar.Value = 50;
            // 
            // contrastTrackBar
            // 
            this.contrastTrackBar.AllowCursorChanges = true;
            this.contrastTrackBar.AllowHomeEndKeysDetection = false;
            this.contrastTrackBar.AllowIncrementalClickMoves = true;
            this.contrastTrackBar.AllowMouseDownEffects = false;
            this.contrastTrackBar.AllowMouseHoverEffects = false;
            this.contrastTrackBar.AllowScrollingAnimations = true;
            this.contrastTrackBar.AllowScrollKeysDetection = true;
            this.contrastTrackBar.AllowScrollOptionsMenu = true;
            this.contrastTrackBar.AllowShrinkingOnFocusLost = false;
            this.contrastTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.contrastTrackBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contrastTrackBar.BackgroundImage")));
            this.contrastTrackBar.BindingContainer = null;
            this.contrastTrackBar.BorderRadius = 2;
            this.contrastTrackBar.BorderThickness = 1;
            this.contrastTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contrastTrackBar.DrawThickBorder = false;
            this.contrastTrackBar.DurationBeforeShrink = 2000;
            this.contrastTrackBar.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.contrastTrackBar.LargeChange = 10;
            this.contrastTrackBar.Location = new System.Drawing.Point(434, 295);
            this.contrastTrackBar.Maximum = 100;
            this.contrastTrackBar.Minimum = 1;
            this.contrastTrackBar.MinimumSize = new System.Drawing.Size(0, 31);
            this.contrastTrackBar.MinimumThumbLength = 18;
            this.contrastTrackBar.Name = "contrastTrackBar";
            this.contrastTrackBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.contrastTrackBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.contrastTrackBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.contrastTrackBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.contrastTrackBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.contrastTrackBar.ShrinkSizeLimit = 3;
            this.contrastTrackBar.Size = new System.Drawing.Size(206, 31);
            this.contrastTrackBar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.contrastTrackBar.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.contrastTrackBar.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.contrastTrackBar.SmallChange = 1;
            this.contrastTrackBar.TabIndex = 11;
            this.contrastTrackBar.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.contrastTrackBar.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.contrastTrackBar.ThumbLength = 20;
            this.contrastTrackBar.ThumbMargin = 1;
            this.contrastTrackBar.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.contrastTrackBar.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuToolTip1.SetToolTip(this.contrastTrackBar, "");
            this.bunifuToolTip1.SetToolTipIcon(this.contrastTrackBar, null);
            this.bunifuToolTip1.SetToolTipTitle(this.contrastTrackBar, "");
            this.contrastTrackBar.Value = 50;
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.AllowCursorChanges = true;
            this.brightnessTrackBar.AllowHomeEndKeysDetection = false;
            this.brightnessTrackBar.AllowIncrementalClickMoves = true;
            this.brightnessTrackBar.AllowMouseDownEffects = false;
            this.brightnessTrackBar.AllowMouseHoverEffects = false;
            this.brightnessTrackBar.AllowScrollingAnimations = true;
            this.brightnessTrackBar.AllowScrollKeysDetection = true;
            this.brightnessTrackBar.AllowScrollOptionsMenu = true;
            this.brightnessTrackBar.AllowShrinkingOnFocusLost = false;
            this.brightnessTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.brightnessTrackBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brightnessTrackBar.BackgroundImage")));
            this.brightnessTrackBar.BindingContainer = null;
            this.brightnessTrackBar.BorderRadius = 2;
            this.brightnessTrackBar.BorderThickness = 1;
            this.brightnessTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brightnessTrackBar.DrawThickBorder = false;
            this.brightnessTrackBar.DurationBeforeShrink = 2000;
            this.brightnessTrackBar.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.brightnessTrackBar.LargeChange = 10;
            this.brightnessTrackBar.Location = new System.Drawing.Point(434, 258);
            this.brightnessTrackBar.Maximum = 100;
            this.brightnessTrackBar.Minimum = 0;
            this.brightnessTrackBar.MinimumSize = new System.Drawing.Size(0, 31);
            this.brightnessTrackBar.MinimumThumbLength = 18;
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.brightnessTrackBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.brightnessTrackBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.brightnessTrackBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.brightnessTrackBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.brightnessTrackBar.ShrinkSizeLimit = 3;
            this.brightnessTrackBar.Size = new System.Drawing.Size(200, 31);
            this.brightnessTrackBar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.brightnessTrackBar.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.brightnessTrackBar.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.brightnessTrackBar.SmallChange = 1;
            this.brightnessTrackBar.TabIndex = 10;
            this.brightnessTrackBar.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.brightnessTrackBar.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.brightnessTrackBar.ThumbLength = 19;
            this.brightnessTrackBar.ThumbMargin = 1;
            this.brightnessTrackBar.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.brightnessTrackBar.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuToolTip1.SetToolTip(this.brightnessTrackBar, "");
            this.bunifuToolTip1.SetToolTipIcon(this.brightnessTrackBar, null);
            this.bunifuToolTip1.SetToolTipTitle(this.brightnessTrackBar, "");
            this.brightnessTrackBar.Value = 50;
            // 
            // useGpuCheckBox
            // 
            this.useGpuCheckBox.AllowBindingControlAnimation = true;
            this.useGpuCheckBox.AllowBindingControlColorChanges = false;
            this.useGpuCheckBox.AllowBindingControlLocation = true;
            this.useGpuCheckBox.AllowCheckBoxAnimation = false;
            this.useGpuCheckBox.AllowCheckmarkAnimation = true;
            this.useGpuCheckBox.AllowOnHoverStates = true;
            this.useGpuCheckBox.AutoCheck = true;
            this.useGpuCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.useGpuCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("useGpuCheckBox.BackgroundImage")));
            this.useGpuCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.useGpuCheckBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.useGpuCheckBox.BorderRadius = 12;
            this.useGpuCheckBox.Checked = true;
            this.useGpuCheckBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.useGpuCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.useGpuCheckBox.CustomCheckmarkImage = null;
            this.useGpuCheckBox.Location = new System.Drawing.Point(413, 475);
            this.useGpuCheckBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.useGpuCheckBox.Name = "useGpuCheckBox";
            this.useGpuCheckBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.useGpuCheckBox.OnCheck.BorderRadius = 12;
            this.useGpuCheckBox.OnCheck.BorderThickness = 2;
            this.useGpuCheckBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.useGpuCheckBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.useGpuCheckBox.OnCheck.CheckmarkThickness = 2;
            this.useGpuCheckBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.useGpuCheckBox.OnDisable.BorderRadius = 12;
            this.useGpuCheckBox.OnDisable.BorderThickness = 2;
            this.useGpuCheckBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.useGpuCheckBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.useGpuCheckBox.OnDisable.CheckmarkThickness = 2;
            this.useGpuCheckBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.useGpuCheckBox.OnHoverChecked.BorderRadius = 12;
            this.useGpuCheckBox.OnHoverChecked.BorderThickness = 2;
            this.useGpuCheckBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.useGpuCheckBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.useGpuCheckBox.OnHoverChecked.CheckmarkThickness = 2;
            this.useGpuCheckBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.useGpuCheckBox.OnHoverUnchecked.BorderRadius = 12;
            this.useGpuCheckBox.OnHoverUnchecked.BorderThickness = 1;
            this.useGpuCheckBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.useGpuCheckBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.useGpuCheckBox.OnUncheck.BorderRadius = 12;
            this.useGpuCheckBox.OnUncheck.BorderThickness = 1;
            this.useGpuCheckBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.useGpuCheckBox.Size = new System.Drawing.Size(21, 21);
            this.useGpuCheckBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.useGpuCheckBox.TabIndex = 7;
            this.useGpuCheckBox.ThreeState = false;
            this.bunifuToolTip1.SetToolTip(this.useGpuCheckBox, "");
            this.bunifuToolTip1.SetToolTipIcon(this.useGpuCheckBox, null);
            this.useGpuCheckBox.ToolTipText = null;
            this.bunifuToolTip1.SetToolTipTitle(this.useGpuCheckBox, "");
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AcceptsReturn = false;
            this.passwordTextBox.AcceptsTab = false;
            this.passwordTextBox.AnimationSpeed = 200;
            this.passwordTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordTextBox.AutoSizeHeight = true;
            this.passwordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordTextBox.BackgroundImage")));
            this.passwordTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.passwordTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passwordTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.passwordTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.passwordTextBox.BorderRadius = 1;
            this.passwordTextBox.BorderThickness = 1;
            this.passwordTextBox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.passwordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.FillColor = System.Drawing.Color.White;
            this.passwordTextBox.HideSelection = true;
            this.passwordTextBox.IconLeft = null;
            this.passwordTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.IconPadding = 10;
            this.passwordTextBox.IconRight = null;
            this.passwordTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(250, 562);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.passwordTextBox.Modified = false;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.passwordTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordTextBox.OnIdleState = stateProperties4;
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordTextBox.PlaceholderText = "Enter text";
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(260, 43);
            this.passwordTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.TextMarginBottom = 0;
            this.passwordTextBox.TextMarginLeft = 3;
            this.passwordTextBox.TextMarginTop = 1;
            this.passwordTextBox.TextPlaceholder = "Enter text";
            this.bunifuToolTip1.SetToolTip(this.passwordTextBox, "");
            this.bunifuToolTip1.SetToolTipIcon(this.passwordTextBox, null);
            this.bunifuToolTip1.SetToolTipTitle(this.passwordTextBox, "");
            this.passwordTextBox.UseSystemPasswordChar = false;
            this.passwordTextBox.WordWrap = true;
            // 
            // notificationsCheckBox
            // 
            this.notificationsCheckBox.AllowBindingControlAnimation = true;
            this.notificationsCheckBox.AllowBindingControlColorChanges = false;
            this.notificationsCheckBox.AllowBindingControlLocation = true;
            this.notificationsCheckBox.AllowCheckBoxAnimation = false;
            this.notificationsCheckBox.AllowCheckmarkAnimation = true;
            this.notificationsCheckBox.AllowOnHoverStates = true;
            this.notificationsCheckBox.AutoCheck = true;
            this.notificationsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.notificationsCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notificationsCheckBox.BackgroundImage")));
            this.notificationsCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.notificationsCheckBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.notificationsCheckBox.BorderRadius = 12;
            this.notificationsCheckBox.Checked = true;
            this.notificationsCheckBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.notificationsCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.notificationsCheckBox.CustomCheckmarkImage = null;
            this.notificationsCheckBox.Location = new System.Drawing.Point(317, 177);
            this.notificationsCheckBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.notificationsCheckBox.Name = "notificationsCheckBox";
            this.notificationsCheckBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.notificationsCheckBox.OnCheck.BorderRadius = 12;
            this.notificationsCheckBox.OnCheck.BorderThickness = 2;
            this.notificationsCheckBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.notificationsCheckBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.notificationsCheckBox.OnCheck.CheckmarkThickness = 2;
            this.notificationsCheckBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.notificationsCheckBox.OnDisable.BorderRadius = 12;
            this.notificationsCheckBox.OnDisable.BorderThickness = 2;
            this.notificationsCheckBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.notificationsCheckBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.notificationsCheckBox.OnDisable.CheckmarkThickness = 2;
            this.notificationsCheckBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.notificationsCheckBox.OnHoverChecked.BorderRadius = 12;
            this.notificationsCheckBox.OnHoverChecked.BorderThickness = 2;
            this.notificationsCheckBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.notificationsCheckBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.notificationsCheckBox.OnHoverChecked.CheckmarkThickness = 2;
            this.notificationsCheckBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.notificationsCheckBox.OnHoverUnchecked.BorderRadius = 12;
            this.notificationsCheckBox.OnHoverUnchecked.BorderThickness = 1;
            this.notificationsCheckBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.notificationsCheckBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.notificationsCheckBox.OnUncheck.BorderRadius = 12;
            this.notificationsCheckBox.OnUncheck.BorderThickness = 1;
            this.notificationsCheckBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.notificationsCheckBox.Size = new System.Drawing.Size(21, 21);
            this.notificationsCheckBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.notificationsCheckBox.TabIndex = 5;
            this.notificationsCheckBox.ThreeState = false;
            this.bunifuToolTip1.SetToolTip(this.notificationsCheckBox, "");
            this.bunifuToolTip1.SetToolTipIcon(this.notificationsCheckBox, null);
            this.notificationsCheckBox.ToolTipText = null;
            this.bunifuToolTip1.SetToolTipTitle(this.notificationsCheckBox, "");
            
            // 
            // trackBar
            // 
            this.trackBar.AllowCursorChanges = true;
            this.trackBar.AllowHomeEndKeysDetection = false;
            this.trackBar.AllowIncrementalClickMoves = true;
            this.trackBar.AllowMouseDownEffects = false;
            this.trackBar.AllowMouseHoverEffects = false;
            this.trackBar.AllowScrollingAnimations = true;
            this.trackBar.AllowScrollKeysDetection = true;
            this.trackBar.AllowScrollOptionsMenu = true;
            this.trackBar.AllowShrinkingOnFocusLost = false;
            this.trackBar.BackColor = System.Drawing.Color.Transparent;
            this.trackBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trackBar.BackgroundImage")));
            this.trackBar.BindingContainer = null;
            this.trackBar.BorderRadius = 2;
            this.trackBar.BorderThickness = 1;
            this.trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar.DrawThickBorder = false;
            this.trackBar.DurationBeforeShrink = 2000;
            this.trackBar.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.trackBar.LargeChange = 10;
            this.trackBar.Location = new System.Drawing.Point(250, 47);
            this.trackBar.Maximum = 20;
            this.trackBar.Minimum = 1;
            this.trackBar.MinimumSize = new System.Drawing.Size(0, 31);
            this.trackBar.MinimumThumbLength = 18;
            this.trackBar.Name = "trackBar";
            this.trackBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.trackBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.trackBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.trackBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.trackBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.trackBar.ShrinkSizeLimit = 3;
            this.trackBar.Size = new System.Drawing.Size(200, 31);
            this.trackBar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.trackBar.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.trackBar.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.trackBar.SmallChange = 1;
            this.trackBar.TabIndex = 1;
            this.trackBar.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.trackBar.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.trackBar.ThumbLength = 100;
            this.trackBar.ThumbMargin = 1;
            this.trackBar.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.trackBar.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuToolTip1.SetToolTip(this.trackBar, "");
            this.bunifuToolTip1.SetToolTipIcon(this.trackBar, null);
            this.bunifuToolTip1.SetToolTipTitle(this.trackBar, "");
            this.trackBar.Value = 2;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "bunifuButton1";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges3;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.Empty;
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeft = null;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRight = null;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleBorderRadius = 0;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(803, 133);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(150, 39);
            this.bunifuButton1.TabIndex = 23;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.bunifuButton1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuButton1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuButton1, "");
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.bunifuIconButton1);
            this.Controls.Add(this.soundsComboBox);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.useGpuLabel);
            this.Controls.Add(this.cameraSettingsLabel);
            this.Controls.Add(this.optimisationLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.notificationLabel);
            this.Controls.Add(this.sensetivityLabel);
            this.Controls.Add(this.saturationTrackBar);
            this.Controls.Add(this.contrastTrackBar);
            this.Controls.Add(this.brightnessTrackBar);
            this.Controls.Add(this.cameraSourceComboBox);
            this.Controls.Add(this.videoQualityComboBox);
            this.Controls.Add(this.useGpuCheckBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.notificationsCheckBox);
            this.Controls.Add(this.trackBar);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(1000, 650);
            this.bunifuToolTip1.SetToolTip(this, "");
            this.bunifuToolTip1.SetToolTipIcon(this, null);
            this.bunifuToolTip1.SetToolTipTitle(this, "");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuHSlider trackBar;
        private Bunifu.UI.WinForms.BunifuCheckBox notificationsCheckBox;
        private Bunifu.UI.WinForms.BunifuTextBox passwordTextBox;
        private Bunifu.UI.WinForms.BunifuCheckBox useGpuCheckBox;
        private System.Windows.Forms.ComboBox videoQualityComboBox;
        private System.Windows.Forms.ComboBox cameraSourceComboBox;
        private Bunifu.UI.WinForms.BunifuHSlider brightnessTrackBar;
        private Bunifu.UI.WinForms.BunifuHSlider contrastTrackBar;
        private Bunifu.UI.WinForms.BunifuHSlider saturationTrackBar;
        private Bunifu.UI.WinForms.BunifuLabel sensetivityLabel;
        private Bunifu.UI.WinForms.BunifuLabel notificationLabel;
        private Bunifu.UI.WinForms.BunifuLabel passwordLabel;
        private Bunifu.UI.WinForms.BunifuLabel optimisationLabel;
        private Bunifu.UI.WinForms.BunifuLabel cameraSettingsLabel;
        private Bunifu.UI.WinForms.BunifuLabel useGpuLabel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private System.Windows.Forms.ComboBox soundsComboBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
    }
}
