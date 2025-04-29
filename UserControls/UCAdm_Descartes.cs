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
    public partial class UCAdm_Descartes : UserControl
    {
        public UCAdm_Descartes()
        {
            InitializeComponent();
        }

        private void cb_TipoOrganico_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox? currentlyChecked = sender as CheckBox;

            if (currentlyChecked != null && currentlyChecked.Checked)
            {
                foreach (Control control in this.Controls) // Se os checkboxes estão diretamente no formulário
                {
                    if (control is CheckBox && control != currentlyChecked)
                    {
                        control.Enabled = false;
                    }
                }
                // Se os checkboxes estão dentro de um Panel ou GroupBox:
                foreach (Control control in panelTiposdeDescartes.Controls)
                {
                    if (control is CheckBox && control != currentlyChecked)
                    {
                        control.Enabled = false;
                    }
                }
            }
            else
            {
                foreach (Control control in this.Controls) // Se os checkboxes estão diretamente no formulário
                {
                    if (control is CheckBox && control != currentlyChecked)
                    {
                        control.Enabled = true;
                    }
                }
                // Se os checkboxes estão dentro de um Panel ou GroupBox:
                foreach (Control control in panelTiposdeDescartes.Controls)
                {
                    if (control is CheckBox && control != currentlyChecked)
                    {
                        control.Enabled = true;
                    }
                }
            }
        }

        private void btn_LimparFiltros_Click(object sender, EventArgs e)
        {
            // Se as checkboxes estão dentro de um Panel
            foreach (Control control in panelTiposdeDescartes.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                    checkBox.Enabled = true; // Reabilita a checkbox, caso tenha sido desabilitada
                }

                // Limpar ComboBox 
                cb_Peso.SelectedIndex = -1; // Desseleciona qualquer item
                cb_Peso.Text = string.Empty;   // Limpa o texto exibido (opcional)

                cb_Destino.SelectedIndex = -1;
                cb_Destino.Text = string.Empty;

                // Limpar a TextBox (supondo que seu TextBox se chama textBoxInformacoes):
                if (textLixoOutrasInfo != null) // Adiciona uma verificação de nulidade por segurança
                {
                    textLixoOutrasInfo.Text = string.Empty;
                }

            }
        }

        private void cb_Peso_KeyPress(object sender, KeyPressEventArgs e)
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

