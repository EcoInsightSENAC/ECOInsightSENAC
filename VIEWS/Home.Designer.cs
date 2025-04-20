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
            panelSuperiorHome = new Panel();
            btnMinimizarHome = new FontAwesome.Sharp.IconButton();
            btnMaximizarRestaurarHome = new FontAwesome.Sharp.IconButton();
            btnFecharHome = new FontAwesome.Sharp.IconButton();
            lblHome = new Label();
            panel2 = new Panel();
            sidebarHome = new Panel();
            btnSair = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnAluno = new FontAwesome.Sharp.IconButton();
            btnProfessor = new FontAwesome.Sharp.IconButton();
            btnGestor = new FontAwesome.Sharp.IconButton();
            timer1 = new System.Windows.Forms.Timer(components);
            panelSuperiorHome.SuspendLayout();
            sidebarHome.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperiorHome
            // 
            panelSuperiorHome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSuperiorHome.BackColor = Color.FromArgb(36, 65, 57);
            panelSuperiorHome.Controls.Add(btnMinimizarHome);
            panelSuperiorHome.Controls.Add(btnMaximizarRestaurarHome);
            panelSuperiorHome.Controls.Add(btnFecharHome);
            panelSuperiorHome.Controls.Add(lblHome);
            panelSuperiorHome.Controls.Add(panel2);
            panelSuperiorHome.Location = new Point(0, 0);
            panelSuperiorHome.Name = "panelSuperiorHome";
            panelSuperiorHome.Size = new Size(1350, 40);
            panelSuperiorHome.TabIndex = 6;
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
            btnMinimizarHome.Location = new Point(1209, 3);
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
            btnMaximizarRestaurarHome.Location = new Point(1254, 3);
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
            btnFecharHome.Location = new Point(1299, 3);
            btnFecharHome.Name = "btnFecharHome";
            btnFecharHome.Size = new Size(39, 37);
            btnFecharHome.TabIndex = 8;
            btnFecharHome.UseVisualStyleBackColor = true;
            btnFecharHome.Click += btnFecharHome_Click;
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHome.ForeColor = SystemColors.ButtonHighlight;
            lblHome.Location = new Point(641, 9);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(69, 25);
            lblHome.TabIndex = 0;
            lblHome.Text = "HOME";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Location = new Point(1202, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 40);
            panel2.TabIndex = 8;
            // 
            // sidebarHome
            // 
            sidebarHome.BackColor = Color.FromArgb(153, 179, 142);
            sidebarHome.Controls.Add(btnSair);
            sidebarHome.Controls.Add(iconButton2);
            sidebarHome.Controls.Add(iconButton1);
            sidebarHome.Controls.Add(btnAluno);
            sidebarHome.Controls.Add(btnProfessor);
            sidebarHome.Controls.Add(btnGestor);
            sidebarHome.Dock = DockStyle.Left;
            sidebarHome.Location = new Point(0, 0);
            sidebarHome.MaximumSize = new Size(161, 729);
            sidebarHome.MinimumSize = new Size(55, 729);
            sidebarHome.Name = "sidebarHome";
            sidebarHome.Size = new Size(161, 729);
            sidebarHome.TabIndex = 7;
            sidebarHome.Paint += panelEsquerdo_Paint;
            // 
            // btnSair
            // 
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnSair.IconColor = Color.Black;
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSair.IconSize = 40;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(0, 677);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(4, 0, 0, 0);
            btnSair.Size = new Size(161, 52);
            btnSair.TabIndex = 8;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click_1;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Bars;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 40;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 40);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(7, 0, 0, 0);
            iconButton2.Size = new Size(161, 52);
            iconButton2.TabIndex = 21;
            iconButton2.Text = "   Menu";
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(-3, 214);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(5, 0, 0, 0);
            iconButton1.Size = new Size(161, 52);
            iconButton1.TabIndex = 20;
            iconButton1.Text = "           Funcionário";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click_1;
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
            btnAluno.Location = new Point(0, 272);
            btnAluno.Name = "btnAluno";
            btnAluno.Padding = new Padding(5, 0, 0, 0);
            btnAluno.Size = new Size(161, 52);
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
            btnProfessor.Location = new Point(-3, 156);
            btnProfessor.Name = "btnProfessor";
            btnProfessor.Padding = new Padding(5, 0, 0, 0);
            btnProfessor.Size = new Size(161, 52);
            btnProfessor.TabIndex = 17;
            btnProfessor.Text = "      Professor";
            btnProfessor.UseVisualStyleBackColor = true;
            btnProfessor.Click += btnProf_Click;
            // 
            // btnGestor
            // 
            btnGestor.FlatAppearance.BorderSize = 0;
            btnGestor.FlatStyle = FlatStyle.Flat;
            btnGestor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestor.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            btnGestor.IconColor = Color.Black;
            btnGestor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGestor.IconSize = 40;
            btnGestor.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestor.Location = new Point(0, 98);
            btnGestor.Name = "btnGestor";
            btnGestor.Padding = new Padding(5, 0, 0, 0);
            btnGestor.Size = new Size(161, 52);
            btnGestor.TabIndex = 16;
            btnGestor.Text = " Adm";
            btnGestor.UseVisualStyleBackColor = true;
            btnGestor.Click += btnGest_Click;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // HomeTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panelSuperiorHome);
            Controls.Add(sidebarHome);
            Name = "HomeTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ECOInsight";
            Load += HomeTela_Load;
            panelSuperiorHome.ResumeLayout(false);
            panelSuperiorHome.PerformLayout();
            sidebarHome.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelSuperiorHome;
        private Label lblHome;
        private Panel sidebarHome;
        private FontAwesome.Sharp.IconButton btnFecharHome;
        private FontAwesome.Sharp.IconButton btnMinimizarHome;
        private FontAwesome.Sharp.IconButton btnMaximizarRestaurarHome;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnSair; 
    
        private FontAwesome.Sharp.IconButton btnGestor;
        private FontAwesome.Sharp.IconButton btnProfessor;
        private FontAwesome.Sharp.IconButton btnAluno;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Timer timer1;
    }
}