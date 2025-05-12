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
            components = new System.ComponentModel.Container();
            btnMinimizarHome = new FontAwesome.Sharp.IconButton();
            btnMaximizarRestaurarHome = new FontAwesome.Sharp.IconButton();
            btnFecharHome = new FontAwesome.Sharp.IconButton();
            lblHome = new Label();
            panel2 = new Panel();
            btnAluno = new FontAwesome.Sharp.IconButton();
            btnProfessor = new FontAwesome.Sharp.IconButton();
            btnFuncionario = new FontAwesome.Sharp.IconButton();
            btnMenu = new FontAwesome.Sharp.IconButton();
            btnAdm = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel4 = new Panel();
            panelSub = new Panel();
            btnSub2 = new FontAwesome.Sharp.IconButton();
            btnSub1 = new FontAwesome.Sharp.IconButton();
            panel8 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panelSuperiorHome = new Panel();
            pictureBox2 = new PictureBox();
            lblLogin = new Label();
            sidebarHome = new FlowLayoutPanel();
            btnSair = new FontAwesome.Sharp.IconButton();
            timerSub = new System.Windows.Forms.Timer(components);
            sidebarhome2 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panelSub.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panelSuperiorHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            sidebarHome.SuspendLayout();
            SuspendLayout();
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
            btnMinimizarHome.Location = new Point(16, 0);
            btnMinimizarHome.Name = "btnMinimizarHome";
            btnMinimizarHome.Size = new Size(39, 37);
            btnMinimizarHome.TabIndex = 10;
            btnMinimizarHome.UseVisualStyleBackColor = true;
            btnMinimizarHome.Click += btnMinimizarHome_Click;
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
            btnMaximizarRestaurarHome.Location = new Point(61, 0);
            btnMaximizarRestaurarHome.Name = "btnMaximizarRestaurarHome";
            btnMaximizarRestaurarHome.Size = new Size(39, 37);
            btnMaximizarRestaurarHome.TabIndex = 9;
            btnMaximizarRestaurarHome.UseVisualStyleBackColor = true;
            btnMaximizarRestaurarHome.Click += btnMaximizarRestaurarHome_Click;
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
            btnFecharHome.Location = new Point(106, 0);
            btnFecharHome.Name = "btnFecharHome";
            btnFecharHome.Size = new Size(39, 37);
            btnFecharHome.TabIndex = 8;
            btnFecharHome.UseVisualStyleBackColor = true;
            btnFecharHome.Click += btnFecharHome_Click;
            // 
            // lblHome
            // 
            lblHome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHome.AutoSize = true;
            lblHome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHome.ForeColor = SystemColors.ButtonHighlight;
            lblHome.Location = new Point(535, 9);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(69, 25);
            lblHome.TabIndex = 0;
            lblHome.Text = "HOME";
            lblHome.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Controls.Add(btnMaximizarRestaurarHome);
            panel2.Controls.Add(btnFecharHome);
            panel2.Controls.Add(btnMinimizarHome);
            panel2.Location = new Point(988, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 40);
            panel2.TabIndex = 8;
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
            btnAluno.Location = new Point(0, 0);
            btnAluno.Name = "btnAluno";
            btnAluno.Padding = new Padding(5, 0, 0, 0);
            btnAluno.Size = new Size(176, 52);
            btnAluno.TabIndex = 18;
            btnAluno.Text = "  Aluno";
            btnAluno.UseVisualStyleBackColor = true;
            btnAluno.Click += iconButton1_Click;
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
            btnProfessor.Location = new Point(-3, 0);
            btnProfessor.Name = "btnProfessor";
            btnProfessor.Padding = new Padding(5, 0, 0, 0);
            btnProfessor.Size = new Size(179, 52);
            btnProfessor.TabIndex = 17;
            btnProfessor.Text = "      Professor";
            btnProfessor.UseVisualStyleBackColor = true;
            btnProfessor.Click += btnProf_Click;
            // 
            // btnFuncionario
            // 
            btnFuncionario.FlatAppearance.BorderSize = 0;
            btnFuncionario.FlatStyle = FlatStyle.Flat;
            btnFuncionario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFuncionario.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnFuncionario.IconColor = Color.Black;
            btnFuncionario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFuncionario.IconSize = 40;
            btnFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuncionario.Location = new Point(-3, 3);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Padding = new Padding(5, 0, 0, 0);
            btnFuncionario.Size = new Size(179, 52);
            btnFuncionario.TabIndex = 20;
            btnFuncionario.Text = "           Funcionário";
            btnFuncionario.UseVisualStyleBackColor = true;
            btnFuncionario.Click += iconButton1_Click_1;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnMenu.IconColor = Color.Black;
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.IconSize = 40;
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(7, 0, 0, 0);
            btnMenu.Size = new Size(176, 52);
            btnMenu.TabIndex = 21;
            btnMenu.Text = "   Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
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
            btnAdm.Location = new Point(0, 0);
            btnAdm.Name = "btnAdm";
            btnAdm.Padding = new Padding(5, 0, 0, 0);
            btnAdm.Size = new Size(176, 52);
            btnAdm.TabIndex = 16;
            btnAdm.Text = " Adm";
            btnAdm.UseVisualStyleBackColor = true;
            btnAdm.Click += btnGest_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(438, 331);
            label1.Name = "label1";
            label1.Size = new Size(388, 65);
            label1.TabIndex = 8;
            label1.Text = "Tela Temporaria";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnMenu);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(176, 52);
            panel4.TabIndex = 29;
            // 
            // panelSub
            // 
            panelSub.Controls.Add(btnSub2);
            panelSub.Controls.Add(btnSub1);
            panelSub.Controls.Add(btnFuncionario);
            panelSub.Location = new Point(3, 119);
            panelSub.Name = "panelSub";
            panelSub.Size = new Size(176, 58);
            panelSub.TabIndex = 31;
            // 
            // btnSub2
            // 
            btnSub2.FlatAppearance.BorderSize = 0;
            btnSub2.FlatStyle = FlatStyle.Flat;
            btnSub2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSub2.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnSub2.IconColor = Color.Black;
            btnSub2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSub2.IconSize = 40;
            btnSub2.ImageAlign = ContentAlignment.MiddleLeft;
            btnSub2.Location = new Point(-3, 105);
            btnSub2.Name = "btnSub2";
            btnSub2.Padding = new Padding(5, 0, 0, 0);
            btnSub2.Size = new Size(179, 52);
            btnSub2.TabIndex = 22;
            btnSub2.Text = "           Sub 02";
            btnSub2.UseVisualStyleBackColor = true;
            // 
            // btnSub1
            // 
            btnSub1.FlatAppearance.BorderSize = 0;
            btnSub1.FlatStyle = FlatStyle.Flat;
            btnSub1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSub1.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnSub1.IconColor = Color.Black;
            btnSub1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSub1.IconSize = 40;
            btnSub1.ImageAlign = ContentAlignment.MiddleLeft;
            btnSub1.Location = new Point(-3, 56);
            btnSub1.Name = "btnSub1";
            btnSub1.Padding = new Padding(5, 0, 0, 0);
            btnSub1.Size = new Size(179, 52);
            btnSub1.TabIndex = 21;
            btnSub1.Text = "           Sub 01";
            btnSub1.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnProfessor);
            panel8.Location = new Point(3, 241);
            panel8.Name = "panel8";
            panel8.Size = new Size(176, 52);
            panel8.TabIndex = 31;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnAluno);
            panel6.Location = new Point(3, 183);
            panel6.Name = "panel6";
            panel6.Size = new Size(176, 52);
            panel6.TabIndex = 30;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnAdm);
            panel5.Location = new Point(3, 61);
            panel5.Name = "panel5";
            panel5.Size = new Size(176, 52);
            panel5.TabIndex = 29;
            // 
            // panelSuperiorHome
            // 
            panelSuperiorHome.BackColor = Color.FromArgb(36, 65, 57);
            panelSuperiorHome.Controls.Add(pictureBox2);
            panelSuperiorHome.Controls.Add(lblLogin);
            panelSuperiorHome.Controls.Add(panel2);
            panelSuperiorHome.Controls.Add(lblHome);
            panelSuperiorHome.Dock = DockStyle.Top;
            panelSuperiorHome.Location = new Point(0, 0);
            panelSuperiorHome.Name = "panelSuperiorHome";
            panelSuperiorHome.Size = new Size(1139, 42);
            panelSuperiorHome.TabIndex = 32;
            panelSuperiorHome.MouseDown += panelSuperiorHome_MouseDown;
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
            lblLogin.Size = new Size(82, 21);
            lblLogin.TabIndex = 18;
            lblLogin.Text = "EcoBoard";
            // 
            // sidebarHome
            // 
            sidebarHome.BackColor = Color.FromArgb(153, 179, 142);
            sidebarHome.Controls.Add(panel4);
            sidebarHome.Controls.Add(panel5);
            sidebarHome.Controls.Add(panelSub);
            sidebarHome.Controls.Add(panel6);
            sidebarHome.Controls.Add(panel8);
            sidebarHome.Controls.Add(btnSair);
            sidebarHome.Dock = DockStyle.Left;
            sidebarHome.Location = new Point(0, 42);
            sidebarHome.Name = "sidebarHome";
            sidebarHome.Size = new Size(180, 687);
            sidebarHome.TabIndex = 33;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnSair.IconColor = Color.Black;
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(3, 299);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(4, 0, 0, 0);
            btnSair.Size = new Size(176, 52);
            btnSair.TabIndex = 34;
            btnSair.Text = "    SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // timerSub
            // 
            timerSub.Interval = 10;
            timerSub.Tick += timerSub_Tick;
            // 
            // sidebarhome2
            // 
            sidebarhome2.Interval = 10;
            sidebarhome2.Tick += sidebarhome2_Tick;
            // 
            // HomeTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 729);
            Controls.Add(sidebarHome);
            Controls.Add(panelSuperiorHome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ECOInsight";
            Load += HomeTela_Load;
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panelSub.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panelSuperiorHome.ResumeLayout(false);
            panelSuperiorHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            sidebarHome.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHome;
        private FontAwesome.Sharp.IconButton btnFecharHome;
        private FontAwesome.Sharp.IconButton btnMinimizarHome;
        private FontAwesome.Sharp.IconButton btnMaximizarRestaurarHome;
        private Panel panel2;
    
        private FontAwesome.Sharp.IconButton btnAdm;
        private FontAwesome.Sharp.IconButton btnProfessor;
        private FontAwesome.Sharp.IconButton btnAluno;
        private FontAwesome.Sharp.IconButton btnFuncionario;
        private FontAwesome.Sharp.IconButton btnMenu;
        private Label label1;
        private Panel panel4;
        private Panel panel8;
        private Panel panel5;
        private Panel panel6;
        private Panel panelSub;
        private FontAwesome.Sharp.IconButton btnSub1;
        private Panel panelSuperiorHome;
        private FontAwesome.Sharp.IconButton btnSub2;
        private FlowLayoutPanel sidebarHome;
        private FontAwesome.Sharp.IconButton btnSair;
        private System.Windows.Forms.Timer timerSub;
        private System.Windows.Forms.Timer sidebarhome2;
        private Label lblLogin;
        private PictureBox pictureBox2;
    }
}