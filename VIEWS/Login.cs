using System;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Text.RegularExpressions;

namespace ECOInsight
{
    public partial class LoginTela : Form
    {
        private Size tamanhoOriginal;
        private bool maximizado = false;

        private const int resizeEdge = 15;
        private bool resizing = false;
        private Point lastMousePosition;

        public LoginTela()
        {
            InitializeComponent();

            // Configuração inicial da janela
            this.MinimumSize = new Size(1064, 633);
            this.FormBorderStyle = FormBorderStyle.None;
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
                HomeTela home = new HomeTela();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email ou senha inválidos!", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarLogin(string email, string senha)
        {
            bool usuarioValido = false;
            string senha_hash_informada = GerarHashSenha(senha);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
                {
                    conn.Open();

                    string query = "SELECT senha_hash FROM usuarios WHERE email = @Email AND ativo = TRUE";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        string senha_hash_armazenada = resultado.ToString();
                        if (senha_hash_informada == senha_hash_armazenada)
                        {
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

        public string GerarHashSenha(string senha)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
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
                textBox.BackColor = SystemColors.Window;
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
            Application.Exit();
        }

        #region Movimentar Janela

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private void panelSuperiorLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        #endregion

        #region Redimensionamento da Janela

        private void LoginTela_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X >= this.ClientSize.Width - resizeEdge)
            {
                resizing = true;
                lastMousePosition = e.Location;
            }
        }

        private void LoginTela_MouseUp(object sender, MouseEventArgs e)
        {
            resizing = false;
        }

        private void LoginTela_MouseMove(object sender, MouseEventArgs e)
        {
            if (resizing)
            {
                int newWidth = e.X + this.Left - lastMousePosition.X;
                newWidth = Math.Max(this.MinimumSize.Width, newWidth);
                this.Width = newWidth;
            }
            else if (e.X >= this.ClientSize.Width - resizeEdge)
            {
                this.Cursor = Cursors.SizeWE;
            }
            else
            {
                this.Cursor = Cursors.Default;
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
    }
}
