using System;
using System.Drawing;
using System.Windows.Forms;
using ECOInsight.UserControls;

namespace ECOInsight
{
    public partial class ProfessorTela : Form
    {
        #region Campos (Fields)

        private bool maximizado = false;
        private bool menuExpand = false;
        private bool sidebarExpand = false;
        private Size tamanhoOriginal;

        #endregion

        #region Construtor (Constructor)

        public ProfessorTela()
        {
            InitializeComponent();
            InitializeSidebar();
            LoadInitialUserControl();
        }

        #endregion

        #region Inicialização

        private void InitializeSidebar()
        {
            sidebarProf.Width = 180; // Define a largura inicial do sidebar para maximizado
            sidebarExpand = true; // Garante que a variável esteja definida como false inicialmente
        }

        private void LoadInitialUserControl()
        {
            UCProf_Destaques uc = new UCProf_Destaques();
            addUserControl(uc);
        }

        #endregion

        #region Métodos Utilitários

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelProf.Controls.Clear();
            panelProf.Controls.Add(userControl);
            userControl.BringToFront();
        }

        #endregion

        #region Métodos de Evento (Event Handlers)

        private void btnAProfMenu_Click(object sender, EventArgs e)
        {
            sidebarTimerProf.Start();
        }

        private void btnFecharProf_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMaximizarRestaurarProf_Click(object sender, EventArgs e)
        {
            if (!maximizado) // Se não estiver maximizado, maximizar
            {
                tamanhoOriginal = this.Size; // Armazena o tamanho atual
                this.WindowState = FormWindowState.Maximized; // Maximiza
                btnMaximizarRestaurarProf.Text = " "; // Atualiza o texto (pode ser um ícone)
                maximizado = true;
            }
            else // Se estiver maximizado, restaurar para o tamanho original
            {
                this.WindowState = FormWindowState.Normal; // Define o estado como normal primeiro
                this.Size = tamanhoOriginal; // Restaura o tamanho
                btnMaximizarRestaurarProf.Text = " "; // Atualiza o texto (pode ser um ícone)
                maximizado = false;
            }
        }

        private void btnMinimizarProf_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnProfAula_Click(object sender, EventArgs e)
        {
            UCProf_Aulas uc = new UCProf_Aulas();
            addUserControl(uc);
            timerSubAula.Start();
        }

        private void btnProfDestaques_Click(object sender, EventArgs e)
        {
            UCProf_Destaques uc = new UCProf_Destaques();
            addUserControl(uc);
        }

        private void btnProfMeuPerfil_Click(object sender, EventArgs e)
        {
            UCProf_MeuPerfil uc = new UCProf_MeuPerfil();
            addUserControl(uc);
        }

        private void btnProfRelatorio_Click(object sender, EventArgs e)
        {
            UCProf_Relatorio uc = new UCProf_Relatorio();
            addUserControl(uc);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSairProf_Click(object sender, EventArgs e)
        {
            LoginTela login = new LoginTela();
            login.Show(); // Abre a nova tela
            this.Hide(); // Oculta a tela atual
        }

        private void btnVoltarPagEsqueciSenha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Eventos de Timer (Animações)

        private void sidebarTimerProf_Tick(object sender, EventArgs e)
        {
            int animationStep = 10;
            int targetWidthExpanded = 180;
            int targetWidthCollapsed = 63;

            if (sidebarExpand)
            {
                sidebarProf.Width -= animationStep;
                if (sidebarProf.Width <= targetWidthCollapsed)
                {
                    sidebarExpand = false;
                    sidebarTimerProf.Stop();
                }
            }
            else
            {
                sidebarProf.Width += animationStep;
                if (sidebarProf.Width >= targetWidthExpanded)
                {
                    sidebarExpand = true;
                    sidebarTimerProf.Stop();
                }
            }
        }

        private void timerSubAula_Tick(object sender, EventArgs e)
        {
            int animationStep = 3;
            int targetHeightExpanded = 114;
            int targetHeightCollapsed = 52;

            if (!menuExpand)
            {
                panelbtnProfAula.Height += animationStep;
                if (panelbtnProfAula.Height >= targetHeightExpanded)
                {
                    timerSubAula.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                panelbtnProfAula.Height -= animationStep;
                if (panelbtnProfAula.Height <= targetHeightCollapsed)
                {
                    timerSubAula.Stop();
                    menuExpand = false;
                }
            }
        }

        #endregion
    }
}