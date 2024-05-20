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

    }
}
