using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECOInsight.DataAccess;
using ECOInsight.Modelos;
using System.Windows.Media.Media3D;

namespace ECOInsight.UserControls
{
    public partial class UCAdm_Descartes : UserControl
    {
        public UCAdm_Descartes()
        {
            InitializeComponent();
            DesativarTodasTextBoxes();
        }

        private void DesativarTodasTextBoxes()
        {
            txt_TipoOrganico.Enabled = false;
            txt_TipoPapel.Enabled = false;
            txt_TipoPlastico.Enabled = false;
            txt_TipoVidro.Enabled = false;
            txt_TipoMetal.Enabled = false;
            txt_TipoEletronico.Enabled = false;
            txt_TipoMedicamentos.Enabled = false;
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

                //Alteração nas telas este campo não existe mais 

                //cb_Destino.SelectedIndex = -1;
                //cb_Destino.Text = string.Empty;

                // Limpar a TextBox
                if (txt_DescartesOutrasInfo != null) // Adiciona uma verificação de nulidade por segurança
                {
                    txt_DescartesOutrasInfo.Text = string.Empty;
                    txt_TipoOrganico.Text = string.Empty;
                    txt_TipoPapel.Text = string.Empty;
                    txt_TipoPlastico.Text = string.Empty;
                    txt_TipoVidro.Text = string.Empty;
                    txt_TipoMetal.Text = string.Empty;
                    txt_TipoEletronico.Text = string.Empty;
                    txt_TipoMedicamentos.Text = string.Empty;
                }

            }
        }

        private void cb_TipoOrganico_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_TipoOrganico.Enabled = cb_TipoOrganico.Checked;

            if (!cb_TipoOrganico.Checked)
            {
                txt_TipoOrganico.Text = string.Empty;
            }
        }

        private void cb_TipoVidro_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_TipoVidro.Enabled = cb_TipoVidro.Checked;

            if (!cb_TipoVidro.Checked)
            {
                txt_TipoVidro.Text = string.Empty;
            }
        }

        private void cb_TipoMetal_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_TipoMetal.Enabled = cb_TipoMetal.Checked;

            if (!cb_TipoMetal.Checked)
            {
                txt_TipoMetal.Text = string.Empty;
            }
        }

        private void cb_TipoEletronico_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_TipoEletronico.Enabled = cb_TipoEletronico.Checked;

            if (!cb_TipoEletronico.Checked)
            {
                txt_TipoEletronico.Text = string.Empty;
            }
        }

        private void cb_TipoMedicamentos_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_TipoMedicamentos.Enabled = cb_TipoMedicamentos.Checked;

            if (!cb_TipoMedicamentos.Checked)
            {
                txt_TipoMedicamentos.Text = string.Empty;
            }
        }

        private void cb_TipoPapel_CheckedChanged(object sender, EventArgs e)
        {
            txt_TipoPapel.Enabled = cb_TipoPapel.Checked;

            if (!cb_TipoPapel.Checked)
            {
                txt_TipoPapel.Text = string.Empty;
            }
        }

        private void cb_TipoPlastico_CheckedChanged(object sender, EventArgs e)
        {
            txt_TipoPlastico.Enabled = cb_TipoPlastico.Checked;

            if (!cb_TipoPlastico.Checked)
            {
                txt_TipoPlastico.Text = string.Empty;
            }
        }

        private void txt_DescartesOutrasInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void UCAdm_Descartes_Load(object sender, EventArgs e)
        {

        }

        private void btn_ProcurArquivos_Click(object sender, EventArgs e)
        {

        }



        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // Seu código para o que deve acontecer quando o botão for clicado
            MessageBox.Show("Botão Salvar foi clicado!");
        }


    }
}