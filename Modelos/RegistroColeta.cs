using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOInsight.Modelos
{
    public class RegistroColeta
    {
        public int IdFuncionario { get; set; }
        public string Material { get; set; }
        public double Quantidade { get; set; }
        public string LocalColeta { get; set; }
        public string DestinoColeta { get; set; }
        public DateTime DataColeta { get; set; }
        public string CaminhoArquivo { get; set; }  // Se for salvar o caminho
        public string OutrasInformacoes { get; set; }
    }

}
