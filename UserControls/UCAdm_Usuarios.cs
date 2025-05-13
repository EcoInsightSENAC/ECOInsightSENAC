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
            string email = txtCadEmail.Text.Trim(); // E-mail do usuário
            string nome = txtCadNome.Text.Trim();   // Nome do usuário
            string telefone = txtCadTelef.Text.Trim(); // Telefone do usuário
            bool ativo = cbCadStatus.SelectedItem.ToString() == "Ativo"; // Status (ativo ou inativo)

            // Validação: Verifique se os campos obrigatórios estão preenchidos
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Iniciar a conexão com o banco de dados
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
                {
                    conn.Open();

                    // Verificar se o e-mail existe no banco
                    string checkUserQuery = "SELECT COUNT(*) FROM usuarios WHERE email = @Email";
                    MySqlCommand cmdCheckUser = new MySqlCommand(checkUserQuery, conn);
                    cmdCheckUser.Parameters.AddWithValue("@Email", email);
                    int userCount = Convert.ToInt32(cmdCheckUser.ExecuteScalar());

                    if (userCount == 0)
                    {
                        MessageBox.Show("Usuário não encontrado com este e-mail.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Atualizar os dados do usuário
                    string updateUserQuery = @"
                UPDATE usuarios 
                SET nome = @Nome, telefone = @Telefone, ativo = @Ativo 
                WHERE email = @Email";

                    MySqlCommand cmdUpdateUser = new MySqlCommand(updateUserQuery, conn);
                    cmdUpdateUser.Parameters.AddWithValue("@Nome", nome);
                    cmdUpdateUser.Parameters.AddWithValue("@Telefone", telefone);
                    cmdUpdateUser.Parameters.AddWithValue("@Ativo", ativo);
                    cmdUpdateUser.Parameters.AddWithValue("@Email", email);

                    int rowsAffected = cmdUpdateUser.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Informações do usuário atualizadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma alteração realizada. O usuário pode não ter sido alterado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar as informações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            string emailBuscado = txtCadEmail.Text.Trim();

            // Verificar se o e-mail foi preenchido
            if (string.IsNullOrEmpty(emailBuscado))
            {
                MessageBox.Show("Por favor, digite o e-mail do usuário para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmar a exclusão com o usuário
            DialogResult dialogResult = MessageBox.Show("Tem certeza de que deseja excluir este usuário?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
                {
                    conn.Open();

                    // Iniciar uma transação para garantir que todas as exclusões sejam realizadas de forma atômica
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Primeiro, verificar se o usuário existe
                            string checkUserQuery = "SELECT COUNT(*) FROM usuarios WHERE email = @Email";
                            MySqlCommand cmdCheckUser = new MySqlCommand(checkUserQuery, conn);
                            cmdCheckUser.Parameters.AddWithValue("@Email", emailBuscado);
                            int userCount = Convert.ToInt32(cmdCheckUser.ExecuteScalar());

                            if (userCount == 0)
                            {
                                MessageBox.Show("Usuário não encontrado com este e-mail.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Excluir os dados relacionados ao usuário nas tabelas de relacionamento (usuarios_perfis, funcionarios)
                            string deleteUserProfile = "DELETE FROM usuarios_perfis WHERE id_usuario = (SELECT id_usuario FROM usuarios WHERE email = @Email)";
                            MySqlCommand cmdDeleteProfile = new MySqlCommand(deleteUserProfile, conn, transaction);
                            cmdDeleteProfile.Parameters.AddWithValue("@Email", emailBuscado);
                            cmdDeleteProfile.ExecuteNonQuery();

                            string deleteFuncionario = "DELETE FROM funcionarios WHERE id_usuario = (SELECT id_usuario FROM usuarios WHERE email = @Email)";
                            MySqlCommand cmdDeleteFuncionario = new MySqlCommand(deleteFuncionario, conn, transaction);
                            cmdDeleteFuncionario.Parameters.AddWithValue("@Email", emailBuscado);
                            cmdDeleteFuncionario.ExecuteNonQuery();

                            // Excluir o usuário da tabela de usuários
                            string deleteUser = "DELETE FROM usuarios WHERE email = @Email";
                            MySqlCommand cmdDeleteUser = new MySqlCommand(deleteUser, conn, transaction);
                            cmdDeleteUser.Parameters.AddWithValue("@Email", emailBuscado);
                            cmdDeleteUser.ExecuteNonQuery();

                            // Commit da transação
                            transaction.Commit();

                            MessageBox.Show("Usuário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            // Caso haja algum erro, realizar rollback da transação
                            transaction.Rollback();
                            MessageBox.Show("Erro ao excluir usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibindo erro de conexão com o banco de dados
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Falha na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CadEditarUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
