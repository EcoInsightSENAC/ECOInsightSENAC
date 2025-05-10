using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECOInsight
{
    public partial class Esqueci_a_SenhaTela : Form
    {
        #region Campos Privados
        private Size tamanhoOriginal; // Variável para armazenar o tamanho original
        private bool maximizado = false;
        #endregion

        #region Construtor
        public Esqueci_a_SenhaTela()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos de Botões (Ações da Interface)
        private void btnMinimizarEsqueciSenha_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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
        private void panelSuperiorEsqueciaSenha_MouseDown(object sender, MouseEventArgs e)
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
