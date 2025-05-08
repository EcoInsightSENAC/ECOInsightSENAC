using System;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Runtime.InteropServices;
<<<<<<< Updated upstream
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Drawing;
=======
using System.Text.RegularExpressions;
>>>>>>> Stashed changes

namespace ECOInsight
{
    public partial class LoginTela : Form
    {
        private Size tamanhoOriginal;
        private bool maximizado = false;

        private const int resizeEdge = 15; // Tamanho da �rea de redimensionamento
        private bool resizing = false;
        private Point lastMousePosition;

        public LoginTela()
        {
            InitializeComponent();

            //Tentativa de fazer o redimensionamento da tela
            this.MinimumSize = new Size(1064, 633);
            this.FormBorderStyle = FormBorderStyle.None; // Mant�m o estilo sem bordas
            this.MouseMove += LoginTela_MouseMove;
            this.MouseDown += LoginTela_MouseDown;
            this.MouseUp += LoginTela_MouseUp;
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            Autenticacao auth = new Autenticacao();
            if (auth.ValidarLogin(email, senha))
            {
                // Se a valida��o for bem-sucedida, abre a tela Home
                HomeTela home = new HomeTela();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email ou senha inv�lidos!", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarLogin(string email, string senha)
        {
            bool usuarioValido = false;

            // Gerar o hash da senha informada pelo usu�rio
            string senha_hash_informada = GerarHashSenha(senha);

            try
            {
                // Cria a conex�o com o banco de dados
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
                {
                    conn.Open();

                    // SQL para validar o login do usu�rio
                    string query = "SELECT senha_hash FROM usuarios WHERE email = @Email AND ativo = TRUE";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);

                    // Executa a consulta e verifica se existe o hash da senha para o email informado
                    object resultado = cmd.ExecuteScalar(); // Retorna o valor do hash armazenado ou null

                    if (resultado != null)
                    {
                        string senha_hash_armazenada = resultado.ToString();

                        // Comparar o hash informado com o hash armazenado
                        if (senha_hash_informada == senha_hash_armazenada)
                        {
                            // Senha v�lida
                            usuarioValido = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return usuarioValido;
        }

        // Fun��o para gerar o hash da senha
        public string GerarHashSenha(string senha)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Outros m�todos que voc� j� possui
        private void btnEsqueciSenha_Click_1(object sender, EventArgs e)
        {
            Esqueci_a_SenhaTela esqueciSenhaTela = new Esqueci_a_SenhaTela();
            esqueciSenhaTela.FormClosed += (s, ev) => this.Show();
            esqueciSenhaTela.Show();
            this.Hide();
        }

        private void checkBoxVizualizarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = checkBoxVizualizarSenha.Checked ? '\0' : '*';
        }

        private void btnMinimizarLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarRestaurarLogin_Click(object sender, EventArgs e)
        {
            if (!maximizado)
            {
                tamanhoOriginal = this.Size;
                this.WindowState = FormWindowState.Maximized;
                btnMaximizarRestaurarLogin.Text = " ";
                maximizado = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = tamanhoOriginal;
                btnMaximizarRestaurarLogin.Text = " ";
                maximizado = false;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string email = textBox.Text.Trim();
            bool formatoValido = IsEmailValido(email);

            if (!formatoValido && !string.IsNullOrEmpty(email))
            {
                textBox.BorderStyle = BorderStyle.Fixed3D;
                textBox.BackColor = Color.MistyRose;
            }
            else
            {
                textBox.BorderStyle = BorderStyle.FixedSingle;
                textBox.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private bool IsEmailValido(string email)
        {
            if (string.IsNullOrEmpty(email))
                return true;

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private void btnFecharLogin_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        #region Movimentar Janela (Barra Customizada)

        // Importa��o de fun��es da API do Windows
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes para simular movimenta��o da janela
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        // Evento que permite mover a janela arrastando a barra superior customizada
        private void panelSuperiorLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        #endregion
<<<<<<< Updated upstream



        #region Tentativa de fazer o redimensionamento da tela 
        // Quando o mouse � pressionado
        private void LoginTela_MouseDown(object sender, MouseEventArgs e)
        {
            // Inicia o redimensionamento se o mouse estiver pr�ximo da borda direita
            if (e.X >= this.ClientSize.Width - resizeEdge)
            {
                resizing = true;
                lastMousePosition = e.Location; // Salva a posi��o do mouse
            }
        }

        // Quando o mouse � solto
        private void LoginTela_MouseUp(object sender, MouseEventArgs e)
        {
            resizing = false; // Finaliza o redimensionamento
        }

        // Quando o mouse se move
        private void LoginTela_MouseMove(object sender, MouseEventArgs e)
        {
            // Verificar se o redimensionamento est� ativo
            if (resizing)
            {
                int newWidth = e.X + this.Left - lastMousePosition.X; // Calcular a largura
                newWidth = Math.Max(this.MinimumSize.Width, newWidth); // Garantir que a largura m�nima seja respeitada
                this.Width = newWidth; // Atualiza a largura da janela
            }
            else if (e.X >= this.ClientSize.Width - resizeEdge) // Detecta se o mouse est� na borda direita
            {
                this.Cursor = Cursors.SizeWE; // Cursor de redimensionamento horizontal
            }
            else
            {
                this.Cursor = Cursors.Default; // Cursor padr�o
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;
            const int WM_NCHITTEST = 0x84;

            const int resizeAreaSize = 10;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                Point pos = PointToClient(new Point(m.LParam.ToInt32()));

                if (pos.X <= resizeAreaSize)
                {
                    if (pos.Y <= resizeAreaSize)
                        m.Result = (IntPtr)HTTOPLEFT;
                    else if (pos.Y >= ClientSize.Height - resizeAreaSize)
                        m.Result = (IntPtr)HTBOTTOMLEFT;
                    else
                        m.Result = (IntPtr)HTLEFT;
                }
                else if (pos.X >= ClientSize.Width - resizeAreaSize)
                {
                    if (pos.Y <= resizeAreaSize)
                        m.Result = (IntPtr)HTTOPRIGHT;
                    else if (pos.Y >= ClientSize.Height - resizeAreaSize)
                        m.Result = (IntPtr)HTBOTTOMRIGHT;
                    else
                        m.Result = (IntPtr)HTRIGHT;
                }
                else if (pos.Y <= resizeAreaSize)
                {
                    m.Result = (IntPtr)HTTOP;
                }
                else if (pos.Y >= ClientSize.Height - resizeAreaSize)
                {
                    m.Result = (IntPtr)HTBOTTOM;
                }
                return;
            }

            base.WndProc(ref m);
        }

        #endregion
=======
>>>>>>> Stashed changes
    }

}


