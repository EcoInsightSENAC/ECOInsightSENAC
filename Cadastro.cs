using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECOInsight
{
    public partial class CadastroTela : Form
    {
        public CadastroTela()
        {
            InitializeComponent();
        }

        private void iconMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void iconX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmailCad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
