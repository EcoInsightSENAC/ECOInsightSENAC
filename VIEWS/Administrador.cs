using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;              // Para ler a connectionString
using ECOInsight.UserControls;
using ECOInsight.DataAccess;            // Para Conexao.CreateConnection()
using System.Collections.Generic;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ECOInsight
{
    public partial class AdmTela : Form
    {
        #region Campos Privados
        private bool sidebarExpand = false;
        private bool menuExpand = false;
        private Size tamanhoOriginal;
        private bool maximizado = false;
        private Stack<UserControl> historicoVoltar = new Stack<UserControl>();
        private Stack<UserControl> historicoAvancar = new Stack<UserControl>();
        private UserControl controleAtual;
        #endregion

        #region Construtor
        public AdmTela()
        {
            InitializeComponent();
            InitializeSidebar();
            this.Load += AdmTela_Load;        // Associa o evento Load para conectar ao banco
            LoadInitialUserControl();
            AtualizarEstadoBotoesNavegacao();
        }
        #endregion

        #region Conexão com o Banco
        private void AdmTela_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = Conexao.CreateConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        MessageBox.Show($"Conexão criada, mas não está aberta. Estado: {conn.State}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco: " + ex.Message, "Falha na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Sidebar e Load Inicial
        private void InitializeSidebar()
        {
            sidebarAdm.Width = 180;
            sidebarExpand = true;
        }

        private void LoadInitialUserControl()
        {
            UCAdm_Destaques uc = new UCAdm_Destaques();
            addUserControl(uc);
        }
        #endregion

        #region Métodos Utilitários
        private void addUserControl(UserControl novoControle, bool limparAvanco = true)
        {
            if (controleAtual != null)
            {
                historicoVoltar.Push(controleAtual);
                if (limparAvanco)
                    historicoAvancar.Clear();
            }

            controleAtual = novoControle;
            novoControle.Dock = DockStyle.Fill;
            panelAdm.Controls.Clear();
            panelAdm.Controls.Add(novoControle);
            novoControle.BringToFront();
            AtualizarEstadoBotoesNavegacao();
        }

        private void AtualizarEstadoBotoesNavegacao()
        {
            btnAdm_Voltar.Enabled = historicoVoltar.Count > 0;
            btnAdm_Avancar.Enabled = historicoAvancar.Count > 0;
        }
        #endregion

        #region Eventos de Botões (Ações da Interface)
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginTela login = new LoginTela();
            login.Show();
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
            System.Windows.Forms.Application.Exit();
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
            UCAdm_Registros uc = new UCAdm_Registros();
            addUserControl(uc);
        }

        private void btnAdmDestaques_Click_1(object sender, EventArgs e)
        {
            UCAdm_Destaques uc = new UCAdm_Destaques();
            addUserControl(uc);
        }

        private void btnAdmUsuario_Click(object sender, EventArgs e)
        {
            UCAdm_Usuarios uc = new UCAdm_Usuarios();
            addUserControl(uc);
        }

        private void btnAdmMPerfil_Click(object sender, EventArgs e)
        {
            UCAdm_MeuPerfil uc = new UCAdm_MeuPerfil();
            addUserControl(uc);
        }

        private void btnAdmDescarte_Click(object sender, EventArgs e)
        {
            UCAdm_Descartes uc = new UCAdm_Descartes();
            addUserControl(uc);
        }

        private void btnAdmMinhocario_Click(object sender, EventArgs e)
        {
            UCAdm_Minhocario uc = new UCAdm_Minhocario();
            addUserControl(uc);
        }

        private void btnAdmAgua_Click(object sender, EventArgs e)
        {
            UCAdm_ConsumoAgua uc = new UCAdm_ConsumoAgua();
            addUserControl(uc);
        }
        #endregion

        #region Eventos de Navegação (Voltar e Avançar)
        private void btnAdm_Voltar_Click_1(object sender, EventArgs e)
        {
            if (historicoVoltar.Count > 0)
            {
                historicoAvancar.Push(controleAtual);
                UserControl controleAnterior = historicoVoltar.Pop();
                addUserControl(controleAnterior, false);
            }
        }

        private void btnAdm_Avancar_Click_1(object sender, EventArgs e)
        {
            if (historicoAvancar.Count > 0)
            {
                historicoVoltar.Push(controleAtual);
                UserControl controleProximo = historicoAvancar.Pop();
                addUserControl(controleProximo, false);
            }
        }
        #endregion

        #region Eventos de Timer (Animações)
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

        private void timerSubRelatorio_Tick(object sender, EventArgs e)
        {
            int animationStep = 5;
            int targetHeightExpanded = 221;
            int targetHeightCollapsed = 52;

            if (!menuExpand)
            {
                SubAdmRelatorio.Height += animationStep;
                if (SubAdmRelatorio.Height >= targetHeightExpanded)
                {
                    timerSubRelatorio.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                SubAdmRelatorio.Height -= animationStep;
                if (SubAdmRelatorio.Height <= targetHeightCollapsed)
                {
                    timerSubRelatorio.Stop();
                    menuExpand = false;
                }
            }
        }
        #endregion

        #region Movimentar Janela (Barra Customizada)
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private void panelSuperiorAdm_MouseDown(object sender, MouseEventArgs e)
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
