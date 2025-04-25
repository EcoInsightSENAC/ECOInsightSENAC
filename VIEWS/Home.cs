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
        bool menuExpand;
        public HomeTela()
        {
            InitializeComponent();
            //sidebarHome.Width = sidebarHome.MinimumSize.Width;
            //sidebarExpand = false;
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
            AdmTela admTela = new AdmTela();
            admTela.FormClosed += (s, ev) => this.Show(); // Adiciona um manipulador para o evento FormClosed
            admTela.Show();
            this.Hide();
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            ProfessorTela professorTela = new ProfessorTela();
            professorTela.FormClosed += (s, ev) => this.Show(); // Adiciona um manipulador para o evento FormClosed
            professorTela.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AlunoTela alunoTela = new AlunoTela();
            alunoTela.FormClosed += (s, ev) => this.Show(); // Adiciona um manipulador para o evento FormClosed
            alunoTela.Show();
            this.Hide();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            timerSub.Start();
            FuncionarioTela funcionarioTela = new FuncionarioTela();
            funcionarioTela.FormClosed += (s, ev) => this.Show(); // Adiciona um manipulador para o evento FormClosed
            funcionarioTela.Show();
            this.Hide();
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

        private void timerSub_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                panelSub.Height += 10;
                if (panelSub.Height >= 111)
                {
                    timerSub.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                panelSub.Height -= 10;
                if (panelSub.Height <= 52)
                {
                    timerSub.Stop();
                    menuExpand = false;

                }
            }
        }
        bool sidebarExpand = true;
        private void sidebarhome2_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarHome.Width -= 10;
                if (sidebarHome.Width <= 70)
                {
                    sidebarExpand = false;
                    sidebarhome2.Stop();
                }
            }
            else
            {
                sidebarHome.Width += 10;
                if (sidebarHome.Width >= 180)
                {
                    sidebarExpand = true;
                    sidebarhome2.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarhome2.Start();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            LoginTela login = new LoginTela();
            login.Show(); //Abre a nova tela
            this.Hide(); //Oculta a tela atual
        }
    }
}