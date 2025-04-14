using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ECOInsight
{
    public partial class AlunoTela : Form
    {
        public AlunoTela()
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnDestaques_Click(object sender, EventArgs e)
        {
            HomeTela homeTela = new HomeTela();
            homeTela.Show(); //Abre a nova tela
            this.Hide(); //Oculta a tela atual
        }

        private void btnGestor_Click(object sender, EventArgs e)
        {
            AdmTela gestor = new AdmTela();
            gestor.Show(); // Abre a nova tela
            this.Hide(); //Oculta a tela atual
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            ProfessorTela professor = new ProfessorTela();
            professor.Show(); // Abre a nova tela
            this.Hide(); //Oculta a tela atual 
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            AlunoTela aluno = new AlunoTela();
            aluno.Show(); // Abre a nova tela
            this.Hide(); //Oculta a tela atual
        }
    }
}
