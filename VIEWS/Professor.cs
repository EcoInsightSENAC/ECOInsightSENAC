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
    public partial class ProfessorTela : Form
    {
        private bool sidebarExpand;
        public ProfessorTela()
        {
            InitializeComponent();
            UCProf_Destaques uc = new UCProf_Destaques();
            addUserControl(uc);
            sidebarProf.Width = sidebarProf.MinimumSize.Width;
            sidebarExpand = false;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelProf.Controls.Clear();
            panelProf.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarProf_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Size tamanhoOriginal; // Variável para armazenar o tamanho original
        private bool maximizado = false;

        private void btnMaximizarRestaurarProf_Click(object sender, EventArgs e)
        {
            if (!maximizado) // Se não estiver maximizado, maximizar
            {
                tamanhoOriginal = this.Size; // Armazena o tamanho atual
                this.WindowState = FormWindowState.Maximized; // Maximiza
                btnMaximizarRestaurarProf.Text = " "; // Atualiza o texto
                maximizado = true;
            }
            else // Se estiver maximizado, restaurar para o tamanho original
            {
                this.WindowState = FormWindowState.Normal; // Define o estado como normal primeiro
                this.Size = tamanhoOriginal; // Restaura o tamanho
                btnMaximizarRestaurarProf.Text = " "; // Atualiza o texto
                maximizado = false;
            }
        }

        private void btnFecharProf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProfDestaques_Click(object sender, EventArgs e)
        {
            UCProf_Destaques uc = new UCProf_Destaques();
            addUserControl(uc);
        }

        private void btnProfAula_Click(object sender, EventArgs e)
        {
            UCProf_Aulas uc = new UCProf_Aulas();
            addUserControl(uc);
        }

        private void btnProfRelatorio_Click(object sender, EventArgs e)
        {
            UCProf_Relatorio uc = new UCProf_Relatorio();
            addUserControl(uc);
        }

        private void btnProfMPerfil_Click(object sender, EventArgs e)
        {
            UCProf_MeuPerfil uc = new UCProf_MeuPerfil();
            addUserControl(uc);
        }

        private void sidebarTimerProf_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarProf.Width -= 10;
                if (sidebarProf.Width == sidebarProf.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimerProf.Stop();
                }

            }
            else
            {
                sidebarProf.Width += 10;
                if (sidebarProf.Width == sidebarProf.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimerProf.Stop();
                }
            }
        }

        private void btnAProfMenu_Click(object sender, EventArgs e)
        {
            sidebarTimerProf.Start();
        }
    }
}
