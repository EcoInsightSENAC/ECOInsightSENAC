namespace ECOInsight
{
    partial class Gestor
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
            btnSair = new Button();
            btnProfessor = new Button();
            btnAluno = new Button();
            btnGestor = new Button();
            btnDestaquesGestor = new Button();
            panelSuperiorGestor = new Panel();
            lblGestor = new Label();
            panelEsquedo.SuspendLayout();
            panelSuperiorGestor.SuspendLayout();
            SuspendLayout();
            // 
            // panelEsquedo
            // 
            panelEsquedo.BackColor = Color.FromArgb(153, 179, 142);
            panelEsquedo.Controls.Add(btnSair);
            panelEsquedo.Controls.Add(btnProfessor);
            panelEsquedo.Controls.Add(btnAluno);
            panelEsquedo.Controls.Add(btnGestor);
            panelEsquedo.Controls.Add(btnDestaquesGestor);
            panelEsquedo.Dock = DockStyle.Left;
            panelEsquedo.Location = new Point(0, 40);
            panelEsquedo.Name = "panelEsquedo";
            panelEsquedo.Size = new Size(161, 593);
            panelEsquedo.TabIndex = 10;
            // 
            // btnSair
            // 
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = SystemColors.ActiveCaptionText;
            btnSair.Location = new Point(0, 524);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(161, 57);
            btnSair.TabIndex = 4;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
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
            // 
            // btnDestaquesGestor
            // 
            btnDestaquesGestor.FlatAppearance.BorderSize = 0;
            btnDestaquesGestor.FlatStyle = FlatStyle.Flat;
            btnDestaquesGestor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDestaquesGestor.ForeColor = SystemColors.ActiveCaptionText;
            btnDestaquesGestor.Location = new Point(0, 0);
            btnDestaquesGestor.Name = "btnDestaquesGestor";
            btnDestaquesGestor.Size = new Size(161, 57);
            btnDestaquesGestor.TabIndex = 0;
            btnDestaquesGestor.Text = "Destaques";
            btnDestaquesGestor.TextAlign = ContentAlignment.MiddleRight;
            btnDestaquesGestor.UseVisualStyleBackColor = true;
            // 
            // panelSuperiorGestor
            // 
            panelSuperiorGestor.BackColor = Color.FromArgb(36, 65, 57);
            panelSuperiorGestor.Controls.Add(lblGestor);
            panelSuperiorGestor.Dock = DockStyle.Top;
            panelSuperiorGestor.Location = new Point(0, 0);
            panelSuperiorGestor.Name = "panelSuperiorGestor";
            panelSuperiorGestor.Size = new Size(1064, 40);
            panelSuperiorGestor.TabIndex = 9;
            // 
            // lblGestor
            // 
            lblGestor.AutoSize = true;
            lblGestor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestor.ForeColor = SystemColors.ButtonHighlight;
            lblGestor.Location = new Point(12, 9);
            lblGestor.Name = "lblGestor";
            lblGestor.Size = new Size(83, 25);
            lblGestor.TabIndex = 0;
            lblGestor.Text = "GESTOR";
            // 
            // Gestor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 633);
            Controls.Add(panelEsquedo);
            Controls.Add(panelSuperiorGestor);
            Name = "Gestor";
            Text = "Gestor";
            panelEsquedo.ResumeLayout(false);
            panelSuperiorGestor.ResumeLayout(false);
            panelSuperiorGestor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEsquedo;
        private Button btnSair;
        private Button btnProfessor;
        private Button btnAluno;
        private Button btnGestor;
        private Button btnDestaquesGestor;
        private Panel panelSuperiorGestor;
        private Label lblGestor;
    }
}