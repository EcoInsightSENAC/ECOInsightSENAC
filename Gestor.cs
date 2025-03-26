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
    public partial class Gestor : Form
    {
        public Gestor()
        {
            InitializeComponent();         
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Show();

            Gestor gestor = new Gestor();
            //gestor.Close();
            //gestor.Dispose();
            gestor.Hide();

        }
    }
}
