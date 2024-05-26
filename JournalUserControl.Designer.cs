namespace MultiFaceRec
{
    partial class JournalUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.imageBoxLogEntry = new Emgu.CV.UI.ImageBox();
            this.logDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.DataGridColumnDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.FilterButton = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxLogEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDatePicker1
            // 
            this.bunifuDatePicker1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDatePicker1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuDatePicker1.BorderRadius = 1;
            this.bunifuDatePicker1.Color = System.Drawing.Color.Silver;
            this.bunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.DisplayWeekNumbers = false;
            this.bunifuDatePicker1.DPHeight = 0;
            this.bunifuDatePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePicker1.FillDatePicker = false;
            this.bunifuDatePicker1.Font = new System.Drawing.Font("Involve", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuDatePicker1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatePicker1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker1.Icon")));
            this.bunifuDatePicker1.IconColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker1.LeftTextMargin = 5;
            this.bunifuDatePicker1.Location = new System.Drawing.Point(250, 48);
            this.bunifuDatePicker1.MinDate = new System.DateTime(2024, 1, 2, 0, 0, 0, 0);
            this.bunifuDatePicker1.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDatePicker1.Name = "bunifuDatePicker1";
            this.bunifuDatePicker1.Size = new System.Drawing.Size(242, 34);
            this.bunifuDatePicker1.TabIndex = 1;
            this.bunifuDatePicker1.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // imageBoxLogEntry
            // 
            this.imageBoxLogEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxLogEntry.Location = new System.Drawing.Point(500, 95);
            this.imageBoxLogEntry.Name = "imageBoxLogEntry";
            this.imageBoxLogEntry.Size = new System.Drawing.Size(484, 384);
            this.imageBoxLogEntry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxLogEntry.TabIndex = 2;
            this.imageBoxLogEntry.TabStop = false;
            // 
            // logDataGridView
            // 
            this.logDataGridView.AllowCustomTheming = true;
            this.logDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.logDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.logDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.logDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.logDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.logDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11.75F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.logDataGridView.ColumnHeadersHeight = 40;
            this.logDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridColumnDateTime,
            this.DataGridColumnName});
            this.logDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.logDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.logDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.logDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.logDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.logDataGridView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.logDataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.logDataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.logDataGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.75F);
            this.logDataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.logDataGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.White;
            this.logDataGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.logDataGridView.CurrentTheme.Name = null;
            this.logDataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.logDataGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.logDataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.logDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.logDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.logDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.logDataGridView.EnableHeadersVisualStyles = false;
            this.logDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.logDataGridView.HeaderBackColor = System.Drawing.Color.White;
            this.logDataGridView.HeaderBgColor = System.Drawing.Color.Empty;
            this.logDataGridView.HeaderForeColor = System.Drawing.Color.Black;
            this.logDataGridView.Location = new System.Drawing.Point(18, 95);
            this.logDataGridView.Name = "logDataGridView";
            this.logDataGridView.RowHeadersVisible = false;
            this.logDataGridView.RowHeadersWidth = 51;
            this.logDataGridView.RowTemplate.Height = 40;
            this.logDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.logDataGridView.Size = new System.Drawing.Size(476, 479);
            this.logDataGridView.TabIndex = 3;
            this.logDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // DataGridColumnDateTime
            // 
            this.DataGridColumnDateTime.HeaderText = "Время";
            this.DataGridColumnDateTime.MinimumWidth = 6;
            this.DataGridColumnDateTime.Name = "DataGridColumnDateTime";
            this.DataGridColumnDateTime.ReadOnly = true;
            // 
            // DataGridColumnName
            // 
            this.DataGridColumnName.HeaderText = "Имя";
            this.DataGridColumnName.MinimumWidth = 6;
            this.DataGridColumnName.Name = "DataGridColumnName";
            this.DataGridColumnName.ReadOnly = true;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel1.Location = new System.Drawing.Point(18, 49);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(185, 28);
            this.bunifuLabel1.TabIndex = 4;
            this.bunifuLabel1.Text = "Фильтрация по дате";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // FilterButton
            // 
            this.FilterButton.AllowBindingControlAnimation = true;
            this.FilterButton.AllowBindingControlColorChanges = false;
            this.FilterButton.AllowBindingControlLocation = true;
            this.FilterButton.AllowCheckBoxAnimation = false;
            this.FilterButton.AllowCheckmarkAnimation = true;
            this.FilterButton.AllowOnHoverStates = true;
            this.FilterButton.AutoCheck = true;
            this.FilterButton.BackColor = System.Drawing.Color.Transparent;
            this.FilterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FilterButton.BackgroundImage")));
            this.FilterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FilterButton.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.FilterButton.BorderRadius = 12;
            this.FilterButton.Checked = true;
            this.FilterButton.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.FilterButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.FilterButton.CustomCheckmarkImage = null;
            this.FilterButton.Location = new System.Drawing.Point(215, 50);
            this.FilterButton.MinimumSize = new System.Drawing.Size(17, 17);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.FilterButton.OnCheck.BorderRadius = 12;
            this.FilterButton.OnCheck.BorderThickness = 2;
            this.FilterButton.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.FilterButton.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.FilterButton.OnCheck.CheckmarkThickness = 2;
            this.FilterButton.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.FilterButton.OnDisable.BorderRadius = 12;
            this.FilterButton.OnDisable.BorderThickness = 2;
            this.FilterButton.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.FilterButton.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.FilterButton.OnDisable.CheckmarkThickness = 2;
            this.FilterButton.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.FilterButton.OnHoverChecked.BorderRadius = 12;
            this.FilterButton.OnHoverChecked.BorderThickness = 2;
            this.FilterButton.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.FilterButton.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.FilterButton.OnHoverChecked.CheckmarkThickness = 2;
            this.FilterButton.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.FilterButton.OnHoverUnchecked.BorderRadius = 12;
            this.FilterButton.OnHoverUnchecked.BorderThickness = 1;
            this.FilterButton.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.FilterButton.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.FilterButton.OnUncheck.BorderRadius = 12;
            this.FilterButton.OnUncheck.BorderThickness = 1;
            this.FilterButton.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.FilterButton.Size = new System.Drawing.Size(29, 29);
            this.FilterButton.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.FilterButton.TabIndex = 6;
            this.FilterButton.ThreeState = false;
            this.FilterButton.ToolTipText = null;
            this.FilterButton.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.notificationsCheckBox_CheckedChanged);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel2.Location = new System.Drawing.Point(690, 49);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(116, 28);
            this.bunifuLabel2.TabIndex = 7;
            this.bunifuLabel2.Text = "Фото записи";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // JournalUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.logDataGridView);
            this.Controls.Add(this.imageBoxLogEntry);
            this.Controls.Add(this.bunifuDatePicker1);
            this.Name = "JournalUserControl";
            this.Size = new System.Drawing.Size(1000, 650);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxLogEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
        private Emgu.CV.UI.ImageBox imageBoxLogEntry;
        private Bunifu.UI.WinForms.BunifuDataGridView logDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnName;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuCheckBox FilterButton;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
    }
}
