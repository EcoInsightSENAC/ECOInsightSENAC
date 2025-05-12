namespace ECOInsightSENAC
{
    partial class FuncionarioTela
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
            components = new System.ComponentModel.Container();
            btnMinimizarFuncionario = new FontAwesome.Sharp.IconButton();
            btnMaximizarRestaurarFuncionario = new FontAwesome.Sharp.IconButton();
            btnFecharFuncionario = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            lblFuncionario = new Label();
            btnFuncionarioDestaques = new FontAwesome.Sharp.IconButton();
            btnFuncionarioSair = new FontAwesome.Sharp.IconButton();
            btnFuncionarioAula = new FontAwesome.Sharp.IconButton();
            btnFuncionarioMenu = new FontAwesome.Sharp.IconButton();
            btnFuncionarioMPerfil = new FontAwesome.Sharp.IconButton();
            sidebarTimerFuncionario = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            lblLogin = new Label();
            sidebarFuncionario = new FlowLayoutPanel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panelFuncionario = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            sidebarFuncionario.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // btnMinimizarFuncionario
            // 
            btnMinimizarFuncionario.Anchor = AnchorStyles.Right;
            btnMinimizarFuncionario.FlatAppearance.BorderSize = 0;
            btnMinimizarFuncionario.FlatStyle = FlatStyle.Flat;
            btnMinimizarFuncionario.ForeColor = Color.Transparent;
            btnMinimizarFuncionario.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            btnMinimizarFuncionario.IconColor = Color.White;
            btnMinimizarFuncionario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizarFuncionario.IconSize = 20;
            btnMinimizarFuncionario.Location = new Point(20, 0);
            btnMinimizarFuncionario.Name = "btnMinimizarFuncionario";
            btnMinimizarFuncionario.Size = new Size(39, 37);
            btnMinimizarFuncionario.TabIndex = 18;
            btnMinimizarFuncionario.UseVisualStyleBackColor = true;
            btnMinimizarFuncionario.Click += btnMinim_Click;
            // 
            // btnMaximizarRestaurarFuncionario
            // 
            btnMaximizarRestaurarFuncionario.Anchor = AnchorStyles.Right;
            btnMaximizarRestaurarFuncionario.FlatAppearance.BorderSize = 0;
            btnMaximizarRestaurarFuncionario.FlatStyle = FlatStyle.Flat;
            btnMaximizarRestaurarFuncionario.ForeColor = Color.Transparent;
            btnMaximizarRestaurarFuncionario.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            btnMaximizarRestaurarFuncionario.IconColor = Color.White;
            btnMaximizarRestaurarFuncionario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizarRestaurarFuncionario.IconSize = 20;
            btnMaximizarRestaurarFuncionario.Location = new Point(65, 0);
            btnMaximizarRestaurarFuncionario.Name = "btnMaximizarRestaurarFuncionario";
            btnMaximizarRestaurarFuncionario.Size = new Size(39, 37);
            btnMaximizarRestaurarFuncionario.TabIndex = 17;
            btnMaximizarRestaurarFuncionario.UseVisualStyleBackColor = true;
            btnMaximizarRestaurarFuncionario.Click += btnMaxPad_Click;
            // 
            // btnFecharFuncionario
            // 
            btnFecharFuncionario.Anchor = AnchorStyles.Right;
            btnFecharFuncionario.FlatAppearance.BorderSize = 0;
            btnFecharFuncionario.FlatStyle = FlatStyle.Flat;
            btnFecharFuncionario.ForeColor = Color.Transparent;
            btnFecharFuncionario.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnFecharFuncionario.IconColor = Color.White;
            btnFecharFuncionario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFecharFuncionario.IconSize = 20;
            btnFecharFuncionario.Location = new Point(110, 0);
            btnFecharFuncionario.Name = "btnFecharFuncionario";
            btnFecharFuncionario.Size = new Size(39, 37);
            btnFecharFuncionario.TabIndex = 15;
            btnFecharFuncionario.UseVisualStyleBackColor = true;
            btnFecharFuncionario.Click += btnFechar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.Controls.Add(btnMinimizarFuncionario);
            panel1.Controls.Add(btnMaximizarRestaurarFuncionario);
            panel1.Controls.Add(btnFecharFuncionario);
            panel1.Location = new Point(988, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(148, 40);
            panel1.TabIndex = 16;
            // 
            // lblFuncionario
            // 
            lblFuncionario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFuncionario.AutoSize = true;
            lblFuncionario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuncionario.ForeColor = SystemColors.ButtonHighlight;
            lblFuncionario.Location = new Point(498, 9);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(143, 25);
            lblFuncionario.TabIndex = 0;
            lblFuncionario.Text = "FUNCIONÁRIO";
            // 
            // btnFuncionarioDestaques
            // 
            btnFuncionarioDestaques.FlatAppearance.BorderSize = 0;
            btnFuncionarioDestaques.FlatStyle = FlatStyle.Flat;
            btnFuncionarioDestaques.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFuncionarioDestaques.IconChar = FontAwesome.Sharp.IconChar.Bullhorn;
            btnFuncionarioDestaques.IconColor = Color.Black;
            btnFuncionarioDestaques.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFuncionarioDestaques.IconSize = 40;
            btnFuncionarioDestaques.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuncionarioDestaques.Location = new Point(-3, 0);
            btnFuncionarioDestaques.Name = "btnFuncionarioDestaques";
            btnFuncionarioDestaques.Padding = new Padding(7, 0, 0, 0);
            btnFuncionarioDestaques.Size = new Size(177, 52);
            btnFuncionarioDestaques.TabIndex = 23;
            btnFuncionarioDestaques.Text = "         Destaques";
            btnFuncionarioDestaques.UseVisualStyleBackColor = true;
            btnFuncionarioDestaques.Click += btnFuncionarioDestaques_Click;
            // 
            // btnFuncionarioSair
            // 
            btnFuncionarioSair.Anchor = AnchorStyles.Left;
            btnFuncionarioSair.FlatAppearance.BorderSize = 0;
            btnFuncionarioSair.FlatStyle = FlatStyle.Flat;
            btnFuncionarioSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFuncionarioSair.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnFuncionarioSair.IconColor = Color.Black;
            btnFuncionarioSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFuncionarioSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuncionarioSair.Location = new Point(3, 3);
            btnFuncionarioSair.Name = "btnFuncionarioSair";
            btnFuncionarioSair.Padding = new Padding(4, 0, 0, 0);
            btnFuncionarioSair.Size = new Size(177, 52);
            btnFuncionarioSair.TabIndex = 30;
            btnFuncionarioSair.Text = "    SAIR";
            btnFuncionarioSair.UseVisualStyleBackColor = true;
            btnFuncionarioSair.Click += btnFuncionarioSair_Click;
            // 
            // btnFuncionarioAula
            // 
            btnFuncionarioAula.FlatAppearance.BorderSize = 0;
            btnFuncionarioAula.FlatStyle = FlatStyle.Flat;
            btnFuncionarioAula.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFuncionarioAula.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            btnFuncionarioAula.IconColor = Color.Black;
            btnFuncionarioAula.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFuncionarioAula.IconSize = 40;
            btnFuncionarioAula.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuncionarioAula.Location = new Point(-3, 0);
            btnFuncionarioAula.Name = "btnFuncionarioAula";
            btnFuncionarioAula.Padding = new Padding(7, 0, 0, 0);
            btnFuncionarioAula.Size = new Size(177, 52);
            btnFuncionarioAula.TabIndex = 20;
            btnFuncionarioAula.Text = "       Registros";
            btnFuncionarioAula.UseVisualStyleBackColor = true;
            btnFuncionarioAula.Click += btnFuncionarioAula_Click;
            // 
            // btnFuncionarioMenu
            // 
            btnFuncionarioMenu.Cursor = Cursors.Hand;
            btnFuncionarioMenu.FlatAppearance.BorderSize = 0;
            btnFuncionarioMenu.FlatStyle = FlatStyle.Flat;
            btnFuncionarioMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFuncionarioMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnFuncionarioMenu.IconColor = Color.Black;
            btnFuncionarioMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFuncionarioMenu.IconSize = 40;
            btnFuncionarioMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuncionarioMenu.Location = new Point(0, 0);
            btnFuncionarioMenu.Name = "btnFuncionarioMenu";
            btnFuncionarioMenu.Padding = new Padding(7, 0, 0, 0);
            btnFuncionarioMenu.Size = new Size(177, 52);
            btnFuncionarioMenu.TabIndex = 29;
            btnFuncionarioMenu.Text = " Menu";
            btnFuncionarioMenu.UseVisualStyleBackColor = true;
            btnFuncionarioMenu.Click += btnFuncionarioMenu_Click;
            // 
            // btnFuncionarioMPerfil
            // 
            btnFuncionarioMPerfil.FlatAppearance.BorderSize = 0;
            btnFuncionarioMPerfil.FlatStyle = FlatStyle.Flat;
            btnFuncionarioMPerfil.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFuncionarioMPerfil.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            btnFuncionarioMPerfil.IconColor = Color.Black;
            btnFuncionarioMPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFuncionarioMPerfil.IconSize = 40;
            btnFuncionarioMPerfil.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuncionarioMPerfil.Location = new Point(-3, 0);
            btnFuncionarioMPerfil.Name = "btnFuncionarioMPerfil";
            btnFuncionarioMPerfil.Padding = new Padding(7, 0, 0, 0);
            btnFuncionarioMPerfil.Size = new Size(177, 52);
            btnFuncionarioMPerfil.TabIndex = 22;
            btnFuncionarioMPerfil.Text = "          Meu Perfil";
            btnFuncionarioMPerfil.UseVisualStyleBackColor = true;
            btnFuncionarioMPerfil.Click += btnFuncionarioMPerfil_Click;
            // 
            // sidebarTimerFuncionario
            // 
            sidebarTimerFuncionario.Interval = 10;
            sidebarTimerFuncionario.Tick += sidebarTimerFuncionario_Tick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 65, 57);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblLogin);
            panel2.Controls.Add(lblFuncionario);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1139, 42);
            panel2.TabIndex = 22;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = ECOInsight.Properties.Resources.LogoEcoInsght;
            pictureBox2.Location = new Point(12, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
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
            lblLogin.TabIndex = 25;
            lblLogin.Text = "EcoBoard";
            // 
            // sidebarFuncionario
            // 
            sidebarFuncionario.BackColor = Color.FromArgb(153, 179, 142);
            sidebarFuncionario.Controls.Add(panel3);
            sidebarFuncionario.Controls.Add(panel4);
            sidebarFuncionario.Controls.Add(panel5);
            sidebarFuncionario.Controls.Add(panel6);
            sidebarFuncionario.Controls.Add(panel7);
            sidebarFuncionario.Dock = DockStyle.Left;
            sidebarFuncionario.Location = new Point(0, 42);
            sidebarFuncionario.Name = "sidebarFuncionario";
            sidebarFuncionario.Size = new Size(180, 687);
            sidebarFuncionario.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnFuncionarioMenu);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(177, 52);
            panel3.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnFuncionarioDestaques);
            panel4.Location = new Point(3, 61);
            panel4.Name = "panel4";
            panel4.Size = new Size(177, 52);
            panel4.TabIndex = 26;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnFuncionarioAula);
            panel5.Location = new Point(3, 119);
            panel5.Name = "panel5";
            panel5.Size = new Size(177, 52);
            panel5.TabIndex = 26;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnFuncionarioMPerfil);
            panel6.Location = new Point(3, 177);
            panel6.Name = "panel6";
            panel6.Size = new Size(177, 52);
            panel6.TabIndex = 26;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnFuncionarioSair);
            panel7.Location = new Point(3, 235);
            panel7.Name = "panel7";
            panel7.Size = new Size(177, 52);
            panel7.TabIndex = 26;
            // 
            // panelFuncionario
            // 
            panelFuncionario.Dock = DockStyle.Fill;
            panelFuncionario.Location = new Point(180, 42);
            panelFuncionario.Name = "panelFuncionario";
            panelFuncionario.Size = new Size(959, 687);
            panelFuncionario.TabIndex = 57;
            // 
            // FuncionarioTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 729);
            Controls.Add(panelFuncionario);
            Controls.Add(sidebarFuncionario);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FuncionarioTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ECOInsight";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            sidebarFuncionario.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblFuncionario;
        private FontAwesome.Sharp.IconButton btnMinimizarFuncionario;
        private FontAwesome.Sharp.IconButton btnMaximizarRestaurarFuncionario;
        private FontAwesome.Sharp.IconButton btnFecharFuncionario;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnFuncionarioMenu;
        private FontAwesome.Sharp.IconButton btnFuncionarioDestaques;
        private FontAwesome.Sharp.IconButton btnFuncionarioMPerfil;
        private FontAwesome.Sharp.IconButton btnFuncionarioAula;
        private FontAwesome.Sharp.IconButton btnFuncionarioSair;
        private System.Windows.Forms.Timer sidebarTimerFuncionario;
        private Panel panel2;
        private FlowLayoutPanel sidebarFuncionario;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panelFuncionario;
        private PictureBox pictureBox2;
        private Label lblLogin;
    }
}
