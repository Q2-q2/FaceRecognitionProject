using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class JournalUserControl : UserControl
    {
        public event EventHandler LogDataGridViewCellClick;
        public event EventHandler DatePickerValueChanged;
        public JournalUserControl()
        {
            InitializeComponent();
        }
        public Bunifu.UI.WinForms.BunifuDatePicker DatePicker
        {
            get { return bunifuDatePicker1; }
        }
        public Bunifu.UI.WinForms.BunifuDataGridView LogDataGrid
        {
            get { return logDataGridView; } 
        }
        public ImageBox LogImageBox 
        {
            get { return imageBoxLogEntry; } 
        }

        private void JournalUserControl_Load(object sender, EventArgs e)
        {
            bunifuDatePicker1.Value = DateTime.Now;
            logDataGridView.CellContentClick += DataGridView_CellContentClick;
            DatePicker.ValueChanged += DatePicker_ValueChanged;
            
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LogDataGridViewCellClick?.Invoke(sender, e);
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            DatePickerValueChanged?.Invoke(sender, e);
        }

        public void AddLogDataGridViewCellClickEventHandler(DataGridViewCellEventHandler eventHandler)
        {
            logDataGridView.CellClick += eventHandler;
            logDataGridView.CellContentClick += DataGridView_CellContentClick;
        }

        public void AddDatePickerValueChangedEventHandler(EventHandler eventHandler)
        {
            DatePickerValueChanged += eventHandler;
            DatePicker.ValueChanged += DatePicker_ValueChanged;
        }

        private void notificationsCheckBox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if(FilterButton.Checked == true)
            {
                bunifuDatePicker1.Enabled = true;
            }
            else
            {
                bunifuDatePicker1.Enabled = false;
            }
        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
