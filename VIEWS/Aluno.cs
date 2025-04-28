using System;
using System.Drawing;
using System.Windows.Forms;
using ECOInsight.UserControls;

namespace ECOInsight
{
    public partial class AlunoTela : Form
    {
        #region Campos (Fields)

        private bool maximizado = false;
        private bool menuExpand = false; // Inicializado como false
        private bool sidebarExpand = false; // Inicializado como false
        private Size tamanhoOriginal;

        #endregion

        #region Construtor (Constructor)

        public AlunoTela()
        {
            InitializeComponent();
            InitializeSidebar();
            LoadInitialUserControl();
        }

        #endregion

        #region Inicialização

        private void InitializeSidebar()
        {
            sidebarAluno.Width = 63; // Define a largura inicial do sidebar para minimizado
        }

        private void LoadInitialUserControl()
        {
            UCAluno_Destaques uc = new UCAluno_Destaques();
            addUserControl(uc);
        }

        #endregion

        #region Métodos Utilitários

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelAluno.Controls.Clear();
            panelAluno.Controls.Add(userControl);
            userControl.BringToFront();
        }

        #endregion

        #region Métodos de Evento (Event Handlers)

        private void btnAlunoAulas_Click(object sender, EventArgs e)
        {
            timerMenuAluno.Start();
            UCAluno_Aulas uc = new UCAluno_Aulas();
            addUserControl(uc);
        }

        private void btnAlunoDestaques_Click(object sender, EventArgs e)
        {
            UCAluno_Destaques uc = new UCAluno_Destaques();
            addUserControl(uc);
        }

        private void btnAlunoMPerfil_Click(object sender, EventArgs e)
        {
            UCAluno_MeuPerfil uc = new UCAluno_MeuPerfil();
            addUserControl(uc);
        }

        private void btnFecharAluno_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMaximizarRestaurarAluno_Click(object sender, EventArgs e)
        {
            if (!maximizado) // Se não estiver maximizado, maximizar
            {
                tamanhoOriginal = this.Size; // Armazena o tamanho atual
                this.WindowState = FormWindowState.Maximized; // Maximiza
                btnMaximizarRestaurarAluno.Text = " "; // Atualiza o texto (pode ser um ícone)
                maximizado = true;
            }
            else // Se estiver maximizado, restaurar para o tamanho original
            {
                this.WindowState = FormWindowState.Normal; // Define o estado como normal primeiro
                this.Size = tamanhoOriginal; // Restaura o tamanho
                btnMaximizarRestaurarAluno.Text = " "; // Atualiza o texto (pode ser um ícone)
                maximizado = false;
            }
        }

        private void btnMinimizarAluno_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            LoginTela login = new LoginTela();
            login.Show(); // Abre a nova tela
            this.Hide(); // Oculta a tela atual
        }

        private void btnVoltarPagEsqueciSenha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            sidebarTimerAluno.Start();
        }

        #endregion

        #region Eventos de Timer (Animações)

        private void sidebarTimerAluno_Tick(object sender, EventArgs e)
        {
            int animationStep = 10;
            int targetWidthExpanded = 180;
            int targetWidthCollapsed = 63;

            if (sidebarExpand)
            {
                sidebarAluno.Width -= animationStep;
                if (sidebarAluno.Width <= targetWidthCollapsed)
                {
                    sidebarExpand = false;
                    sidebarTimerAluno.Stop();
                }
            }
            else
            {
                sidebarAluno.Width += animationStep;
                if (sidebarAluno.Width >= targetWidthExpanded)
                {
                    sidebarExpand = true;
                    sidebarTimerAluno.Stop();
                }
            }
        }

        private void timerMenuAluno_Tick(object sender, EventArgs e)
        {
            int animationStep = 10;
            int targetHeightExpanded = 111;
            int targetHeightCollapsed = 52;

            if (!menuExpand)
            {
                menuAluno.Height += animationStep;
                if (menuAluno.Height >= targetHeightExpanded)
                {
                    timerMenuAluno.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuAluno.Height -= animationStep;
                if (menuAluno.Height <= targetHeightCollapsed)
                {
                    timerMenuAluno.Stop();
                    menuExpand = false;
                }
            }
        }

        #endregion
    }
}