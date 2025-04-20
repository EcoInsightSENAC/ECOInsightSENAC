using ECOInsight;
using ECOInsight.UserControls;

namespace ECOInsightSENAC
{
    public partial class FuncionarioTela : Form
    {
        private bool sidebarExpand;

        public FuncionarioTela()
        {
            InitializeComponent();
            UCFuncio_Destaques uc = new UCFuncio_Destaques();
            addUserControl(uc);
            sidebarFuncionario.Width = sidebarFuncionario.MinimumSize.Width;
            sidebarExpand = false;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelFuncionario.Controls.Clear();
            panelFuncionario.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxPad_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFuncionarioDestaques_Click(object sender, EventArgs e)
        {
            UCFuncio_Destaques uc = new UCFuncio_Destaques();
            addUserControl(uc);
        }

        private void btnFuncionarioAula_Click(object sender, EventArgs e)
        {
            UCFuncio_Relatorio uc = new UCFuncio_Relatorio();
            addUserControl(uc);
        }

        private void btnFuncionarioMPerfil_Click(object sender, EventArgs e)
        {
            UCFuncio_MeuPerfil uc = new UCFuncio_MeuPerfil();
            addUserControl(uc);
        }

        private void sidebarTimerFuncionario_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarFuncionario.Width -= 10;
                if (sidebarFuncionario.Width == sidebarFuncionario.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimerFuncionario.Stop();
                }

            }
            else
            {
                sidebarFuncionario.Width += 10;
                if (sidebarFuncionario.Width == sidebarFuncionario.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimerFuncionario.Stop();
                }
            }
        }

        private void btnFuncionarioMenu_Click(object sender, EventArgs e)
        {
            sidebarTimerFuncionario.Start();
        }

        private void btnFuncionarioSair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
