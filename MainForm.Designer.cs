﻿namespace MultiFaceRec
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuFormDrag1 = new Bunifu.UI.WinForms.BunifuFormDrag();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuFormControlBox1 = new Bunifu.UI.WinForms.BunifuFormControlBox();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.facerecBackgroundUserControl = new Bunifu.UI.WinForms.BunifuUserControl();
            this.bunifuButton21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.sidebar = new Bunifu.UI.WinForms.BunifuPanel();
            this.JournalLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.JournalImageButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.settingsLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.settingImageButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.faceRecLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.faceRecImageButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.journalUserControl1 = new MultiFaceRec.JournalUserControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGroupBox1.SuspendLayout();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(116, 247);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "2. Add face";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 209);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Sergio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(833, 392);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(245, 298);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name: ";
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(15, 22);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(4);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(217, 164);
            this.imageBox1.TabIndex = 5;
            this.imageBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(833, 59);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(279, 298);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Persons present in the scene:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nobody";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(217, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Number of faces detected: ";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(112, 220);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "1. Detect and recognize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuFormDrag1
            // 
            this.bunifuFormDrag1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDrag1.ContainerControl = this;
            this.bunifuFormDrag1.DockIndicatorsOpacity = 0.5D;
            this.bunifuFormDrag1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDrag1.DockingOptions.DockAll = false;
            this.bunifuFormDrag1.DockingOptions.DockBottomLeft = false;
            this.bunifuFormDrag1.DockingOptions.DockBottomRight = false;
            this.bunifuFormDrag1.DockingOptions.DockFullScreen = false;
            this.bunifuFormDrag1.DockingOptions.DockLeft = false;
            this.bunifuFormDrag1.DockingOptions.DockRight = false;
            this.bunifuFormDrag1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDrag1.DockingOptions.DockTopRight = true;
            this.bunifuFormDrag1.DragOpacity = 0.9D;
            this.bunifuFormDrag1.Enabled = true;
            this.bunifuFormDrag1.ParentForm = this;
            this.bunifuFormDrag1.ShowCursorChanges = true;
            this.bunifuFormDrag1.ShowDockingIndicators = true;
            this.bunifuFormDrag1.TitleBarOptions.BunifuFormDrag = this.bunifuFormDrag1;
            this.bunifuFormDrag1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDrag1.TitleBarOptions.Enabled = true;
            this.bunifuFormDrag1.TitleBarOptions.TitleBarControl = this.bunifuGradientPanel1;
            this.bunifuFormDrag1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 0;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuGroupBox1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFormControlBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(161)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(179)))), ((int)(((byte)(222)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(161)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(161)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1280, 40);
            this.bunifuGradientPanel1.TabIndex = 12;
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(161)))), ((int)(((byte)(212)))));
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuGroupBox1.BorderRadius = 0;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(3, 0);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(74, 44);
            this.bunifuGroupBox1.TabIndex = 13;
            this.bunifuGroupBox1.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::MultiFaceRec.Properties.Resources.png_transparent_menu_feather_icon;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 20;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(6, -6);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(50, 50);
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuFormControlBox1
            // 
            this.bunifuFormControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFormControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormControlBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFormControlBox1.BunifuFormDrag = null;
            this.bunifuFormControlBox1.CloseBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormControlBox1.CloseBoxOptions.BorderRadius = 0;
            this.bunifuFormControlBox1.CloseBoxOptions.Enabled = true;
            this.bunifuFormControlBox1.CloseBoxOptions.EnableDefaultAction = true;
            this.bunifuFormControlBox1.CloseBoxOptions.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.bunifuFormControlBox1.CloseBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuFormControlBox1.CloseBoxOptions.Icon")));
            this.bunifuFormControlBox1.CloseBoxOptions.IconAlt = null;
            this.bunifuFormControlBox1.CloseBoxOptions.IconColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.CloseBoxOptions.IconHoverColor = System.Drawing.Color.White;
            this.bunifuFormControlBox1.CloseBoxOptions.IconPressedColor = System.Drawing.Color.White;
            this.bunifuFormControlBox1.CloseBoxOptions.IconSize = new System.Drawing.Size(18, 18);
            this.bunifuFormControlBox1.CloseBoxOptions.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.bunifuFormControlBox1.HelpBox = false;
            this.bunifuFormControlBox1.HelpBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormControlBox1.HelpBoxOptions.BorderRadius = 0;
            this.bunifuFormControlBox1.HelpBoxOptions.Enabled = true;
            this.bunifuFormControlBox1.HelpBoxOptions.EnableDefaultAction = true;
            this.bunifuFormControlBox1.HelpBoxOptions.HoverColor = System.Drawing.Color.LightGray;
            this.bunifuFormControlBox1.HelpBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuFormControlBox1.HelpBoxOptions.Icon")));
            this.bunifuFormControlBox1.HelpBoxOptions.IconAlt = null;
            this.bunifuFormControlBox1.HelpBoxOptions.IconColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.HelpBoxOptions.IconHoverColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.HelpBoxOptions.IconPressedColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.HelpBoxOptions.IconSize = new System.Drawing.Size(22, 22);
            this.bunifuFormControlBox1.HelpBoxOptions.PressedColor = System.Drawing.Color.Silver;
            this.bunifuFormControlBox1.Location = new System.Drawing.Point(1141, -5);
            this.bunifuFormControlBox1.MaximizeBox = false;
            this.bunifuFormControlBox1.MaximizeBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormControlBox1.MaximizeBoxOptions.BorderRadius = 0;
            this.bunifuFormControlBox1.MaximizeBoxOptions.Enabled = true;
            this.bunifuFormControlBox1.MaximizeBoxOptions.EnableDefaultAction = true;
            this.bunifuFormControlBox1.MaximizeBoxOptions.HoverColor = System.Drawing.Color.LightGray;
            this.bunifuFormControlBox1.MaximizeBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuFormControlBox1.MaximizeBoxOptions.Icon")));
            this.bunifuFormControlBox1.MaximizeBoxOptions.IconAlt = ((System.Drawing.Image)(resources.GetObject("bunifuFormControlBox1.MaximizeBoxOptions.IconAlt")));
            this.bunifuFormControlBox1.MaximizeBoxOptions.IconColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.MaximizeBoxOptions.IconHoverColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.MaximizeBoxOptions.IconPressedColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.MaximizeBoxOptions.IconSize = new System.Drawing.Size(16, 16);
            this.bunifuFormControlBox1.MaximizeBoxOptions.PressedColor = System.Drawing.Color.Silver;
            this.bunifuFormControlBox1.MinimizeBox = true;
            this.bunifuFormControlBox1.MinimizeBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormControlBox1.MinimizeBoxOptions.BorderRadius = 0;
            this.bunifuFormControlBox1.MinimizeBoxOptions.Enabled = true;
            this.bunifuFormControlBox1.MinimizeBoxOptions.EnableDefaultAction = true;
            this.bunifuFormControlBox1.MinimizeBoxOptions.HoverColor = System.Drawing.Color.LightGray;
            this.bunifuFormControlBox1.MinimizeBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuFormControlBox1.MinimizeBoxOptions.Icon")));
            this.bunifuFormControlBox1.MinimizeBoxOptions.IconAlt = null;
            this.bunifuFormControlBox1.MinimizeBoxOptions.IconColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.MinimizeBoxOptions.IconHoverColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.MinimizeBoxOptions.IconPressedColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.MinimizeBoxOptions.IconSize = new System.Drawing.Size(14, 14);
            this.bunifuFormControlBox1.MinimizeBoxOptions.PressedColor = System.Drawing.Color.Silver;
            this.bunifuFormControlBox1.Name = "bunifuFormControlBox1";
            this.bunifuFormControlBox1.ShowDesignBorders = false;
            this.bunifuFormControlBox1.Size = new System.Drawing.Size(136, 49);
            this.bunifuFormControlBox1.TabIndex = 11;
            this.bunifuFormControlBox1.HelpClicked += new System.EventHandler(this.bunifuFormControlBox1_HelpClicked);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 20;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // facerecBackgroundUserControl
            // 
            this.facerecBackgroundUserControl.AllowAnimations = false;
            this.facerecBackgroundUserControl.AllowBorderColorChanges = false;
            this.facerecBackgroundUserControl.AllowMouseEffects = false;
            this.facerecBackgroundUserControl.AnimationSpeed = 200;
            this.facerecBackgroundUserControl.BackColor = System.Drawing.Color.Transparent;
            this.facerecBackgroundUserControl.BackgroundColor = System.Drawing.Color.White;
            this.facerecBackgroundUserControl.BorderColor = System.Drawing.Color.Transparent;
            this.facerecBackgroundUserControl.BorderRadius = 0;
            this.facerecBackgroundUserControl.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.facerecBackgroundUserControl.BorderThickness = 0;
            this.facerecBackgroundUserControl.ColorContrastOnClick = 30;
            this.facerecBackgroundUserControl.ColorContrastOnHover = 30;
            this.facerecBackgroundUserControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.facerecBackgroundUserControl.Image = null;
            this.facerecBackgroundUserControl.ImageMargin = new System.Windows.Forms.Padding(0);
            this.facerecBackgroundUserControl.Location = new System.Drawing.Point(251, 46);
            this.facerecBackgroundUserControl.Name = "facerecBackgroundUserControl";
            this.facerecBackgroundUserControl.ShowBorders = true;
            this.facerecBackgroundUserControl.Size = new System.Drawing.Size(1000, 650);
            this.facerecBackgroundUserControl.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.facerecBackgroundUserControl.TabIndex = 13;
            // 
            // bunifuButton21
            // 
            this.bunifuButton21.AllowAnimations = true;
            this.bunifuButton21.AllowMouseEffects = true;
            this.bunifuButton21.AllowToggling = false;
            this.bunifuButton21.AnimationSpeed = 200;
            this.bunifuButton21.AutoGenerateColors = false;
            this.bunifuButton21.AutoRoundBorders = false;
            this.bunifuButton21.AutoSizeLeftIcon = true;
            this.bunifuButton21.AutoSizeRightIcon = true;
            this.bunifuButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton21.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton21.BackgroundImage")));
            this.bunifuButton21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.ButtonText = "bunifuButton21";
            this.bunifuButton21.ButtonTextMarginLeft = 0;
            this.bunifuButton21.ColorContrastOnClick = 45;
            this.bunifuButton21.ColorContrastOnHover = 45;
            this.bunifuButton21.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton21.CustomizableEdges = borderEdges2;
            this.bunifuButton21.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton21.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton21.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton21.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton21.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton21.IconMarginLeft = 11;
            this.bunifuButton21.IconPadding = 10;
            this.bunifuButton21.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton21.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton21.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton21.IconSize = 25;
            this.bunifuButton21.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton21.IdleBorderRadius = 1;
            this.bunifuButton21.IdleBorderThickness = 1;
            this.bunifuButton21.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton21.IdleIconLeftImage = null;
            this.bunifuButton21.IdleIconRightImage = null;
            this.bunifuButton21.IndicateFocus = false;
            this.bunifuButton21.Location = new System.Drawing.Point(474, 474);
            this.bunifuButton21.Name = "bunifuButton21";
            this.bunifuButton21.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.OnDisabledState.BorderRadius = 1;
            this.bunifuButton21.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnDisabledState.BorderThickness = 1;
            this.bunifuButton21.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.OnDisabledState.IconLeftImage = null;
            this.bunifuButton21.OnDisabledState.IconRightImage = null;
            this.bunifuButton21.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton21.onHoverState.BorderRadius = 1;
            this.bunifuButton21.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.onHoverState.BorderThickness = 1;
            this.bunifuButton21.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton21.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.onHoverState.IconLeftImage = null;
            this.bunifuButton21.onHoverState.IconRightImage = null;
            this.bunifuButton21.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton21.OnIdleState.BorderRadius = 1;
            this.bunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnIdleState.BorderThickness = 1;
            this.bunifuButton21.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton21.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.OnIdleState.IconLeftImage = null;
            this.bunifuButton21.OnIdleState.IconRightImage = null;
            this.bunifuButton21.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton21.OnPressedState.BorderRadius = 1;
            this.bunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnPressedState.BorderThickness = 1;
            this.bunifuButton21.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton21.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.OnPressedState.IconLeftImage = null;
            this.bunifuButton21.OnPressedState.IconRightImage = null;
            this.bunifuButton21.Size = new System.Drawing.Size(150, 39);
            this.bunifuButton21.TabIndex = 15;
            this.bunifuButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton21.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton21.TextMarginLeft = 0;
            this.bunifuButton21.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton21.UseDefaultRadiusAndThickness = true;
            this.bunifuButton21.Click += new System.EventHandler(this.bunifuButton21_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidebar.BackgroundImage")));
            this.sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidebar.BorderColor = System.Drawing.Color.Transparent;
            this.sidebar.BorderRadius = 0;
            this.sidebar.BorderThickness = 0;
            this.sidebar.Controls.Add(this.JournalLabel);
            this.sidebar.Controls.Add(this.JournalImageButton);
            this.sidebar.Controls.Add(this.settingsLabel);
            this.sidebar.Controls.Add(this.settingImageButton);
            this.sidebar.Controls.Add(this.faceRecLabel);
            this.sidebar.Controls.Add(this.faceRecImageButton);
            this.sidebar.Location = new System.Drawing.Point(0, 39);
            this.sidebar.MaximumSize = new System.Drawing.Size(245, 700);
            this.sidebar.MinimumSize = new System.Drawing.Size(70, 700);
            this.sidebar.Name = "sidebar";
            this.sidebar.ShowBorders = true;
            this.sidebar.Size = new System.Drawing.Size(245, 700);
            this.sidebar.TabIndex = 10;
            // 
            // JournalLabel
            // 
            this.JournalLabel.AllowParentOverrides = false;
            this.JournalLabel.AutoEllipsis = false;
            this.JournalLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.JournalLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.JournalLabel.Font = new System.Drawing.Font("Involve", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JournalLabel.Location = new System.Drawing.Point(69, 133);
            this.JournalLabel.Name = "JournalLabel";
            this.JournalLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.JournalLabel.Size = new System.Drawing.Size(79, 26);
            this.JournalLabel.TabIndex = 5;
            this.JournalLabel.Text = "Журнал";
            this.JournalLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.JournalLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.JournalLabel.Click += new System.EventHandler(this.JournalImageButton_Click);
            this.JournalLabel.MouseEnter += new System.EventHandler(this.JournalLabel_MouseEnter);
            this.JournalLabel.MouseLeave += new System.EventHandler(this.JournalLabel_MouseLeave);
            // 
            // JournalImageButton
            // 
            this.JournalImageButton.ActiveImage = null;
            this.JournalImageButton.AllowAnimations = true;
            this.JournalImageButton.AllowBuffering = false;
            this.JournalImageButton.AllowToggling = false;
            this.JournalImageButton.AllowZooming = true;
            this.JournalImageButton.AllowZoomingOnFocus = false;
            this.JournalImageButton.BackColor = System.Drawing.Color.Gainsboro;
            this.JournalImageButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.JournalImageButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("JournalImageButton.ErrorImage")));
            this.JournalImageButton.FadeWhenInactive = false;
            this.JournalImageButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.JournalImageButton.Image = global::MultiFaceRec.Properties.Resources.journal1;
            this.JournalImageButton.ImageActive = null;
            this.JournalImageButton.ImageLocation = null;
            this.JournalImageButton.ImageMargin = 20;
            this.JournalImageButton.ImageSize = new System.Drawing.Size(40, 40);
            this.JournalImageButton.ImageZoomSize = new System.Drawing.Size(60, 60);
            this.JournalImageButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("JournalImageButton.InitialImage")));
            this.JournalImageButton.Location = new System.Drawing.Point(3, 113);
            this.JournalImageButton.Name = "JournalImageButton";
            this.JournalImageButton.Rotation = 0;
            this.JournalImageButton.ShowActiveImage = true;
            this.JournalImageButton.ShowCursorChanges = true;
            this.JournalImageButton.ShowImageBorders = true;
            this.JournalImageButton.ShowSizeMarkers = false;
            this.JournalImageButton.Size = new System.Drawing.Size(60, 60);
            this.JournalImageButton.TabIndex = 4;
            this.JournalImageButton.ToolTipText = "";
            this.JournalImageButton.WaitOnLoad = false;
            this.JournalImageButton.Zoom = 20;
            this.JournalImageButton.ZoomSpeed = 10;
            this.JournalImageButton.Click += new System.EventHandler(this.JournalImageButton_Click);
            // 
            // settingsLabel
            // 
            this.settingsLabel.AllowParentOverrides = false;
            this.settingsLabel.AutoEllipsis = false;
            this.settingsLabel.CursorType = null;
            this.settingsLabel.Font = new System.Drawing.Font("Involve", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsLabel.Location = new System.Drawing.Point(69, 616);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.settingsLabel.Size = new System.Drawing.Size(110, 26);
            this.settingsLabel.TabIndex = 3;
            this.settingsLabel.Text = "Настройки";
            this.settingsLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.settingsLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.settingsLabel.Click += new System.EventHandler(this.settingImageButton_Click);
            this.settingsLabel.MouseEnter += new System.EventHandler(this.settingsLabel_MouseEnter);
            this.settingsLabel.MouseLeave += new System.EventHandler(this.settingsLabel_MouseLeave);
            // 
            // settingImageButton
            // 
            this.settingImageButton.ActiveImage = null;
            this.settingImageButton.AllowAnimations = true;
            this.settingImageButton.AllowBuffering = false;
            this.settingImageButton.AllowToggling = false;
            this.settingImageButton.AllowZooming = true;
            this.settingImageButton.AllowZoomingOnFocus = false;
            this.settingImageButton.BackColor = System.Drawing.Color.Gainsboro;
            this.settingImageButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.settingImageButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("settingImageButton.ErrorImage")));
            this.settingImageButton.FadeWhenInactive = false;
            this.settingImageButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.settingImageButton.Image = global::MultiFaceRec.Properties.Resources.windows_settings_app_icon_292036;
            this.settingImageButton.ImageActive = null;
            this.settingImageButton.ImageLocation = null;
            this.settingImageButton.ImageMargin = 20;
            this.settingImageButton.ImageSize = new System.Drawing.Size(40, 40);
            this.settingImageButton.ImageZoomSize = new System.Drawing.Size(60, 60);
            this.settingImageButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("settingImageButton.InitialImage")));
            this.settingImageButton.Location = new System.Drawing.Point(3, 596);
            this.settingImageButton.Name = "settingImageButton";
            this.settingImageButton.Rotation = 0;
            this.settingImageButton.ShowActiveImage = true;
            this.settingImageButton.ShowCursorChanges = true;
            this.settingImageButton.ShowImageBorders = true;
            this.settingImageButton.ShowSizeMarkers = false;
            this.settingImageButton.Size = new System.Drawing.Size(60, 60);
            this.settingImageButton.TabIndex = 2;
            this.settingImageButton.ToolTipText = "";
            this.settingImageButton.WaitOnLoad = false;
            this.settingImageButton.Zoom = 20;
            this.settingImageButton.ZoomSpeed = 10;
            this.settingImageButton.Click += new System.EventHandler(this.settingImageButton_Click);
            // 
            // faceRecLabel
            // 
            this.faceRecLabel.AllowParentOverrides = false;
            this.faceRecLabel.AutoEllipsis = false;
            this.faceRecLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.faceRecLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.faceRecLabel.Font = new System.Drawing.Font("Involve", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.faceRecLabel.Location = new System.Drawing.Point(69, 44);
            this.faceRecLabel.Name = "faceRecLabel";
            this.faceRecLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.faceRecLabel.Size = new System.Drawing.Size(161, 26);
            this.faceRecLabel.TabIndex = 1;
            this.faceRecLabel.Text = "Распознование";
            this.faceRecLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.faceRecLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.faceRecLabel.Click += new System.EventHandler(this.faceRecImageButton_Click);
            this.faceRecLabel.MouseEnter += new System.EventHandler(this.faceRecLabel_MouseEnter);
            this.faceRecLabel.MouseLeave += new System.EventHandler(this.faceRecLabel_MouseLeave);
            // 
            // faceRecImageButton
            // 
            this.faceRecImageButton.ActiveImage = null;
            this.faceRecImageButton.AllowAnimations = true;
            this.faceRecImageButton.AllowBuffering = false;
            this.faceRecImageButton.AllowToggling = false;
            this.faceRecImageButton.AllowZooming = true;
            this.faceRecImageButton.AllowZoomingOnFocus = false;
            this.faceRecImageButton.BackColor = System.Drawing.Color.Gainsboro;
            this.faceRecImageButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.faceRecImageButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("faceRecImageButton.ErrorImage")));
            this.faceRecImageButton.FadeWhenInactive = false;
            this.faceRecImageButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.faceRecImageButton.Image = global::MultiFaceRec.Properties.Resources.png_transparent_facial_recognition_system_computer_icons_reconnaissance_text_emoticon_black_and_white;
            this.faceRecImageButton.ImageActive = null;
            this.faceRecImageButton.ImageLocation = null;
            this.faceRecImageButton.ImageMargin = 20;
            this.faceRecImageButton.ImageSize = new System.Drawing.Size(40, 40);
            this.faceRecImageButton.ImageZoomSize = new System.Drawing.Size(60, 60);
            this.faceRecImageButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("faceRecImageButton.InitialImage")));
            this.faceRecImageButton.Location = new System.Drawing.Point(3, 24);
            this.faceRecImageButton.Name = "faceRecImageButton";
            this.faceRecImageButton.Rotation = 0;
            this.faceRecImageButton.ShowActiveImage = true;
            this.faceRecImageButton.ShowCursorChanges = true;
            this.faceRecImageButton.ShowImageBorders = true;
            this.faceRecImageButton.ShowSizeMarkers = false;
            this.faceRecImageButton.Size = new System.Drawing.Size(60, 60);
            this.faceRecImageButton.TabIndex = 0;
            this.faceRecImageButton.ToolTipText = "";
            this.faceRecImageButton.WaitOnLoad = false;
            this.faceRecImageButton.Zoom = 20;
            this.faceRecImageButton.ZoomSpeed = 10;
            this.faceRecImageButton.Click += new System.EventHandler(this.faceRecImageButton_Click);
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(294, 102);
            this.imageBoxFrameGrabber.Margin = new System.Windows.Forms.Padding(4);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(426, 295);
            this.imageBoxFrameGrabber.TabIndex = 4;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // journalUserControl1
            // 
            this.journalUserControl1.Location = new System.Drawing.Point(251, 46);
            this.journalUserControl1.Name = "journalUserControl1";
            this.journalUserControl1.Size = new System.Drawing.Size(1000, 650);
            this.journalUserControl1.TabIndex = 16;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.journalUserControl1);
            this.Controls.Add(this.bunifuButton21);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Controls.Add(this.facerecBackgroundUserControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGroupBox1.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuPanel sidebar;
        private Bunifu.UI.WinForms.BunifuFormControlBox bunifuFormControlBox1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuImageButton faceRecImageButton;
        private Bunifu.UI.WinForms.BunifuLabel faceRecLabel;
        private Bunifu.UI.WinForms.BunifuLabel settingsLabel;
        private Bunifu.UI.WinForms.BunifuImageButton settingImageButton;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuFormDrag bunifuFormDrag1;
        private System.Windows.Forms.Timer sidebarTimer;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Bunifu.UI.WinForms.BunifuUserControl facerecBackgroundUserControl;
        private Bunifu.UI.WinForms.BunifuLabel JournalLabel;
        private Bunifu.UI.WinForms.BunifuImageButton JournalImageButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton21;
        private JournalUserControl journalUserControl1;
    }
}

