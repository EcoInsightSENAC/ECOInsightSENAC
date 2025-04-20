using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECOInsight
{
    public partial class Esqueci_a_SenhaTela : Form
    {
        public Esqueci_a_SenhaTela()
        {
            InitializeComponent();
        }

        private void btnMinimizarEsqueciSenha_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Size tamanhoOriginal; // Variável para armazenar o tamanho original
        private bool maximizado = false;
        private void btnMaximizarRestaurarEsqueciSenha_Click(object sender, EventArgs e)
        {
            if (!maximizado) // Se não estiver maximizado, maximizar
            {
                tamanhoOriginal = this.Size; // Armazena o tamanho atual
                this.WindowState = FormWindowState.Maximized; // Maximiza
                btnMaximizarRestaurarEsqueciSenha.Text = " "; // Atualiza o texto
                maximizado = true;
            }
            else // Se estiver maximizado, restaurar para o tamanho original
            {
                this.WindowState = FormWindowState.Normal; // Define o estado como normal primeiro
                this.Size = tamanhoOriginal; // Restaura o tamanho
                btnMaximizarRestaurarEsqueciSenha.Text = " "; // Atualiza o texto
                maximizado = false;
            }
        }

        private void btnFecharEsqueciSenha_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnVoltarPagEsqueciSenha_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
