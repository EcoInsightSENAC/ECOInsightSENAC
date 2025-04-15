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
            panelEsquerdo = new Panel();
            btnDestaques = new FontAwesome.Sharp.IconButton();
            btnAluno = new FontAwesome.Sharp.IconButton();
            btnProfessor = new FontAwesome.Sharp.IconButton();
            btnGestor = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnSair = new FontAwesome.Sharp.IconButton();
            panelSuperiorProfessor = new Panel();
            iconMinim = new FontAwesome.Sharp.IconButton();
            lblAluno = new Label();
            iconMax = new FontAwesome.Sharp.IconButton();
            iconX = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panelEsquerdo.SuspendLayout();
            panel1.SuspendLayout();
            panelSuperiorProfessor.SuspendLayout();
            SuspendLayout();
            // 
            // panelEsquerdo
            // 
            panelEsquerdo.BackColor = Color.FromArgb(153, 179, 142);
            panelEsquerdo.Controls.Add(btnDestaques);
            panelEsquerdo.Controls.Add(btnAluno);
            panelEsquerdo.Controls.Add(btnProfessor);
            panelEsquerdo.Controls.Add(btnGestor);
            panelEsquerdo.Controls.Add(panel1);
            panelEsquerdo.Dock = DockStyle.Left;
            panelEsquerdo.Location = new Point(0, 40);
            panelEsquerdo.Name = "panelEsquerdo";
            panelEsquerdo.Size = new Size(161, 593);
            panelEsquerdo.TabIndex = 14;
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
            btnDestaques.TabIndex = 23;
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
            btnAluno.TabIndex = 22;
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
            btnProfessor.TabIndex = 21;
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
            btnGestor.TabIndex = 20;
            btnGestor.Text = "Gestor";
            btnGestor.UseVisualStyleBackColor = true;
            btnGestor.Click += btnGestor_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom;
            panel1.Controls.Add(btnSair);
            panel1.Location = new Point(3, 520);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 70);
            panel1.TabIndex = 16;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Left;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnSair.IconColor = Color.Black;
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(3, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(155, 70);
            btnSair.TabIndex = 11;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // panelSuperiorProfessor
            // 
            panelSuperiorProfessor.BackColor = Color.FromArgb(36, 65, 57);
            panelSuperiorProfessor.Controls.Add(iconMinim);
            panelSuperiorProfessor.Controls.Add(lblAluno);
            panelSuperiorProfessor.Controls.Add(iconMax);
            panelSuperiorProfessor.Controls.Add(iconX);
            panelSuperiorProfessor.Controls.Add(panel2);
            panelSuperiorProfessor.Dock = DockStyle.Top;
            panelSuperiorProfessor.Location = new Point(0, 0);
            panelSuperiorProfessor.Name = "panelSuperiorProfessor";
            panelSuperiorProfessor.Size = new Size(1064, 40);
            panelSuperiorProfessor.TabIndex = 13;
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
            iconMinim.Location = new Point(922, 3);
            iconMinim.Name = "iconMinim";
            iconMinim.Size = new Size(39, 37);
            iconMinim.TabIndex = 18;
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
            lblAluno.Size = new Size(118, 25);
            lblAluno.TabIndex = 0;
            lblAluno.Text = "PROFESSOR";
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
            iconMax.Location = new Point(967, 3);
            iconMax.Name = "iconMax";
            iconMax.Size = new Size(39, 37);
            iconMax.TabIndex = 17;
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
            iconX.Location = new Point(1012, 3);
            iconX.Name = "iconX";
            iconX.Size = new Size(39, 37);
            iconX.TabIndex = 15;
            iconX.UseVisualStyleBackColor = true;
            iconX.Click += iconX_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Location = new Point(915, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 40);
            panel2.TabIndex = 16;
            // 
            // ProfessorTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 633);
            Controls.Add(panelEsquerdo);
            Controls.Add(panelSuperiorProfessor);
            Name = "ProfessorTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Professor";
            Load += Professor_Load;
            panelEsquerdo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelSuperiorProfessor.ResumeLayout(false);
            panelSuperiorProfessor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEsquerdo;
        private Panel panelSuperiorProfessor;
        private Label lblAluno;
        private Panel panel1;
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