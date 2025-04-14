namespace ECOInsight
{
    partial class AlunoTela
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
            panelEsquerdo = new Panel();
            btnDestaques = new FontAwesome.Sharp.IconButton();
            btnAluno = new FontAwesome.Sharp.IconButton();
            btnProfessor = new FontAwesome.Sharp.IconButton();
            btnGestor = new FontAwesome.Sharp.IconButton();
            panelSairAluno = new Panel();
            btnSair = new FontAwesome.Sharp.IconButton();
            panelSuperiorAluno = new Panel();
            iconMinim = new FontAwesome.Sharp.IconButton();
            lblAluno = new Label();
            iconMax = new FontAwesome.Sharp.IconButton();
            iconX = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panelEsquerdo.SuspendLayout();
            panelSairAluno.SuspendLayout();
            panelSuperiorAluno.SuspendLayout();
            SuspendLayout();
            // 
            // panelEsquerdo
            // 
            panelEsquerdo.BackColor = Color.FromArgb(153, 179, 142);
            panelEsquerdo.Controls.Add(btnDestaques);
            panelEsquerdo.Controls.Add(btnAluno);
            panelEsquerdo.Controls.Add(btnProfessor);
            panelEsquerdo.Controls.Add(btnGestor);
            panelEsquerdo.Controls.Add(panelSairAluno);
            panelEsquerdo.Dock = DockStyle.Left;
            panelEsquerdo.Location = new Point(0, 40);
            panelEsquerdo.Name = "panelEsquerdo";
            panelEsquerdo.Size = new Size(161, 593);
            panelEsquerdo.TabIndex = 12;
            // 
            // btnDestaques
            // 
            btnDestaques.FlatAppearance.BorderSize = 0;
            btnDestaques.FlatStyle = FlatStyle.Flat;
            btnDestaques.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDestaques.IconChar = FontAwesome.Sharp.IconChar.Bullhorn;
            btnDestaques.IconColor = Color.Black;
            btnDestaques.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDestaques.IconSize = 40;
            btnDestaques.ImageAlign = ContentAlignment.MiddleLeft;
            btnDestaques.Location = new Point(0, 0);
            btnDestaques.Name = "btnDestaques";
            btnDestaques.Size = new Size(161, 72);
            btnDestaques.TabIndex = 27;
            btnDestaques.Text = "      Destaques";
            btnDestaques.UseVisualStyleBackColor = true;
            btnDestaques.Click += btnDestaques_Click;
            // 
            // btnAluno
            // 
            btnAluno.FlatAppearance.BorderSize = 0;
            btnAluno.FlatStyle = FlatStyle.Flat;
            btnAluno.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAluno.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            btnAluno.IconColor = Color.Black;
            btnAluno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAluno.IconSize = 40;
            btnAluno.ImageAlign = ContentAlignment.MiddleLeft;
            btnAluno.Location = new Point(0, 234);
            btnAluno.Name = "btnAluno";
            btnAluno.Size = new Size(161, 72);
            btnAluno.TabIndex = 26;
            btnAluno.Text = "Aluno";
            btnAluno.UseVisualStyleBackColor = true;
            btnAluno.Click += btnAluno_Click;
            // 
            // btnProfessor
            // 
            btnProfessor.FlatAppearance.BorderSize = 0;
            btnProfessor.FlatStyle = FlatStyle.Flat;
            btnProfessor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfessor.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            btnProfessor.IconColor = Color.Black;
            btnProfessor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProfessor.IconSize = 40;
            btnProfessor.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfessor.Location = new Point(0, 156);
            btnProfessor.Name = "btnProfessor";
            btnProfessor.Size = new Size(161, 72);
            btnProfessor.TabIndex = 25;
            btnProfessor.Text = "    Professor";
            btnProfessor.UseVisualStyleBackColor = true;
            btnProfessor.Click += btnProfessor_Click;
            // 
            // btnGestor
            // 
            btnGestor.FlatAppearance.BorderSize = 0;
            btnGestor.FlatStyle = FlatStyle.Flat;
            btnGestor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestor.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            btnGestor.IconColor = Color.Black;
            btnGestor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGestor.IconSize = 40;
            btnGestor.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestor.Location = new Point(0, 78);
            btnGestor.Name = "btnGestor";
            btnGestor.Size = new Size(161, 72);
            btnGestor.TabIndex = 24;
            btnGestor.Text = "Gestor";
            btnGestor.UseVisualStyleBackColor = true;
            btnGestor.Click += btnGestor_Click;
            // 
            // panelSairAluno
            // 
            panelSairAluno.Anchor = AnchorStyles.Bottom;
            panelSairAluno.Controls.Add(btnSair);
            panelSairAluno.Location = new Point(0, 524);
            panelSairAluno.Name = "panelSairAluno";
            panelSairAluno.Size = new Size(161, 70);
            panelSairAluno.TabIndex = 16;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnSair.IconColor = Color.Black;
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(0, -1);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(161, 70);
            btnSair.TabIndex = 9;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // panelSuperiorAluno
            // 
            panelSuperiorAluno.BackColor = Color.FromArgb(36, 65, 57);
            panelSuperiorAluno.Controls.Add(iconMinim);
            panelSuperiorAluno.Controls.Add(lblAluno);
            panelSuperiorAluno.Controls.Add(iconMax);
            panelSuperiorAluno.Controls.Add(iconX);
            panelSuperiorAluno.Controls.Add(panel2);
            panelSuperiorAluno.Dock = DockStyle.Top;
            panelSuperiorAluno.Location = new Point(0, 0);
            panelSuperiorAluno.Name = "panelSuperiorAluno";
            panelSuperiorAluno.Size = new Size(1064, 40);
            panelSuperiorAluno.TabIndex = 11;
            // 
            // iconMinim
            // 
            iconMinim.Anchor = AnchorStyles.Right;
            iconMinim.FlatAppearance.BorderSize = 0;
            iconMinim.FlatStyle = FlatStyle.Flat;
            iconMinim.ForeColor = Color.Transparent;
            iconMinim.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            iconMinim.IconColor = Color.White;
            iconMinim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMinim.IconSize = 20;
            iconMinim.Location = new Point(923, 3);
            iconMinim.Name = "iconMinim";
            iconMinim.Size = new Size(39, 37);
            iconMinim.TabIndex = 16;
            iconMinim.UseVisualStyleBackColor = true;
            iconMinim.Click += iconMinim_Click;
            // 
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.FlatStyle = FlatStyle.Flat;
            lblAluno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAluno.ForeColor = SystemColors.ButtonHighlight;
            lblAluno.Location = new Point(12, 9);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(78, 25);
            lblAluno.TabIndex = 0;
            lblAluno.Text = "ALUNO";
            // 
            // iconMax
            // 
            iconMax.Anchor = AnchorStyles.Right;
            iconMax.FlatAppearance.BorderSize = 0;
            iconMax.FlatStyle = FlatStyle.Flat;
            iconMax.ForeColor = Color.Transparent;
            iconMax.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            iconMax.IconColor = Color.White;
            iconMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMax.IconSize = 20;
            iconMax.Location = new Point(968, 3);
            iconMax.Name = "iconMax";
            iconMax.Size = new Size(39, 37);
            iconMax.TabIndex = 15;
            iconMax.UseVisualStyleBackColor = true;
            iconMax.Click += iconMax_Click;
            // 
            // iconX
            // 
            iconX.Anchor = AnchorStyles.Right;
            iconX.FlatAppearance.BorderSize = 0;
            iconX.FlatStyle = FlatStyle.Flat;
            iconX.ForeColor = Color.Transparent;
            iconX.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconX.IconColor = Color.White;
            iconX.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconX.IconSize = 20;
            iconX.Location = new Point(1013, 3);
            iconX.Name = "iconX";
            iconX.Size = new Size(39, 37);
            iconX.TabIndex = 13;
            iconX.UseVisualStyleBackColor = true;
            iconX.Click += iconX_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Location = new Point(916, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 40);
            panel2.TabIndex = 14;
            // 
            // AlunoTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 633);
            Controls.Add(panelEsquerdo);
            Controls.Add(panelSuperiorAluno);
            Name = "AlunoTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aluno";
            panelEsquerdo.ResumeLayout(false);
            panelSairAluno.ResumeLayout(false);
            panelSuperiorAluno.ResumeLayout(false);
            panelSuperiorAluno.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEsquerdo;
        private Panel panelSuperiorAluno;
        private Label lblAluno;
        private Panel panelSairAluno;
        private FontAwesome.Sharp.IconButton iconMinim;
        private FontAwesome.Sharp.IconButton iconMax;
        private FontAwesome.Sharp.IconButton iconX;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnDestaques;
        private FontAwesome.Sharp.IconButton btnAluno;
        private FontAwesome.Sharp.IconButton btnProfessor;
        private FontAwesome.Sharp.IconButton btnGestor;
    }
}