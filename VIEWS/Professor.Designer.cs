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
            sidebarProf = new Panel();
            btnProfSair = new FontAwesome.Sharp.IconButton();
            btnAProfMenu = new FontAwesome.Sharp.IconButton();
            btnProfDestaques = new FontAwesome.Sharp.IconButton();
            btnProfMPerfil = new FontAwesome.Sharp.IconButton();
            btnProfRelatorio = new FontAwesome.Sharp.IconButton();
            btnProfAula = new FontAwesome.Sharp.IconButton();
            panelSuperiorProfessor = new Panel();
            btnMinimizarProf = new FontAwesome.Sharp.IconButton();
            lblAluno = new Label();
            btnMaximizarRestaurarProf = new FontAwesome.Sharp.IconButton();
            btnFecharProf = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panelProf = new Panel();
            sidebarTimerProf = new System.Windows.Forms.Timer(components);
            sidebarProf.SuspendLayout();
            panelSuperiorProfessor.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarProf
            // 
            sidebarProf.BackColor = Color.FromArgb(153, 179, 142);
            sidebarProf.Controls.Add(btnProfSair);
            sidebarProf.Controls.Add(btnAProfMenu);
            sidebarProf.Controls.Add(btnProfDestaques);
            sidebarProf.Controls.Add(btnProfMPerfil);
            sidebarProf.Controls.Add(btnProfRelatorio);
            sidebarProf.Controls.Add(btnProfAula);
            sidebarProf.Dock = DockStyle.Left;
            sidebarProf.Location = new Point(0, 40);
            sidebarProf.MaximumSize = new Size(161, 689);
            sidebarProf.MinimumSize = new Size(58, 689);
            sidebarProf.Name = "sidebarProf";
            sidebarProf.Size = new Size(161, 689);
            sidebarProf.TabIndex = 14;
            // 
            // btnProfSair
            // 
            btnProfSair.Anchor = AnchorStyles.Left;
            btnProfSair.FlatAppearance.BorderSize = 0;
            btnProfSair.FlatStyle = FlatStyle.Flat;
            btnProfSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfSair.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnProfSair.IconColor = Color.Black;
            btnProfSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProfSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfSair.Location = new Point(0, 637);
            btnProfSair.Name = "btnProfSair";
            btnProfSair.Padding = new Padding(4, 0, 0, 0);
            btnProfSair.Size = new Size(161, 52);
            btnProfSair.TabIndex = 11;
            btnProfSair.Text = "    SAIR";
            btnProfSair.UseVisualStyleBackColor = true;
            btnProfSair.Click += btnSair_Click;
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
            btnAProfMenu.Size = new Size(161, 52);
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
            btnProfDestaques.Location = new Point(0, 58);
            btnProfDestaques.Name = "btnProfDestaques";
            btnProfDestaques.Padding = new Padding(5, 0, 0, 0);
            btnProfDestaques.Size = new Size(161, 52);
            btnProfDestaques.TabIndex = 23;
            btnProfDestaques.Text = "         Destaques";
            btnProfDestaques.UseVisualStyleBackColor = true;
            btnProfDestaques.Click += btnProfDestaques_Click;
            // 
            // btnProfMPerfil
            // 
            btnProfMPerfil.FlatAppearance.BorderSize = 0;
            btnProfMPerfil.FlatStyle = FlatStyle.Flat;
            btnProfMPerfil.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfMPerfil.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            btnProfMPerfil.IconColor = Color.Black;
            btnProfMPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProfMPerfil.IconSize = 40;
            btnProfMPerfil.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfMPerfil.Location = new Point(0, 232);
            btnProfMPerfil.Name = "btnProfMPerfil";
            btnProfMPerfil.Padding = new Padding(5, 0, 0, 0);
            btnProfMPerfil.Size = new Size(161, 52);
            btnProfMPerfil.TabIndex = 22;
            btnProfMPerfil.Text = "          Meu Perfil";
            btnProfMPerfil.UseVisualStyleBackColor = true;
            btnProfMPerfil.Click += btnProfMPerfil_Click;
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
            btnProfRelatorio.Location = new Point(0, 174);
            btnProfRelatorio.Name = "btnProfRelatorio";
            btnProfRelatorio.Padding = new Padding(5, 0, 0, 0);
            btnProfRelatorio.Size = new Size(161, 52);
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
            btnProfAula.Location = new Point(0, 116);
            btnProfAula.Name = "btnProfAula";
            btnProfAula.Padding = new Padding(5, 0, 0, 0);
            btnProfAula.Size = new Size(161, 52);
            btnProfAula.TabIndex = 20;
            btnProfAula.Text = "Aula";
            btnProfAula.UseVisualStyleBackColor = true;
            btnProfAula.Click += btnProfAula_Click;
            // 
            // panelSuperiorProfessor
            // 
            panelSuperiorProfessor.BackColor = Color.FromArgb(36, 65, 57);
            panelSuperiorProfessor.Controls.Add(btnMinimizarProf);
            panelSuperiorProfessor.Controls.Add(lblAluno);
            panelSuperiorProfessor.Controls.Add(btnMaximizarRestaurarProf);
            panelSuperiorProfessor.Controls.Add(btnFecharProf);
            panelSuperiorProfessor.Controls.Add(panel2);
            panelSuperiorProfessor.Dock = DockStyle.Top;
            panelSuperiorProfessor.Location = new Point(0, 0);
            panelSuperiorProfessor.Name = "panelSuperiorProfessor";
            panelSuperiorProfessor.Size = new Size(1350, 40);
            panelSuperiorProfessor.TabIndex = 13;
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
            btnMinimizarProf.Location = new Point(1208, 3);
            btnMinimizarProf.Name = "btnMinimizarProf";
            btnMinimizarProf.Size = new Size(39, 37);
            btnMinimizarProf.TabIndex = 18;
            btnMinimizarProf.UseVisualStyleBackColor = true;
            btnMinimizarProf.Click += btnMinimizarProf_Click;
            // 
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.FlatStyle = FlatStyle.Flat;
            lblAluno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAluno.ForeColor = SystemColors.ButtonHighlight;
            lblAluno.Location = new Point(616, 9);
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
            btnMaximizarRestaurarProf.Location = new Point(1253, 3);
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
            btnFecharProf.Location = new Point(1298, 3);
            btnFecharProf.Name = "btnFecharProf";
            btnFecharProf.Size = new Size(39, 37);
            btnFecharProf.TabIndex = 15;
            btnFecharProf.UseVisualStyleBackColor = true;
            btnFecharProf.Click += btnFecharProf_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Location = new Point(1201, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 40);
            panel2.TabIndex = 16;
            // 
            // panelProf
            // 
            panelProf.Dock = DockStyle.Fill;
            panelProf.Location = new Point(161, 40);
            panelProf.Name = "panelProf";
            panelProf.Size = new Size(1189, 689);
            panelProf.TabIndex = 15;
            // 
            // sidebarTimerProf
            // 
            sidebarTimerProf.Interval = 10;
            sidebarTimerProf.Tick += sidebarTimerProf_Tick;
            // 
            // ProfessorTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panelProf);
            Controls.Add(sidebarProf);
            Controls.Add(panelSuperiorProfessor);
            Name = "ProfessorTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ECOInsight";
            sidebarProf.ResumeLayout(false);
            panelSuperiorProfessor.ResumeLayout(false);
            panelSuperiorProfessor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarProf;
        private Panel panelSuperiorProfessor;
        private Label lblAluno;
        private FontAwesome.Sharp.IconButton btnMinimizarProf;
        private FontAwesome.Sharp.IconButton btnMaximizarRestaurarProf;
        private FontAwesome.Sharp.IconButton btnFecharProf;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnProfSair;
        private FontAwesome.Sharp.IconButton btnProfDestaques;
        private FontAwesome.Sharp.IconButton btnProfMPerfil;
        private FontAwesome.Sharp.IconButton btnProfRelatorio;
        private FontAwesome.Sharp.IconButton btnProfAula;
        private FontAwesome.Sharp.IconButton btnAProfMenu;
        private Panel panelProf;
        private System.Windows.Forms.Timer sidebarTimerProf;
    }
}