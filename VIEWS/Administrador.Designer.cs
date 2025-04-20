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
            sidebarAdm = new Panel();
            btnAdmMenu = new FontAwesome.Sharp.IconButton();
            btnSair = new FontAwesome.Sharp.IconButton();
            btnAdmDestaques = new FontAwesome.Sharp.IconButton();
            btnAdmMPerfil = new FontAwesome.Sharp.IconButton();
            btnAdmUsuario = new FontAwesome.Sharp.IconButton();
            btnAdmRelatorio = new FontAwesome.Sharp.IconButton();
            panelSuperiorAdm = new Panel();
            btnMinimizarAdm = new FontAwesome.Sharp.IconButton();
            btnMaximizarRestaurarAdm = new FontAwesome.Sharp.IconButton();
            btnFecharAdm = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            lblAdm = new Label();
            panelAdm = new Panel();
            sidebarTimerAdm = new System.Windows.Forms.Timer(components);
            sidebarAdm.SuspendLayout();
            panelSuperiorAdm.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarAdm
            // 
            sidebarAdm.BackColor = Color.FromArgb(153, 179, 142);
            sidebarAdm.Controls.Add(btnAdmMenu);
            sidebarAdm.Controls.Add(btnSair);
            sidebarAdm.Controls.Add(btnAdmDestaques);
            sidebarAdm.Controls.Add(btnAdmMPerfil);
            sidebarAdm.Controls.Add(btnAdmUsuario);
            sidebarAdm.Controls.Add(btnAdmRelatorio);
            sidebarAdm.Dock = DockStyle.Left;
            sidebarAdm.Location = new Point(0, 40);
            sidebarAdm.MaximumSize = new Size(161, 689);
            sidebarAdm.MinimumSize = new Size(60, 689);
            sidebarAdm.Name = "sidebarAdm";
            sidebarAdm.Size = new Size(161, 689);
            sidebarAdm.TabIndex = 10;
            sidebarAdm.Resize += sidebarAdm_Resize;
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
            btnAdmMenu.Size = new Size(161, 52);
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
            btnSair.Location = new Point(0, 637);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(4, 0, 0, 0);
            btnSair.Size = new Size(161, 52);
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
            btnAdmDestaques.Location = new Point(0, 58);
            btnAdmDestaques.Name = "btnAdmDestaques";
            btnAdmDestaques.Padding = new Padding(7, 0, 0, 0);
            btnAdmDestaques.Size = new Size(161, 52);
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
            btnAdmMPerfil.Location = new Point(0, 232);
            btnAdmMPerfil.Name = "btnAdmMPerfil";
            btnAdmMPerfil.Padding = new Padding(7, 0, 0, 0);
            btnAdmMPerfil.Size = new Size(161, 52);
            btnAdmMPerfil.TabIndex = 22;
            btnAdmMPerfil.Text = "       Meu Perfil";
            btnAdmMPerfil.UseVisualStyleBackColor = true;
            btnAdmMPerfil.Click += btnAdmMPerfil_Click;
            // 
            // btnAdmUsuario
            // 
            btnAdmUsuario.FlatAppearance.BorderSize = 0;
            btnAdmUsuario.FlatStyle = FlatStyle.Flat;
            btnAdmUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmUsuario.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            btnAdmUsuario.IconColor = Color.Black;
            btnAdmUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmUsuario.IconSize = 40;
            btnAdmUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmUsuario.Location = new Point(0, 174);
            btnAdmUsuario.Name = "btnAdmUsuario";
            btnAdmUsuario.Padding = new Padding(7, 0, 0, 0);
            btnAdmUsuario.Size = new Size(161, 52);
            btnAdmUsuario.TabIndex = 21;
            btnAdmUsuario.Text = "     Usuários";
            btnAdmUsuario.UseVisualStyleBackColor = true;
            btnAdmUsuario.Click += btnAdmUsuario_Click;
            // 
            // btnAdmRelatorio
            // 
            btnAdmRelatorio.FlatAppearance.BorderSize = 0;
            btnAdmRelatorio.FlatStyle = FlatStyle.Flat;
            btnAdmRelatorio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmRelatorio.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            btnAdmRelatorio.IconColor = Color.Black;
            btnAdmRelatorio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmRelatorio.IconSize = 40;
            btnAdmRelatorio.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmRelatorio.Location = new Point(0, 116);
            btnAdmRelatorio.Name = "btnAdmRelatorio";
            btnAdmRelatorio.Padding = new Padding(7, 0, 0, 0);
            btnAdmRelatorio.Size = new Size(161, 52);
            btnAdmRelatorio.TabIndex = 20;
            btnAdmRelatorio.Text = "         Relatórios";
            btnAdmRelatorio.UseVisualStyleBackColor = true;
            btnAdmRelatorio.Click += btnAdmRelatorio_Click_1;
            // 
            // panelSuperiorAdm
            // 
            panelSuperiorAdm.BackColor = Color.FromArgb(36, 65, 57);
            panelSuperiorAdm.Controls.Add(btnMinimizarAdm);
            panelSuperiorAdm.Controls.Add(btnMaximizarRestaurarAdm);
            panelSuperiorAdm.Controls.Add(btnFecharAdm);
            panelSuperiorAdm.Controls.Add(panel2);
            panelSuperiorAdm.Controls.Add(lblAdm);
            panelSuperiorAdm.Dock = DockStyle.Top;
            panelSuperiorAdm.Location = new Point(0, 0);
            panelSuperiorAdm.Name = "panelSuperiorAdm";
            panelSuperiorAdm.Size = new Size(1350, 40);
            panelSuperiorAdm.TabIndex = 9;
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
            btnMinimizarAdm.Location = new Point(1208, 3);
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
            btnMaximizarRestaurarAdm.Location = new Point(1253, 3);
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
            btnFecharAdm.Location = new Point(1298, 3);
            btnFecharAdm.Name = "btnFecharAdm";
            btnFecharAdm.Size = new Size(39, 37);
            btnFecharAdm.TabIndex = 11;
            btnFecharAdm.UseVisualStyleBackColor = true;
            btnFecharAdm.Click += btnFecharAdm_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Location = new Point(1201, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 40);
            panel2.TabIndex = 12;
            // 
            // lblAdm
            // 
            lblAdm.AutoSize = true;
            lblAdm.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdm.ForeColor = SystemColors.ButtonHighlight;
            lblAdm.Location = new Point(590, 9);
            lblAdm.Name = "lblAdm";
            lblAdm.Size = new Size(171, 25);
            lblAdm.TabIndex = 0;
            lblAdm.Text = "ADMINISTRADOR";
            // 
            // panelAdm
            // 
            panelAdm.Dock = DockStyle.Fill;
            panelAdm.Location = new Point(161, 40);
            panelAdm.Name = "panelAdm";
            panelAdm.Size = new Size(1189, 689);
            panelAdm.TabIndex = 11;
            // 
            // sidebarTimerAdm
            // 
            sidebarTimerAdm.Interval = 10;
            sidebarTimerAdm.Tick += sidebarTimerAdm_Tick;
            // 
            // AdmTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panelAdm);
            Controls.Add(sidebarAdm);
            Controls.Add(panelSuperiorAdm);
            Name = "AdmTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ECOInsight";
            sidebarAdm.ResumeLayout(false);
            panelSuperiorAdm.ResumeLayout(false);
            panelSuperiorAdm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarAdm;
        private Panel panelSuperiorAdm;
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
        private Panel panelAdm;
        private System.Windows.Forms.Timer sidebarTimerAdm;
        private FontAwesome.Sharp.IconButton btnAdmMenu;
    }
}