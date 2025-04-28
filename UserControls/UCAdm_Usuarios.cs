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
    public partial class UCAdm_Usuarios : UserControl
    {
        public UCAdm_Usuarios()
        {
            InitializeComponent();
        }

        private void btnCadCancelar_Click(object sender, EventArgs e)
        {
            if (txtCadNome != null)
            {
                txtCadNome.Text = string.Empty;
            }
            if (txtCadEmail != null)
            {
                txtCadEmail.Text = string.Empty;
            }
            if (txtCadTelef != null)
            {
                txtCadTelef.Text = string.Empty;
            }
            if (txtCadSenha != null)
            {
                txtCadSenha.Text = string.Empty;
            }
            if (txtCadConfirSenha != null)
            {
                txtCadConfirSenha.Text = string.Empty;
            }
            // Limpar ComboBox 
            cbCadTurno.SelectedIndex = -1; // Desseleciona qualquer item
            cbCadTurno.Text = string.Empty;   // Limpa o texto exibido (opcional)

            cbCadPerfil.SelectedIndex = -1;
            cbCadPerfil.Text = string.Empty;

            cbCadStatus.SelectedIndex = -1;
            cbCadStatus.Text = string.Empty;
        }
    }
}
