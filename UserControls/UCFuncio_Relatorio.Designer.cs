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
            txtLixoReciclavel = new TextBox();
            txtMinhocario = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            LblLixoOutrasInfo = new Label();
            lblLixoDestino = new Label();
            lblMinhocario = new Label();
            lbllixoReciclavel = new Label();
            lbllixoOrganico = new Label();
            lblTiposdemateriais = new Label();
            txtLixoOrganico = new TextBox();
            panelTiposdemateriais.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(92, 372);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(366, 23);
            comboBox1.TabIndex = 80;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(629, 492);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 79;
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
            iconButton3.Location = new Point(773, 555);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(3, 0, 0, 0);
            iconButton3.Size = new Size(105, 41);
            iconButton3.TabIndex = 76;
            iconButton3.Text = "       Salvar ";
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(868, 232);
            label3.Name = "label3";
            label3.Size = new Size(26, 19);
            label3.TabIndex = 75;
            label3.Text = "Kg";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(609, 232);
            label2.Name = "label2";
            label2.Size = new Size(26, 19);
            label2.TabIndex = 74;
            label2.Text = "Kg";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(313, 231);
            label1.Name = "label1";
            label1.Size = new Size(26, 19);
            label1.TabIndex = 73;
            label1.Text = "Kg";
            // 
            // textLixoOutrasInfo
            // 
            textLixoOutrasInfo.Anchor = AnchorStyles.Top;
            textLixoOutrasInfo.Location = new Point(519, 372);
            textLixoOutrasInfo.Multiline = true;
            textLixoOutrasInfo.Name = "textLixoOutrasInfo";
            textLixoOutrasInfo.Size = new Size(366, 76);
            textLixoOutrasInfo.TabIndex = 72;
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
            panelTiposdemateriais.Location = new Point(92, 87);
            panelTiposdemateriais.Name = "panelTiposdemateriais";
            panelTiposdemateriais.Size = new Size(795, 55);
            panelTiposdemateriais.TabIndex = 71;
            // 
            // checkBoxTipoPapel
            // 
            checkBoxTipoPapel.Anchor = AnchorStyles.Top;
            checkBoxTipoPapel.AutoSize = true;
            checkBoxTipoPapel.FlatStyle = FlatStyle.Flat;
            checkBoxTipoPapel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBoxTipoPapel.Location = new Point(17, 16);
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
            checkBoxTipoPlastico.Location = new Point(130, 16);
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
            checkBoxTipoMedicamentos.Location = new Point(633, 16);
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
            checkBoxTipoEletronico.Location = new Point(488, 16);
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
            checkBoxTipoMetal.Location = new Point(373, 16);
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
            checkBoxTipoVidro.Location = new Point(259, 16);
            checkBoxTipoVidro.Name = "checkBoxTipoVidro";
            checkBoxTipoVidro.Size = new Size(68, 25);
            checkBoxTipoVidro.TabIndex = 34;
            checkBoxTipoVidro.Text = "Vidro";
            checkBoxTipoVidro.UseVisualStyleBackColor = true;
            // 
            // txtLixoReciclavel
            // 
            txtLixoReciclavel.Anchor = AnchorStyles.Top;
            txtLixoReciclavel.Location = new Point(496, 230);
            txtLixoReciclavel.Name = "txtLixoReciclavel";
            txtLixoReciclavel.Size = new Size(111, 23);
            txtLixoReciclavel.TabIndex = 70;
            // 
            // txtMinhocario
            // 
            txtMinhocario.Anchor = AnchorStyles.Top;
            txtMinhocario.Location = new Point(761, 230);
            txtMinhocario.Name = "txtMinhocario";
            txtMinhocario.Size = new Size(111, 23);
            txtMinhocario.TabIndex = 69;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.Font = new Font("Segoe UI", 11F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(761, 488);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(124, 27);
            dateTimePicker1.TabIndex = 68;
            // 
            // LblLixoOutrasInfo
            // 
            LblLixoOutrasInfo.Anchor = AnchorStyles.Top;
            LblLixoOutrasInfo.AutoSize = true;
            LblLixoOutrasInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLixoOutrasInfo.Location = new Point(519, 338);
            LblLixoOutrasInfo.Name = "LblLixoOutrasInfo";
            LblLixoOutrasInfo.Size = new Size(158, 21);
            LblLixoOutrasInfo.TabIndex = 67;
            LblLixoOutrasInfo.Text = "Outras Informações ";
            // 
            // lblLixoDestino
            // 
            lblLixoDestino.Anchor = AnchorStyles.Top;
            lblLixoDestino.AutoSize = true;
            lblLixoDestino.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLixoDestino.Location = new Point(90, 338);
            lblLixoDestino.Name = "lblLixoDestino";
            lblLixoDestino.Size = new Size(70, 21);
            lblLixoDestino.TabIndex = 66;
            lblLixoDestino.Text = "Destino ";
            // 
            // lblMinhocario
            // 
            lblMinhocario.Anchor = AnchorStyles.Top;
            lblMinhocario.AutoSize = true;
            lblMinhocario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinhocario.Location = new Point(658, 231);
            lblMinhocario.Name = "lblMinhocario";
            lblMinhocario.Size = new Size(97, 21);
            lblMinhocario.TabIndex = 65;
            lblMinhocario.Text = "Minhocário:";
            // 
            // lbllixoReciclavel
            // 
            lbllixoReciclavel.Anchor = AnchorStyles.Top;
            lbllixoReciclavel.AutoSize = true;
            lbllixoReciclavel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllixoReciclavel.Location = new Point(370, 231);
            lbllixoReciclavel.Name = "lbllixoReciclavel";
            lbllixoReciclavel.Size = new Size(120, 21);
            lbllixoReciclavel.TabIndex = 64;
            lbllixoReciclavel.Text = "Lixo Reciclável:";
            // 
            // lbllixoOrganico
            // 
            lbllixoOrganico.Anchor = AnchorStyles.Top;
            lbllixoOrganico.AutoSize = true;
            lbllixoOrganico.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllixoOrganico.Location = new Point(84, 231);
            lbllixoOrganico.Name = "lbllixoOrganico";
            lbllixoOrganico.Size = new Size(115, 21);
            lbllixoOrganico.TabIndex = 61;
            lbllixoOrganico.Text = "Lixo Orgânico:";
            // 
            // lblTiposdemateriais
            // 
            lblTiposdemateriais.Anchor = AnchorStyles.Top;
            lblTiposdemateriais.AutoSize = true;
            lblTiposdemateriais.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiposdemateriais.Location = new Point(92, 51);
            lblTiposdemateriais.Name = "lblTiposdemateriais";
            lblTiposdemateriais.Size = new Size(144, 21);
            lblTiposdemateriais.TabIndex = 62;
            lblTiposdemateriais.Text = "Tipos de Materiais";
            // 
            // txtLixoOrganico
            // 
            txtLixoOrganico.Anchor = AnchorStyles.Top;
            txtLixoOrganico.Location = new Point(205, 230);
            txtLixoOrganico.Name = "txtLixoOrganico";
            txtLixoOrganico.Size = new Size(111, 23);
            txtLixoOrganico.TabIndex = 63;
            // 
            // UCFuncio_Relatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(label4);
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
            Name = "UCFuncio_Relatorio";
            Size = new Size(978, 646);
            panelTiposdemateriais.ResumeLayout(false);
            panelTiposdemateriais.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private TextBox txtLixoReciclavel;
        private TextBox txtMinhocario;
        private DateTimePicker dateTimePicker1;
        private Label LblLixoOutrasInfo;
        private Label lblLixoDestino;
        private Label lblMinhocario;
        private Label lbllixoReciclavel;
        private Label lbllixoOrganico;
        private Label lblTiposdemateriais;
        private TextBox txtLixoOrganico;
    }
}
