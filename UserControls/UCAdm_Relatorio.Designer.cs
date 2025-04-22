namespace ECOInsight.UserControls
{
    partial class UCAdm_Relatorio
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
            txtLixoOrganico = new TextBox();
            lblTiposdemateriais = new Label();
            lbllixoOrganico = new Label();
            lbllixoReciclavel = new Label();
            lblMinhocario = new Label();
            lblLixoDestino = new Label();
            LblLixoOutrasInfo = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtMinhocario = new TextBox();
            txtLixoReciclavel = new TextBox();
            checkBoxTipoVidro = new CheckBox();
            checkBoxTipoMetal = new CheckBox();
            checkBoxTipoEletronico = new CheckBox();
            checkBoxTipoMedicamentos = new CheckBox();
            checkBoxTipoPlastico = new CheckBox();
            checkBoxTipoPapel = new CheckBox();
            panelTiposdemateriais = new Panel();
            textLixoOutrasInfo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            comboBox1 = new ComboBox();
            panelTiposdemateriais.SuspendLayout();
            SuspendLayout();
            // 
            // txtLixoOrganico
            // 
            txtLixoOrganico.Anchor = AnchorStyles.Top;
            txtLixoOrganico.Location = new Point(205, 226);
            txtLixoOrganico.Name = "txtLixoOrganico";
            txtLixoOrganico.Size = new Size(111, 23);
            txtLixoOrganico.TabIndex = 28;
            // 
            // lblTiposdemateriais
            // 
            lblTiposdemateriais.Anchor = AnchorStyles.Top;
            lblTiposdemateriais.AutoSize = true;
            lblTiposdemateriais.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiposdemateriais.Location = new Point(92, 47);
            lblTiposdemateriais.Name = "lblTiposdemateriais";
            lblTiposdemateriais.Size = new Size(144, 21);
            lblTiposdemateriais.TabIndex = 26;
            lblTiposdemateriais.Text = "Tipos de Materiais";
            // 
            // lbllixoOrganico
            // 
            lbllixoOrganico.Anchor = AnchorStyles.Top;
            lbllixoOrganico.AutoSize = true;
            lbllixoOrganico.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllixoOrganico.Location = new Point(84, 227);
            lbllixoOrganico.Name = "lbllixoOrganico";
            lbllixoOrganico.Size = new Size(115, 21);
            lbllixoOrganico.TabIndex = 25;
            lbllixoOrganico.Text = "Lixo Orgânico:";
            // 
            // lbllixoReciclavel
            // 
            lbllixoReciclavel.Anchor = AnchorStyles.Top;
            lbllixoReciclavel.AutoSize = true;
            lbllixoReciclavel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllixoReciclavel.Location = new Point(370, 227);
            lbllixoReciclavel.Name = "lbllixoReciclavel";
            lbllixoReciclavel.Size = new Size(120, 21);
            lbllixoReciclavel.TabIndex = 29;
            lbllixoReciclavel.Text = "Lixo Reciclável:";
            // 
            // lblMinhocario
            // 
            lblMinhocario.Anchor = AnchorStyles.Top;
            lblMinhocario.AutoSize = true;
            lblMinhocario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinhocario.Location = new Point(658, 227);
            lblMinhocario.Name = "lblMinhocario";
            lblMinhocario.Size = new Size(97, 21);
            lblMinhocario.TabIndex = 30;
            lblMinhocario.Text = "Minhocário:";
            // 
            // lblLixoDestino
            // 
            lblLixoDestino.Anchor = AnchorStyles.Top;
            lblLixoDestino.AutoSize = true;
            lblLixoDestino.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLixoDestino.Location = new Point(90, 334);
            lblLixoDestino.Name = "lblLixoDestino";
            lblLixoDestino.Size = new Size(70, 21);
            lblLixoDestino.TabIndex = 37;
            lblLixoDestino.Text = "Destino ";
            // 
            // LblLixoOutrasInfo
            // 
            LblLixoOutrasInfo.Anchor = AnchorStyles.Top;
            LblLixoOutrasInfo.AutoSize = true;
            LblLixoOutrasInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLixoOutrasInfo.Location = new Point(519, 334);
            LblLixoOutrasInfo.Name = "LblLixoOutrasInfo";
            LblLixoOutrasInfo.Size = new Size(158, 21);
            LblLixoOutrasInfo.TabIndex = 38;
            LblLixoOutrasInfo.Text = "Outras Informações ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.Font = new Font("Segoe UI", 11F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(761, 484);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(124, 27);
            dateTimePicker1.TabIndex = 39;
            // 
            // txtMinhocario
            // 
            txtMinhocario.Anchor = AnchorStyles.Top;
            txtMinhocario.Location = new Point(761, 226);
            txtMinhocario.Name = "txtMinhocario";
            txtMinhocario.Size = new Size(111, 23);
            txtMinhocario.TabIndex = 41;
            // 
            // txtLixoReciclavel
            // 
            txtLixoReciclavel.Anchor = AnchorStyles.Top;
            txtLixoReciclavel.Location = new Point(496, 226);
            txtLixoReciclavel.Name = "txtLixoReciclavel";
            txtLixoReciclavel.Size = new Size(111, 23);
            txtLixoReciclavel.TabIndex = 42;
            // 
            // checkBoxTipoVidro
            // 
            checkBoxTipoVidro.Anchor = AnchorStyles.Top;
            checkBoxTipoVidro.AutoSize = true;
            checkBoxTipoVidro.FlatStyle = FlatStyle.Flat;
            checkBoxTipoVidro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxTipoVidro.Location = new Point(262, 15);
            checkBoxTipoVidro.Name = "checkBoxTipoVidro";
            checkBoxTipoVidro.Size = new Size(68, 25);
            checkBoxTipoVidro.TabIndex = 34;
            checkBoxTipoVidro.Text = "Vidro";
            checkBoxTipoVidro.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipoMetal
            // 
            checkBoxTipoMetal.Anchor = AnchorStyles.Top;
            checkBoxTipoMetal.AutoSize = true;
            checkBoxTipoMetal.FlatStyle = FlatStyle.Flat;
            checkBoxTipoMetal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxTipoMetal.Location = new Point(376, 15);
            checkBoxTipoMetal.Name = "checkBoxTipoMetal";
            checkBoxTipoMetal.Size = new Size(70, 25);
            checkBoxTipoMetal.TabIndex = 33;
            checkBoxTipoMetal.Text = "Metal";
            checkBoxTipoMetal.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipoEletronico
            // 
            checkBoxTipoEletronico.Anchor = AnchorStyles.Top;
            checkBoxTipoEletronico.AutoSize = true;
            checkBoxTipoEletronico.FlatStyle = FlatStyle.Flat;
            checkBoxTipoEletronico.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxTipoEletronico.Location = new Point(491, 15);
            checkBoxTipoEletronico.Name = "checkBoxTipoEletronico";
            checkBoxTipoEletronico.Size = new Size(104, 25);
            checkBoxTipoEletronico.TabIndex = 32;
            checkBoxTipoEletronico.Text = "Eletrônico";
            checkBoxTipoEletronico.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipoMedicamentos
            // 
            checkBoxTipoMedicamentos.Anchor = AnchorStyles.Top;
            checkBoxTipoMedicamentos.AutoSize = true;
            checkBoxTipoMedicamentos.FlatStyle = FlatStyle.Flat;
            checkBoxTipoMedicamentos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxTipoMedicamentos.Location = new Point(636, 15);
            checkBoxTipoMedicamentos.Name = "checkBoxTipoMedicamentos";
            checkBoxTipoMedicamentos.Size = new Size(143, 25);
            checkBoxTipoMedicamentos.TabIndex = 36;
            checkBoxTipoMedicamentos.Text = "Medicamentos ";
            checkBoxTipoMedicamentos.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipoPlastico
            // 
            checkBoxTipoPlastico.Anchor = AnchorStyles.Top;
            checkBoxTipoPlastico.AutoSize = true;
            checkBoxTipoPlastico.FlatStyle = FlatStyle.Flat;
            checkBoxTipoPlastico.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxTipoPlastico.Location = new Point(133, 15);
            checkBoxTipoPlastico.Name = "checkBoxTipoPlastico";
            checkBoxTipoPlastico.Size = new Size(86, 25);
            checkBoxTipoPlastico.TabIndex = 35;
            checkBoxTipoPlastico.Text = "Plástico";
            checkBoxTipoPlastico.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipoPapel
            // 
            checkBoxTipoPapel.Anchor = AnchorStyles.Top;
            checkBoxTipoPapel.AutoSize = true;
            checkBoxTipoPapel.FlatStyle = FlatStyle.Flat;
            checkBoxTipoPapel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxTipoPapel.Location = new Point(20, 15);
            checkBoxTipoPapel.Name = "checkBoxTipoPapel";
            checkBoxTipoPapel.Size = new Size(69, 25);
            checkBoxTipoPapel.TabIndex = 31;
            checkBoxTipoPapel.Text = "Papel";
            checkBoxTipoPapel.UseVisualStyleBackColor = true;
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
            panelTiposdemateriais.Location = new Point(92, 83);
            panelTiposdemateriais.Name = "panelTiposdemateriais";
            panelTiposdemateriais.Size = new Size(795, 55);
            panelTiposdemateriais.TabIndex = 43;
            // 
            // textLixoOutrasInfo
            // 
            textLixoOutrasInfo.Anchor = AnchorStyles.Top;
            textLixoOutrasInfo.Location = new Point(519, 368);
            textLixoOutrasInfo.Multiline = true;
            textLixoOutrasInfo.Name = "textLixoOutrasInfo";
            textLixoOutrasInfo.Size = new Size(366, 76);
            textLixoOutrasInfo.TabIndex = 44;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(313, 227);
            label1.Name = "label1";
            label1.Size = new Size(26, 19);
            label1.TabIndex = 45;
            label1.Text = "Kg";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(609, 228);
            label2.Name = "label2";
            label2.Size = new Size(26, 19);
            label2.TabIndex = 46;
            label2.Text = "Kg";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(868, 228);
            label3.Name = "label3";
            label3.Size = new Size(26, 19);
            label3.TabIndex = 47;
            label3.Text = "Kg";
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
            iconButton3.Location = new Point(773, 551);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(3, 0, 0, 0);
            iconButton3.Size = new Size(105, 41);
            iconButton3.TabIndex = 48;
            iconButton3.Text = "       Salvar ";
            iconButton3.UseVisualStyleBackColor = false;
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
            iconButton1.Location = new Point(792, 153);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(5, 0, 0, 0);
            iconButton1.Size = new Size(95, 41);
            iconButton1.TabIndex = 57;
            iconButton1.Text = "Editar lista";
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Top;
            iconButton2.BackColor = Color.White;
            iconButton2.FlatAppearance.BorderColor = Color.FromArgb(35, 68, 57);
            iconButton2.FlatAppearance.BorderSize = 2;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = Color.FromArgb(35, 68, 57);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 25;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(773, 267);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(5, 0, 0, 0);
            iconButton2.Size = new Size(114, 41);
            iconButton2.TabIndex = 58;
            iconButton2.Text = "Editar campos";
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(629, 488);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 59;
            label4.Text = "Selecionar data:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(92, 368);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(366, 23);
            comboBox1.TabIndex = 60;
            // 
            // UCAdm_Relatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(iconButton3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textLixoOutrasInfo);
            Controls.Add(panelTiposdemateriais);
            Controls.Add(txtLixoReciclavel);
            Controls.Add(txtMinhocario);
            Controls.Add(dateTimePicker1);
            Controls.Add(LblLixoOutrasInfo);
            Controls.Add(lblLixoDestino);
            Controls.Add(lblMinhocario);
            Controls.Add(lbllixoReciclavel);
            Controls.Add(lbllixoOrganico);
            Controls.Add(lblTiposdemateriais);
            Controls.Add(txtLixoOrganico);
            Name = "UCAdm_Relatorio";
            Size = new Size(978, 646);
            panelTiposdemateriais.ResumeLayout(false);
            panelTiposdemateriais.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLixoOrganico;
        private Label lblTiposdemateriais;
        private Label lbllixoOrganico;
        private Label lbllixoReciclavel;
        private Label lblMinhocario;
        private Label lblLixoDestino;
        private Label LblLixoOutrasInfo;
        private DateTimePicker dateTimePicker1;
        private TextBox txtMinhocario;
        private TextBox txtLixoReciclavel;
        private CheckBox checkBoxTipoVidro;
        private CheckBox checkBoxTipoMetal;
        private CheckBox checkBoxTipoEletronico;
        private CheckBox checkBoxTipoMedicamentos;
        private CheckBox checkBoxTipoPlastico;
        private CheckBox checkBoxTipoPapel;
        private Panel panelTiposdemateriais;
        private TextBox textLixoOutrasInfo;
        private Label label1;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label4;
        private ComboBox comboBox1;
    }
}
