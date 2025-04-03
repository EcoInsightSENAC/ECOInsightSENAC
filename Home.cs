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

        private void btnGestor_Click(object sender, EventArgs e)
        {
            GestorTela gestor = new GestorTela();
            gestor.Show(); // Abre a nova tela
            this.Hide(); //Oculta a tela atual 
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            AlunoTela aluno = new AlunoTela();
            aluno.Show(); // Abre a nova tela
            this.Hide(); //Oculta a tela atual 
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            ProfessorTela professor = new ProfessorTela();
            professor.Show(); // Abre a nova tela
            this.Hide(); //Oculta a tela atual 
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeTela_Load(object sender, EventArgs e)
        {

        }
    }
}
