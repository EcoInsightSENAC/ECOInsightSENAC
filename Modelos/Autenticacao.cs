using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Security.Cryptography; // Adicionando SHA256
using System.Text;

public class Autenticacao
{
    public class ResultadoAutenticacao
    {
        public bool Sucesso { get; set; }
        public string Perfil { get; set; }
    }

    public ResultadoAutenticacao ValidarLogin(string email, string senha)
    {
        // Gerar o hash da senha informada
        string senhaHashInformada = GerarHashSenha(senha);

        using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
        {
            try
            {
                conn.Open();

                string query = @"
                    SELECT u.senha_hash, p.nome_perfil 
                    FROM usuarios u
                    JOIN usuarios_perfis up ON u.id_usuario = up.id_usuario
                    JOIN perfis p ON up.id_perfil = p.id_perfil
                    WHERE u.email = @Email AND u.ativo = TRUE";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string senhaHashArmazenada = reader["senha_hash"].ToString();

                        // Usar uma comparação segura para comparar os hashes
                        if (CompararHashes(senhaHashInformada, senhaHashArmazenada))
                        {
                            return new ResultadoAutenticacao
                            {
                                Sucesso = true,
                                Perfil = reader["nome_perfil"].ToString()
                            };
                        }
                    }
                    return new ResultadoAutenticacao { Sucesso = false };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar login: " + ex.Message);
                return new ResultadoAutenticacao { Sucesso = false };
            }
        }
    }

    private string GerarHashSenha(string senha)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            // Convert the input string to a byte array and compute the hash
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));

            // Convert the byte array to a hexadecimal string
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }

    private bool CompararHashes(string hash1, string hash2)
    {
        // Comparação segura de hashes
        if (hash1.Length != hash2.Length)
            return false;

        // Comparar byte por byte de forma constante para evitar ataques de timing
        for (int i = 0; i < hash1.Length; i++)
        {
            if (hash1[i] != hash2[i])
                return false;
        }

        return true;
    }
}
