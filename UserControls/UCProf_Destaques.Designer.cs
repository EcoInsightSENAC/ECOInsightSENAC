namespace ECOInsight.UserControls
{
    partial class UCProf_Destaques
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblDestaques = new Label();
            pictureBoxDestaques = new PictureBox();
            txtMensagem = new TextBox();
            lblMensagem = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDestaques).BeginInit();
            SuspendLayout();
            // 
            // lblDestaques
            // 
            lblDestaques.Anchor = AnchorStyles.Top;
            lblDestaques.AutoSize = true;
            lblDestaques.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestaques.Location = new Point(52, 53);
            lblDestaques.Name = "lblDestaques";
            lblDestaques.Size = new Size(163, 37);
            lblDestaques.TabIndex = 58;
            lblDestaques.Text = "Destaques!";
            // 
            // pictureBoxDestaques
            // 
            pictureBoxDestaques.Anchor = AnchorStyles.Top;
            pictureBoxDestaques.BackColor = SystemColors.ControlLight;
            pictureBoxDestaques.Location = new Point(52, 106);
            pictureBoxDestaques.Name = "pictureBoxDestaques";
            pictureBoxDestaques.Size = new Size(874, 237);
            pictureBoxDestaques.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDestaques.TabIndex = 59;
            pictureBoxDestaques.TabStop = false;
            // 
            // txtMensagem
            // 
            txtMensagem.Anchor = AnchorStyles.Top;
            txtMensagem.Location = new Point(52, 448);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(874, 146);
            txtMensagem.TabIndex = 60;
            // 
            // lblMensagem
            // 
            lblMensagem.Anchor = AnchorStyles.Top;
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagem.Location = new Point(52, 395);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(162, 37);
            lblMensagem.TabIndex = 61;
            lblMensagem.Text = "Mensagem";
            // 
            // UCProf_Destaques
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblMensagem);
            Controls.Add(txtMensagem);
            Controls.Add(pictureBoxDestaques);
            Controls.Add(lblDestaques);
            Name = "UCProf_Destaques";
            Size = new Size(978, 646);
            ((System.ComponentModel.ISupportInitialize)pictureBoxDestaques).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDestaques;
        private PictureBox pictureBoxDestaques;
        private TextBox txtMensagem;
        private Label lblMensagem;
    }
}
