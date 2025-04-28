using System.Text.RegularExpressions;

namespace ECOInsight;

public partial class LoginTela : Form
{
    #region Campos (Fields)

    private Size tamanhoOriginal; // Variável para armazenar o tamanho original
    private bool maximizado = false;

    #endregion

    #region Construtor (Constructor)

    public LoginTela()
    {
        InitializeComponent();
    }

    #endregion

    #region Métodos de Evento (Event Handlers)

    private void btnEntrar_Click(object sender, EventArgs e)
    {
        HomeTela home = new HomeTela();
        home.Show(); // Abre a nova tela
        this.Hide(); // Oculta a tela atual
    }

    private void btnEsqueciSenha_Click_1(object sender, EventArgs e)
    {
        Esqueci_a_SenhaTela esqueciSenhaTela = new Esqueci_a_SenhaTela();
        esqueciSenhaTela.FormClosed += (s, ev) => this.Show(); // Adiciona um manipulador para o evento FormClosed
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
        if (!maximizado) // Se não estiver maximizado, maximizar
        {
            tamanhoOriginal = this.Size; // Armazena o tamanho atual
            this.WindowState = FormWindowState.Maximized; // Maximiza
            btnMaximizarRestaurarLogin.Text = " "; // Atualiza o texto (pode ser um ícone)
            maximizado = true;
        }
        else // Se estiver maximizado, restaurar para o tamanho original
        {
            this.WindowState = FormWindowState.Normal; // Define o estado como normal primeiro
            this.Size = tamanhoOriginal; // Restaura o tamanho
            btnMaximizarRestaurarLogin.Text = " "; // Atualiza o texto (pode ser um ícone)
            maximizado = false;
        }
    }



    #endregion

    private void txtEmail_TextChanged(object sender, EventArgs e)
    {
        TextBox textBox = (TextBox)sender;
        string email = textBox.Text.Trim();
        bool formatoValido = IsEmailValido(email);

        if (!formatoValido && !string.IsNullOrEmpty(email))
        {
            // Feedback de erro: altere a cor da borda do TextBox para vermelho
            textBox.BorderStyle = BorderStyle.Fixed3D;
            textBox.BackColor = Color.MistyRose; //optional
        }
        else
        {
            // Restaura a cor da borda padrão
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.BackColor = System.Drawing.SystemColors.Window; //optional
        }
    }

    private bool IsEmailValido(string email)
    {
        if (string.IsNullOrEmpty(email))
            return true; // Permite campo vazio se for opcional

        // Expressão regular para validar o formato de e-mail (uma versão básica)
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        return Regex.IsMatch(email, pattern);
    }

    private void btnFecharLogin_Click(object sender, EventArgs e)
    {
        System.Windows.Forms.Application.Exit();
    }
}