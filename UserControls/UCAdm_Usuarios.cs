using MySql.Data.MySqlClient;  // Importa o namespace do MySQL, que contém as classes necessárias para a conexão com o banco de dados MySQL.
using System;  // Importa o namespace básico do .NET.
using System.Configuration;  // Importa o namespace necessário para acessar configurações (como a connection string) do arquivo de configuração.
using System.Windows.Forms;  // Importa o namespace que fornece classes para criar interfaces gráficas de usuário (Forms, controles, etc.).

namespace ECOInsight.UserControls  // Define o namespace que está encapsulando os controles do usuário.
{
    public partial class UCAdm_Usuarios : UserControl  // Define a classe do controle de usuário UCAdm_Usuarios, herda de UserControl.
    {
        public UCAdm_Usuarios()  // Construtor da classe UCAdm_Usuarios.
        {
            InitializeComponent();  // Inicializa os componentes do controle (cria e configura os controles, como botões e campos de texto).
        }

        // Método chamado quando o botão "Cancelar" é clicado.
        private void btnCadCancelar_Click(object sender, EventArgs e)
        {
            if (txtCadNome != null)  // Verifica se o campo de texto 'txtCadNome' não é nulo.
            {
                txtCadNome.Text = string.Empty;  // Limpa o texto do campo 'txtCadNome'.
            }
            if (txtCadEmail != null)  // Verifica se o campo de texto 'txtCadEmail' não é nulo.
            {
                txtCadEmail.Text = string.Empty;  // Limpa o texto do campo 'txtCadEmail'.
            }
            if (txtCadTelef != null)  // Verifica se o campo de texto 'txtCadTelef' não é nulo.
            {
                txtCadTelef.Text = string.Empty;  // Limpa o texto do campo 'txtCadTelef'.
            }
            if (txtCadSenha != null)  // Verifica se o campo de texto 'txtCadSenha' não é nulo.
            {
                txtCadSenha.Text = string.Empty;  // Limpa o texto do campo 'txtCadSenha'.
            }
            if (txtCadConfirSenha != null)  // Verifica se o campo de texto 'txtCadConfirSenha' não é nulo.
            {
                txtCadConfirSenha.Text = string.Empty;  // Limpa o texto do campo 'txtCadConfirSenha'.
            }

            // Limpar ComboBox (tira qualquer seleção ou texto exibido).
            cbCadTurno.SelectedIndex = -1;  // Desseleciona qualquer item da ComboBox 'cbCadTurno'.
            cbCadTurno.Text = string.Empty;  // Limpa o texto exibido na ComboBox 'cbCadTurno'.

            cbCadPerfil.SelectedIndex = -1;  // Desseleciona qualquer item da ComboBox 'cbCadPerfil'.
            cbCadPerfil.Text = string.Empty;  // Limpa o texto exibido na ComboBox 'cbCadPerfil'.

            cbCadStatus.SelectedIndex = -1;  // Desseleciona qualquer item da ComboBox 'cbCadStatus'.
            cbCadStatus.Text = string.Empty;  // Limpa o texto exibido na ComboBox 'cbCadStatus'.
        }

        // Método chamado quando o botão "Salvar" é clicado.
        private void btn_CadSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Estabelece a conexão com o banco de dados MySQL, usando a connection string do arquivo de configuração (web.config ou app.config).
                MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
                conn.Open();  // Abre a conexão com o banco de dados.

                // Comando SQL para inserir dados na tabela "usuarios" do banco de dados.
                string query = "INSERT INTO usuarios (nome, email, telefone, senha_hash, turno, perfil, ativo) VALUES (@Nome, @Email, @Telefone, @SenhaHash, @Turno, @Perfil, @Ativo)";

                // Coleta os dados dos campos de texto e ComboBoxes na interface do usuário.
                string nome = txtCadNome.Text;  // Obtém o nome do usuário do campo de texto 'txtCadNome'.
                string email = txtCadEmail.Text;  // Obtém o e-mail do usuário do campo de texto 'txtCadEmail'.
                string telefone = txtCadTelef.Text;  // Obtém o telefone do usuário do campo de texto 'txtCadTelef'.
                string senha_hash = txtCadSenha.Text;  // Obtém a senha do usuário (em texto simples) do campo 'txtCadSenha'.
                string turno = cbCadTurno.SelectedItem.ToString();  // Obtém o turno selecionado na ComboBox 'cbCadTurno'.
                string perfil = cbCadPerfil.SelectedItem.ToString();  // Obtém o perfil selecionado na ComboBox 'cbCadPerfil'.
                string ativo = cbCadStatus.SelectedItem.ToString();  // Obtém o status (ativo ou inativo) selecionado na ComboBox 'cbCadStatus'.

                // Cria o comando SQL e adiciona os parâmetros que serão passados para a consulta.
                MySqlCommand cmd = new MySqlCommand(query, conn);  // Cria o comando SQL usando a string de consulta e a conexão com o banco de dados.
                cmd.Parameters.AddWithValue("@Nome", nome);  // Adiciona o valor do nome no parâmetro '@Nome'.
                cmd.Parameters.AddWithValue("@Email", email);  // Adiciona o valor do e-mail no parâmetro '@Email'.
                cmd.Parameters.AddWithValue("@Telefone", telefone);  // Adiciona o valor do telefone no parâmetro '@Telefone'.
                cmd.Parameters.AddWithValue("@SenhaHash", senha_hash);  // Adiciona o valor da senha no parâmetro '@SenhaHash'.
                cmd.Parameters.AddWithValue("@Turno", turno);  // Adiciona o valor do turno no parâmetro '@Turno'.
                cmd.Parameters.AddWithValue("@Perfil", perfil);  // Adiciona o valor do perfil no parâmetro '@Perfil'.
                cmd.Parameters.AddWithValue("@Ativo", ativo);  // Adiciona o valor do status (ativo ou inativo) no parâmetro '@Ativo'.

                // Executa o comando SQL. O método ExecuteNonQuery() retorna o número de linhas afetadas pela execução do comando.
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)  // Verifica se ao menos uma linha foi afetada (indicando que o cadastro foi bem-sucedido).
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);  // Exibe uma mensagem de sucesso.
                }
                else  // Se nenhuma linha foi afetada, indica que ocorreu um erro ao tentar cadastrar.
                {
                    MessageBox.Show("Erro ao cadastrar o usuário. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);  // Exibe uma mensagem de erro.
                }

                // Fecha a conexão com o banco de dados.
                conn.Close();
            }
            catch (Exception ex)  // Captura qualquer exceção que ocorrer durante o processo.
            {
                // Exibe uma mensagem de erro se houver algum problema ao conectar ao banco de dados ou executar a consulta.
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Falha na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
