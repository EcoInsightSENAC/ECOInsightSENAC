using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace ECOInsight
{
    public partial class LoginTela : Form
    {
        private Size tamanhoOriginal;
        private bool maximizado = false;

        public LoginTela()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Lógica de validação de login
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (ValidarLogin(email, senha))
            {
                // Se a validação for bem-sucedida, abre a tela Home
                HomeTela home = new HomeTela();
                home.Show();
                this.Hide();
            }
            else
            {
                // Exibe mensagem de erro se o login for inválido
                MessageBox.Show("Email ou senha inválidos!", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarLogin(string email, string senha)
        {
            bool usuarioValido = false;

            try
            {
                // Cria a conexão com o banco de dados
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
                {
                    conn.Open();

                    // SQL para validar o login do usuário administrador
                    string query = "SELECT COUNT(*) FROM usuarios WHERE email = @Email AND senha_hash = @Senha AND ativo = TRUE";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha); // Aqui, é importante que a senha esteja criptografada antes de ser comparada

                    // Executa a consulta e verifica se existe um usuário válido
                    int usuarioCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (usuarioCount > 0)
                    {
                        // Se existir um usuário, retorna verdadeiro
                        usuarioValido = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return usuarioValido;
        }

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

        // Importação de funções da API do Windows
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes para simular movimentação da janela
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
    }
}
