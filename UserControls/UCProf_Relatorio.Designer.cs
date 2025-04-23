namespace ECOInsight.UserControls
{
    partial class UCProf_Relatorio
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            lblFuncionarioHome = new Label();
            btnVoltarPagEsqueciSenha = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 259);
            label1.Name = "label1";
            label1.Size = new Size(471, 128);
            label1.TabIndex = 1;
            label1.Text = "Registros";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(iconButton8);
            panel1.Controls.Add(lblFuncionarioHome);
            panel1.Controls.Add(btnVoltarPagEsqueciSenha);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 39);
            panel1.TabIndex = 3;
            // 
            // iconButton8
            // 
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            iconButton8.IconColor = Color.Black;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 25;
            iconButton8.Location = new Point(48, 2);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(39, 34);
            iconButton8.TabIndex = 72;
            iconButton8.UseVisualStyleBackColor = true;
            // 
            // lblFuncionarioHome
            // 
            lblFuncionarioHome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFuncionarioHome.AutoSize = true;
            lblFuncionarioHome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuncionarioHome.ForeColor = Color.Black;
            lblFuncionarioHome.Location = new Point(433, 7);
            lblFuncionarioHome.Name = "lblFuncionarioHome";
            lblFuncionarioHome.Size = new Size(113, 25);
            lblFuncionarioHome.TabIndex = 68;
            lblFuncionarioHome.Text = "REGISTROS";
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
            btnVoltarPagEsqueciSenha.TabIndex = 71;
            btnVoltarPagEsqueciSenha.UseVisualStyleBackColor = true;
            // 
            // UCProf_Relatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "UCProf_Relatorio";
            Size = new Size(978, 646);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label lblFuncionarioHome;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton btnVoltarPagEsqueciSenha;
    }
}
