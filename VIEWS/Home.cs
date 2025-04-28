using System;
using System.Drawing;
using System.Windows.Forms;
using ECOInsightSENAC;

namespace ECOInsight
{
    public partial class HomeTela : Form
    {
        #region Campos (Fields)

        private bool maximizado = false;
        private bool menuExpand;
        private bool sidebarExpand = true;
        private Size tamanhoOriginal;

        #endregion

        #region Construtor (Constructor)

        public HomeTela()
        {
            InitializeComponent();
            this.FormClosing += HomeTela_FormClosing; // Adiciona o manipulador de eventos
        }

        #endregion

        #region Métodos de Evento (Event Handlers)

        private void btnDestaques_Click(object sender, EventArgs e)
        {
            // Lógica do botão Destaques
        }

        private void btnFecharHome_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnGest_Click(object sender, EventArgs e)
        {
            AdmTela admTela = new AdmTela();
            admTela.FormClosed += (s, ev) => this.Show(); // Adiciona um manipulador para o evento FormClosed
            admTela.Show();
            this.Hide();
        }

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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarhome2.Start();
        }

        private void btnMinimizarHome_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            ProfessorTela professorTela = new ProfessorTela();
            professorTela.FormClosed += (s, ev) => this.Show(); // Adiciona um manipulador para o evento FormClosed
            professorTela.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            LoginTela login = new LoginTela();
            login.Show(); // Abre a nova tela
            this.Hide(); // Oculta a tela atual
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeTela_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true; // Impede o fechamento
            }
        }

        private void HomeTela_Load(object sender, EventArgs e)
        {
            // Lógica de carregamento do formulário
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

        #endregion

        #region Outros Métodos

        // Não há outros métodos explícitos neste código.

        #endregion
    }
}