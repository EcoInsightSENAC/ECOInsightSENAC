using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECOInsight.UserControls;
using static System.Net.Mime.MediaTypeNames;

namespace ECOInsight
{
    public partial class AlunoTela : Form
    {
        bool menuExpand;
        bool sidebarExpand = true;

        public AlunoTela()
        {
            InitializeComponent();
            sidebarAluno.Width = 63; // Define a largura inicial do sidebar para minimizado
            sidebarExpand = false; // Garante que a variável esteja definida como false inicialmente
            UCAluno_Destaques uc = new UCAluno_Destaques();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelAluno.Controls.Clear();
            panelAluno.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            LoginTela login = new LoginTela();
            login.Show(); //Abre a nova tela
            this.Hide(); //Oculta a tela atual
        }

        private void btnMinimizarAluno_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Size tamanhoOriginal; // Variável para armazenar o tamanho original
        private bool maximizado = false;
        private void btnMaximizarRestaurarAluno_Click(object sender, EventArgs e)
        {
            if (!maximizado) // Se não estiver maximizado, maximizar
            {
                tamanhoOriginal = this.Size; // Armazena o tamanho atual
                this.WindowState = FormWindowState.Maximized; // Maximiza
                btnMaximizarRestaurarAluno.Text = " "; // Atualiza o texto
                maximizado = true;
            }
            else // Se estiver maximizado, restaurar para o tamanho original
            {
                this.WindowState = FormWindowState.Normal; // Define o estado como normal primeiro
                this.Size = tamanhoOriginal; // Restaura o tamanho
                btnMaximizarRestaurarAluno.Text = " "; // Atualiza o texto
                maximizado = false;
            }
        }

        private void btnFecharAluno_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnAlunoDestaques_Click(object sender, EventArgs e)
        {
            UCAluno_Destaques uc = new UCAluno_Destaques();
            addUserControl(uc);
        }

        private void btnAlunoAulas_Click(object sender, EventArgs e)
        {
            timerMenuAluno.Start();
            UCAluno_Aulas uc = new UCAluno_Aulas();
            addUserControl(uc);
        }

        private void btnAlunoMPerfil_Click(object sender, EventArgs e)
        {
            UCAluno_MeuPerfil uc = new UCAluno_MeuPerfil();
            addUserControl(uc);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            sidebarTimerAluno.Start();
        }

        private void btnVoltarPagEsqueciSenha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerMenuAluno_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuAluno.Height += 10;
                if (menuAluno.Height >= 111)
                {
                    timerMenuAluno.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuAluno.Height -= 10;
                if (menuAluno.Height <= 52)
                {
                    timerMenuAluno.Stop();
                    menuExpand = false;

                }
            }
        }

        private void sidebarTimerAluno_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarAluno.Width -= 10;
                if (sidebarAluno.Width <= 63)
                {
                    sidebarExpand = false;
                    sidebarTimerAluno.Stop();
                }
            }
            else
            {
                sidebarAluno.Width += 10;
                if (sidebarAluno.Width >= 180)
                {
                    sidebarExpand = true;
                    sidebarTimerAluno.Stop();
                }
            }
        }
    }
}