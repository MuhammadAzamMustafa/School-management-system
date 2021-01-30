using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace School_management_system
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }
        private void MDI_Load(object sender, EventArgs e)
        {
                Login logscrn = new Login();
                logscrn.MdiParent = this;
                logscrn.WindowState = FormWindowState.Maximized;
                logscrn.Show();
        }
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
