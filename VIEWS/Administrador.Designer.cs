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
            components = new System.ComponentModel.Container();
            btnAdmMenu = new FontAwesome.Sharp.IconButton();
            btnSair = new FontAwesome.Sharp.IconButton();
            btnAdmDestaques = new FontAwesome.Sharp.IconButton();
            btnAdmMPerfil = new FontAwesome.Sharp.IconButton();
            btnAdmUsuario = new FontAwesome.Sharp.IconButton();
            btnAdmRelatorio = new FontAwesome.Sharp.IconButton();
            btnMinimizarAdm = new FontAwesome.Sharp.IconButton();
            btnMaximizarRestaurarAdm = new FontAwesome.Sharp.IconButton();
            btnFecharAdm = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            lblAdm = new Label();
            sidebarTimerAdm = new System.Windows.Forms.Timer(components);
            btnVoltarPagEsqueciSenha = new FontAwesome.Sharp.IconButton();
            panelSubRelatorioAdm = new Panel();
            btnAdmGerarRelatorio = new FontAwesome.Sharp.IconButton();
            panelbtnAdmSair = new Panel();
            panelbtnAdmMeuPer = new Panel();
            panelSubUsuarios = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panelSuperiorAdm = new Panel();
            lblLogin = new Label();
            panel1 = new Panel();
            btnMaximizarRestaurarHome = new FontAwesome.Sharp.IconButton();
            btnFecharHome = new FontAwesome.Sharp.IconButton();
            btnMinimizarHome = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            btnMinimizarAluno = new FontAwesome.Sharp.IconButton();
            btnMaximizarRestaurarAluno = new FontAwesome.Sharp.IconButton();
            btnFecharAluno = new FontAwesome.Sharp.IconButton();
            sidebarAdm = new FlowLayoutPanel();
            panelbtnAdmMenu = new Panel();
            panelbtnAdmDestaques = new Panel();
            timerSubRelatorio = new System.Windows.Forms.Timer(components);
            timerSubUsuarios = new System.Windows.Forms.Timer(components);
            panelAdm = new Panel();
            panel2.SuspendLayout();
            panelSubRelatorioAdm.SuspendLayout();
            panelbtnAdmSair.SuspendLayout();
            panelbtnAdmMeuPer.SuspendLayout();
            panelSubUsuarios.SuspendLayout();
            panelSuperiorAdm.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            sidebarAdm.SuspendLayout();
            panelbtnAdmMenu.SuspendLayout();
            panelbtnAdmDestaques.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdmMenu
            // 
            btnAdmMenu.Cursor = Cursors.Hand;
            btnAdmMenu.FlatAppearance.BorderSize = 0;
            btnAdmMenu.FlatStyle = FlatStyle.Flat;
            btnAdmMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnAdmMenu.IconColor = Color.Black;
            btnAdmMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmMenu.IconSize = 40;
            btnAdmMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmMenu.Location = new Point(0, 0);
            btnAdmMenu.Name = "btnAdmMenu";
            btnAdmMenu.Padding = new Padding(7, 0, 0, 0);
            btnAdmMenu.Size = new Size(177, 52);
            btnAdmMenu.TabIndex = 29;
            btnAdmMenu.Text = " Menu";
            btnAdmMenu.UseVisualStyleBackColor = true;
            btnAdmMenu.Click += btnAdmMenu_Click;
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
            btnSair.Location = new Point(0, -3);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(4, 0, 0, 0);
            btnSair.Size = new Size(177, 52);
            btnSair.TabIndex = 10;
            btnSair.Text = "    SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnAdmDestaques
            // 
            btnAdmDestaques.FlatAppearance.BorderSize = 0;
            btnAdmDestaques.FlatStyle = FlatStyle.Flat;
            btnAdmDestaques.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmDestaques.IconChar = FontAwesome.Sharp.IconChar.Bullhorn;
            btnAdmDestaques.IconColor = Color.Black;
            btnAdmDestaques.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmDestaques.IconSize = 40;
            btnAdmDestaques.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmDestaques.Location = new Point(0, 0);
            btnAdmDestaques.Name = "btnAdmDestaques";
            btnAdmDestaques.Padding = new Padding(7, 0, 0, 0);
            btnAdmDestaques.Size = new Size(177, 52);
            btnAdmDestaques.TabIndex = 23;
            btnAdmDestaques.Text = "      Destaques";
            btnAdmDestaques.UseVisualStyleBackColor = true;
            btnAdmDestaques.Click += btnAdmDestaques_Click_1;
            // 
            // btnAdmMPerfil
            // 
            btnAdmMPerfil.FlatAppearance.BorderSize = 0;
            btnAdmMPerfil.FlatStyle = FlatStyle.Flat;
            btnAdmMPerfil.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmMPerfil.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            btnAdmMPerfil.IconColor = Color.Black;
            btnAdmMPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmMPerfil.IconSize = 40;
            btnAdmMPerfil.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmMPerfil.Location = new Point(-3, 0);
            btnAdmMPerfil.Name = "btnAdmMPerfil";
            btnAdmMPerfil.Padding = new Padding(7, 0, 0, 0);
            btnAdmMPerfil.Size = new Size(180, 52);
            btnAdmMPerfil.TabIndex = 22;
            btnAdmMPerfil.Text = "       Meu Perfil";
            btnAdmMPerfil.UseVisualStyleBackColor = true;
            btnAdmMPerfil.Click += btnAdmMPerfil_Click;
            // 
            // btnAdmUsuario
            // 
            btnAdmUsuario.BackColor = Color.FromArgb(153, 179, 142);
            btnAdmUsuario.FlatAppearance.BorderSize = 0;
            btnAdmUsuario.FlatStyle = FlatStyle.Flat;
            btnAdmUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmUsuario.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            btnAdmUsuario.IconColor = Color.Black;
            btnAdmUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmUsuario.IconSize = 40;
            btnAdmUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmUsuario.Location = new Point(0, -3);
            btnAdmUsuario.Name = "btnAdmUsuario";
            btnAdmUsuario.Padding = new Padding(7, 0, 0, 0);
            btnAdmUsuario.Size = new Size(177, 52);
            btnAdmUsuario.TabIndex = 21;
            btnAdmUsuario.Text = "     Usuários";
            btnAdmUsuario.UseVisualStyleBackColor = false;
            btnAdmUsuario.Click += btnAdmUsuario_Click;
            // 
            // btnAdmRelatorio
            // 
            btnAdmRelatorio.BackColor = Color.FromArgb(153, 179, 142);
            btnAdmRelatorio.FlatAppearance.BorderSize = 0;
            btnAdmRelatorio.FlatStyle = FlatStyle.Flat;
            btnAdmRelatorio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmRelatorio.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            btnAdmRelatorio.IconColor = Color.Black;
            btnAdmRelatorio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmRelatorio.IconSize = 40;
            btnAdmRelatorio.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmRelatorio.Location = new Point(0, -3);
            btnAdmRelatorio.Name = "btnAdmRelatorio";
            btnAdmRelatorio.Padding = new Padding(7, 0, 0, 0);
            btnAdmRelatorio.Size = new Size(177, 56);
            btnAdmRelatorio.TabIndex = 20;
            btnAdmRelatorio.Text = "      Registros";
            btnAdmRelatorio.UseVisualStyleBackColor = false;
            btnAdmRelatorio.Click += btnAdmRelatorio_Click_1;
            // 
            // btnMinimizarAdm
            // 
            btnMinimizarAdm.Anchor = AnchorStyles.Right;
            btnMinimizarAdm.FlatAppearance.BorderSize = 0;
            btnMinimizarAdm.FlatStyle = FlatStyle.Flat;
            btnMinimizarAdm.ForeColor = Color.Transparent;
            btnMinimizarAdm.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            btnMinimizarAdm.IconColor = Color.White;
            btnMinimizarAdm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarAdm.IconSize = 20;
            btnMinimizarAdm.Location = new Point(18, 3);
            btnMinimizarAdm.Name = "btnMinimizarAdm";
            btnMinimizarAdm.Size = new Size(39, 37);
            btnMinimizarAdm.TabIndex = 14;
            btnMinimizarAdm.UseVisualStyleBackColor = true;
            btnMinimizarAdm.Click += btnMinimizarAdm_Click;
            // 
            // btnMaximizarRestaurarAdm
            // 
            btnMaximizarRestaurarAdm.Anchor = AnchorStyles.Right;
            btnMaximizarRestaurarAdm.FlatAppearance.BorderSize = 0;
            btnMaximizarRestaurarAdm.FlatStyle = FlatStyle.Flat;
            btnMaximizarRestaurarAdm.ForeColor = Color.Transparent;
            btnMaximizarRestaurarAdm.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarRestaurarAdm.IconColor = Color.White;
            btnMaximizarRestaurarAdm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarRestaurarAdm.IconSize = 20;
            btnMaximizarRestaurarAdm.Location = new Point(63, 3);
            btnMaximizarRestaurarAdm.Name = "btnMaximizarRestaurarAdm";
            btnMaximizarRestaurarAdm.Size = new Size(39, 37);
            btnMaximizarRestaurarAdm.TabIndex = 13;
            btnMaximizarRestaurarAdm.UseVisualStyleBackColor = true;
            btnMaximizarRestaurarAdm.Click += btnMaximizarRestaurarAdm_Click;
            // 
            // btnFecharAdm
            // 
            btnFecharAdm.Anchor = AnchorStyles.Right;
            btnFecharAdm.FlatAppearance.BorderSize = 0;
            btnFecharAdm.FlatStyle = FlatStyle.Flat;
            btnFecharAdm.ForeColor = Color.Transparent;
            btnFecharAdm.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnFecharAdm.IconColor = Color.White;
            btnFecharAdm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFecharAdm.IconSize = 20;
            btnFecharAdm.Location = new Point(108, 3);
            btnFecharAdm.Name = "btnFecharAdm";
            btnFecharAdm.Size = new Size(39, 37);
            btnFecharAdm.TabIndex = 11;
            btnFecharAdm.UseVisualStyleBackColor = true;
            btnFecharAdm.Click += btnFecharAdm_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Controls.Add(btnMinimizarAdm);
            panel2.Controls.Add(btnMaximizarRestaurarAdm);
            panel2.Controls.Add(btnFecharAdm);
            panel2.Location = new Point(988, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 40);
            panel2.TabIndex = 12;
            // 
            // lblAdm
            // 
            lblAdm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAdm.AutoSize = true;
            lblAdm.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdm.ForeColor = SystemColors.ButtonHighlight;
            lblAdm.Location = new Point(456, 9);
            lblAdm.Name = "lblAdm";
            lblAdm.Size = new Size(171, 25);
            lblAdm.TabIndex = 0;
            lblAdm.Text = "ADMINISTRADOR";
            // 
            // sidebarTimerAdm
            // 
            sidebarTimerAdm.Interval = 10;
            sidebarTimerAdm.Tick += sidebarTimerAdm_Tick;
            // 
            // btnVoltarPagEsqueciSenha
            // 
            btnVoltarPagEsqueciSenha.FlatAppearance.BorderSize = 0;
            btnVoltarPagEsqueciSenha.FlatStyle = FlatStyle.Flat;
            btnVoltarPagEsqueciSenha.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            btnVoltarPagEsqueciSenha.IconColor = Color.Black;
            btnVoltarPagEsqueciSenha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVoltarPagEsqueciSenha.IconSize = 25;
            btnVoltarPagEsqueciSenha.Location = new Point(3, 3);
            btnVoltarPagEsqueciSenha.Name = "btnVoltarPagEsqueciSenha";
            btnVoltarPagEsqueciSenha.Size = new Size(39, 34);
            btnVoltarPagEsqueciSenha.TabIndex = 21;
            btnVoltarPagEsqueciSenha.UseVisualStyleBackColor = true;
            btnVoltarPagEsqueciSenha.Click += btnVoltarPagEsqueciSenha_Click;
            // 
            // panelSubRelatorioAdm
            // 
            panelSubRelatorioAdm.Controls.Add(btnAdmGerarRelatorio);
            panelSubRelatorioAdm.Controls.Add(btnAdmRelatorio);
            panelSubRelatorioAdm.Location = new Point(3, 119);
            panelSubRelatorioAdm.Name = "panelSubRelatorioAdm";
            panelSubRelatorioAdm.Size = new Size(177, 62);
            panelSubRelatorioAdm.TabIndex = 58;
            // 
            // btnAdmGerarRelatorio
            // 
            btnAdmGerarRelatorio.FlatAppearance.BorderSize = 0;
            btnAdmGerarRelatorio.FlatStyle = FlatStyle.Flat;
            btnAdmGerarRelatorio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmGerarRelatorio.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            btnAdmGerarRelatorio.IconColor = Color.Black;
            btnAdmGerarRelatorio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmGerarRelatorio.IconSize = 40;
            btnAdmGerarRelatorio.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmGerarRelatorio.Location = new Point(0, 57);
            btnAdmGerarRelatorio.Name = "btnAdmGerarRelatorio";
            btnAdmGerarRelatorio.Padding = new Padding(7, 0, 0, 0);
            btnAdmGerarRelatorio.Size = new Size(177, 52);
            btnAdmGerarRelatorio.TabIndex = 21;
            btnAdmGerarRelatorio.Text = "          Gerar Relátorio";
            btnAdmGerarRelatorio.TextAlign = ContentAlignment.MiddleRight;
            btnAdmGerarRelatorio.UseVisualStyleBackColor = true;
            btnAdmGerarRelatorio.Click += btnAdmGerarRelatorio_Click;
            // 
            // panelbtnAdmSair
            // 
            panelbtnAdmSair.Controls.Add(btnSair);
            panelbtnAdmSair.Location = new Point(3, 304);
            panelbtnAdmSair.Name = "panelbtnAdmSair";
            panelbtnAdmSair.Size = new Size(177, 52);
            panelbtnAdmSair.TabIndex = 58;
            // 
            // panelbtnAdmMeuPer
            // 
            panelbtnAdmMeuPer.Controls.Add(btnAdmMPerfil);
            panelbtnAdmMeuPer.Location = new Point(3, 246);
            panelbtnAdmMeuPer.Name = "panelbtnAdmMeuPer";
            panelbtnAdmMeuPer.Size = new Size(177, 52);
            panelbtnAdmMeuPer.TabIndex = 58;
            // 
            // panelSubUsuarios
            // 
            panelSubUsuarios.Controls.Add(iconButton1);
            panelSubUsuarios.Controls.Add(btnAdmUsuario);
            panelSubUsuarios.Location = new Point(3, 187);
            panelSubUsuarios.Name = "panelSubUsuarios";
            panelSubUsuarios.Size = new Size(177, 53);
            panelSubUsuarios.TabIndex = 58;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 50);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(7, 0, 0, 0);
            iconButton1.Size = new Size(177, 52);
            iconButton1.TabIndex = 22;
            iconButton1.Text = "     Usuários";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // panelSuperiorAdm
            // 
            panelSuperiorAdm.BackColor = Color.FromArgb(36, 65, 57);
            panelSuperiorAdm.Controls.Add(lblLogin);
            panelSuperiorAdm.Controls.Add(panel1);
            panelSuperiorAdm.Controls.Add(panel3);
            panelSuperiorAdm.Controls.Add(lblAdm);
            panelSuperiorAdm.Controls.Add(panel2);
            panelSuperiorAdm.Dock = DockStyle.Top;
            panelSuperiorAdm.Location = new Point(0, 0);
            panelSuperiorAdm.Name = "panelSuperiorAdm";
            panelSuperiorAdm.Size = new Size(1139, 42);
            panelSuperiorAdm.TabIndex = 34;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = SystemColors.ButtonHighlight;
            lblLogin.Location = new Point(12, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(86, 21);
            lblLogin.TabIndex = 59;
            lblLogin.Text = "ECOBoard";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.Controls.Add(btnMaximizarRestaurarHome);
            panel1.Controls.Add(btnFecharHome);
            panel1.Controls.Add(btnMinimizarHome);
            panel1.Location = new Point(2866, -58);
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
            btnMaximizarRestaurarHome.Location = new Point(-43, -60);
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
            btnFecharHome.Location = new Point(2, -60);
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
            btnMinimizarHome.Location = new Point(-88, -60);
            btnMinimizarHome.Name = "btnMinimizarHome";
            btnMinimizarHome.Size = new Size(39, 37);
            btnMinimizarHome.TabIndex = 10;
            btnMinimizarHome.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Right;
            panel3.Controls.Add(btnMinimizarAluno);
            panel3.Controls.Add(btnMaximizarRestaurarAluno);
            panel3.Controls.Add(btnFecharAluno);
            panel3.Location = new Point(1927, -26);
            panel3.Name = "panel3";
            panel3.Size = new Size(148, 40);
            panel3.TabIndex = 14;
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
            btnMinimizarAluno.Location = new Point(-34, -30);
            btnMinimizarAluno.Name = "btnMinimizarAluno";
            btnMinimizarAluno.Size = new Size(39, 37);
            btnMinimizarAluno.TabIndex = 16;
            btnMinimizarAluno.UseVisualStyleBackColor = true;
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
            btnMaximizarRestaurarAluno.Location = new Point(11, -30);
            btnMaximizarRestaurarAluno.Name = "btnMaximizarRestaurarAluno";
            btnMaximizarRestaurarAluno.Size = new Size(39, 37);
            btnMaximizarRestaurarAluno.TabIndex = 15;
            btnMaximizarRestaurarAluno.UseVisualStyleBackColor = true;
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
            btnFecharAluno.Location = new Point(56, -30);
            btnFecharAluno.Name = "btnFecharAluno";
            btnFecharAluno.Size = new Size(39, 37);
            btnFecharAluno.TabIndex = 13;
            btnFecharAluno.UseVisualStyleBackColor = true;
            // 
            // sidebarAdm
            // 
            sidebarAdm.BackColor = Color.FromArgb(153, 179, 142);
            sidebarAdm.Controls.Add(panelbtnAdmMenu);
            sidebarAdm.Controls.Add(panelbtnAdmDestaques);
            sidebarAdm.Controls.Add(panelSubRelatorioAdm);
            sidebarAdm.Controls.Add(panelSubUsuarios);
            sidebarAdm.Controls.Add(panelbtnAdmMeuPer);
            sidebarAdm.Controls.Add(panelbtnAdmSair);
            sidebarAdm.Dock = DockStyle.Left;
            sidebarAdm.Location = new Point(0, 42);
            sidebarAdm.Name = "sidebarAdm";
            sidebarAdm.Size = new Size(180, 687);
            sidebarAdm.TabIndex = 35;
            // 
            // panelbtnAdmMenu
            // 
            panelbtnAdmMenu.Controls.Add(btnAdmMenu);
            panelbtnAdmMenu.Location = new Point(3, 3);
            panelbtnAdmMenu.Name = "panelbtnAdmMenu";
            panelbtnAdmMenu.Size = new Size(177, 52);
            panelbtnAdmMenu.TabIndex = 57;
            // 
            // panelbtnAdmDestaques
            // 
            panelbtnAdmDestaques.Controls.Add(btnAdmDestaques);
            panelbtnAdmDestaques.Location = new Point(3, 61);
            panelbtnAdmDestaques.Name = "panelbtnAdmDestaques";
            panelbtnAdmDestaques.Size = new Size(177, 52);
            panelbtnAdmDestaques.TabIndex = 58;
            // 
            // timerSubRelatorio
            // 
            timerSubRelatorio.Interval = 10;
            timerSubRelatorio.Tick += timerSubRelatorio_Tick;
            // 
            // timerSubUsuarios
            // 
            timerSubUsuarios.Interval = 10;
            timerSubUsuarios.Tick += timerSubUsuarios_Tick;
            // 
            // panelAdm
            // 
            panelAdm.Dock = DockStyle.Fill;
            panelAdm.Location = new Point(180, 42);
            panelAdm.Name = "panelAdm";
            panelAdm.Size = new Size(959, 687);
            panelAdm.TabIndex = 58;
            // 
            // AdmTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 729);
            Controls.Add(panelAdm);
            Controls.Add(sidebarAdm);
            Controls.Add(panelSuperiorAdm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdmTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ECOInsight";
            panel2.ResumeLayout(false);
            panelSubRelatorioAdm.ResumeLayout(false);
            panelbtnAdmSair.ResumeLayout(false);
            panelbtnAdmMeuPer.ResumeLayout(false);
            panelSubUsuarios.ResumeLayout(false);
            panelSuperiorAdm.ResumeLayout(false);
            panelSuperiorAdm.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            sidebarAdm.ResumeLayout(false);
            panelbtnAdmMenu.ResumeLayout(false);
            panelbtnAdmDestaques.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblAdm;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnAdmDestaques;
        private FontAwesome.Sharp.IconButton btnAdmMPerfil;
        private FontAwesome.Sharp.IconButton btnAdmUsuario;
        private FontAwesome.Sharp.IconButton btnAdmRelatorio;
        private FontAwesome.Sharp.IconButton btnMinimizarAdm;
        private FontAwesome.Sharp.IconButton btnMaximizarRestaurarAdm;
        private FontAwesome.Sharp.IconButton btnFecharAdm;
        private Panel panel2;
        private System.Windows.Forms.Timer sidebarTimerAdm;
        private FontAwesome.Sharp.IconButton btnAdmMenu;
        private FontAwesome.Sharp.IconButton btnVoltarPagEsqueciSenha;
        private Panel panelSuperiorAdm;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnMaximizarRestaurarHome;
        private FontAwesome.Sharp.IconButton btnFecharHome;
        private FontAwesome.Sharp.IconButton btnMinimizarHome;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnMinimizarAluno;
        private FontAwesome.Sharp.IconButton btnMaximizarRestaurarAluno;
        private FontAwesome.Sharp.IconButton btnFecharAluno;
        private FlowLayoutPanel sidebarAdm;
        private Panel panelbtnAdmMenu;
        private Panel panelbtnAdmDestaques;
        private Panel panelSubRelatorioAdm;
        private Panel panelSubUsuarios;
        private Panel panelbtnAdmMeuPer;
        private Panel panelbtnAdmSair;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnAdmGerarRelatorio;
        private System.Windows.Forms.Timer timerSubRelatorio;
        private System.Windows.Forms.Timer timerSubUsuarios;
        private Panel panelAdm;
        private Label lblLogin;
    }
}