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
        Esqueci_a_SenhaTela esqueci_A_Senha = new Esqueci_a_SenhaTela();
        esqueci_A_Senha.Show(); //Abre a nova tela
        this.Hide(); //Oculta a tela atual 
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

    private void iconMinim_Click_1(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void iconMax_Click_1(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Maximized;

    }

    private void iconX_Click_1(object sender, EventArgs e)
    {
        this.Close();
    }

    private void checkBoxVizualizarSenha_CheckedChanged(object sender, EventArgs e)
    {
        txtSenha.PasswordChar = checkBoxVizualizarSenha.Checked ? '\0' : '*';
    }
}
