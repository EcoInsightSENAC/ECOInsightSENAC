using System.Windows.Forms;

namespace ECOInsight.Helpers
{
    public static class ComboBoxHelper
    {
        public static void PreencherStatusUsuario(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("Ativo");
            comboBox.Items.Add("Inativo");
        }
        public static void PreencherPerfisUsuario(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("Administrador");
            comboBox.Items.Add("Aluno");
            comboBox.Items.Add("Professor");
            comboBox.Items.Add("Funcionário");
        }

        public static void PreencherTurnos(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("Manhã");
            comboBox.Items.Add("Tarde");
            comboBox.Items.Add("Noite");
        }
    }
}

