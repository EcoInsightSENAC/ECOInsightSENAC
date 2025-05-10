using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

public class Autenticacao
{
    // Função para validar o login
    public bool ValidarLogin(string email, string senha)
    {
        // Gerar o hash da senha informada pelo usuário
        string senhaHashInformada = GerarHashSenha(senha);

        // Estabelecer a conexão com o banco de dados
        using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
        {
            try
            {
                conn.Open();

                // Consulta SQL para pegar o hash da senha armazenada no banco
                string query = "SELECT senha_hash FROM usuarios WHERE email = @Email AND ativo = TRUE";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                // Executar a consulta e obter o hash armazenado
                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    string senhaHashArmazenada = resultado.ToString();

                    // Comparar o hash informado com o hash armazenado
                    if (senhaHashInformada == senhaHashArmazenada)
                    {
                        // Senha válida
                        return true;
                    }
                    else
                    {
                        // Senha inválida
                        return false;
                    }
                }
                else
                {
                    // Usuário não encontrado
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Tratar erros de conexão ou exceções
                Console.WriteLine("Erro ao verificar login: " + ex.Message);
                return false;
            }
        }
    }

    // Função para gerar o hash SHA-256 da senha
    private string GerarHashSenha(string senha)
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
}
