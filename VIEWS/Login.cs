namespace ECOInsight;

public partial class LoginTela : Form
{
    public LoginTela()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void btnEntrar_Click(object sender, EventArgs e)
    {
        HomeTela home = new HomeTela();
        home.Show(); //Abre a nova tela
        this.Hide(); //Oculta a tela atual
    }

    private void btnEsqueciSenha_Click_1(object sender, EventArgs e)
    {
        Esqueci_a_SenhaTela Esqueci_a_SenhaTela = new Esqueci_a_SenhaTela();
        Esqueci_a_SenhaTela.FormClosed += (s, ev) => this.Show(); // Adiciona um manipulador para o evento FormClosed
        Esqueci_a_SenhaTela.Show();
        this.Hide();
    }

    private void checkBoxVizualizarSenha_CheckedChanged(object sender, EventArgs e)
    {
        txtSenha.PasswordChar = checkBoxVizualizarSenha.Checked ? '\0' : '*';
    }

    private void btnCriarCadastro_Click(object sender, EventArgs e)
    {
        CadastroTela cadastro = new CadastroTela();
        cadastro.Show(); //Abre a nova tela
        this.Hide(); //Oculta a tela atual 
    }

    private void LoginTela_Load(object sender, EventArgs e)
    {

    }

    private void btnMinimizarLogin_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private Size tamanhoOriginal; // Variável para armazenar o tamanho original
    private bool maximizado = false;

    private void btnMaximizarRestaurarLogin_Click(object sender, EventArgs e)
    {
        if (!maximizado) // Se não estiver maximizado, maximizar
        {
            tamanhoOriginal = this.Size; // Armazena o tamanho atual
            this.WindowState = FormWindowState.Maximized; // Maximiza
            btnMaximizarRestaurarLogin.Text = " "; // Atualiza o texto
            maximizado = true;
        }
        else // Se estiver maximizado, restaurar para o tamanho original
        {
            this.WindowState = FormWindowState.Normal; // Define o estado como normal primeiro
            this.Size = tamanhoOriginal; // Restaura o tamanho
            btnMaximizarRestaurarLogin.Text = " "; // Atualiza o texto
            maximizado = false;
        }
    }

    private void btnFecharLogin_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
