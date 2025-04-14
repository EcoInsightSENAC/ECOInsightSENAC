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
    public partial class HomeTela : Form
    {
        public HomeTela()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void HomeTela_Load(object sender, EventArgs e)
        {

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

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGest_Click(object sender, EventArgs e)
        {
            AdmTela gestor = new AdmTela();
            gestor.Show(); // Abre a nova tela
            this.Hide(); //Oculta a tela atual 
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            ProfessorTela professor = new ProfessorTela();
            professor.Show(); // Abre a nova tela
            this.Hide(); //Oculta a tela atual 
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AlunoTela aluno = new AlunoTela();
            aluno.Show(); // Abre a nova tela
            this.Hide(); //Oculta a tela atual 
        }

        private void btnDestaques_Click(object sender, EventArgs e)
        {

        }
    }
}

