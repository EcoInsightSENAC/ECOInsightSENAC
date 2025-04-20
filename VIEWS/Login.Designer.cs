namespace ECOInsight
{
    partial class LoginTela
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginTela));
            panelSuperiorLogin = new Panel();
            btnMinimizarLogin = new FontAwesome.Sharp.IconButton();
            btnMaximizarRestaurarLogin = new FontAwesome.Sharp.IconButton();
            btnFecharLogin = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            lblLogin = new Label();
            pictureBoxLogo = new PictureBox();
            lblUsuario = new Label();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnEsqueciSenha = new Button();
            btnEntrar = new Button();
            checkBoxLembrarSenha = new CheckBox();
            checkBoxVizualizarSenha = new CheckBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panelSuperiorLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelSuperiorLogin
            // 
            panelSuperiorLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSuperiorLogin.BackColor = Color.FromArgb(32, 65, 57);
            panelSuperiorLogin.Controls.Add(btnMinimizarLogin);
            panelSuperiorLogin.Controls.Add(btnMaximizarRestaurarLogin);
            panelSuperiorLogin.Controls.Add(btnFecharLogin);
            panelSuperiorLogin.Controls.Add(panel3);
            panelSuperiorLogin.Controls.Add(lblLogin);
            panelSuperiorLogin.Location = new Point(0, 0);
            panelSuperiorLogin.Name = "panelSuperiorLogin";
            panelSuperiorLogin.Size = new Size(1064, 40);
            panelSuperiorLogin.TabIndex = 0;
            // 
            // btnMinimizarLogin
            // 
            btnMinimizarLogin.Anchor = AnchorStyles.Right;
            btnMinimizarLogin.FlatAppearance.BorderSize = 0;
            btnMinimizarLogin.FlatStyle = FlatStyle.Flat;
            btnMinimizarLogin.ForeColor = Color.Transparent;
            btnMinimizarLogin.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            btnMinimizarLogin.IconColor = Color.White;
            btnMinimizarLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarLogin.IconSize = 20;
            btnMinimizarLogin.Location = new Point(918, 3);
            btnMinimizarLogin.Name = "btnMinimizarLogin";
            btnMinimizarLogin.Size = new Size(39, 37);
            btnMinimizarLogin.TabIndex = 22;
            btnMinimizarLogin.UseVisualStyleBackColor = true;
            btnMinimizarLogin.Click += btnMinimizarLogin_Click;
            // 
            // btnMaximizarRestaurarLogin
            // 
            btnMaximizarRestaurarLogin.Anchor = AnchorStyles.Right;
            btnMaximizarRestaurarLogin.FlatAppearance.BorderSize = 0;
            btnMaximizarRestaurarLogin.FlatStyle = FlatStyle.Flat;
            btnMaximizarRestaurarLogin.ForeColor = Color.Transparent;
            btnMaximizarRestaurarLogin.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarRestaurarLogin.IconColor = Color.White;
            btnMaximizarRestaurarLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarRestaurarLogin.IconSize = 20;
            btnMaximizarRestaurarLogin.Location = new Point(963, 3);
            btnMaximizarRestaurarLogin.Name = "btnMaximizarRestaurarLogin";
            btnMaximizarRestaurarLogin.Size = new Size(39, 37);
            btnMaximizarRestaurarLogin.TabIndex = 21;
            btnMaximizarRestaurarLogin.UseVisualStyleBackColor = true;
            btnMaximizarRestaurarLogin.Click += btnMaximizarRestaurarLogin_Click;
            // 
            // btnFecharLogin
            // 
            btnFecharLogin.Anchor = AnchorStyles.Right;
            btnFecharLogin.FlatAppearance.BorderSize = 0;
            btnFecharLogin.FlatStyle = FlatStyle.Flat;
            btnFecharLogin.ForeColor = Color.Transparent;
            btnFecharLogin.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnFecharLogin.IconColor = Color.White;
            btnFecharLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFecharLogin.IconSize = 20;
            btnFecharLogin.Location = new Point(1008, 3);
            btnFecharLogin.Name = "btnFecharLogin";
            btnFecharLogin.Size = new Size(39, 37);
            btnFecharLogin.TabIndex = 19;
            btnFecharLogin.UseVisualStyleBackColor = true;
            btnFecharLogin.Click += btnFecharLogin_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Right;
            panel3.Location = new Point(911, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(148, 40);
            panel3.TabIndex = 20;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = SystemColors.ButtonHighlight;
            lblLogin.Location = new Point(12, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(71, 25);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            lblLogin.Click += label1_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.Top;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(542, 106);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(460, 462);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(117, 178);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(86, 25);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuário ";
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.Top;
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(117, 253);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(66, 25);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top;
            txtUsuario.Location = new Point(117, 217);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(314, 23);
            txtUsuario.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top;
            txtSenha.Location = new Point(117, 293);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '•';
            txtSenha.Size = new Size(314, 23);
            txtSenha.TabIndex = 5;
            // 
            // btnEsqueciSenha
            // 
            btnEsqueciSenha.Anchor = AnchorStyles.Top;
            btnEsqueciSenha.FlatAppearance.BorderSize = 0;
            btnEsqueciSenha.FlatStyle = FlatStyle.Flat;
            btnEsqueciSenha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEsqueciSenha.Location = new Point(221, 407);
            btnEsqueciSenha.Name = "btnEsqueciSenha";
            btnEsqueciSenha.Size = new Size(101, 23);
            btnEsqueciSenha.TabIndex = 6;
            btnEsqueciSenha.Text = "Esqueci a Senha";
            btnEsqueciSenha.UseVisualStyleBackColor = true;
            btnEsqueciSenha.Click += btnEsqueciSenha_Click_1;
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.Top;
            btnEntrar.BackColor = Color.FromArgb(35, 68, 57);
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.ButtonHighlight;
            btnEntrar.Location = new Point(221, 455);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(101, 30);
            btnEntrar.TabIndex = 8;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // checkBoxLembrarSenha
            // 
            checkBoxLembrarSenha.Anchor = AnchorStyles.Top;
            checkBoxLembrarSenha.AutoSize = true;
            checkBoxLembrarSenha.Location = new Point(117, 331);
            checkBoxLembrarSenha.Name = "checkBoxLembrarSenha";
            checkBoxLembrarSenha.Size = new Size(105, 19);
            checkBoxLembrarSenha.TabIndex = 9;
            checkBoxLembrarSenha.Text = "Lembrar Senha";
            checkBoxLembrarSenha.UseVisualStyleBackColor = true;
            // 
            // checkBoxVizualizarSenha
            // 
            checkBoxVizualizarSenha.Anchor = AnchorStyles.Top;
            checkBoxVizualizarSenha.AutoSize = true;
            checkBoxVizualizarSenha.Location = new Point(117, 356);
            checkBoxVizualizarSenha.Name = "checkBoxVizualizarSenha";
            checkBoxVizualizarSenha.Size = new Size(110, 19);
            checkBoxVizualizarSenha.TabIndex = 10;
            checkBoxVizualizarSenha.Text = "Vizualizar Senha";
            checkBoxVizualizarSenha.UseVisualStyleBackColor = true;
            checkBoxVizualizarSenha.CheckedChanged += checkBoxVizualizarSenha_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 584);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Location = new Point(503, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(558, 581);
            panel2.TabIndex = 12;
            // 
            // LoginTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1064, 633);
            Controls.Add(btnEsqueciSenha);
            Controls.Add(checkBoxVizualizarSenha);
            Controls.Add(btnEntrar);
            Controls.Add(checkBoxLembrarSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(pictureBoxLogo);
            Controls.Add(panelSuperiorLogin);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "LoginTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ECOInsight";
            Load += LoginTela_Load;
            panelSuperiorLogin.ResumeLayout(false);
            panelSuperiorLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSuperiorLogin;
        private PictureBox pictureBoxLogo;
        private Label lblLogin;
        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnEsqueciSenha;
        private Button btnEntrar;
        private CheckBox checkBoxLembrarSenha;
        private CheckBox checkBoxVizualizarSenha;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnMinimizarLogin;
        private FontAwesome.Sharp.IconButton btnMaximizarRestaurarLogin;
        private FontAwesome.Sharp.IconButton btnFecharLogin;
        private Panel panel3;
    }
}
