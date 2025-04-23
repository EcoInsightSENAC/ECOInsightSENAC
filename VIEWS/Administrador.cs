using System;
using System.Drawing;
using System.Windows.Forms;
using ECOInsight.UserControls;

namespace ECOInsight
{
    public partial class AdmTela : Form
    {
        #region Campos Privados

        private bool menuExpand;
        private bool sidebarExpand = false;
        private Size tamanhoOriginal;
        private bool maximizado = false;

        #endregion

        #region Construtor

        public AdmTela()
        {
            InitializeComponent();
            InitializeSidebar();
            LoadInitialUserControl();
        }

        private void InitializeSidebar()
        {
            sidebarAdm.Width = 63; // Define a largura inicial do sidebar para minimizado
            sidebarExpand = false; // Garante que a variável esteja definida como false inicialmente
        }

        private void LoadInitialUserControl()
        {
            UCAdm_Destaques uc = new UCAdm_Destaques();
            addUserControl(uc);
        }

        #endregion

        #region Métodos Utilitários

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelAdm.Controls.Clear();
            panelAdm.Controls.Add(userControl);
            userControl.BringToFront();
        }

        #endregion

        #region Eventos de Botões (Ações da Interface)

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarAdm_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarRestaurarAdm_Click(object sender, EventArgs e)
        {
            if (!maximizado)
            {
                tamanhoOriginal = Size;
                WindowState = FormWindowState.Maximized;
                btnMaximizarRestaurarAdm.Text = " ";
                maximizado = true;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                Size = tamanhoOriginal;
                btnMaximizarRestaurarAdm.Text = " ";
                maximizado = false;
            }
        }

        private void btnFecharAdm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVoltarPagEsqueciSenha_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdmMenu_Click(object sender, EventArgs e)
        {
            sidebarTimerAdm.Start();
        }

        private void btnAdmRelatorio_Click_1(object sender, EventArgs e)
        {
            timerSubRelatorio.Start();
            UCAdm_Relatorio uc = new UCAdm_Relatorio();
            addUserControl(uc);
        }

        private void btnAdmDestaques_Click_1(object sender, EventArgs e)
        {
            UCAdm_Destaques uc = new UCAdm_Destaques();
            addUserControl(uc);
        }

        private void btnAdmUsuario_Click(object sender, EventArgs e)
        {
            timerSubUsuarios.Start();
            UCAdm_Usuarios uc = new UCAdm_Usuarios();
            addUserControl(uc);
        }

        private void btnAdmMPerfil_Click(object sender, EventArgs e)
        {
            UCAdm_MeuPerfil uc = new UCAdm_MeuPerfil();
            addUserControl(uc);
        }

        #endregion

        #region Eventos de Timer (Animações)

        private void timerSubRelatorio_Tick(object sender, EventArgs e)
        {
            int animationStep = 3;
            int targetHeightExpanded = 104;
            int targetHeightCollapsed = 52;

            if (!menuExpand)
            {
                panelSubRelatorioAdm.Height += animationStep;
                if (panelSubRelatorioAdm.Height >= targetHeightExpanded)
                {
                    timerSubRelatorio.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                panelSubRelatorioAdm.Height -= animationStep;
                if (panelSubRelatorioAdm.Height <= targetHeightCollapsed)
                {
                    timerSubRelatorio.Stop();
                    menuExpand = false;
                }
            }
        }

        private void timerSubUsuarios_Tick(object sender, EventArgs e)
        {
            int animationStep = 3;
            int targetHeightExpanded = 104;
            int targetHeightCollapsed = 52;

            if (!menuExpand)
            {
                panelSubUsuarios.Height += animationStep;
                if (panelSubUsuarios.Height >= targetHeightExpanded)
                {
                    timerSubUsuarios.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                panelSubUsuarios.Height -= animationStep;
                if (panelSubUsuarios.Height <= targetHeightCollapsed)
                {
                    timerSubUsuarios.Stop();
                    menuExpand = false;
                }
            }
        }

        private void sidebarTimerAdm_Tick(object sender, EventArgs e)
        {
            int animationStep = 10;
            int targetWidthExpanded = 180;
            int targetWidthCollapsed = 63;

            if (sidebarExpand)
            {
                sidebarAdm.Width -= animationStep;
                if (sidebarAdm.Width <= targetWidthCollapsed)
                {
                    sidebarExpand = false;
                    sidebarTimerAdm.Stop();
                }
            }
            else
            {
                sidebarAdm.Width += animationStep;
                if (sidebarAdm.Width >= targetWidthExpanded)
                {
                    sidebarExpand = true;
                    sidebarTimerAdm.Stop();
                }
            }
        }

        #endregion

        private void btnAdmGerarRelatorio_Click(object sender, EventArgs e)
        {
            UCAdmGerarRelatorio uc = new UCAdmGerarRelatorio();
            addUserControl(uc);
        }
    }
}