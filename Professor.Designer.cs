namespace ECOInsight
{
    partial class ProfessorTela
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
            panelEsquedo = new Panel();
            btnSairProfessor = new Button();
            btnProfessor = new Button();
            btnAluno = new Button();
            btnGestor = new Button();
            btnDestaques = new Button();
            panel1 = new Panel();
            panelSuperiorProfessor = new Panel();
            lblAluno = new Label();
            panelEsquedo.SuspendLayout();
            panelSuperiorProfessor.SuspendLayout();
            SuspendLayout();
            // 
            // panelEsquedo
            // 
            panelEsquedo.BackColor = Color.FromArgb(153, 179, 142);
            panelEsquedo.Controls.Add(btnSairProfessor);
            panelEsquedo.Controls.Add(btnProfessor);
            panelEsquedo.Controls.Add(btnAluno);
            panelEsquedo.Controls.Add(btnGestor);
            panelEsquedo.Controls.Add(btnDestaques);
            panelEsquedo.Controls.Add(panel1);
            panelEsquedo.Dock = DockStyle.Left;
            panelEsquedo.Location = new Point(0, 40);
            panelEsquedo.Name = "panelEsquedo";
            panelEsquedo.Size = new Size(161, 593);
            panelEsquedo.TabIndex = 14;
            // 
            // btnSairProfessor
            // 
            btnSairProfessor.Anchor = AnchorStyles.Bottom;
            btnSairProfessor.FlatAppearance.BorderSize = 0;
            btnSairProfessor.FlatStyle = FlatStyle.Flat;
            btnSairProfessor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSairProfessor.ForeColor = SystemColors.ActiveCaptionText;
            btnSairProfessor.Location = new Point(0, 524);
            btnSairProfessor.Name = "btnSairProfessor";
            btnSairProfessor.Size = new Size(161, 57);
            btnSairProfessor.TabIndex = 4;
            btnSairProfessor.Text = "SAIR";
            btnSairProfessor.UseVisualStyleBackColor = true;
            btnSairProfessor.Click += btnSairProfessor_Click;
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
            btnDestaques.Click += btnDestaques_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 520);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 70);
            panel1.TabIndex = 16;
            // 
            // panelSuperiorProfessor
            // 
            panelSuperiorProfessor.BackColor = Color.FromArgb(36, 65, 57);
            panelSuperiorProfessor.Controls.Add(lblAluno);
            panelSuperiorProfessor.Dock = DockStyle.Top;
            panelSuperiorProfessor.Location = new Point(0, 0);
            panelSuperiorProfessor.Name = "panelSuperiorProfessor";
            panelSuperiorProfessor.Size = new Size(1064, 40);
            panelSuperiorProfessor.TabIndex = 13;
            // 
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.FlatStyle = FlatStyle.Flat;
            lblAluno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAluno.ForeColor = SystemColors.ButtonHighlight;
            lblAluno.Location = new Point(12, 9);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(118, 25);
            lblAluno.TabIndex = 0;
            lblAluno.Text = "PROFESSOR";
            // 
            // ProfessorTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 633);
            Controls.Add(panelEsquedo);
            Controls.Add(panelSuperiorProfessor);
            Name = "ProfessorTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Professor";
            Load += Professor_Load;
            panelEsquedo.ResumeLayout(false);
            panelSuperiorProfessor.ResumeLayout(false);
            panelSuperiorProfessor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEsquedo;
        private Button btnSairProfessor;
        private Button btnProfessor;
        private Button btnAluno;
        private Button btnGestor;
        private Button btnDestaques;
        private Panel panelSuperiorProfessor;
        private Label lblAluno;
        private Panel panel1;
    }
}