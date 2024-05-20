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
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.imageBoxLogEntry = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxLogEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.Font = new System.Drawing.Font("Involve", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.ItemHeight = 26;
            this.listBoxLogs.Location = new System.Drawing.Point(18, 64);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(423, 342);
            this.listBoxLogs.TabIndex = 0;
            this.listBoxLogs.SelectedIndexChanged += new System.EventHandler(this.logListBox_SelectedIndexChanged);
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
            this.bunifuDatePicker1.Location = new System.Drawing.Point(18, 13);
            this.bunifuDatePicker1.MinDate = new System.DateTime(2024, 1, 2, 0, 0, 0, 0);
            this.bunifuDatePicker1.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDatePicker1.Name = "bunifuDatePicker1";
            this.bunifuDatePicker1.Size = new System.Drawing.Size(220, 34);
            this.bunifuDatePicker1.TabIndex = 1;
            // 
            // imageBoxLogEntry
            // 
            this.imageBoxLogEntry.Location = new System.Drawing.Point(511, 113);
            this.imageBoxLogEntry.Name = "imageBoxLogEntry";
            this.imageBoxLogEntry.Size = new System.Drawing.Size(333, 293);
            this.imageBoxLogEntry.TabIndex = 2;
            this.imageBoxLogEntry.TabStop = false;
            // 
            // JournalUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.imageBoxLogEntry);
            this.Controls.Add(this.bunifuDatePicker1);
            this.Controls.Add(this.listBoxLogs);
            this.Name = "JournalUserControl";
            this.Size = new System.Drawing.Size(1000, 650);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxLogEntry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLogs;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
        private Emgu.CV.UI.ImageBox imageBoxLogEntry;
    }
}
