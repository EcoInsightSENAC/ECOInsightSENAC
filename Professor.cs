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
    public partial class ProfessorTela : Form
    {
        public ProfessorTela()
        {
            InitializeComponent();
        }

        private void Professor_Load(object sender, EventArgs e)
        {

        }

        private void btnGestor_Click(object sender, EventArgs e)
        {
            GestorTela gestorTela = new GestorTela();
            gestorTela.Show(); //Abre a nova tela
            this.Hide(); //Oculta a tela atual
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            AlunoTela alunoTela = new AlunoTela();
            alunoTela.Show(); //Abre a nova tela
            this.Hide(); //Oculta a tela atual
        }

        private void btnDestaques_Click(object sender, EventArgs e)
        {
            HomeTela homeTela = new HomeTela();
            homeTela.Show(); //Abre a nova tela
            this.Hide(); //Oculta a tela atual
        }

        private void btnSairProfessor_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
