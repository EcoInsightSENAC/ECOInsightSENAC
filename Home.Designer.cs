namespace ECOInsight
{
    partial class HomeTela
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
            lblDestaques = new Label();
            panelSuperiorLogin = new Panel();
            lblLogin = new Label();
            panelEsquedo = new Panel();
            btnSairHome = new Button();
            btnProfessor = new Button();
            btnAluno = new Button();
            btnGestor = new Button();
            btnDestaques = new Button();
            panel1 = new Panel();
            panelSuperiorLogin.SuspendLayout();
            panelEsquedo.SuspendLayout();
            SuspendLayout();
            // 
            // lblDestaques
            // 
            lblDestaques.AutoSize = true;
            lblDestaques.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestaques.Location = new Point(188, 72);
            lblDestaques.Name = "lblDestaques";
            lblDestaques.Size = new Size(103, 25);
            lblDestaques.TabIndex = 5;
            lblDestaques.Text = "Destaques";
            lblDestaques.Click += label1_Click;
            // 
            // panelSuperiorLogin
            // 
            panelSuperiorLogin.BackColor = Color.FromArgb(36, 65, 57);
            panelSuperiorLogin.Controls.Add(lblLogin);
            panelSuperiorLogin.Dock = DockStyle.Top;
            panelSuperiorLogin.Location = new Point(0, 0);
            panelSuperiorLogin.Name = "panelSuperiorLogin";
            panelSuperiorLogin.Size = new Size(1064, 40);
            panelSuperiorLogin.TabIndex = 6;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = SystemColors.ButtonHighlight;
            lblLogin.Location = new Point(12, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(69, 25);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "HOME";
            // 
            // panelEsquedo
            // 
            panelEsquedo.BackColor = Color.FromArgb(153, 179, 142);
            panelEsquedo.Controls.Add(btnSairHome);
            panelEsquedo.Controls.Add(btnProfessor);
            panelEsquedo.Controls.Add(btnAluno);
            panelEsquedo.Controls.Add(btnGestor);
            panelEsquedo.Controls.Add(btnDestaques);
            panelEsquedo.Controls.Add(panel1);
            panelEsquedo.Dock = DockStyle.Left;
            panelEsquedo.Location = new Point(0, 40);
            panelEsquedo.Name = "panelEsquedo";
            panelEsquedo.Size = new Size(161, 593);
            panelEsquedo.TabIndex = 7;
            // 
            // btnSairHome
            // 
            btnSairHome.Anchor = AnchorStyles.Bottom;
            btnSairHome.FlatAppearance.BorderSize = 0;
            btnSairHome.FlatStyle = FlatStyle.Flat;
            btnSairHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSairHome.ForeColor = SystemColors.ActiveCaptionText;
            btnSairHome.Location = new Point(0, 524);
            btnSairHome.Name = "btnSairHome";
            btnSairHome.Size = new Size(161, 57);
            btnSairHome.TabIndex = 4;
            btnSairHome.Text = "SAIR";
            btnSairHome.UseVisualStyleBackColor = true;
            btnSairHome.Click += btnSair_Click;
            // 
            // btnProfessor
            // 
            btnProfessor.FlatAppearance.BorderSize = 0;
            btnProfessor.FlatStyle = FlatStyle.Flat;
            btnProfessor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfessor.ForeColor = SystemColors.ActiveCaptionText;
            btnProfessor.Location = new Point(0, 189);
            btnProfessor.Name = "btnProfessor";
            btnProfessor.Size = new Size(161, 57);
            btnProfessor.TabIndex = 3;
            btnProfessor.Text = "Professor  ";
            btnProfessor.TextAlign = ContentAlignment.MiddleRight;
            btnProfessor.UseVisualStyleBackColor = true;
            btnProfessor.Click += btnProfessor_Click;
            // 
            // btnAluno
            // 
            btnAluno.FlatAppearance.BorderSize = 0;
            btnAluno.FlatStyle = FlatStyle.Flat;
            btnAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAluno.ForeColor = SystemColors.ActiveCaptionText;
            btnAluno.Location = new Point(0, 126);
            btnAluno.Name = "btnAluno";
            btnAluno.Size = new Size(161, 57);
            btnAluno.TabIndex = 2;
            btnAluno.Text = "Aluno        ";
            btnAluno.TextAlign = ContentAlignment.MiddleRight;
            btnAluno.UseVisualStyleBackColor = true;
            btnAluno.Click += btnAluno_Click;
            // 
            // btnGestor
            // 
            btnGestor.FlatAppearance.BorderSize = 0;
            btnGestor.FlatStyle = FlatStyle.Flat;
            btnGestor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestor.ForeColor = SystemColors.ActiveCaptionText;
            btnGestor.Location = new Point(0, 63);
            btnGestor.Name = "btnGestor";
            btnGestor.Size = new Size(161, 57);
            btnGestor.TabIndex = 1;
            btnGestor.Text = "Gestor       ";
            btnGestor.TextAlign = ContentAlignment.MiddleRight;
            btnGestor.UseVisualStyleBackColor = true;
            btnGestor.Click += btnGestor_Click;
            // 
            // btnDestaques
            // 
            btnDestaques.FlatAppearance.BorderSize = 0;
            btnDestaques.FlatStyle = FlatStyle.Flat;
            btnDestaques.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDestaques.ForeColor = SystemColors.ActiveCaptionText;
            btnDestaques.Location = new Point(0, 0);
            btnDestaques.Name = "btnDestaques";
            btnDestaques.Size = new Size(161, 57);
            btnDestaques.TabIndex = 0;
            btnDestaques.Text = "Destaques";
            btnDestaques.TextAlign = ContentAlignment.MiddleRight;
            btnDestaques.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 520);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 70);
            panel1.TabIndex = 15;
            // 
            // HomeTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 633);
            Controls.Add(panelEsquedo);
            Controls.Add(panelSuperiorLogin);
            Controls.Add(lblDestaques);
            Name = "HomeTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += HomeTela_Load;
            panelSuperiorLogin.ResumeLayout(false);
            panelSuperiorLogin.PerformLayout();
            panelEsquedo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDestaques;
        private Panel panelSuperiorLogin;
        private Label lblLogin;
        private Panel panelEsquedo;
        private Button btnGestor;
        private Button btnDestaques;
        private Button btnSairHome;
        private Button btnProfessor;
        private Button btnAluno;
        private Panel panel1;
    }
}