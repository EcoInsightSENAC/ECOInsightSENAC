namespace ECOInsight.UserControls
{
    partial class UCAdmGerarRelatorio
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
            lblFiltros = new Label();
            txtLixoOrganico = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker3 = new DateTimePicker();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            comboBox3 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            comboBox4 = new ComboBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            label1 = new Label();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            lblAlunoAulas = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFiltros
            // 
            lblFiltros.Anchor = AnchorStyles.Top;
            lblFiltros.AutoSize = true;
            lblFiltros.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltros.ForeColor = Color.FromArgb(35, 68, 57);
            lblFiltros.Location = new Point(54, 61);
            lblFiltros.Name = "lblFiltros";
            lblFiltros.Size = new Size(77, 30);
            lblFiltros.TabIndex = 46;
            lblFiltros.Text = "Filtros";
            // 
            // txtLixoOrganico
            // 
            txtLixoOrganico.Anchor = AnchorStyles.Top;
            txtLixoOrganico.Location = new Point(52, 289);
            txtLixoOrganico.Multiline = true;
            txtLixoOrganico.Name = "txtLixoOrganico";
            txtLixoOrganico.Size = new Size(878, 102);
            txtLixoOrganico.TabIndex = 47;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.Font = new Font("Segoe UI", 11F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(272, 33);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 27);
            dateTimePicker1.TabIndex = 55;
            dateTimePicker1.Value = new DateTime(2025, 4, 20, 22, 40, 38, 0);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 36);
            label2.Name = "label2";
            label2.Size = new Size(152, 21);
            label2.TabIndex = 54;
            label2.Text = "Gerar Relatório de: ";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Anchor = AnchorStyles.Top;
            dateTimePicker3.Font = new Font("Segoe UI", 11F);
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(463, 33);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(100, 27);
            dateTimePicker3.TabIndex = 52;
            dateTimePicker3.Value = new DateTime(2025, 4, 20, 22, 40, 38, 0);
            // 
            // iconButton6
            // 
            iconButton6.Anchor = AnchorStyles.Top;
            iconButton6.BackColor = Color.FromArgb(35, 68, 57);
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton6.ForeColor = Color.White;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            iconButton6.IconColor = Color.White;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 25;
            iconButton6.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton6.Location = new Point(597, 26);
            iconButton6.Name = "iconButton6";
            iconButton6.Padding = new Padding(5, 0, 0, 0);
            iconButton6.Size = new Size(113, 41);
            iconButton6.TabIndex = 53;
            iconButton6.Text = "Gerar PDF";
            iconButton6.TextAlign = ContentAlignment.MiddleRight;
            iconButton6.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(413, 36);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 51;
            label4.Text = "Até: ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 118);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 56;
            label3.Text = "Tipo de Material: ";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(199, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 23);
            comboBox1.TabIndex = 57;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(514, 117);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(147, 23);
            comboBox2.TabIndex = 59;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(400, 118);
            label5.Name = "label5";
            label5.Size = new Size(108, 21);
            label5.TabIndex = 58;
            label5.Text = "Tipo de Lixo: ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(706, 118);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 60;
            label6.Text = "Destino: ";
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Top;
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(786, 117);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(147, 23);
            comboBox3.TabIndex = 61;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(50, 246);
            label7.Name = "label7";
            label7.Size = new Size(209, 21);
            label7.TabIndex = 62;
            label7.Text = "Inserir outras informações: ";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(58, 182);
            label8.Name = "label8";
            label8.Size = new Size(135, 21);
            label8.TabIndex = 63;
            label8.Text = "Quem descartou:";
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.Top;
            comboBox4.FlatStyle = FlatStyle.Flat;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(202, 181);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(147, 23);
            comboBox4.TabIndex = 64;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top;
            iconButton1.BackColor = Color.White;
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(35, 68, 57);
            iconButton1.FlatAppearance.BorderSize = 2;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.FromArgb(35, 68, 57);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(724, 421);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(5, 0, 0, 0);
            iconButton1.Size = new Size(113, 41);
            iconButton1.TabIndex = 56;
            iconButton1.Text = "Limpar Filtros";
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Top;
            iconButton2.BackColor = Color.FromArgb(35, 68, 57);
            iconButton2.FlatAppearance.BorderColor = Color.FromArgb(35, 68, 57);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 25;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(852, 421);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(5, 0, 0, 0);
            iconButton2.Size = new Size(64, 41);
            iconButton2.TabIndex = 65;
            iconButton2.Text = "Filtrar";
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(dateTimePicker1);
            panel5.Controls.Add(iconButton6);
            panel5.Controls.Add(dateTimePicker3);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(52, 508);
            panel5.Name = "panel5";
            panel5.Size = new Size(866, 91);
            panel5.TabIndex = 66;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(399, 186);
            label1.Name = "label1";
            label1.Size = new Size(156, 21);
            label1.TabIndex = 67;
            label1.Text = "Upload de arquivos:";
            // 
            // iconButton3
            // 
            iconButton3.Anchor = AnchorStyles.Top;
            iconButton3.BackColor = Color.FromArgb(35, 68, 57);
            iconButton3.FlatAppearance.BorderColor = Color.FromArgb(35, 68, 57);
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 25;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(571, 182);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(5, 0, 0, 0);
            iconButton3.Size = new Size(139, 29);
            iconButton3.TabIndex = 68;
            iconButton3.Text = "Procurar Arquivos";
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(iconButton8);
            panel1.Controls.Add(lblAlunoAulas);
            panel1.Controls.Add(iconButton4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 39);
            panel1.TabIndex = 69;
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
            // lblAlunoAulas
            // 
            lblAlunoAulas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAlunoAulas.AutoSize = true;
            lblAlunoAulas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlunoAulas.ForeColor = Color.Black;
            lblAlunoAulas.Location = new Point(433, 7);
            lblAlunoAulas.Name = "lblAlunoAulas";
            lblAlunoAulas.Size = new Size(112, 25);
            lblAlunoAulas.TabIndex = 68;
            lblAlunoAulas.Text = "RELATÓRIO";
            // 
            // iconButton4
            // 
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 25;
            iconButton4.Location = new Point(3, 3);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(39, 34);
            iconButton4.TabIndex = 71;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // UCAdmGerarRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(iconButton3);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(comboBox4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBox3);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(lblFiltros);
            Controls.Add(txtLixoOrganico);
            Name = "UCAdmGerarRelatorio";
            Size = new Size(978, 646);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFiltros;
        private TextBox txtLixoOrganico;
        private DateTimePicker dateTimePicker3;
        private FontAwesome.Sharp.IconButton iconButton6;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label5;
        private Label label6;
        private ComboBox comboBox3;
        private Label label7;
        private Label label8;
        private ComboBox comboBox4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel5;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Panel panel1;
        private Label lblAlunoAulas;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}
