using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ECOInsight.Helpers;

namespace ECOInsight.UserControls
{
    public partial class UCAdm_Usuarios : UserControl
    {
        public UCAdm_Usuarios()
        {
            InitializeComponent();
            ComboBoxHelper.PreencherStatusUsuario(cbCadStatus);
            ComboBoxHelper.PreencherPerfisUsuario(txtCadPerfil);
            ComboBoxHelper.PreencherTurnos(txtCadTurno);


        }

        private void btnCadCancelar_Click(object sender, EventArgs e)
        {
            txtCadNome.Text = string.Empty;
            txtCadEmail.Text = string.Empty;
            txtCadTelef.Text = string.Empty;
            txtCadSenha.Text = string.Empty;
            txtCadConfirSenha.Text = string.Empty;

            txtCadTurno.SelectedIndex = -1;
            txtCadTurno.Text = string.Empty;

            txtCadPerfil.Text = string.Empty;

            cbCadStatus.SelectedIndex = -1;
            cbCadStatus.Text = string.Empty;
        }

        private void btn_CadSalvar_Click(object sender, EventArgs e)
        {

        }

        private string GerarHashSenha(string senha)
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

        private void btn_CadBuscarUsuario_Click(object sender, EventArgs e)
        {
            string emailBuscado = txtCadEmail.Text.Trim();

            // Verificar se o e-mail foi preenchido
            if (string.IsNullOrEmpty(emailBuscado))
            {
                MessageBox.Show("Por favor, digite um e-mail para buscar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
                {
                    conn.Open();

                    // Query para buscar as informações do usuário baseado no e-mail
                    string query = @"
                SELECT 
                    u.id_usuario,
                    u.nome,
                    u.email,
                    u.telefone,
                    u.ativo,
                    p.nome_perfil,
                    f.turno
                FROM usuarios u
                LEFT JOIN usuarios_perfis up ON u.id_usuario = up.id_usuario
                LEFT JOIN perfis p ON up.id_perfil = p.id_perfil
                LEFT JOIN funcionarios f ON u.id_usuario = f.id_usuario
                WHERE u.email = @Email
                LIMIT 1;
            ";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", emailBuscado);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Preenchendo os campos com as informações retornadas
                            txtCadNome.Text = reader["nome"].ToString();
                            txtCadEmail.Text = reader["email"].ToString();
                            txtCadTelef.Text = reader["telefone"].ToString();
                            cbCadStatus.Text = Convert.ToBoolean(reader["ativo"]) ? "Ativo" : "Inativo";
                            txtCadPerfil.Text = reader["nome_perfil"].ToString();

                            // Se for um funcionário, preenche o turno
                            if (reader["turno"] != DBNull.Value)
                            {
                                txtCadTurno.Text = reader["turno"].ToString();
                            }
                            else
                            {
                                txtCadTurno.Text = ""; // Caso não seja funcionário, deixe em branco
                            }
                        }
                        else
                        {
                            // Caso o e-mail não exista
                            MessageBox.Show("Usuário não encontrado com este e-mail.", "Não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibindo erros, se houver
                MessageBox.Show("Erro ao buscar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CadNovoUsuario_Click(object sender, EventArgs e)
        {
            // 1. Validação das senhas
            if (string.IsNullOrEmpty(txtCadSenha.Text) || string.IsNullOrEmpty(txtCadConfirSenha.Text))
            {
                MessageBox.Show("Os campos de senha e confirmação de senha não podem estar vazios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtCadSenha.Text != txtCadConfirSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem. Por favor, insira as senhas novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
                {
                    conn.Open();

                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 2. Gerar hash da senha
                            string senhaHash = GerarHashSenha(txtCadSenha.Text);

                            // 3. Inserir na tabela "usuarios"
                            string insertUsuario = @"
                                INSERT INTO usuarios (nome, email, telefone, senha_hash, ativo)
                                VALUES (@Nome, @Email, @Telefone, @SenhaHash, @Ativo);
                                SELECT LAST_INSERT_ID();";

                            MySqlCommand cmdUsuario = new MySqlCommand(insertUsuario, conn, transaction);
                            cmdUsuario.Parameters.AddWithValue("@Nome", txtCadNome.Text);
                            cmdUsuario.Parameters.AddWithValue("@Email", txtCadEmail.Text);
                            cmdUsuario.Parameters.AddWithValue("@Telefone", txtCadTelef.Text);
                            cmdUsuario.Parameters.AddWithValue("@SenhaHash", senhaHash); // Hash aplicado aqui
                            cmdUsuario.Parameters.AddWithValue("@Ativo", cbCadStatus.Text.Trim().ToLower() == "ativo"); // Verificação do valor de Ativo

                            int idUsuario = Convert.ToInt32(cmdUsuario.ExecuteScalar());

                            // 4. Buscar id_perfil com base no nome informado
                            string selectPerfil = "SELECT id_perfil FROM perfis WHERE nome_perfil = @Perfil LIMIT 1";
                            MySqlCommand cmdPerfil = new MySqlCommand(selectPerfil, conn, transaction);
                            cmdPerfil.Parameters.AddWithValue("@Perfil", txtCadPerfil.Text.Trim());

                            object perfilResult = cmdPerfil.ExecuteScalar();
                            if (perfilResult == null)
                                throw new Exception("Perfil informado não existe.");

                            int idPerfil = Convert.ToInt32(perfilResult);

                            // 5. Inserir na tabela de relação usuarios_perfis
                            string insertRelacao = "INSERT INTO usuarios_perfis (id_usuario, id_perfil) VALUES (@IdUsuario, @IdPerfil)";
                            MySqlCommand cmdRelacao = new MySqlCommand(insertRelacao, conn, transaction);
                            cmdRelacao.Parameters.AddWithValue("@IdUsuario", idUsuario);
                            cmdRelacao.Parameters.AddWithValue("@IdPerfil", idPerfil);
                            cmdRelacao.ExecuteNonQuery();

                            // 6. Se perfil for Funcionário, insere também na tabela funcionarios
                            string perfilTexto = txtCadPerfil.Text.Trim().ToLower();
                            if (perfilTexto == "funcionário" || perfilTexto == "funcionario")
                            {
                                string insertFuncionario = @"
                                    INSERT INTO funcionarios (id_usuario, turno, data_contratacao)
                                    VALUES (@IdUsuario, @Turno, @DataContratacao)";
                                MySqlCommand cmdFuncionario = new MySqlCommand(insertFuncionario, conn, transaction);
                                cmdFuncionario.Parameters.AddWithValue("@IdUsuario", idUsuario);
                                cmdFuncionario.Parameters.AddWithValue("@Turno", txtCadTurno.SelectedItem?.ToString() ?? "");
                                cmdFuncionario.Parameters.AddWithValue("@DataContratacao", DateTime.Now);
                                cmdFuncionario.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception exTransacao)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Erro ao salvar o usuário: " + exTransacao.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Falha na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_CadExcluirUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btn_CadEditarUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
