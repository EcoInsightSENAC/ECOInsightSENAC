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
            btnSair = new FontAwesome.Sharp.IconButton();
            btnAlunoMenu = new FontAwesome.Sharp.IconButton();
            btnAlunoDestaques = new FontAwesome.Sharp.IconButton();
            btnAlunoMPerfil = new FontAwesome.Sharp.IconButton();
            btnAlunoAulas = new FontAwesome.Sharp.IconButton();
            btnMinimizarAluno = new FontAwesome.Sharp.IconButton();
            lblAluno = new Label();
            btnMaximizarRestaurarAluno = new FontAwesome.Sharp.IconButton();
            btnFecharAluno = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panelSuperiorAluno = new Panel();
            pictureBox2 = new PictureBox();
            lblLogin = new Label();
            panel1 = new Panel();
            btnMaximizarRestaurarHome = new FontAwesome.Sharp.IconButton();
            btnFecharHome = new FontAwesome.Sharp.IconButton();
            btnMinimizarHome = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            panel5 = new Panel();
            menuAluno = new Panel();
            btnAlunoNotas = new FontAwesome.Sharp.IconButton();
            panel7 = new Panel();
            panel8 = new Panel();
            timerMenuAluno = new System.Windows.Forms.Timer(components);
            sidebarTimerAluno = new System.Windows.Forms.Timer(components);
            sidebarAluno = new FlowLayoutPanel();
            panelAluno = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            panelSuperiorAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            menuAluno.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            sidebarAluno.SuspendLayout();
            panelAluno.SuspendLayout();
            SuspendLayout();
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
            btnSair.Location = new Point(0, 0);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(4, 0, 0, 0);
            btnSair.Size = new Size(177, 52);
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
            btnAlunoMenu.Size = new Size(177, 52);
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
            btnAlunoDestaques.Location = new Point(0, 0);
            btnAlunoDestaques.Name = "btnAlunoDestaques";
            btnAlunoDestaques.Padding = new Padding(7, 0, 0, 0);
            btnAlunoDestaques.Size = new Size(177, 52);
            btnAlunoDestaques.TabIndex = 27;
            btnAlunoDestaques.Text = "       Destaques";
            btnAlunoDestaques.UseVisualStyleBackColor = true;
            btnAlunoDestaques.Click += btnAlunoDestaques_Click;
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
            btnAlunoMPerfil.Location = new Point(0, 0);
            btnAlunoMPerfil.Name = "btnAlunoMPerfil";
            btnAlunoMPerfil.Padding = new Padding(7, 0, 0, 0);
            btnAlunoMPerfil.Size = new Size(177, 52);
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
            btnAlunoAulas.Location = new Point(0, 0);
            btnAlunoAulas.Name = "btnAlunoAulas";
            btnAlunoAulas.Padding = new Padding(7, 0, 0, 0);
            btnAlunoAulas.Size = new Size(177, 52);
            btnAlunoAulas.TabIndex = 24;
            btnAlunoAulas.Text = "Aulas";
            btnAlunoAulas.UseVisualStyleBackColor = true;
            btnAlunoAulas.Click += btnAlunoAulas_Click;
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
            btnMinimizarAluno.Location = new Point(18, 0);
            btnMinimizarAluno.Name = "btnMinimizarAluno";
            btnMinimizarAluno.Size = new Size(39, 37);
            btnMinimizarAluno.TabIndex = 16;
            btnMinimizarAluno.UseVisualStyleBackColor = true;
            btnMinimizarAluno.Click += btnMinimizarAluno_Click;
            // 
            // lblAluno
            // 
            lblAluno.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAluno.AutoSize = true;
            lblAluno.FlatStyle = FlatStyle.Flat;
            lblAluno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAluno.ForeColor = SystemColors.ButtonHighlight;
            lblAluno.Location = new Point(486, 9);
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
            btnMaximizarRestaurarAluno.Location = new Point(63, 0);
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
            btnFecharAluno.Location = new Point(108, 0);
            btnFecharAluno.Name = "btnFecharAluno";
            btnFecharAluno.Size = new Size(39, 37);
            btnFecharAluno.TabIndex = 13;
            btnFecharAluno.UseVisualStyleBackColor = true;
            btnFecharAluno.Click += btnFecharAluno_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Controls.Add(btnMinimizarAluno);
            panel2.Controls.Add(btnMaximizarRestaurarAluno);
            panel2.Controls.Add(btnFecharAluno);
            panel2.Location = new Point(988, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 40);
            panel2.TabIndex = 14;
            // 
            // panelSuperiorAluno
            // 
            panelSuperiorAluno.BackColor = Color.FromArgb(36, 65, 57);
            panelSuperiorAluno.Controls.Add(pictureBox2);
            panelSuperiorAluno.Controls.Add(lblLogin);
            panelSuperiorAluno.Controls.Add(panel1);
            panelSuperiorAluno.Controls.Add(panel2);
            panelSuperiorAluno.Controls.Add(lblAluno);
            panelSuperiorAluno.Dock = DockStyle.Top;
            panelSuperiorAluno.Location = new Point(0, 0);
            panelSuperiorAluno.Name = "panelSuperiorAluno";
            panelSuperiorAluno.Size = new Size(1139, 42);
            panelSuperiorAluno.TabIndex = 33;
            panelSuperiorAluno.MouseDown += panelSuperiorAluno_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LogoEcoInsght;
            pictureBox2.Location = new Point(12, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = SystemColors.ButtonHighlight;
            lblLogin.Location = new Point(53, 10);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(82, 21);
            lblLogin.TabIndex = 57;
            lblLogin.Text = "EcoBoard";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.Controls.Add(btnMaximizarRestaurarHome);
            panel1.Controls.Add(btnFecharHome);
            panel1.Controls.Add(btnMinimizarHome);
            panel1.Location = new Point(1927, -29);
            panel1.Name = "panel1";
            panel1.Size = new Size(148, 40);
            panel1.TabIndex = 8;
            // 
            // btnMaximizarRestaurarHome
            // 
            btnMaximizarRestaurarHome.Anchor = AnchorStyles.Right;
            btnMaximizarRestaurarHome.FlatAppearance.BorderSize = 0;
            btnMaximizarRestaurarHome.FlatStyle = FlatStyle.Flat;
            btnMaximizarRestaurarHome.ForeColor = Color.Transparent;
            btnMaximizarRestaurarHome.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarRestaurarHome.IconColor = Color.White;
            btnMaximizarRestaurarHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarRestaurarHome.IconSize = 20;
            btnMaximizarRestaurarHome.Location = new Point(9, -30);
            btnMaximizarRestaurarHome.Name = "btnMaximizarRestaurarHome";
            btnMaximizarRestaurarHome.Size = new Size(39, 37);
            btnMaximizarRestaurarHome.TabIndex = 9;
            btnMaximizarRestaurarHome.UseVisualStyleBackColor = true;
            // 
            // btnFecharHome
            // 
            btnFecharHome.Anchor = AnchorStyles.Right;
            btnFecharHome.FlatAppearance.BorderSize = 0;
            btnFecharHome.FlatStyle = FlatStyle.Flat;
            btnFecharHome.ForeColor = Color.Transparent;
            btnFecharHome.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnFecharHome.IconColor = Color.White;
            btnFecharHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFecharHome.IconSize = 20;
            btnFecharHome.Location = new Point(54, -30);
            btnFecharHome.Name = "btnFecharHome";
            btnFecharHome.Size = new Size(39, 37);
            btnFecharHome.TabIndex = 8;
            btnFecharHome.UseVisualStyleBackColor = true;
            // 
            // btnMinimizarHome
            // 
            btnMinimizarHome.Anchor = AnchorStyles.Right;
            btnMinimizarHome.FlatAppearance.BorderSize = 0;
            btnMinimizarHome.FlatStyle = FlatStyle.Flat;
            btnMinimizarHome.ForeColor = Color.Transparent;
            btnMinimizarHome.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            btnMinimizarHome.IconColor = Color.White;
            btnMinimizarHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarHome.IconSize = 20;
            btnMinimizarHome.Location = new Point(-36, -30);
            btnMinimizarHome.Name = "btnMinimizarHome";
            btnMinimizarHome.Size = new Size(39, 37);
            btnMinimizarHome.TabIndex = 10;
            btnMinimizarHome.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnAlunoMenu);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(177, 52);
            panel6.TabIndex = 38;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnAlunoDestaques);
            panel5.Location = new Point(3, 61);
            panel5.Name = "panel5";
            panel5.Size = new Size(177, 52);
            panel5.TabIndex = 37;
            // 
            // menuAluno
            // 
            menuAluno.Controls.Add(btnAlunoNotas);
            menuAluno.Controls.Add(btnAlunoAulas);
            menuAluno.Location = new Point(3, 119);
            menuAluno.Name = "menuAluno";
            menuAluno.Size = new Size(177, 53);
            menuAluno.TabIndex = 36;
            // 
            // btnAlunoNotas
            // 
            btnAlunoNotas.FlatAppearance.BorderSize = 0;
            btnAlunoNotas.FlatStyle = FlatStyle.Flat;
            btnAlunoNotas.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlunoNotas.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnAlunoNotas.IconColor = Color.Black;
            btnAlunoNotas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAlunoNotas.IconSize = 40;
            btnAlunoNotas.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlunoNotas.Location = new Point(0, 57);
            btnAlunoNotas.Name = "btnAlunoNotas";
            btnAlunoNotas.Padding = new Padding(7, 0, 0, 0);
            btnAlunoNotas.Size = new Size(161, 52);
            btnAlunoNotas.TabIndex = 25;
            btnAlunoNotas.Text = "Notas";
            btnAlunoNotas.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnAlunoMPerfil);
            panel7.Location = new Point(3, 178);
            panel7.Name = "panel7";
            panel7.Size = new Size(177, 52);
            panel7.TabIndex = 36;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnSair);
            panel8.Location = new Point(3, 236);
            panel8.Name = "panel8";
            panel8.Size = new Size(177, 52);
            panel8.TabIndex = 36;
            // 
            // timerMenuAluno
            // 
            timerMenuAluno.Interval = 10;
            timerMenuAluno.Tick += timerMenuAluno_Tick;
            // 
            // sidebarTimerAluno
            // 
            sidebarTimerAluno.Interval = 10;
            sidebarTimerAluno.Tick += sidebarTimerAluno_Tick;
            // 
            // sidebarAluno
            // 
            sidebarAluno.BackColor = Color.FromArgb(153, 179, 142);
            sidebarAluno.Controls.Add(panel6);
            sidebarAluno.Controls.Add(panel5);
            sidebarAluno.Controls.Add(menuAluno);
            sidebarAluno.Controls.Add(panel7);
            sidebarAluno.Controls.Add(panel8);
            sidebarAluno.Dock = DockStyle.Left;
            sidebarAluno.Location = new Point(0, 42);
            sidebarAluno.Name = "sidebarAluno";
            sidebarAluno.Size = new Size(180, 687);
            sidebarAluno.TabIndex = 39;
            // 
            // panelAluno
            // 
            panelAluno.Controls.Add(label1);
            panelAluno.Dock = DockStyle.Fill;
            panelAluno.Location = new Point(180, 42);
            panelAluno.Name = "panelAluno";
            panelAluno.Size = new Size(959, 687);
            panelAluno.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 196);
            label1.Name = "label1";
            label1.Size = new Size(705, 256);
            label1.TabIndex = 0;
            label1.Text = "TELA EM \r\nCONSTRUÇÃO";
            // 
            // AlunoTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 729);
            Controls.Add(panelAluno);
            Controls.Add(sidebarAluno);
            Controls.Add(panelSuperiorAluno);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlunoTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ECOInsight";
            panel2.ResumeLayout(false);
            panelSuperiorAluno.ResumeLayout(false);
            panelSuperiorAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            menuAluno.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            sidebarAluno.ResumeLayout(false);
            panelAluno.ResumeLayout(false);
            panelAluno.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblAluno;
        private FontAwesome.Sharp.IconButton btnMinimizarAluno;
        private FontAwesome.Sharp.IconButton btnMaximizarRestaurarAluno;
        private FontAwesome.Sharp.IconButton btnFecharAluno;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnAlunoDestaques;
        private FontAwesome.Sharp.IconButton btnAlunoMPerfil;
        private FontAwesome.Sharp.IconButton btnAlunoAulas;
        private FontAwesome.Sharp.IconButton btnAlunoMenu;
        private Panel panelSuperiorAluno;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnMaximizarRestaurarHome;
        private FontAwesome.Sharp.IconButton btnFecharHome;
        private FontAwesome.Sharp.IconButton btnMinimizarHome;
        private Panel panel6;
        private Panel panel5;
        private Panel menuAluno;
        private FontAwesome.Sharp.IconButton btnAlunoNotas;
        private Panel panel7;
        private Panel panel8;
        private System.Windows.Forms.Timer timerMenuAluno;
        private System.Windows.Forms.Timer sidebarTimerAluno;
        private FlowLayoutPanel sidebarAluno;
        private Panel panelAluno;
        private Label label1;
        private Label lblLogin;
        private PictureBox pictureBox2;
    }
}