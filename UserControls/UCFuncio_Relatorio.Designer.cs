namespace ECOInsight.UserControls
{
    partial class UCFuncio_Relatorio
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
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            dateTimePicker3 = new DateTimePicker();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textLixoOutrasInfo = new TextBox();
            panelTiposdemateriais = new Panel();
            checkBoxTipoPapel = new CheckBox();
            checkBoxTipoPlastico = new CheckBox();
            checkBoxTipoMedicamentos = new CheckBox();
            checkBoxTipoEletronico = new CheckBox();
            checkBoxTipoMetal = new CheckBox();
            checkBoxTipoVidro = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            LblLixoOutrasInfo = new Label();
            lblLixoDestino = new Label();
            lblMinhocario = new Label();
            lbllixoReciclavel = new Label();
            lbllixoOrganico = new Label();
            lblTiposdemateriais = new Label();
            panel5.SuspendLayout();
            panelTiposdemateriais.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.Top;
            comboBox4.FlatStyle = FlatStyle.Flat;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(750, 196);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(111, 23);
            comboBox4.TabIndex = 105;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Top;
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(491, 196);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(111, 23);
            comboBox3.TabIndex = 104;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(200, 196);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(111, 23);
            comboBox2.TabIndex = 103;
            // 
            // iconButton5
            // 
            iconButton5.Anchor = AnchorStyles.Top;
            iconButton5.BackColor = Color.White;
            iconButton5.FlatAppearance.BorderColor = Color.FromArgb(35, 68, 57);
            iconButton5.FlatAppearance.BorderSize = 2;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton5.ForeColor = Color.FromArgb(35, 68, 57);
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton5.IconColor = Color.White;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 25;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(657, 419);
            iconButton5.Name = "iconButton5";
            iconButton5.Padding = new Padding(5, 0, 0, 0);
            iconButton5.Size = new Size(113, 41);
            iconButton5.TabIndex = 102;
            iconButton5.Text = "Limpar Filtros";
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.Anchor = AnchorStyles.Top;
            iconButton4.BackColor = Color.FromArgb(35, 68, 57);
            iconButton4.FlatAppearance.BorderColor = Color.FromArgb(35, 68, 57);
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 25;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(261, 425);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(5, 0, 0, 0);
            iconButton4.Size = new Size(139, 29);
            iconButton4.TabIndex = 101;
            iconButton4.Text = "Procurar Arquivos";
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(89, 429);
            label7.Name = "label7";
            label7.Size = new Size(156, 21);
            label7.TabIndex = 100;
            label7.Text = "Upload de arquivos:";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(dateTimePicker2);
            panel5.Controls.Add(iconButton6);
            panel5.Controls.Add(dateTimePicker3);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(85, 509);
            panel5.Name = "panel5";
            panel5.Size = new Size(808, 85);
            panel5.TabIndex = 99;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(403, 32);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 51;
            label5.Text = "Até: ";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Top;
            dateTimePicker2.Font = new Font("Segoe UI", 11F);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(262, 29);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(100, 27);
            dateTimePicker2.TabIndex = 55;
            dateTimePicker2.Value = new DateTime(2025, 4, 20, 22, 40, 38, 0);
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
            iconButton6.Location = new Point(587, 22);
            iconButton6.Name = "iconButton6";
            iconButton6.Padding = new Padding(5, 0, 0, 0);
            iconButton6.Size = new Size(113, 41);
            iconButton6.TabIndex = 53;
            iconButton6.Text = "Gerar PDF";
            iconButton6.TextAlign = ContentAlignment.MiddleRight;
            iconButton6.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Anchor = AnchorStyles.Top;
            dateTimePicker3.Font = new Font("Segoe UI", 11F);
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(453, 29);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(100, 27);
            dateTimePicker3.TabIndex = 52;
            dateTimePicker3.Value = new DateTime(2025, 4, 20, 22, 40, 38, 0);
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(107, 32);
            label6.Name = "label6";
            label6.Size = new Size(152, 21);
            label6.TabIndex = 54;
            label6.Text = "Gerar Relatório de: ";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(520, 314);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(366, 23);
            comboBox1.TabIndex = 98;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(628, 367);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 97;
            label4.Text = "Selecionar data:";
            // 
            // iconButton3
            // 
            iconButton3.Anchor = AnchorStyles.Top;
            iconButton3.BackColor = Color.FromArgb(35, 68, 57);
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 25;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(781, 419);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(3, 0, 0, 0);
            iconButton3.Size = new Size(105, 41);
            iconButton3.TabIndex = 94;
            iconButton3.Text = "       Salvar ";
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(867, 198);
            label3.Name = "label3";
            label3.Size = new Size(26, 19);
            label3.TabIndex = 93;
            label3.Text = "Kg";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(608, 198);
            label2.Name = "label2";
            label2.Size = new Size(26, 19);
            label2.TabIndex = 92;
            label2.Text = "Kg";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(312, 198);
            label1.Name = "label1";
            label1.Size = new Size(26, 19);
            label1.TabIndex = 91;
            label1.Text = "Kg";
            // 
            // textLixoOutrasInfo
            // 
            textLixoOutrasInfo.Anchor = AnchorStyles.Top;
            textLixoOutrasInfo.Location = new Point(91, 314);
            textLixoOutrasInfo.Multiline = true;
            textLixoOutrasInfo.Name = "textLixoOutrasInfo";
            textLixoOutrasInfo.Size = new Size(366, 76);
            textLixoOutrasInfo.TabIndex = 90;
            // 
            // panelTiposdemateriais
            // 
            panelTiposdemateriais.Anchor = AnchorStyles.Top;
            panelTiposdemateriais.BackColor = Color.FromArgb(153, 179, 142);
            panelTiposdemateriais.BorderStyle = BorderStyle.FixedSingle;
            panelTiposdemateriais.Controls.Add(checkBoxTipoPapel);
            panelTiposdemateriais.Controls.Add(checkBoxTipoPlastico);
            panelTiposdemateriais.Controls.Add(checkBoxTipoMedicamentos);
            panelTiposdemateriais.Controls.Add(checkBoxTipoEletronico);
            panelTiposdemateriais.Controls.Add(checkBoxTipoMetal);
            panelTiposdemateriais.Controls.Add(checkBoxTipoVidro);
            panelTiposdemateriais.Location = new Point(91, 88);
            panelTiposdemateriais.Name = "panelTiposdemateriais";
            panelTiposdemateriais.Size = new Size(795, 55);
            panelTiposdemateriais.TabIndex = 89;
            // 
            // checkBoxTipoPapel
            // 
            checkBoxTipoPapel.Anchor = AnchorStyles.Top;
            checkBoxTipoPapel.AutoSize = true;
            checkBoxTipoPapel.FlatStyle = FlatStyle.Flat;
            checkBoxTipoPapel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxTipoPapel.Location = new Point(17, 15);
            checkBoxTipoPapel.Name = "checkBoxTipoPapel";
            checkBoxTipoPapel.Size = new Size(69, 25);
            checkBoxTipoPapel.TabIndex = 31;
            checkBoxTipoPapel.Text = "Papel";
            checkBoxTipoPapel.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipoPlastico
            // 
            checkBoxTipoPlastico.Anchor = AnchorStyles.Top;
            checkBoxTipoPlastico.AutoSize = true;
            checkBoxTipoPlastico.FlatStyle = FlatStyle.Flat;
            checkBoxTipoPlastico.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxTipoPlastico.Location = new Point(130, 15);
            checkBoxTipoPlastico.Name = "checkBoxTipoPlastico";
            checkBoxTipoPlastico.Size = new Size(86, 25);
            checkBoxTipoPlastico.TabIndex = 35;
            checkBoxTipoPlastico.Text = "Plástico";
            checkBoxTipoPlastico.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipoMedicamentos
            // 
            checkBoxTipoMedicamentos.Anchor = AnchorStyles.Top;
            checkBoxTipoMedicamentos.AutoSize = true;
            checkBoxTipoMedicamentos.FlatStyle = FlatStyle.Flat;
            checkBoxTipoMedicamentos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxTipoMedicamentos.Location = new Point(633, 15);
            checkBoxTipoMedicamentos.Name = "checkBoxTipoMedicamentos";
            checkBoxTipoMedicamentos.Size = new Size(143, 25);
            checkBoxTipoMedicamentos.TabIndex = 36;
            checkBoxTipoMedicamentos.Text = "Medicamentos ";
            checkBoxTipoMedicamentos.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipoEletronico
            // 
            checkBoxTipoEletronico.Anchor = AnchorStyles.Top;
            checkBoxTipoEletronico.AutoSize = true;
            checkBoxTipoEletronico.FlatStyle = FlatStyle.Flat;
            checkBoxTipoEletronico.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxTipoEletronico.Location = new Point(488, 15);
            checkBoxTipoEletronico.Name = "checkBoxTipoEletronico";
            checkBoxTipoEletronico.Size = new Size(104, 25);
            checkBoxTipoEletronico.TabIndex = 32;
            checkBoxTipoEletronico.Text = "Eletrônico";
            checkBoxTipoEletronico.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipoMetal
            // 
            checkBoxTipoMetal.Anchor = AnchorStyles.Top;
            checkBoxTipoMetal.AutoSize = true;
            checkBoxTipoMetal.FlatStyle = FlatStyle.Flat;
            checkBoxTipoMetal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxTipoMetal.Location = new Point(373, 15);
            checkBoxTipoMetal.Name = "checkBoxTipoMetal";
            checkBoxTipoMetal.Size = new Size(70, 25);
            checkBoxTipoMetal.TabIndex = 33;
            checkBoxTipoMetal.Text = "Metal";
            checkBoxTipoMetal.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipoVidro
            // 
            checkBoxTipoVidro.Anchor = AnchorStyles.Top;
            checkBoxTipoVidro.AutoSize = true;
            checkBoxTipoVidro.FlatStyle = FlatStyle.Flat;
            checkBoxTipoVidro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxTipoVidro.Location = new Point(259, 15);
            checkBoxTipoVidro.Name = "checkBoxTipoVidro";
            checkBoxTipoVidro.Size = new Size(68, 25);
            checkBoxTipoVidro.TabIndex = 34;
            checkBoxTipoVidro.Text = "Vidro";
            checkBoxTipoVidro.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.Font = new Font("Segoe UI", 11F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(760, 363);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(124, 27);
            dateTimePicker1.TabIndex = 88;
            // 
            // LblLixoOutrasInfo
            // 
            LblLixoOutrasInfo.Anchor = AnchorStyles.Top;
            LblLixoOutrasInfo.AutoSize = true;
            LblLixoOutrasInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLixoOutrasInfo.Location = new Point(91, 280);
            LblLixoOutrasInfo.Name = "LblLixoOutrasInfo";
            LblLixoOutrasInfo.Size = new Size(158, 21);
            LblLixoOutrasInfo.TabIndex = 87;
            LblLixoOutrasInfo.Text = "Outras Informações ";
            // 
            // lblLixoDestino
            // 
            lblLixoDestino.Anchor = AnchorStyles.Top;
            lblLixoDestino.AutoSize = true;
            lblLixoDestino.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLixoDestino.Location = new Point(518, 280);
            lblLixoDestino.Name = "lblLixoDestino";
            lblLixoDestino.Size = new Size(70, 21);
            lblLixoDestino.TabIndex = 86;
            lblLixoDestino.Text = "Destino ";
            // 
            // lblMinhocario
            // 
            lblMinhocario.Anchor = AnchorStyles.Top;
            lblMinhocario.AutoSize = true;
            lblMinhocario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinhocario.Location = new Point(657, 197);
            lblMinhocario.Name = "lblMinhocario";
            lblMinhocario.Size = new Size(97, 21);
            lblMinhocario.TabIndex = 85;
            lblMinhocario.Text = "Minhocário:";
            // 
            // lbllixoReciclavel
            // 
            lbllixoReciclavel.Anchor = AnchorStyles.Top;
            lbllixoReciclavel.AutoSize = true;
            lbllixoReciclavel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllixoReciclavel.Location = new Point(369, 197);
            lbllixoReciclavel.Name = "lbllixoReciclavel";
            lbllixoReciclavel.Size = new Size(120, 21);
            lbllixoReciclavel.TabIndex = 84;
            lbllixoReciclavel.Text = "Lixo Reciclável:";
            // 
            // lbllixoOrganico
            // 
            lbllixoOrganico.Anchor = AnchorStyles.Top;
            lbllixoOrganico.AutoSize = true;
            lbllixoOrganico.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllixoOrganico.Location = new Point(85, 197);
            lbllixoOrganico.Name = "lbllixoOrganico";
            lbllixoOrganico.Size = new Size(115, 21);
            lbllixoOrganico.TabIndex = 82;
            lbllixoOrganico.Text = "Lixo Orgânico:";
            // 
            // lblTiposdemateriais
            // 
            lblTiposdemateriais.Anchor = AnchorStyles.Top;
            lblTiposdemateriais.AutoSize = true;
            lblTiposdemateriais.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiposdemateriais.Location = new Point(91, 52);
            lblTiposdemateriais.Name = "lblTiposdemateriais";
            lblTiposdemateriais.Size = new Size(144, 21);
            lblTiposdemateriais.TabIndex = 83;
            lblTiposdemateriais.Text = "Tipos de Materiais";
            // 
            // UCFuncio_Relatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(iconButton5);
            Controls.Add(iconButton4);
            Controls.Add(label7);
            Controls.Add(panel5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(iconButton3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textLixoOutrasInfo);
            Controls.Add(panelTiposdemateriais);
            Controls.Add(dateTimePicker1);
            Controls.Add(LblLixoOutrasInfo);
            Controls.Add(lblLixoDestino);
            Controls.Add(lblMinhocario);
            Controls.Add(lbllixoReciclavel);
            Controls.Add(lbllixoOrganico);
            Controls.Add(lblTiposdemateriais);
            Name = "UCFuncio_Relatorio";
            Size = new Size(978, 646);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panelTiposdemateriais.ResumeLayout(false);
            panelTiposdemateriais.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Label label7;
        private Panel panel5;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private FontAwesome.Sharp.IconButton iconButton6;
        private DateTimePicker dateTimePicker3;
        private Label label6;
        private ComboBox comboBox1;
        private Label label4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textLixoOutrasInfo;
        private Panel panelTiposdemateriais;
        private CheckBox checkBoxTipoPapel;
        private CheckBox checkBoxTipoPlastico;
        private CheckBox checkBoxTipoMedicamentos;
        private CheckBox checkBoxTipoEletronico;
        private CheckBox checkBoxTipoMetal;
        private CheckBox checkBoxTipoVidro;
        private DateTimePicker dateTimePicker1;
        private Label LblLixoOutrasInfo;
        private Label lblLixoDestino;
        private Label lblMinhocario;
        private Label lbllixoReciclavel;
        private Label lbllixoOrganico;
        private Label lblTiposdemateriais;
    }
}
