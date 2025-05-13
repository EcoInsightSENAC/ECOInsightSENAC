using System; // Importa a biblioteca básica para manipulação de tipos e operações comuns.
using System.Security.Cryptography; // Importa a biblioteca para criptografia, incluindo SHA256.
using System.Text; // Importa a biblioteca para manipulação de strings e codificações.

namespace ECOInsight.Utils // Define o namespace para organizar o código em pacotes lógicos.
{
    // Classe estática Criptografia que contém o método de criptografia.
    public static class Criptografia
    {
        // Método para gerar o hash SHA256 de uma senha recebida como parâmetro.
        public static string GerarHashSHA256(string senha)
        {
            // Utiliza o bloco "using" para garantir que o objeto sha256 seja descartado corretamente após o uso.
            using (SHA256 sha256 = SHA256.Create())
            {
                // Converte a senha para uma sequência de bytes utilizando a codificação UTF-8.
                byte[] bytes = Encoding.UTF8.GetBytes(senha);

                // Calcula o hash SHA256 da sequência de bytes da senha.
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Converte o array de bytes do hash para uma string em formato Base64, para facilitar o armazenamento e a comparação.
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}