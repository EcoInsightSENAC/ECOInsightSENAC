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

        // Cria, abre e devolve a conexão
        public static MySqlConnection CreateConnection()
        {
            var conn = new MySqlConnection(_cs);
            conn.Open();
            return conn;
        }
    }
}