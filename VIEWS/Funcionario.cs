using ECOInsight;
using ECOInsight.UserControls;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ECOInsightSENAC
{
    public partial class FuncionarioTela : Form
    {
        #region Campos (Fields)

        private bool sidebarExpand = false;

        #endregion

        #region Construtor (Constructor)

        public FuncionarioTela()
        {
            InitializeComponent();
            InitializeSidebar();
            LoadInitialUserControl();
        }

        #endregion

        #region Inicialização

        private void InitializeSidebar()
        {
            sidebarFuncionario.Width = 180; // Define a largura inicial do sidebar para maximizado
            sidebarExpand = true; // Garante que a variável esteja definida como true inicialmente
        }

        private void LoadInitialUserControl()
        {
            UCFuncio_Destaques uc = new UCFuncio_Destaques();
            addUserControl(uc);
        }

        #endregion

        #region Métodos Utilitários

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelFuncionario.Controls.Clear();
            panelFuncionario.Controls.Add(userControl);
            userControl.BringToFront();
        }

        #endregion

        #region Métodos de Evento (Event Handlers)

        private void btnFechar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnFuncionarioAula_Click(object sender, EventArgs e)
        {
            UCFuncio_Relatorio uc = new UCFuncio_Relatorio();
            addUserControl(uc);
        }

        private void btnFuncionarioDestaques_Click(object sender, EventArgs e)
        {
            UCFuncio_Destaques uc = new UCFuncio_Destaques();
            addUserControl(uc);
        }

        private void btnFuncionarioMenu_Click(object sender, EventArgs e)
        {
            sidebarTimerFuncionario.Start();
        }

        private void btnFuncionarioMPerfil_Click(object sender, EventArgs e)
        {
            UCFuncio_MeuPerfil uc = new UCFuncio_MeuPerfil();
            addUserControl(uc);
        }

        private void btnFuncionarioSair_Click(object sender, EventArgs e)
        {
            LoginTela login = new LoginTela();
            login.Show(); // Abre a nova tela
            this.Hide(); // Oculta a tela atual
        }

        private void btnMaxPad_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVoltarPagEsqueciSenha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Eventos de Timer (Animações)

        private void sidebarTimerFuncionario_Tick(object sender, EventArgs e)
        {
            int animationStep = 10;
            int targetWidthExpanded = 180;
            int targetWidthCollapsed = 63;

            if (sidebarExpand)
            {
                sidebarFuncionario.Width -= animationStep;
                if (sidebarFuncionario.Width <= targetWidthCollapsed)
                {
                    sidebarExpand = false;
                    sidebarTimerFuncionario.Stop();
                }
            }
            else
            {
                sidebarFuncionario.Width += animationStep;
                if (sidebarFuncionario.Width >= targetWidthExpanded)
                {
                    sidebarExpand = true;
                    sidebarTimerFuncionario.Stop();
                }
            }
        }

        #endregion

        #region Movimentar Janela (Barra Customizada)

        // Importação de funções da API do Windows
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes para simular movimentação da janela
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        // Evento que permite mover a janela arrastando a barra superior customizada

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

#endregion
    }
}