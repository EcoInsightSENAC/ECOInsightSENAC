namespace ECOInsight
{
    partial class Cadastro
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
            panelSuperiorCad = new Panel();
            lblCad = new Label();
            lblNomeCad = new Label();
            lblEmailCad = new Label();
            lblSenhaCad = new Label();
            lblPerfilCad = new Label();
            lblUsuarioCad = new Label();
            lblConfirSenhaCad = new Label();
            txtNomeCad = new TextBox();
            txtEmailCad = new TextBox();
            txtUsuarioCad = new TextBox();
            txtSenhaCad = new TextBox();
            txtConfirSenhaCad = new TextBox();
            txtPerfilCad = new TextBox();
            btnCancelarCad = new Button();
            btnSalvarCad = new Button();
            panelSuperiorCad.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperiorCad
            // 
            panelSuperiorCad.BackColor = Color.FromArgb(32, 65, 57);
            panelSuperiorCad.Controls.Add(lblCad);
            panelSuperiorCad.Dock = DockStyle.Top;
            panelSuperiorCad.Location = new Point(0, 0);
            panelSuperiorCad.Name = "panelSuperiorCad";
            panelSuperiorCad.Size = new Size(1064, 40);
            panelSuperiorCad.TabIndex = 1;
            // 
            // lblCad
            // 
            lblCad.AutoSize = true;
            lblCad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCad.ForeColor = SystemColors.ButtonHighlight;
            lblCad.Location = new Point(12, 9);
            lblCad.Name = "lblCad";
            lblCad.Size = new Size(112, 25);
            lblCad.TabIndex = 0;
            lblCad.Text = "CADASTRO";
            // 
            // lblNomeCad
            // 
            lblNomeCad.AutoSize = true;
            lblNomeCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeCad.Location = new Point(188, 149);
            lblNomeCad.Name = "lblNomeCad";
            lblNomeCad.Size = new Size(55, 21);
            lblNomeCad.TabIndex = 2;
            lblNomeCad.Text = "Nome";
            // 
            // lblEmailCad
            // 
            lblEmailCad.AutoSize = true;
            lblEmailCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailCad.Location = new Point(195, 221);
            lblEmailCad.Name = "lblEmailCad";
            lblEmailCad.Size = new Size(54, 21);
            lblEmailCad.TabIndex = 3;
            lblEmailCad.Text = "E-mail";
            // 
            // lblSenhaCad
            // 
            lblSenhaCad.AutoSize = true;
            lblSenhaCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenhaCad.Location = new Point(195, 302);
            lblSenhaCad.Name = "lblSenhaCad";
            lblSenhaCad.Size = new Size(54, 21);
            lblSenhaCad.TabIndex = 4;
            lblSenhaCad.Text = "Senha";
            // 
            // lblPerfilCad
            // 
            lblPerfilCad.AutoSize = true;
            lblPerfilCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerfilCad.Location = new Point(195, 385);
            lblPerfilCad.Name = "lblPerfilCad";
            lblPerfilCad.Size = new Size(47, 21);
            lblPerfilCad.TabIndex = 5;
            lblPerfilCad.Text = "Perfil";
            // 
            // lblUsuarioCad
            // 
            lblUsuarioCad.AutoSize = true;
            lblUsuarioCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioCad.Location = new Point(533, 221);
            lblUsuarioCad.Name = "lblUsuarioCad";
            lblUsuarioCad.Size = new Size(65, 21);
            lblUsuarioCad.TabIndex = 6;
            lblUsuarioCad.Text = "Usuário";
            // 
            // lblConfirSenhaCad
            // 
            lblConfirSenhaCad.AutoSize = true;
            lblConfirSenhaCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirSenhaCad.Location = new Point(533, 302);
            lblConfirSenhaCad.Name = "lblConfirSenhaCad";
            lblConfirSenhaCad.Size = new Size(131, 21);
            lblConfirSenhaCad.TabIndex = 7;
            lblConfirSenhaCad.Text = "Confirmar Senha";
            // 
            // txtNomeCad
            // 
            txtNomeCad.Location = new Point(195, 179);
            txtNomeCad.Name = "txtNomeCad";
            txtNomeCad.Size = new Size(634, 23);
            txtNomeCad.TabIndex = 8;
            // 
            // txtEmailCad
            // 
            txtEmailCad.Location = new Point(195, 260);
            txtEmailCad.Name = "txtEmailCad";
            txtEmailCad.Size = new Size(296, 23);
            txtEmailCad.TabIndex = 9;
            // 
            // txtUsuarioCad
            // 
            txtUsuarioCad.Location = new Point(533, 260);
            txtUsuarioCad.Name = "txtUsuarioCad";
            txtUsuarioCad.Size = new Size(296, 23);
            txtUsuarioCad.TabIndex = 10;
            // 
            // txtSenhaCad
            // 
            txtSenhaCad.Location = new Point(195, 341);
            txtSenhaCad.Name = "txtSenhaCad";
            txtSenhaCad.Size = new Size(296, 23);
            txtSenhaCad.TabIndex = 11;
            // 
            // txtConfirSenhaCad
            // 
            txtConfirSenhaCad.Location = new Point(533, 341);
            txtConfirSenhaCad.Name = "txtConfirSenhaCad";
            txtConfirSenhaCad.Size = new Size(296, 23);
            txtConfirSenhaCad.TabIndex = 12;
            // 
            // txtPerfilCad
            // 
            txtPerfilCad.Location = new Point(195, 424);
            txtPerfilCad.Name = "txtPerfilCad";
            txtPerfilCad.Size = new Size(296, 23);
            txtPerfilCad.TabIndex = 13;
            // 
            // btnCancelarCad
            // 
            btnCancelarCad.BackColor = Color.FromArgb(30, 66, 57);
            btnCancelarCad.FlatAppearance.BorderSize = 0;
            btnCancelarCad.FlatStyle = FlatStyle.Flat;
            btnCancelarCad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarCad.ForeColor = SystemColors.ButtonHighlight;
            btnCancelarCad.Location = new Point(577, 403);
            btnCancelarCad.Name = "btnCancelarCad";
            btnCancelarCad.Size = new Size(87, 84);
            btnCancelarCad.TabIndex = 14;
            btnCancelarCad.Text = "Cancelar";
            btnCancelarCad.TextAlign = ContentAlignment.BottomCenter;
            btnCancelarCad.UseVisualStyleBackColor = false;
            // 
            // btnSalvarCad
            // 
            btnSalvarCad.BackColor = Color.FromArgb(30, 66, 57);
            btnSalvarCad.FlatAppearance.BorderSize = 0;
            btnSalvarCad.FlatStyle = FlatStyle.Flat;
            btnSalvarCad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvarCad.ForeColor = SystemColors.ButtonHighlight;
            btnSalvarCad.Location = new Point(703, 403);
            btnSalvarCad.Name = "btnSalvarCad";
            btnSalvarCad.Size = new Size(87, 84);
            btnSalvarCad.TabIndex = 15;
            btnSalvarCad.Text = "Salvar";
            btnSalvarCad.TextAlign = ContentAlignment.BottomCenter;
            btnSalvarCad.UseVisualStyleBackColor = false;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 633);
            Controls.Add(btnSalvarCad);
            Controls.Add(btnCancelarCad);
            Controls.Add(txtPerfilCad);
            Controls.Add(txtConfirSenhaCad);
            Controls.Add(txtSenhaCad);
            Controls.Add(txtUsuarioCad);
            Controls.Add(txtEmailCad);
            Controls.Add(txtNomeCad);
            Controls.Add(lblConfirSenhaCad);
            Controls.Add(lblUsuarioCad);
            Controls.Add(lblPerfilCad);
            Controls.Add(lblSenhaCad);
            Controls.Add(lblEmailCad);
            Controls.Add(lblNomeCad);
            Controls.Add(panelSuperiorCad);
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            panelSuperiorCad.ResumeLayout(false);
            panelSuperiorCad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSuperiorCad;
        private Label lblCad;
        private Label lblNomeCad;
        private Label lblEmailCad;
        private Label lblSenhaCad;
        private Label lblPerfilCad;
        private Label lblUsuarioCad;
        private Label lblConfirSenhaCad;
        private TextBox txtNomeCad;
        private TextBox txtEmailCad;
        private TextBox txtUsuarioCad;
        private TextBox txtSenhaCad;
        private TextBox txtConfirSenhaCad;
        private TextBox txtPerfilCad;
        private Button btnCancelarCad;
        private Button btnSalvarCad;
    }
}