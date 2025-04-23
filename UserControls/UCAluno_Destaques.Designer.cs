namespace ECOInsight.UserControls
{
    partial class UCAluno_Destaques
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
            panel1 = new Panel();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            btnVoltarPagEsqueciSenha = new FontAwesome.Sharp.IconButton();
            lblFuncionarioHome = new Label();
            lblMensagem = new Label();
            txtMensagem = new TextBox();
            pictureBoxDestaques = new PictureBox();
            lblDestaques = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDestaques).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(iconButton8);
            panel1.Controls.Add(btnVoltarPagEsqueciSenha);
            panel1.Controls.Add(lblFuncionarioHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 39);
            panel1.TabIndex = 62;
            // 
            // iconButton8
            // 
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            iconButton8.IconColor = Color.Black;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 25;
            iconButton8.Location = new Point(48, 2);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(39, 34);
            iconButton8.TabIndex = 72;
            iconButton8.UseVisualStyleBackColor = true;
            // 
            // btnVoltarPagEsqueciSenha
            // 
            btnVoltarPagEsqueciSenha.FlatAppearance.BorderSize = 0;
            btnVoltarPagEsqueciSenha.FlatStyle = FlatStyle.Flat;
            btnVoltarPagEsqueciSenha.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            btnVoltarPagEsqueciSenha.IconColor = Color.Black;
            btnVoltarPagEsqueciSenha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVoltarPagEsqueciSenha.IconSize = 25;
            btnVoltarPagEsqueciSenha.Location = new Point(3, 3);
            btnVoltarPagEsqueciSenha.Name = "btnVoltarPagEsqueciSenha";
            btnVoltarPagEsqueciSenha.Size = new Size(39, 34);
            btnVoltarPagEsqueciSenha.TabIndex = 71;
            btnVoltarPagEsqueciSenha.UseVisualStyleBackColor = true;
            // 
            // lblFuncionarioHome
            // 
            lblFuncionarioHome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFuncionarioHome.AutoSize = true;
            lblFuncionarioHome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuncionarioHome.ForeColor = Color.Black;
            lblFuncionarioHome.Location = new Point(455, 7);
            lblFuncionarioHome.Name = "lblFuncionarioHome";
            lblFuncionarioHome.Size = new Size(69, 25);
            lblFuncionarioHome.TabIndex = 68;
            lblFuncionarioHome.Text = "HOME";
            // 
            // lblMensagem
            // 
            lblMensagem.Anchor = AnchorStyles.Top;
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagem.Location = new Point(52, 395);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(162, 37);
            lblMensagem.TabIndex = 66;
            lblMensagem.Text = "Mensagem";
            // 
            // txtMensagem
            // 
            txtMensagem.Anchor = AnchorStyles.Top;
            txtMensagem.Location = new Point(52, 448);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(874, 146);
            txtMensagem.TabIndex = 65;
            // 
            // pictureBoxDestaques
            // 
            pictureBoxDestaques.Anchor = AnchorStyles.Top;
            pictureBoxDestaques.BackColor = SystemColors.ControlLight;
            pictureBoxDestaques.Location = new Point(52, 106);
            pictureBoxDestaques.Name = "pictureBoxDestaques";
            pictureBoxDestaques.Size = new Size(874, 237);
            pictureBoxDestaques.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDestaques.TabIndex = 64;
            pictureBoxDestaques.TabStop = false;
            // 
            // lblDestaques
            // 
            lblDestaques.Anchor = AnchorStyles.Top;
            lblDestaques.AutoSize = true;
            lblDestaques.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestaques.Location = new Point(52, 53);
            lblDestaques.Name = "lblDestaques";
            lblDestaques.Size = new Size(163, 37);
            lblDestaques.TabIndex = 63;
            lblDestaques.Text = "Destaques!";
            // 
            // UCAluno_Destaques
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblMensagem);
            Controls.Add(txtMensagem);
            Controls.Add(pictureBoxDestaques);
            Controls.Add(lblDestaques);
            Controls.Add(panel1);
            Name = "UCAluno_Destaques";
            RightToLeft = RightToLeft.No;
            Size = new Size(978, 646);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDestaques).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label lblMensagem;
        private TextBox txtMensagem;
        private PictureBox pictureBoxDestaques;
        private Label lblDestaques;
        private Label lblFuncionarioHome;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton btnVoltarPagEsqueciSenha;
    }
}
