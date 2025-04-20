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
            panelSuperiorGestor = new Panel();
            btnMinimizarFuncionario = new FontAwesome.Sharp.IconButton();
            btnMaximizarRestaurarFuncionario = new FontAwesome.Sharp.IconButton();
            btnFecharFuncionario = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            iconMinim = new FontAwesome.Sharp.IconButton();
            iconMax = new FontAwesome.Sharp.IconButton();
            iconX = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            lblFuncionario = new Label();
            sidebarFuncionario = new Panel();
            btnFuncionarioDestaques = new FontAwesome.Sharp.IconButton();
            btnFuncionarioSair = new FontAwesome.Sharp.IconButton();
            btnFuncionarioAula = new FontAwesome.Sharp.IconButton();
            btnProfSair = new FontAwesome.Sharp.IconButton();
            btnFuncionarioMenu = new FontAwesome.Sharp.IconButton();
            btnFuncionarioMPerfil = new FontAwesome.Sharp.IconButton();
            panelFuncionario = new Panel();
            sidebarTimerFuncionario = new System.Windows.Forms.Timer(components);
            panelSuperiorGestor.SuspendLayout();
            sidebarFuncionario.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperiorGestor
            // 
            panelSuperiorGestor.BackColor = Color.FromArgb(36, 65, 57);
            panelSuperiorGestor.Controls.Add(btnMinimizarFuncionario);
            panelSuperiorGestor.Controls.Add(btnMaximizarRestaurarFuncionario);
            panelSuperiorGestor.Controls.Add(btnFecharFuncionario);
            panelSuperiorGestor.Controls.Add(panel1);
            panelSuperiorGestor.Controls.Add(iconMinim);
            panelSuperiorGestor.Controls.Add(iconMax);
            panelSuperiorGestor.Controls.Add(iconX);
            panelSuperiorGestor.Controls.Add(panel2);
            panelSuperiorGestor.Controls.Add(lblFuncionario);
            panelSuperiorGestor.Dock = DockStyle.Top;
            panelSuperiorGestor.Location = new Point(0, 0);
            panelSuperiorGestor.Name = "panelSuperiorGestor";
            panelSuperiorGestor.Size = new Size(1350, 40);
            panelSuperiorGestor.TabIndex = 10;
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
            btnMinimizarFuncionario.Location = new Point(1208, 3);
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
            btnMaximizarRestaurarFuncionario.Location = new Point(1253, 3);
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
            btnFecharFuncionario.Location = new Point(1298, 3);
            btnFecharFuncionario.Name = "btnFecharFuncionario";
            btnFecharFuncionario.Size = new Size(39, 37);
            btnFecharFuncionario.TabIndex = 15;
            btnFecharFuncionario.UseVisualStyleBackColor = true;
            btnFecharFuncionario.Click += btnFechar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.Location = new Point(1201, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(148, 40);
            panel1.TabIndex = 16;
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
            iconMinim.Location = new Point(2072, -27);
            iconMinim.Name = "iconMinim";
            iconMinim.Size = new Size(39, 37);
            iconMinim.TabIndex = 14;
            iconMinim.UseVisualStyleBackColor = true;
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
            iconMax.Location = new Point(2117, -27);
            iconMax.Name = "iconMax";
            iconMax.Size = new Size(39, 37);
            iconMax.TabIndex = 13;
            iconMax.UseVisualStyleBackColor = true;
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
            iconX.Location = new Point(2162, -27);
            iconX.Name = "iconX";
            iconX.Size = new Size(39, 37);
            iconX.TabIndex = 11;
            iconX.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Location = new Point(2065, -30);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 40);
            panel2.TabIndex = 12;
            // 
            // lblFuncionario
            // 
            lblFuncionario.AutoSize = true;
            lblFuncionario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuncionario.ForeColor = SystemColors.ButtonHighlight;
            lblFuncionario.Location = new Point(639, 9);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(143, 25);
            lblFuncionario.TabIndex = 0;
            lblFuncionario.Text = "FUNCIONÁRIO";
            // 
            // sidebarFuncionario
            // 
            sidebarFuncionario.BackColor = Color.FromArgb(153, 179, 142);
            sidebarFuncionario.Controls.Add(btnFuncionarioDestaques);
            sidebarFuncionario.Controls.Add(btnFuncionarioSair);
            sidebarFuncionario.Controls.Add(btnFuncionarioAula);
            sidebarFuncionario.Controls.Add(btnProfSair);
            sidebarFuncionario.Controls.Add(btnFuncionarioMenu);
            sidebarFuncionario.Controls.Add(btnFuncionarioMPerfil);
            sidebarFuncionario.Dock = DockStyle.Left;
            sidebarFuncionario.Location = new Point(0, 40);
            sidebarFuncionario.MaximumSize = new Size(161, 689);
            sidebarFuncionario.MinimumSize = new Size(58, 689);
            sidebarFuncionario.Name = "sidebarFuncionario";
            sidebarFuncionario.Size = new Size(161, 689);
            sidebarFuncionario.TabIndex = 15;
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
            btnFuncionarioDestaques.Location = new Point(0, 58);
            btnFuncionarioDestaques.Name = "btnFuncionarioDestaques";
            btnFuncionarioDestaques.Padding = new Padding(7, 0, 0, 0);
            btnFuncionarioDestaques.Size = new Size(161, 52);
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
            btnFuncionarioSair.Location = new Point(0, 637);
            btnFuncionarioSair.Name = "btnFuncionarioSair";
            btnFuncionarioSair.Padding = new Padding(4, 0, 0, 0);
            btnFuncionarioSair.Size = new Size(161, 52);
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
            btnFuncionarioAula.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            btnFuncionarioAula.IconColor = Color.Black;
            btnFuncionarioAula.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFuncionarioAula.IconSize = 40;
            btnFuncionarioAula.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuncionarioAula.Location = new Point(0, 116);
            btnFuncionarioAula.Name = "btnFuncionarioAula";
            btnFuncionarioAula.Padding = new Padding(7, 0, 0, 0);
            btnFuncionarioAula.Size = new Size(161, 52);
            btnFuncionarioAula.TabIndex = 20;
            btnFuncionarioAula.Text = "       Relatório";
            btnFuncionarioAula.UseVisualStyleBackColor = true;
            btnFuncionarioAula.Click += btnFuncionarioAula_Click;
            // 
            // btnProfSair
            // 
            btnProfSair.Anchor = AnchorStyles.Left;
            btnProfSair.FlatAppearance.BorderSize = 0;
            btnProfSair.FlatStyle = FlatStyle.Flat;
            btnProfSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfSair.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnProfSair.IconColor = Color.Black;
            btnProfSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProfSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfSair.Location = new Point(0, 910);
            btnProfSair.Name = "btnProfSair";
            btnProfSair.Padding = new Padding(7, 0, 0, 0);
            btnProfSair.Size = new Size(155, 70);
            btnProfSair.TabIndex = 11;
            btnProfSair.Text = "    SAIR";
            btnProfSair.UseVisualStyleBackColor = true;
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
            btnFuncionarioMenu.Size = new Size(161, 52);
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
            btnFuncionarioMPerfil.Location = new Point(0, 174);
            btnFuncionarioMPerfil.Name = "btnFuncionarioMPerfil";
            btnFuncionarioMPerfil.Padding = new Padding(7, 0, 0, 0);
            btnFuncionarioMPerfil.Size = new Size(161, 52);
            btnFuncionarioMPerfil.TabIndex = 22;
            btnFuncionarioMPerfil.Text = "          Meu Perfil";
            btnFuncionarioMPerfil.UseVisualStyleBackColor = true;
            btnFuncionarioMPerfil.Click += btnFuncionarioMPerfil_Click;
            // 
            // panelFuncionario
            // 
            panelFuncionario.Dock = DockStyle.Fill;
            panelFuncionario.Location = new Point(161, 40);
            panelFuncionario.Name = "panelFuncionario";
            panelFuncionario.Size = new Size(1189, 689);
            panelFuncionario.TabIndex = 16;
            // 
            // sidebarTimerFuncionario
            // 
            sidebarTimerFuncionario.Interval = 10;
            sidebarTimerFuncionario.Tick += sidebarTimerFuncionario_Tick;
            // 
            // FuncionarioTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panelFuncionario);
            Controls.Add(sidebarFuncionario);
            Controls.Add(panelSuperiorGestor);
            Name = "FuncionarioTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ECOInsight";
            panelSuperiorGestor.ResumeLayout(false);
            panelSuperiorGestor.PerformLayout();
            sidebarFuncionario.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperiorGestor;
        private FontAwesome.Sharp.IconButton iconMinim;
        private FontAwesome.Sharp.IconButton iconMax;
        private FontAwesome.Sharp.IconButton iconX;
        private Panel panel2;
        private Label lblFuncionario;
        private FontAwesome.Sharp.IconButton btnMinimizarFuncionario;
        private FontAwesome.Sharp.IconButton btnMaximizarRestaurarFuncionario;
        private FontAwesome.Sharp.IconButton btnFecharFuncionario;
        private Panel panel1;
        private Panel sidebarFuncionario;
        private FontAwesome.Sharp.IconButton btnProfSair;
        private FontAwesome.Sharp.IconButton btnFuncionarioMenu;
        private FontAwesome.Sharp.IconButton btnFuncionarioDestaques;
        private FontAwesome.Sharp.IconButton btnFuncionarioMPerfil;
        private FontAwesome.Sharp.IconButton btnFuncionarioAula;
        private FontAwesome.Sharp.IconButton btnFuncionarioSair;
        private Panel panelFuncionario;
        private System.Windows.Forms.Timer sidebarTimerFuncionario;
    }
}
