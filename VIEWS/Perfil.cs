using ECOInsight;

namespace ECOInsightSENAC
{
    public partial class PerfilTela : Form
    {
        public PerfilTela()
        {
            InitializeComponent();
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxPad_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdinistrador_Click(object sender, EventArgs e)
        {
            LoginTela gestor = new LoginTela();
            gestor.Show(); // Abre a nova tela
            this.Hide(); //Oculta a tela atual 
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            LoginTela gestor = new LoginTela(); // Tela que deseja mostrar 
            gestor.Show(); // Abre a nova tela
            this.Hide(); //Oculta a tela atual 
        }
    }
}
