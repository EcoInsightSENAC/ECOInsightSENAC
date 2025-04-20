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

namespace ECOInsight
{
    public partial class AdmTela : Form
    {
        private bool sidebarExpand;

        public AdmTela()
        {
            InitializeComponent();
            UCAdm_Destaques uc = new UCAdm_Destaques();
            addUserControl(uc);
            sidebarAdm.Width = sidebarAdm.MinimumSize.Width;
            sidebarExpand = false;
            // Certifique-se de que o Dock do sidebarAdm está definido como Left no Designer do Visual Studio
            // E que o Anchor está definido como Top, Bottom, Left
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelAdm.Controls.Clear();
            panelAdm.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarAdm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Size tamanhoOriginal;
        private bool maximizado = false;

        private void btnMaximizarRestaurarAdm_Click(object sender, EventArgs e)
        {
            if (!maximizado)
            {
                tamanhoOriginal = this.Size;
                this.WindowState = FormWindowState.Maximized;
                btnMaximizarRestaurarAdm.Text = " ";
                maximizado = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = tamanhoOriginal;
                btnMaximizarRestaurarAdm.Text = " ";
                maximizado = false;
            }
        }

        private void btnFecharAdm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdmRelatorio_Click_1(object sender, EventArgs e)
        {
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
            UCAdm_Usuarios uc = new UCAdm_Usuarios();
            addUserControl(uc);
        }

        private void btnAdmMPerfil_Click(object sender, EventArgs e)
        {
            UCAdm_MeuPerfil uc = new UCAdm_MeuPerfil();
            addUserControl(uc);
        }

        private void sidebarTimerAdm_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarAdm.Width -= 10;
                if (sidebarAdm.Width == sidebarAdm.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimerAdm.Stop();
                }
            }
            else
            {
                sidebarAdm.Width += 10;
                if (sidebarAdm.Width == sidebarAdm.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimerAdm.Stop();
                }
            }
        }

        private void btnAdmMenu_Click(object sender, EventArgs e)
        {
            sidebarTimerAdm.Start();
        }

        private void sidebarAdm_Resize(object sender, EventArgs e)
        {
            sidebarAdm.Height = this.ClientSize.Height;
            this.PerformLayout();
        }
    }
}
