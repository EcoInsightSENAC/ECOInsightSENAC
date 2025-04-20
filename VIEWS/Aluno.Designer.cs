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
            components = new System.ComponentModel.Container();
            sidebarAluno = new Panel();
            btnSair = new FontAwesome.Sharp.IconButton();
            btnAlunoMenu = new FontAwesome.Sharp.IconButton();
            btnAlunoDestaques = new FontAwesome.Sharp.IconButton();
            btnAluno = new FontAwesome.Sharp.IconButton();
            btnAlunoMPerfil = new FontAwesome.Sharp.IconButton();
            btnAlunoAulas = new FontAwesome.Sharp.IconButton();
            panelSuperiorAluno = new Panel();
            btnMinimizarAluno = new FontAwesome.Sharp.IconButton();
            lblAluno = new Label();
            btnMaximizarRestaurarAluno = new FontAwesome.Sharp.IconButton();
            btnFecharAluno = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panelAluno = new Panel();
            sidebarTimerAluno = new System.Windows.Forms.Timer(components);
            sidebarAluno.SuspendLayout();
            panelSuperiorAluno.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarAluno
            // 
            sidebarAluno.BackColor = Color.FromArgb(153, 179, 142);
            sidebarAluno.Controls.Add(btnSair);
            sidebarAluno.Controls.Add(btnAlunoMenu);
            sidebarAluno.Controls.Add(btnAlunoDestaques);
            sidebarAluno.Controls.Add(btnAluno);
            sidebarAluno.Controls.Add(btnAlunoMPerfil);
            sidebarAluno.Controls.Add(btnAlunoAulas);
            sidebarAluno.Dock = DockStyle.Left;
            sidebarAluno.Location = new Point(0, 40);
            sidebarAluno.MaximumSize = new Size(161, 689);
            sidebarAluno.MinimumSize = new Size(58, 689);
            sidebarAluno.Name = "sidebarAluno";
            sidebarAluno.Size = new Size(161, 689);
            sidebarAluno.TabIndex = 12;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Left;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnSair.IconColor = Color.Black;
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(0, 619);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(4, 0, 0, 0);
            btnSair.Size = new Size(161, 52);
            btnSair.TabIndex = 9;
            btnSair.Text = "    SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnAlunoMenu
            // 
            btnAlunoMenu.Cursor = Cursors.Hand;
            btnAlunoMenu.FlatAppearance.BorderSize = 0;
            btnAlunoMenu.FlatStyle = FlatStyle.Flat;
            btnAlunoMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlunoMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnAlunoMenu.IconColor = Color.Black;
            btnAlunoMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAlunoMenu.IconSize = 40;
            btnAlunoMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlunoMenu.Location = new Point(0, 0);
            btnAlunoMenu.Name = "btnAlunoMenu";
            btnAlunoMenu.Padding = new Padding(7, 0, 0, 0);
            btnAlunoMenu.Size = new Size(161, 52);
            btnAlunoMenu.TabIndex = 28;
            btnAlunoMenu.Text = " Menu";
            btnAlunoMenu.UseVisualStyleBackColor = true;
            btnAlunoMenu.Click += iconButton1_Click;
            // 
            // btnAlunoDestaques
            // 
            btnAlunoDestaques.Cursor = Cursors.Hand;
            btnAlunoDestaques.FlatAppearance.BorderSize = 0;
            btnAlunoDestaques.FlatStyle = FlatStyle.Flat;
            btnAlunoDestaques.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlunoDestaques.IconChar = FontAwesome.Sharp.IconChar.Bullhorn;
            btnAlunoDestaques.IconColor = Color.Black;
            btnAlunoDestaques.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAlunoDestaques.IconSize = 40;
            btnAlunoDestaques.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlunoDestaques.Location = new Point(0, 58);
            btnAlunoDestaques.Name = "btnAlunoDestaques";
            btnAlunoDestaques.Padding = new Padding(7, 0, 0, 0);
            btnAlunoDestaques.Size = new Size(161, 52);
            btnAlunoDestaques.TabIndex = 27;
            btnAlunoDestaques.Text = "       Destaques";
            btnAlunoDestaques.UseVisualStyleBackColor = true;
            btnAlunoDestaques.Click += btnAlunoDestaques_Click;
            // 
            // btnAluno
            // 
            btnAluno.FlatAppearance.BorderSize = 0;
            btnAluno.FlatStyle = FlatStyle.Flat;
            btnAluno.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAluno.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btnAluno.IconColor = Color.Black;
            btnAluno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAluno.IconSize = 40;
            btnAluno.ImageAlign = ContentAlignment.MiddleLeft;
            btnAluno.Location = new Point(0, 232);
            btnAluno.Name = "btnAluno";
            btnAluno.Padding = new Padding(7, 0, 0, 0);
            btnAluno.Size = new Size(161, 52);
            btnAluno.TabIndex = 26;
            btnAluno.Text = "- - - - ";
            btnAluno.UseVisualStyleBackColor = true;
            // 
            // btnAlunoMPerfil
            // 
            btnAlunoMPerfil.FlatAppearance.BorderSize = 0;
            btnAlunoMPerfil.FlatStyle = FlatStyle.Flat;
            btnAlunoMPerfil.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlunoMPerfil.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            btnAlunoMPerfil.IconColor = Color.Black;
            btnAlunoMPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAlunoMPerfil.IconSize = 40;
            btnAlunoMPerfil.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlunoMPerfil.Location = new Point(0, 174);
            btnAlunoMPerfil.Name = "btnAlunoMPerfil";
            btnAlunoMPerfil.Padding = new Padding(7, 0, 0, 0);
            btnAlunoMPerfil.Size = new Size(161, 52);
            btnAlunoMPerfil.TabIndex = 25;
            btnAlunoMPerfil.Text = "       Meu Perfil";
            btnAlunoMPerfil.UseVisualStyleBackColor = true;
            btnAlunoMPerfil.Click += btnAlunoMPerfil_Click;
            // 
            // btnAlunoAulas
            // 
            btnAlunoAulas.FlatAppearance.BorderSize = 0;
            btnAlunoAulas.FlatStyle = FlatStyle.Flat;
            btnAlunoAulas.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlunoAulas.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnAlunoAulas.IconColor = Color.Black;
            btnAlunoAulas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAlunoAulas.IconSize = 40;
            btnAlunoAulas.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlunoAulas.Location = new Point(0, 116);
            btnAlunoAulas.Name = "btnAlunoAulas";
            btnAlunoAulas.Padding = new Padding(7, 0, 0, 0);
            btnAlunoAulas.Size = new Size(161, 52);
            btnAlunoAulas.TabIndex = 24;
            btnAlunoAulas.Text = "Aulas";
            btnAlunoAulas.UseVisualStyleBackColor = true;
            btnAlunoAulas.Click += btnAlunoAulas_Click;
            // 
            // panelSuperiorAluno
            // 
            panelSuperiorAluno.BackColor = Color.FromArgb(36, 65, 57);
            panelSuperiorAluno.Controls.Add(btnMinimizarAluno);
            panelSuperiorAluno.Controls.Add(lblAluno);
            panelSuperiorAluno.Controls.Add(btnMaximizarRestaurarAluno);
            panelSuperiorAluno.Controls.Add(btnFecharAluno);
            panelSuperiorAluno.Controls.Add(panel2);
            panelSuperiorAluno.Dock = DockStyle.Top;
            panelSuperiorAluno.Location = new Point(0, 0);
            panelSuperiorAluno.Name = "panelSuperiorAluno";
            panelSuperiorAluno.Size = new Size(1350, 40);
            panelSuperiorAluno.TabIndex = 11;
            // 
            // btnMinimizarAluno
            // 
            btnMinimizarAluno.Anchor = AnchorStyles.Right;
            btnMinimizarAluno.FlatAppearance.BorderSize = 0;
            btnMinimizarAluno.FlatStyle = FlatStyle.Flat;
            btnMinimizarAluno.ForeColor = Color.Transparent;
            btnMinimizarAluno.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            btnMinimizarAluno.IconColor = Color.White;
            btnMinimizarAluno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarAluno.IconSize = 20;
            btnMinimizarAluno.Location = new Point(1209, 3);
            btnMinimizarAluno.Name = "btnMinimizarAluno";
            btnMinimizarAluno.Size = new Size(39, 37);
            btnMinimizarAluno.TabIndex = 16;
            btnMinimizarAluno.UseVisualStyleBackColor = true;
            btnMinimizarAluno.Click += btnMinimizarAluno_Click;
            // 
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.FlatStyle = FlatStyle.Flat;
            lblAluno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAluno.ForeColor = SystemColors.ButtonHighlight;
            lblAluno.Location = new Point(636, 9);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(78, 25);
            lblAluno.TabIndex = 0;
            lblAluno.Text = "ALUNO";
            // 
            // btnMaximizarRestaurarAluno
            // 
            btnMaximizarRestaurarAluno.Anchor = AnchorStyles.Right;
            btnMaximizarRestaurarAluno.FlatAppearance.BorderSize = 0;
            btnMaximizarRestaurarAluno.FlatStyle = FlatStyle.Flat;
            btnMaximizarRestaurarAluno.ForeColor = Color.Transparent;
            btnMaximizarRestaurarAluno.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarRestaurarAluno.IconColor = Color.White;
            btnMaximizarRestaurarAluno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarRestaurarAluno.IconSize = 20;
            btnMaximizarRestaurarAluno.Location = new Point(1254, 3);
            btnMaximizarRestaurarAluno.Name = "btnMaximizarRestaurarAluno";
            btnMaximizarRestaurarAluno.Size = new Size(39, 37);
            btnMaximizarRestaurarAluno.TabIndex = 15;
            btnMaximizarRestaurarAluno.UseVisualStyleBackColor = true;
            btnMaximizarRestaurarAluno.Click += btnMaximizarRestaurarAluno_Click;
            // 
            // btnFecharAluno
            // 
            btnFecharAluno.Anchor = AnchorStyles.Right;
            btnFecharAluno.FlatAppearance.BorderSize = 0;
            btnFecharAluno.FlatStyle = FlatStyle.Flat;
            btnFecharAluno.ForeColor = Color.Transparent;
            btnFecharAluno.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnFecharAluno.IconColor = Color.White;
            btnFecharAluno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFecharAluno.IconSize = 20;
            btnFecharAluno.Location = new Point(1299, 3);
            btnFecharAluno.Name = "btnFecharAluno";
            btnFecharAluno.Size = new Size(39, 37);
            btnFecharAluno.TabIndex = 13;
            btnFecharAluno.UseVisualStyleBackColor = true;
            btnFecharAluno.Click += btnFecharAluno_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Location = new Point(1202, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 40);
            panel2.TabIndex = 14;
            // 
            // panelAluno
            // 
            panelAluno.Anchor = AnchorStyles.Left;
            panelAluno.Location = new Point(161, 40);
            panelAluno.Name = "panelAluno";
            panelAluno.Size = new Size(1189, 689);
            panelAluno.TabIndex = 13;
            // 
            // sidebarTimerAluno
            // 
            sidebarTimerAluno.Interval = 10;
            sidebarTimerAluno.Tick += SidebarTimerAluno_Tick;
            // 
            // AlunoTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panelAluno);
            Controls.Add(sidebarAluno);
            Controls.Add(panelSuperiorAluno);
            Name = "AlunoTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ECOInsight";
            sidebarAluno.ResumeLayout(false);
            panelSuperiorAluno.ResumeLayout(false);
            panelSuperiorAluno.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarAluno;
        private Panel panelSuperiorAluno;
        private Label lblAluno;
        private FontAwesome.Sharp.IconButton btnMinimizarAluno;
        private FontAwesome.Sharp.IconButton btnMaximizarRestaurarAluno;
        private FontAwesome.Sharp.IconButton btnFecharAluno;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnAlunoDestaques;
        private FontAwesome.Sharp.IconButton btnAluno;
        private FontAwesome.Sharp.IconButton btnAlunoMPerfil;
        private FontAwesome.Sharp.IconButton btnAlunoAulas;
        private Panel panelAluno;
        private System.Windows.Forms.Timer sidebarTimerAluno;
        private FontAwesome.Sharp.IconButton btnAlunoMenu;
    }
}