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
    public partial class UCAdm_Registros : UserControl
    {
        public UCAdm_Registros()
        {
            InitializeComponent();
        }

        private void btn_LimparFiltros_Click(object sender, EventArgs e)
        {
            // Lista para armazenar os ComboBoxes
            List<ComboBox> comboBoxesParaLimpar = new List<ComboBox>();

            // Adiciona os ComboBoxes à lista
            comboBoxesParaLimpar.Add(cb_Categoria);
            comboBoxesParaLimpar.Add(cb_TipoDescarte);
            comboBoxesParaLimpar.Add(cb_Destino);
            comboBoxesParaLimpar.Add(cb_GarrafasEcono);
            comboBoxesParaLimpar.Add(cb_Minhocario);
            comboBoxesParaLimpar.Add(cb_TipoMinhoca);
            comboBoxesParaLimpar.Add(cb_Pesototal);
            comboBoxesParaLimpar.Add(cb_Bebedouro);
            comboBoxesParaLimpar.Add(cb_TotalLitros);
            comboBoxesParaLimpar.Add(cb_HumusColetado);

            // Itera pela lista de ComboBoxes e limpa a seleção
            foreach (ComboBox comboBox in comboBoxesParaLimpar)
            {
                comboBox.SelectedIndex = -1; // Desseleciona o item
                comboBox.Text = string.Empty;       // Limpa o texto exibido (opcional)
            }
        }
    }
}
