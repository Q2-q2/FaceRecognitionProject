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
        public JournalUserControl()
        {
            InitializeComponent();
        }
        public ListBox LogListBox
        {
            get { return listBoxLogs; }
        }
        public Bunifu.UI.WinForms.BunifuDatePicker DatePicker
        {
            get { return bunifuDatePicker1; }
        }
        public ImageBox LogImageBox 
        {
            get { return imageBoxLogEntry; } 
        }
        public event EventHandler LogListBoxSelectedIndexChanged;

        private void logListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogListBoxSelectedIndexChanged?.Invoke(sender, e);
        }

        public void AddLogListBoxSelectedIndexChangedEventHandler(EventHandler eventHandler)
        {
            LogListBoxSelectedIndexChanged += eventHandler;
            LogListBox.SelectedIndexChanged += logListBox_SelectedIndexChanged;
        }
    }
}
