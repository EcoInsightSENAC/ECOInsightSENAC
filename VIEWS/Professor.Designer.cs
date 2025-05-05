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
            components = new System.ComponentModel.Container();
            btnAProfMenu = new FontAwesome.Sharp.IconButton();
            btnProfDestaques = new FontAwesome.Sharp.IconButton();
            btnProfMPerfil = new FontAwesome.Sharp.IconButton();
            btnProfRelatorio = new FontAwesome.Sharp.IconButton();
            btnProfAula = new FontAwesome.Sharp.IconButton();
            btnMinimizarProf = new FontAwesome.Sharp.IconButton();
            lblAluno = new Label();
            btnMaximizarRestaurarProf = new FontAwesome.Sharp.IconButton();
            btnFecharProf = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            sidebarTimerProf = new System.Windows.Forms.Timer(components);
            panelSuperiorProf = new Panel();
            pictureBox2 = new PictureBox();
            lblLogin = new Label();
            sidebarProf = new FlowLayoutPanel();
            panelbtnAProfMenu = new Panel();
            panelbtnProfDestaques = new Panel();
            panelbtnProfAula = new Panel();
            panelbtnProfMPerfil = new Panel();
            btnProfMeuPerfil = new FontAwesome.Sharp.IconButton();
            panelbtnSairProf = new Panel();
            btnSairProf = new FontAwesome.Sharp.IconButton();
            timerSubAula = new System.Windows.Forms.Timer(components);
            panelProf = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            panelSuperiorProf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            sidebarProf.SuspendLayout();
            panelbtnAProfMenu.SuspendLayout();
            panelbtnProfDestaques.SuspendLayout();
            panelbtnProfAula.SuspendLayout();
            panelbtnProfMPerfil.SuspendLayout();
            panelbtnSairProf.SuspendLayout();
            panelProf.SuspendLayout();
            SuspendLayout();
            // 
            // btnAProfMenu
            // 
            btnAProfMenu.Cursor = Cursors.Hand;
            btnAProfMenu.FlatAppearance.BorderSize = 0;
            btnAProfMenu.FlatStyle = FlatStyle.Flat;
            btnAProfMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAProfMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnAProfMenu.IconColor = Color.Black;
            btnAProfMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAProfMenu.IconSize = 40;
            btnAProfMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnAProfMenu.Location = new Point(0, 0);
            btnAProfMenu.Name = "btnAProfMenu";
            btnAProfMenu.Padding = new Padding(7, 0, 0, 0);
            btnAProfMenu.Size = new Size(177, 52);
            btnAProfMenu.TabIndex = 29;
            btnAProfMenu.Text = " Menu";
            btnAProfMenu.UseVisualStyleBackColor = true;
            btnAProfMenu.Click += btnAProfMenu_Click;
            // 
            // btnProfDestaques
            // 
            btnProfDestaques.FlatAppearance.BorderSize = 0;
            btnProfDestaques.FlatStyle = FlatStyle.Flat;
            btnProfDestaques.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfDestaques.IconChar = FontAwesome.Sharp.IconChar.Bullhorn;
            btnProfDestaques.IconColor = Color.Black;
            btnProfDestaques.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProfDestaques.IconSize = 40;
            btnProfDestaques.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfDestaques.Location = new Point(0, 0);
            btnProfDestaques.Name = "btnProfDestaques";
            btnProfDestaques.Padding = new Padding(5, 0, 0, 0);
            btnProfDestaques.Size = new Size(177, 52);
            btnProfDestaques.TabIndex = 23;
            btnProfDestaques.Text = "         Destaques";
            btnProfDestaques.UseVisualStyleBackColor = true;
            btnProfDestaques.Click += btnProfDestaques_Click;
            // 
            // btnProfMPerfil
            // 
            btnProfMPerfil.IconChar = FontAwesome.Sharp.IconChar.None;
            btnProfMPerfil.IconColor = Color.Black;
            btnProfMPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProfMPerfil.Location = new Point(0, 0);
            btnProfMPerfil.Name = "btnProfMPerfil";
            btnProfMPerfil.Size = new Size(75, 23);
            btnProfMPerfil.TabIndex = 24;
            // 
            // btnProfRelatorio
            // 
            btnProfRelatorio.FlatAppearance.BorderSize = 0;
            btnProfRelatorio.FlatStyle = FlatStyle.Flat;
            btnProfRelatorio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfRelatorio.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            btnProfRelatorio.IconColor = Color.Black;
            btnProfRelatorio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProfRelatorio.IconSize = 40;
            btnProfRelatorio.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfRelatorio.Location = new Point(0, 58);
            btnProfRelatorio.Name = "btnProfRelatorio";
            btnProfRelatorio.Padding = new Padding(5, 0, 0, 0);
            btnProfRelatorio.Size = new Size(177, 52);
            btnProfRelatorio.TabIndex = 21;
            btnProfRelatorio.Text = "    Notas";
            btnProfRelatorio.UseVisualStyleBackColor = true;
            btnProfRelatorio.Click += btnProfRelatorio_Click;
            // 
            // btnProfAula
            // 
            btnProfAula.FlatAppearance.BorderSize = 0;
            btnProfAula.FlatStyle = FlatStyle.Flat;
            btnProfAula.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfAula.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnProfAula.IconColor = Color.Black;
            btnProfAula.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProfAula.IconSize = 40;
            btnProfAula.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfAula.Location = new Point(0, 0);
            btnProfAula.Name = "btnProfAula";
            btnProfAula.Padding = new Padding(5, 0, 0, 0);
            btnProfAula.Size = new Size(177, 52);
            btnProfAula.TabIndex = 20;
            btnProfAula.Text = "Aula";
            btnProfAula.UseVisualStyleBackColor = true;
            btnProfAula.Click += btnProfAula_Click;
            // 
            // btnMinimizarProf
            // 
            btnMinimizarProf.Anchor = AnchorStyles.Right;
            btnMinimizarProf.FlatAppearance.BorderSize = 0;
            btnMinimizarProf.FlatStyle = FlatStyle.Flat;
            btnMinimizarProf.ForeColor = Color.Transparent;
            btnMinimizarProf.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            btnMinimizarProf.IconColor = Color.White;
            btnMinimizarProf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarProf.IconSize = 20;
            btnMinimizarProf.Location = new Point(19, 0);
            btnMinimizarProf.Name = "btnMinimizarProf";
            btnMinimizarProf.Size = new Size(39, 37);
            btnMinimizarProf.TabIndex = 18;
            btnMinimizarProf.UseVisualStyleBackColor = true;
            btnMinimizarProf.Click += btnMinimizarProf_Click;
            // 
            // lblAluno
            // 
            lblAluno.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAluno.AutoSize = true;
            lblAluno.FlatStyle = FlatStyle.Flat;
            lblAluno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAluno.ForeColor = SystemColors.ButtonHighlight;
            lblAluno.Location = new Point(510, 9);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(118, 25);
            lblAluno.TabIndex = 0;
            lblAluno.Text = "PROFESSOR";
            // 
            // btnMaximizarRestaurarProf
            // 
            btnMaximizarRestaurarProf.Anchor = AnchorStyles.Right;
            btnMaximizarRestaurarProf.FlatAppearance.BorderSize = 0;
            btnMaximizarRestaurarProf.FlatStyle = FlatStyle.Flat;
            btnMaximizarRestaurarProf.ForeColor = Color.Transparent;
            btnMaximizarRestaurarProf.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarRestaurarProf.IconColor = Color.White;
            btnMaximizarRestaurarProf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarRestaurarProf.IconSize = 20;
            btnMaximizarRestaurarProf.Location = new Point(64, 0);
            btnMaximizarRestaurarProf.Name = "btnMaximizarRestaurarProf";
            btnMaximizarRestaurarProf.Size = new Size(39, 37);
            btnMaximizarRestaurarProf.TabIndex = 17;
            btnMaximizarRestaurarProf.UseVisualStyleBackColor = true;
            btnMaximizarRestaurarProf.Click += btnMaximizarRestaurarProf_Click;
            // 
            // btnFecharProf
            // 
            btnFecharProf.Anchor = AnchorStyles.Right;
            btnFecharProf.FlatAppearance.BorderSize = 0;
            btnFecharProf.FlatStyle = FlatStyle.Flat;
            btnFecharProf.ForeColor = Color.Transparent;
            btnFecharProf.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnFecharProf.IconColor = Color.White;
            btnFecharProf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFecharProf.IconSize = 20;
            btnFecharProf.Location = new Point(109, 0);
            btnFecharProf.Name = "btnFecharProf";
            btnFecharProf.Size = new Size(39, 37);
            btnFecharProf.TabIndex = 15;
            btnFecharProf.UseVisualStyleBackColor = true;
            btnFecharProf.Click += btnFecharProf_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Controls.Add(btnMinimizarProf);
            panel2.Controls.Add(btnMaximizarRestaurarProf);
            panel2.Controls.Add(btnFecharProf);
            panel2.Location = new Point(988, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 40);
            panel2.TabIndex = 16;
            // 
            // sidebarTimerProf
            // 
            sidebarTimerProf.Interval = 10;
            sidebarTimerProf.Tick += sidebarTimerProf_Tick;
            // 
            // panelSuperiorProf
            // 
            panelSuperiorProf.BackColor = Color.FromArgb(36, 65, 57);
            panelSuperiorProf.Controls.Add(pictureBox2);
            panelSuperiorProf.Controls.Add(lblLogin);
            panelSuperiorProf.Controls.Add(panel2);
            panelSuperiorProf.Controls.Add(lblAluno);
            panelSuperiorProf.Dock = DockStyle.Top;
            panelSuperiorProf.Location = new Point(0, 0);
            panelSuperiorProf.Name = "panelSuperiorProf";
            panelSuperiorProf.Size = new Size(1139, 42);
            panelSuperiorProf.TabIndex = 22;
            panelSuperiorProf.MouseDown += panelSuperiorProf_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LogoEcoInsght;
            pictureBox2.Location = new Point(12, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = SystemColors.ButtonHighlight;
            lblLogin.Location = new Point(53, 10);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(86, 21);
            lblLogin.TabIndex = 17;
            lblLogin.Text = "ECOBoard";
            // 
            // sidebarProf
            // 
            sidebarProf.BackColor = Color.FromArgb(153, 179, 142);
            sidebarProf.Controls.Add(panelbtnAProfMenu);
            sidebarProf.Controls.Add(panelbtnProfDestaques);
            sidebarProf.Controls.Add(panelbtnProfAula);
            sidebarProf.Controls.Add(panelbtnProfMPerfil);
            sidebarProf.Controls.Add(panelbtnSairProf);
            sidebarProf.Dock = DockStyle.Left;
            sidebarProf.Location = new Point(0, 42);
            sidebarProf.Name = "sidebarProf";
            sidebarProf.Size = new Size(180, 687);
            sidebarProf.TabIndex = 23;
            // 
            // panelbtnAProfMenu
            // 
            panelbtnAProfMenu.Controls.Add(btnAProfMenu);
            panelbtnAProfMenu.Location = new Point(3, 3);
            panelbtnAProfMenu.Name = "panelbtnAProfMenu";
            panelbtnAProfMenu.Size = new Size(177, 52);
            panelbtnAProfMenu.TabIndex = 57;
            // 
            // panelbtnProfDestaques
            // 
            panelbtnProfDestaques.Controls.Add(btnProfDestaques);
            panelbtnProfDestaques.Location = new Point(3, 61);
            panelbtnProfDestaques.Name = "panelbtnProfDestaques";
            panelbtnProfDestaques.Size = new Size(177, 52);
            panelbtnProfDestaques.TabIndex = 58;
            // 
            // panelbtnProfAula
            // 
            panelbtnProfAula.Controls.Add(btnProfRelatorio);
            panelbtnProfAula.Controls.Add(btnProfAula);
            panelbtnProfAula.Location = new Point(3, 119);
            panelbtnProfAula.Name = "panelbtnProfAula";
            panelbtnProfAula.Size = new Size(177, 52);
            panelbtnProfAula.TabIndex = 58;
            // 
            // panelbtnProfMPerfil
            // 
            panelbtnProfMPerfil.Controls.Add(btnProfMeuPerfil);
            panelbtnProfMPerfil.Controls.Add(btnProfMPerfil);
            panelbtnProfMPerfil.Location = new Point(3, 177);
            panelbtnProfMPerfil.Name = "panelbtnProfMPerfil";
            panelbtnProfMPerfil.Size = new Size(177, 52);
            panelbtnProfMPerfil.TabIndex = 58;
            // 
            // btnProfMeuPerfil
            // 
            btnProfMeuPerfil.FlatAppearance.BorderSize = 0;
            btnProfMeuPerfil.FlatStyle = FlatStyle.Flat;
            btnProfMeuPerfil.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfMeuPerfil.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            btnProfMeuPerfil.IconColor = Color.Black;
            btnProfMeuPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProfMeuPerfil.IconSize = 40;
            btnProfMeuPerfil.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfMeuPerfil.Location = new Point(0, 0);
            btnProfMeuPerfil.Name = "btnProfMeuPerfil";
            btnProfMeuPerfil.Padding = new Padding(5, 0, 0, 0);
            btnProfMeuPerfil.Size = new Size(177, 52);
            btnProfMeuPerfil.TabIndex = 23;
            btnProfMeuPerfil.Text = "          Meu Perfil";
            btnProfMeuPerfil.UseVisualStyleBackColor = true;
            btnProfMeuPerfil.Click += btnProfMeuPerfil_Click;
            // 
            // panelbtnSairProf
            // 
            panelbtnSairProf.Controls.Add(btnSairProf);
            panelbtnSairProf.Location = new Point(3, 235);
            panelbtnSairProf.Name = "panelbtnSairProf";
            panelbtnSairProf.Size = new Size(177, 52);
            panelbtnSairProf.TabIndex = 59;
            // 
            // btnSairProf
            // 
            btnSairProf.Anchor = AnchorStyles.Left;
            btnSairProf.FlatAppearance.BorderSize = 0;
            btnSairProf.FlatStyle = FlatStyle.Flat;
            btnSairProf.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSairProf.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnSairProf.IconColor = Color.Black;
            btnSairProf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSairProf.ImageAlign = ContentAlignment.MiddleLeft;
            btnSairProf.Location = new Point(3, -3);
            btnSairProf.Name = "btnSairProf";
            btnSairProf.Padding = new Padding(4, 0, 0, 0);
            btnSairProf.Size = new Size(177, 52);
            btnSairProf.TabIndex = 60;
            btnSairProf.Text = "    SAIR";
            btnSairProf.UseVisualStyleBackColor = true;
            btnSairProf.Click += btnSairProf_Click;
            // 
            // panelProf
            // 
            panelProf.Controls.Add(label1);
            panelProf.Dock = DockStyle.Fill;
            panelProf.Location = new Point(180, 42);
            panelProf.Name = "panelProf";
            panelProf.Size = new Size(959, 687);
            panelProf.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 196);
            label1.Name = "label1";
            label1.Size = new Size(705, 256);
            label1.TabIndex = 1;
            label1.Text = "TELA EM \r\nCONSTRUÇÃO";
            // 
            // ProfessorTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 729);
            Controls.Add(panelProf);
            Controls.Add(sidebarProf);
            Controls.Add(panelSuperiorProf);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfessorTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ECOInsight";
            panel2.ResumeLayout(false);
            panelSuperiorProf.ResumeLayout(false);
            panelSuperiorProf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            sidebarProf.ResumeLayout(false);
            panelbtnAProfMenu.ResumeLayout(false);
            panelbtnProfDestaques.ResumeLayout(false);
            panelbtnProfAula.ResumeLayout(false);
            panelbtnProfMPerfil.ResumeLayout(false);
            panelbtnSairProf.ResumeLayout(false);
            panelProf.ResumeLayout(false);
            panelProf.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblAluno;
        private FontAwesome.Sharp.IconButton btnMinimizarProf;
        private FontAwesome.Sharp.IconButton btnMaximizarRestaurarProf;
        private FontAwesome.Sharp.IconButton btnFecharProf;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnProfDestaques;
        private FontAwesome.Sharp.IconButton btnProfMPerfil;
        private FontAwesome.Sharp.IconButton btnProfRelatorio;
        private FontAwesome.Sharp.IconButton btnProfAula;
        private FontAwesome.Sharp.IconButton btnAProfMenu;
        private System.Windows.Forms.Timer sidebarTimerProf;
        private Panel panelSuperiorProf;
        private FlowLayoutPanel sidebarProf;
        private Panel panelbtnAProfMenu;
        private Panel panelbtnProfDestaques;
        private Panel panelbtnProfAula;
        private Panel panelbtnProfMPerfil;
        private FontAwesome.Sharp.IconButton btnProfMeuPerfil;
        private System.Windows.Forms.Timer timerSubAula;
        private Panel panelbtnSairProf;
        private FontAwesome.Sharp.IconButton btnSairProf;
        private Panel panelProf;
        private Label label1;
        private Label lblLogin;
        private PictureBox pictureBox2;
    }
}