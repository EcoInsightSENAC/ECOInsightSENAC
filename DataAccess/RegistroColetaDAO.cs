using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECOInsight.Modelos;
using MySql.Data.MySqlClient;

namespace ECOInsight.DataAccess
{
    public class RegistroColetaDAO
    {
        public static void InserirRegistro(RegistroColeta registro)
        {
            string query = @"INSERT INTO registro_coletas 
                        (id_funcionario, material, quantidade, local_coleta, destino_coleta, data_coleta, caminho_arquivo, outras_informacoes) 
                        VALUES 
                        (@id_funcionario, @material, @quantidade, @local_coleta, @destino_coleta, @data_coleta, @caminho_arquivo, @outras_informacoes)";

            using (var conn = Conexao.CreateConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_funcionario", registro.IdFuncionario);
                    cmd.Parameters.AddWithValue("@material", registro.Material);
                    cmd.Parameters.AddWithValue("@quantidade", registro.Quantidade);
                    cmd.Parameters.AddWithValue("@local_coleta", registro.LocalColeta);
                    cmd.Parameters.AddWithValue("@destino_coleta", registro.DestinoColeta);
                    cmd.Parameters.AddWithValue("@data_coleta", registro.DataColeta);
                    cmd.Parameters.AddWithValue("@caminho_arquivo", registro.CaminhoArquivo ?? "");
                    cmd.Parameters.AddWithValue("@outras_informacoes", registro.OutrasInformacoes ?? "");

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

}
