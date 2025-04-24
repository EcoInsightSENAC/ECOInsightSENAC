namespace ECOInsight.UserControls
{
    partial class UCAluno_Aulas
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
            panel1 = new Panel();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            lblAlunoAulas = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(iconButton8);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(lblAlunoAulas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 39);
            panel1.TabIndex = 63;
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
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(3, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(39, 34);
            iconButton1.TabIndex = 71;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // lblAlunoAulas
            // 
            lblAlunoAulas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAlunoAulas.AutoSize = true;
            lblAlunoAulas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlunoAulas.ForeColor = Color.Black;
            lblAlunoAulas.Location = new Point(455, 7);
            lblAlunoAulas.Name = "lblAlunoAulas";
            lblAlunoAulas.Size = new Size(73, 25);
            lblAlunoAulas.TabIndex = 68;
            lblAlunoAulas.Text = "AULAS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(137, 195);
            label1.Name = "label1";
            label1.Size = new Size(705, 256);
            label1.TabIndex = 64;
            label1.Text = "TELA EM \r\nCONSTRUÇÃO";
            // 
            // UCAluno_Aulas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "UCAluno_Aulas";
            Size = new Size(978, 646);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label lblAlunoAulas;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
    }
}
