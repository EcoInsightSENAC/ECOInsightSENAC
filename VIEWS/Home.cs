using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECOInsightSENAC;

namespace ECOInsight
{
    public partial class HomeTela : Form
    {
        private bool sidebarExpand;
        public HomeTela()
        {
            InitializeComponent();
            sidebarHome.Width = sidebarHome.MinimumSize.Width;
            sidebarExpand = false;
        }

        private void HomeTela_Load(object sender, EventArgs e)
        {

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

        private void btnMinimizarHome_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Size tamanhoOriginal; // Variável para armazenar o tamanho original
        private bool maximizado = false;

        private void btnMaximizarRestaurarHome_Click(object sender, EventArgs e)
        {
            if (!maximizado) // Se não estiver maximizado, maximizar
            {
                tamanhoOriginal = this.Size; // Armazena o tamanho atual
                this.WindowState = FormWindowState.Maximized; // Maximiza
                btnMaximizarRestaurarHome.Text = " "; // Atualiza o texto
                maximizado = true;
            }
            else // Se estiver maximizado, restaurar para o tamanho original
            {
                this.WindowState = FormWindowState.Normal; // Define o estado como normal primeiro
                this.Size = tamanhoOriginal; // Restaura o tamanho
                btnMaximizarRestaurarHome.Text = " "; // Atualiza o texto
                maximizado = false;
            }
        }

        private void btnFecharHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            FuncionarioTela aluno = new FuncionarioTela();
            aluno.Show(); // Abre a nova tela
            this.Hide(); //Oculta a tela atual
        }

        private void panelEsquerdo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarHome.Width -= 10;
                if (sidebarHome.Width == sidebarHome.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timer1.Stop();
                }

            }
            else
            {
                sidebarHome.Width += 10;
                if (sidebarHome.Width == sidebarHome.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timer1.Stop();
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

