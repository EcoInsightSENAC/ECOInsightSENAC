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

        private void btnAluno_Click(object sender, EventArgs e)
        {
            AlunoTela aluno = new AlunoTela();
            aluno.Show(); //Abre a nova tela
            this.Hide(); //Oculta a tela atual
        }

        private void btnGestor_Click(object sender, EventArgs e)
        {
            GestorTela gestorTela = new GestorTela();
            gestorTela.Show(); //Abre a nova tela
            this.Hide(); //Oculta a tela atual
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            ProfessorTela professorTela = new ProfessorTela();
            professorTela.Show(); //Abre a nova tela
            this.Hide(); //Oculta a tela atual
        }

        private void btnDestaques_Click(object sender, EventArgs e)
        {
            HomeTela homeTela = new HomeTela();
            homeTela.Show(); //Abre a nova tela
            this.Hide(); //Oculta a tela atual
        }

        private void btnSairAluno_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
