namespace ECOInsight
{
    partial class AdmTela
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
            btnAdm = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnSair = new FontAwesome.Sharp.IconButton();
            panelSuperiorAdm = new Panel();
            iconMinim = new FontAwesome.Sharp.IconButton();
            iconMax = new FontAwesome.Sharp.IconButton();
            iconX = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            lblAdm = new Label();
            panelEsquerdo.SuspendLayout();
            panel1.SuspendLayout();
            panelSuperiorAdm.SuspendLayout();
            SuspendLayout();
            // 
            // panelEsquerdo
            // 
            panelEsquerdo.BackColor = Color.FromArgb(153, 179, 142);
            panelEsquerdo.Controls.Add(btnDestaques);
            panelEsquerdo.Controls.Add(btnAluno);
            panelEsquerdo.Controls.Add(btnProfessor);
            panelEsquerdo.Controls.Add(btnAdm);
            panelEsquerdo.Controls.Add(panel1);
            panelEsquerdo.Dock = DockStyle.Left;
            panelEsquerdo.Location = new Point(0, 40);
            panelEsquerdo.Name = "panelEsquerdo";
            panelEsquerdo.Size = new Size(161, 593);
            panelEsquerdo.TabIndex = 10;
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
            btnDestaques.Location = new Point(0, 3);
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
            btnAluno.Location = new Point(0, 237);
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
            btnProfessor.Location = new Point(0, 159);
            btnProfessor.Name = "btnProfessor";
            btnProfessor.Size = new Size(161, 72);
            btnProfessor.TabIndex = 21;
            btnProfessor.Text = "    Professor";
            btnProfessor.UseVisualStyleBackColor = true;
            btnProfessor.Click += btnProfessor_Click;
            // 
            // btnAdm
            // 
            btnAdm.FlatAppearance.BorderSize = 0;
            btnAdm.FlatStyle = FlatStyle.Flat;
            btnAdm.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdm.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            btnAdm.IconColor = Color.Black;
            btnAdm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdm.IconSize = 40;
            btnAdm.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdm.Location = new Point(0, 81);
            btnAdm.Name = "btnAdm";
            btnAdm.Size = new Size(161, 72);
            btnAdm.TabIndex = 20;
            btnAdm.Text = "          Administrador";
            btnAdm.UseVisualStyleBackColor = true;
            btnAdm.Click += btnGestor_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom;
            panel1.Controls.Add(btnSair);
            panel1.Location = new Point(0, 524);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 70);
            panel1.TabIndex = 14;
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
            btnSair.TabIndex = 10;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // panelSuperiorAdm
            // 
            panelSuperiorAdm.BackColor = Color.FromArgb(36, 65, 57);
            panelSuperiorAdm.Controls.Add(iconMinim);
            panelSuperiorAdm.Controls.Add(iconMax);
            panelSuperiorAdm.Controls.Add(iconX);
            panelSuperiorAdm.Controls.Add(panel2);
            panelSuperiorAdm.Controls.Add(lblAdm);
            panelSuperiorAdm.Dock = DockStyle.Top;
            panelSuperiorAdm.Location = new Point(0, 0);
            panelSuperiorAdm.Name = "panelSuperiorAdm";
            panelSuperiorAdm.Size = new Size(1064, 40);
            panelSuperiorAdm.TabIndex = 9;
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
            iconMinim.TabIndex = 14;
            iconMinim.UseVisualStyleBackColor = true;
            iconMinim.Click += iconMinim_Click;
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
            iconMax.TabIndex = 13;
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
            iconX.TabIndex = 11;
            iconX.UseVisualStyleBackColor = true;
            iconX.Click += iconX_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Location = new Point(915, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 40);
            panel2.TabIndex = 12;
            // 
            // lblAdm
            // 
            lblAdm.AutoSize = true;
            lblAdm.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdm.ForeColor = SystemColors.ButtonHighlight;
            lblAdm.Location = new Point(12, 9);
            lblAdm.Name = "lblAdm";
            lblAdm.Size = new Size(171, 25);
            lblAdm.TabIndex = 0;
            lblAdm.Text = "ADMINISTRADOR";
            // 
            // AdmTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 633);
            Controls.Add(panelEsquerdo);
            Controls.Add(panelSuperiorAdm);
            Name = "AdmTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador";
            Load += GestorTela_Load;
            panelEsquerdo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelSuperiorAdm.ResumeLayout(false);
            panelSuperiorAdm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEsquerdo;
        private Panel panelSuperiorAdm;
        private Label lblAdm;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnDestaques;
        private FontAwesome.Sharp.IconButton btnAluno;
        private FontAwesome.Sharp.IconButton btnProfessor;
        private FontAwesome.Sharp.IconButton btnAdm;
        private FontAwesome.Sharp.IconButton iconMinim;
        private FontAwesome.Sharp.IconButton iconMax;
        private FontAwesome.Sharp.IconButton iconX;
        private Panel panel2;
    }
}