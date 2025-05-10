using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace ECOInsight.DataAccess
{
    public static class Conexao
    {
        // Lê a cadeia de conexão uma única vez
        private static readonly string _cs =
            ConfigurationManager
               .ConnectionStrings["MyConnectionString"]
               .ConnectionString;

        // Cria, abre e devolve a conexão com tratamento de erros
        public static MySqlConnection CreateConnection()
        {
            try
            {
                var conn = new MySqlConnection(_cs);
                conn.Open();  // Tenta abrir a conexão
                return conn;
            }
            catch (MySqlException ex)
            {
                // Aqui você pode tratar o erro de conexão (ex: log ou mensagem amigável)
                throw new Exception("Erro ao conectar ao banco de dados.", ex);
            }
        }

        // Método de exemplo para obter dados do banco usando a conexão
        public static void ExecutarComando(string query)
        {
            using (var conn = CreateConnection())  // Usando o 'using' para garantir que a conexão será fechada
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    // Exemplo de execução de comando (sem retorno de dados)
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Exemplo de método que usa a conexão para buscar dados (retorno de dados)
        public static MySqlDataReader ExecutarLeitura(string query)
        {
            var conn = CreateConnection();
            try
            {
                var cmd = new MySqlCommand(query, conn);
                return cmd.ExecuteReader();  // Retorna um leitor de dados
            }
            catch (Exception ex)
            {
                conn.Close();  // Fecha a conexão em caso de erro
                throw new Exception("Erro ao executar a consulta no banco de dados.", ex);
            }
        }
    }
}
