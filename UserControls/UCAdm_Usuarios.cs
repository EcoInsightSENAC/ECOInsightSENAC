using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace ECOInsight.UserControls
{
    public partial class UCAdm_Usuarios : UserControl
    {
        public UCAdm_Usuarios()
        {
            InitializeComponent();
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
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
                {
                    conn.Open();

                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Inserir na tabela "usuarios"
                            string insertUsuario = @"
                                INSERT INTO usuarios (nome, email, telefone, senha_hash, ativo)
                                VALUES (@Nome, @Email, @Telefone, @SenhaHash, @Ativo);
                                SELECT LAST_INSERT_ID();";

                            MySqlCommand cmdUsuario = new MySqlCommand(insertUsuario, conn, transaction);
                            cmdUsuario.Parameters.AddWithValue("@Nome", txtCadNome.Text);
                            cmdUsuario.Parameters.AddWithValue("@Email", txtCadEmail.Text);
                            cmdUsuario.Parameters.AddWithValue("@Telefone", txtCadTelef.Text);
                            cmdUsuario.Parameters.AddWithValue("@SenhaHash", txtCadSenha.Text); // Aqui poderia aplicar hash
                            cmdUsuario.Parameters.AddWithValue("@Ativo", cbCadStatus.Text == "Ativo");

                            int idUsuario = Convert.ToInt32(cmdUsuario.ExecuteScalar());

                            // 2. Buscar id_perfil com base no nome informado
                            string selectPerfil = "SELECT id_perfil FROM perfis WHERE nome_perfil = @Perfil LIMIT 1";
                            MySqlCommand cmdPerfil = new MySqlCommand(selectPerfil, conn, transaction);
                            cmdPerfil.Parameters.AddWithValue("@Perfil", txtCadPerfil.Text.Trim());

                            object perfilResult = cmdPerfil.ExecuteScalar();
                            if (perfilResult == null)
                                throw new Exception("Perfil informado não existe.");

                            int idPerfil = Convert.ToInt32(perfilResult);

                            // 3. Inserir na tabela de relação usuarios_perfis
                            string insertRelacao = "INSERT INTO usuarios_perfis (id_usuario, id_perfil) VALUES (@IdUsuario, @IdPerfil)";
                            MySqlCommand cmdRelacao = new MySqlCommand(insertRelacao, conn, transaction);
                            cmdRelacao.Parameters.AddWithValue("@IdUsuario", idUsuario);
                            cmdRelacao.Parameters.AddWithValue("@IdPerfil", idPerfil);
                            cmdRelacao.ExecuteNonQuery();

                            // 4. Se perfil for Funcionário, insere também na tabela funcionarios
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
    }
}
