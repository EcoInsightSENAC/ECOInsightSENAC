using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECOInsight.UserControls
{
    public partial class UCAdm_MeuPerfil : UserControl
    {
        public UCAdm_MeuPerfil()
        {
            InitializeComponent();
        }

        private void txtAdm_PerfilTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere digitado é um dígito (0-9)
            if (char.IsDigit(e.KeyChar))
            {
                // Se for um dígito, permite a entrada
                e.Handled = false;
            }
            // Verifica se o caractere é um caractere de controle (como Backspace)
            else if (char.IsControl(e.KeyChar))
            {
                // Se for um caractere de controle, permite a entrada
                e.Handled = false;
            }
            else
            {
                // Se não for um dígito nem um caractere de controle, bloqueia a entrada
                e.Handled = true;
            }
        }

    }
}
