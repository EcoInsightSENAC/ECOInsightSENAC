namespace ECOInsight
{
    partial class Esqueci_a_Senha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtConfirSenha = new TextBox();
            txtNovaSenha = new TextBox();
            txtEmail = new TextBox();
            lblConfirSenha = new Label();
            lblNovaSenha = new Label();
            lblEmail = new Label();
            btnRecuperar = new Button();
            panelSuperiorEsqueciaSenha = new Panel();
            lblEsqueciSenha = new Label();
            panelSuperiorEsqueciaSenha.SuspendLayout();
            SuspendLayout();
            // 
            // txtConfirSenha
            // 
            txtConfirSenha.Location = new Point(554, 324);
            txtConfirSenha.Margin = new Padding(4);
            txtConfirSenha.Name = "txtConfirSenha";
            txtConfirSenha.Size = new Size(367, 29);
            txtConfirSenha.TabIndex = 16;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(141, 324);
            txtNovaSenha.Margin = new Padding(4);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(367, 29);
            txtNovaSenha.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(141, 211);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(780, 29);
            txtEmail.TabIndex = 14;
            // 
            // lblConfirSenha
            // 
            lblConfirSenha.AutoSize = true;
            lblConfirSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirSenha.Location = new Point(554, 282);
            lblConfirSenha.Margin = new Padding(4, 0, 4, 0);
            lblConfirSenha.Name = "lblConfirSenha";
            lblConfirSenha.Size = new Size(131, 21);
            lblConfirSenha.TabIndex = 13;
            lblConfirSenha.Text = "Confirmar Senha";
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNovaSenha.Location = new Point(141, 282);
            lblNovaSenha.Margin = new Padding(4, 0, 4, 0);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(96, 21);
            lblNovaSenha.TabIndex = 12;
            lblNovaSenha.Text = "Nova Senha";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(141, 167);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 21);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "E-mail";
            // 
            // btnRecuperar
            // 
            btnRecuperar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRecuperar.BackColor = Color.FromArgb(30, 66, 57);
            btnRecuperar.FlatAppearance.BorderSize = 0;
            btnRecuperar.FlatStyle = FlatStyle.Flat;
            btnRecuperar.ForeColor = SystemColors.ButtonHighlight;
            btnRecuperar.Location = new Point(457, 430);
            btnRecuperar.Margin = new Padding(4);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Size = new Size(122, 41);
            btnRecuperar.TabIndex = 17;
            btnRecuperar.Text = "RECUPERAR";
            btnRecuperar.UseVisualStyleBackColor = false;
            // 
            // panelSuperiorEsqueciaSenha
            // 
            panelSuperiorEsqueciaSenha.BackColor = Color.FromArgb(32, 65, 57);
            panelSuperiorEsqueciaSenha.Controls.Add(lblEsqueciSenha);
            panelSuperiorEsqueciaSenha.Dock = DockStyle.Top;
            panelSuperiorEsqueciaSenha.Location = new Point(0, 0);
            panelSuperiorEsqueciaSenha.Name = "panelSuperiorEsqueciaSenha";
            panelSuperiorEsqueciaSenha.Size = new Size(1064, 40);
            panelSuperiorEsqueciaSenha.TabIndex = 18;
            // 
            // lblEsqueciSenha
            // 
            lblEsqueciSenha.AutoSize = true;
            lblEsqueciSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEsqueciSenha.ForeColor = SystemColors.ButtonHighlight;
            lblEsqueciSenha.Location = new Point(12, 9);
            lblEsqueciSenha.Name = "lblEsqueciSenha";
            lblEsqueciSenha.Size = new Size(176, 25);
            lblEsqueciSenha.TabIndex = 0;
            lblEsqueciSenha.Text = "ESQUECI A SENHA";
            // 
            // Esqueci_a_Senha
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 633);
            Controls.Add(panelSuperiorEsqueciaSenha);
            Controls.Add(btnRecuperar);
            Controls.Add(txtConfirSenha);
            Controls.Add(txtNovaSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblConfirSenha);
            Controls.Add(lblNovaSenha);
            Controls.Add(lblEmail);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Esqueci_a_Senha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Esqueci_a_Senha";
            panelSuperiorEsqueciaSenha.ResumeLayout(false);
            panelSuperiorEsqueciaSenha.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtConfirSenha;
        private TextBox txtNovaSenha;
        private TextBox txtEmail;
        private Label lblConfirSenha;
        private Label lblNovaSenha;
        private Label lblEmail;
        private Button btnRecuperar;
        private Panel panelSuperiorEsqueciaSenha;
        private Label lblEsqueciSenha;
    }
}