namespace ECOInsight.UserControls
{
    partial class UCAdm_Descartes
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
            lblTiposdemateriais = new Label();
            lbllixoReciclavel = new Label();
            lblLixoDestino = new Label();
            LblLixoOutrasInfo = new Label();
            dateTimeRegistros = new DateTimePicker();
            cb_TipoVidro = new CheckBox();
            cb_TipoMetal = new CheckBox();
            cb_TipoEletronico = new CheckBox();
            cb_TipoMedicamentos = new CheckBox();
            cb_TipoPlastico = new CheckBox();
            cb_TipoPapel = new CheckBox();
            panelTiposdeDescartes = new Panel();
            cb_TipoOrganico = new CheckBox();
            textLixoOutrasInfo = new TextBox();
            lblAdmKg = new Label();
            btn_EditarLista = new FontAwesome.Sharp.IconButton();
            lblAdmSeleData = new Label();
            cb_Destino = new ComboBox();
            lbRegistros = new Label();
            btn_ProcurArquivos = new FontAwesome.Sharp.IconButton();
            lblAdmUploadRegistros = new Label();
            btn_LimparFiltros = new FontAwesome.Sharp.IconButton();
            cb_Peso = new ComboBox();
            btn_Salvar = new FontAwesome.Sharp.IconButton();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            comboBox3 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            comboBox4 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            comboBox5 = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            comboBox6 = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            panelTiposdeDescartes.SuspendLayout();
            SuspendLayout();
            // 
            // lblTiposdemateriais
            // 
            lblTiposdemateriais.Anchor = AnchorStyles.Top;
            lblTiposdemateriais.AutoSize = true;
            lblTiposdemateriais.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiposdemateriais.Location = new Point(86, 104);
            lblTiposdemateriais.Name = "lblTiposdemateriais";
            lblTiposdemateriais.Size = new Size(148, 21);
            lblTiposdemateriais.TabIndex = 26;
            lblTiposdemateriais.Text = "Tipos de Descartes";
            // 
            // lbllixoReciclavel
            // 
            lbllixoReciclavel.Anchor = AnchorStyles.Top;
            lbllixoReciclavel.AutoSize = true;
            lbllixoReciclavel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllixoReciclavel.Location = new Point(287, 147);
            lbllixoReciclavel.Name = "lbllixoReciclavel";
            lbllixoReciclavel.Size = new Size(52, 21);
            lbllixoReciclavel.TabIndex = 29;
            lbllixoReciclavel.Text = "Peso :";
            // 
            // lblLixoDestino
            // 
            lblLixoDestino.Anchor = AnchorStyles.Top;
            lblLixoDestino.AutoSize = true;
            lblLixoDestino.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLixoDestino.Location = new Point(582, 195);
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
            LblLixoOutrasInfo.Location = new Point(583, 319);
            LblLixoOutrasInfo.Name = "LblLixoOutrasInfo";
            LblLixoOutrasInfo.Size = new Size(158, 21);
            LblLixoOutrasInfo.TabIndex = 38;
            LblLixoOutrasInfo.Text = "Outras Informações ";
            // 
            // dateTimeRegistros
            // 
            dateTimeRegistros.Anchor = AnchorStyles.Top;
            dateTimeRegistros.Font = new Font("Segoe UI", 11F);
            dateTimeRegistros.Format = DateTimePickerFormat.Short;
            dateTimeRegistros.Location = new Point(769, 270);
            dateTimeRegistros.Name = "dateTimeRegistros";
            dateTimeRegistros.Size = new Size(124, 27);
            dateTimeRegistros.TabIndex = 39;
            // 
            // cb_TipoVidro
            // 
            cb_TipoVidro.Anchor = AnchorStyles.Top;
            cb_TipoVidro.AutoSize = true;
            cb_TipoVidro.FlatStyle = FlatStyle.Flat;
            cb_TipoVidro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cb_TipoVidro.Location = new Point(17, 193);
            cb_TipoVidro.Name = "cb_TipoVidro";
            cb_TipoVidro.Size = new Size(68, 25);
            cb_TipoVidro.TabIndex = 34;
            cb_TipoVidro.Text = "Vidro";
            cb_TipoVidro.UseVisualStyleBackColor = true;
            cb_TipoVidro.CheckedChanged += cb_TipoOrganico_CheckedChanged;
            // 
            // cb_TipoMetal
            // 
            cb_TipoMetal.Anchor = AnchorStyles.Top;
            cb_TipoMetal.AutoSize = true;
            cb_TipoMetal.FlatStyle = FlatStyle.Flat;
            cb_TipoMetal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cb_TipoMetal.Location = new Point(17, 255);
            cb_TipoMetal.Name = "cb_TipoMetal";
            cb_TipoMetal.Size = new Size(70, 25);
            cb_TipoMetal.TabIndex = 33;
            cb_TipoMetal.Text = "Metal";
            cb_TipoMetal.UseVisualStyleBackColor = true;
            cb_TipoMetal.CheckedChanged += cb_TipoOrganico_CheckedChanged;
            // 
            // cb_TipoEletronico
            // 
            cb_TipoEletronico.Anchor = AnchorStyles.Top;
            cb_TipoEletronico.AutoSize = true;
            cb_TipoEletronico.FlatStyle = FlatStyle.Flat;
            cb_TipoEletronico.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cb_TipoEletronico.Location = new Point(16, 317);
            cb_TipoEletronico.Name = "cb_TipoEletronico";
            cb_TipoEletronico.Size = new Size(104, 25);
            cb_TipoEletronico.TabIndex = 32;
            cb_TipoEletronico.Text = "Eletrônico";
            cb_TipoEletronico.UseVisualStyleBackColor = true;
            cb_TipoEletronico.CheckedChanged += cb_TipoOrganico_CheckedChanged;
            // 
            // cb_TipoMedicamentos
            // 
            cb_TipoMedicamentos.Anchor = AnchorStyles.Top;
            cb_TipoMedicamentos.AutoSize = true;
            cb_TipoMedicamentos.FlatStyle = FlatStyle.Flat;
            cb_TipoMedicamentos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cb_TipoMedicamentos.Location = new Point(16, 379);
            cb_TipoMedicamentos.Name = "cb_TipoMedicamentos";
            cb_TipoMedicamentos.Size = new Size(143, 25);
            cb_TipoMedicamentos.TabIndex = 36;
            cb_TipoMedicamentos.Text = "Medicamentos ";
            cb_TipoMedicamentos.UseVisualStyleBackColor = true;
            cb_TipoMedicamentos.CheckedChanged += cb_TipoOrganico_CheckedChanged;
            // 
            // cb_TipoPlastico
            // 
            cb_TipoPlastico.Anchor = AnchorStyles.Top;
            cb_TipoPlastico.AutoSize = true;
            cb_TipoPlastico.FlatStyle = FlatStyle.Flat;
            cb_TipoPlastico.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cb_TipoPlastico.Location = new Point(17, 131);
            cb_TipoPlastico.Name = "cb_TipoPlastico";
            cb_TipoPlastico.Size = new Size(86, 25);
            cb_TipoPlastico.TabIndex = 35;
            cb_TipoPlastico.Text = "Plástico";
            cb_TipoPlastico.UseVisualStyleBackColor = true;
            cb_TipoPlastico.CheckedChanged += cb_TipoOrganico_CheckedChanged;
            // 
            // cb_TipoPapel
            // 
            cb_TipoPapel.Anchor = AnchorStyles.Top;
            cb_TipoPapel.AutoSize = true;
            cb_TipoPapel.FlatStyle = FlatStyle.Flat;
            cb_TipoPapel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cb_TipoPapel.Location = new Point(17, 69);
            cb_TipoPapel.Name = "cb_TipoPapel";
            cb_TipoPapel.Size = new Size(69, 25);
            cb_TipoPapel.TabIndex = 31;
            cb_TipoPapel.Text = "Papel";
            cb_TipoPapel.UseVisualStyleBackColor = true;
            cb_TipoPapel.CheckedChanged += cb_TipoOrganico_CheckedChanged;
            // 
            // panelTiposdeDescartes
            // 
            panelTiposdeDescartes.Anchor = AnchorStyles.Top;
            panelTiposdeDescartes.BackColor = Color.FromArgb(153, 179, 142);
            panelTiposdeDescartes.BorderStyle = BorderStyle.FixedSingle;
            panelTiposdeDescartes.Controls.Add(cb_TipoMedicamentos);
            panelTiposdeDescartes.Controls.Add(cb_TipoOrganico);
            panelTiposdeDescartes.Controls.Add(cb_TipoEletronico);
            panelTiposdeDescartes.Controls.Add(cb_TipoPlastico);
            panelTiposdeDescartes.Controls.Add(cb_TipoMetal);
            panelTiposdeDescartes.Controls.Add(cb_TipoPapel);
            panelTiposdeDescartes.Controls.Add(cb_TipoVidro);
            panelTiposdeDescartes.Location = new Point(86, 135);
            panelTiposdeDescartes.Name = "panelTiposdeDescartes";
            panelTiposdeDescartes.Size = new Size(195, 415);
            panelTiposdeDescartes.TabIndex = 43;
            // 
            // cb_TipoOrganico
            // 
            cb_TipoOrganico.Anchor = AnchorStyles.Top;
            cb_TipoOrganico.AutoSize = true;
            cb_TipoOrganico.FlatStyle = FlatStyle.Flat;
            cb_TipoOrganico.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cb_TipoOrganico.Location = new Point(17, 7);
            cb_TipoOrganico.Name = "cb_TipoOrganico";
            cb_TipoOrganico.Size = new Size(96, 25);
            cb_TipoOrganico.TabIndex = 37;
            cb_TipoOrganico.Text = "Orgânico";
            cb_TipoOrganico.UseVisualStyleBackColor = true;
            cb_TipoOrganico.CheckedChanged += cb_TipoOrganico_CheckedChanged;
            // 
            // textLixoOutrasInfo
            // 
            textLixoOutrasInfo.Anchor = AnchorStyles.Top;
            textLixoOutrasInfo.Location = new Point(583, 351);
            textLixoOutrasInfo.Multiline = true;
            textLixoOutrasInfo.Name = "textLixoOutrasInfo";
            textLixoOutrasInfo.Size = new Size(310, 190);
            textLixoOutrasInfo.TabIndex = 44;
            // 
            // lblAdmKg
            // 
            lblAdmKg.Anchor = AnchorStyles.Top;
            lblAdmKg.AutoSize = true;
            lblAdmKg.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblAdmKg.Location = new Point(453, 148);
            lblAdmKg.Name = "lblAdmKg";
            lblAdmKg.Size = new Size(26, 19);
            lblAdmKg.TabIndex = 46;
            lblAdmKg.Text = "Kg";
            // 
            // btn_EditarLista
            // 
            btn_EditarLista.Anchor = AnchorStyles.Top;
            btn_EditarLista.BackColor = Color.White;
            btn_EditarLista.FlatAppearance.BorderColor = Color.FromArgb(35, 68, 57);
            btn_EditarLista.FlatAppearance.BorderSize = 2;
            btn_EditarLista.FlatStyle = FlatStyle.Flat;
            btn_EditarLista.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EditarLista.ForeColor = Color.FromArgb(35, 68, 57);
            btn_EditarLista.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_EditarLista.IconColor = Color.White;
            btn_EditarLista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_EditarLista.IconSize = 25;
            btn_EditarLista.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EditarLista.Location = new Point(86, 556);
            btn_EditarLista.Name = "btn_EditarLista";
            btn_EditarLista.Padding = new Padding(5, 0, 0, 0);
            btn_EditarLista.Size = new Size(83, 35);
            btn_EditarLista.TabIndex = 57;
            btn_EditarLista.Text = "Editar lista";
            btn_EditarLista.UseVisualStyleBackColor = false;
            // 
            // lblAdmSeleData
            // 
            lblAdmSeleData.Anchor = AnchorStyles.Top;
            lblAdmSeleData.AutoSize = true;
            lblAdmSeleData.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmSeleData.Location = new Point(582, 274);
            lblAdmSeleData.Name = "lblAdmSeleData";
            lblAdmSeleData.Size = new Size(126, 21);
            lblAdmSeleData.TabIndex = 59;
            lblAdmSeleData.Text = "Selecionar data:";
            // 
            // cb_Destino
            // 
            cb_Destino.Anchor = AnchorStyles.Top;
            cb_Destino.FlatStyle = FlatStyle.Flat;
            cb_Destino.FormattingEnabled = true;
            cb_Destino.Location = new Point(582, 219);
            cb_Destino.Name = "cb_Destino";
            cb_Destino.Size = new Size(311, 23);
            cb_Destino.TabIndex = 60;
            // 
            // lbRegistros
            // 
            lbRegistros.Anchor = AnchorStyles.Top;
            lbRegistros.AutoSize = true;
            lbRegistros.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRegistros.ForeColor = Color.FromArgb(35, 68, 57);
            lbRegistros.Location = new Point(84, 52);
            lbRegistros.Name = "lbRegistros";
            lbRegistros.Size = new Size(119, 25);
            lbRegistros.TabIndex = 68;
            lbRegistros.Text = "DESCARTES";
            // 
            // btn_ProcurArquivos
            // 
            btn_ProcurArquivos.Anchor = AnchorStyles.Top;
            btn_ProcurArquivos.BackColor = Color.FromArgb(35, 68, 57);
            btn_ProcurArquivos.FlatAppearance.BorderColor = Color.FromArgb(35, 68, 57);
            btn_ProcurArquivos.FlatAppearance.BorderSize = 0;
            btn_ProcurArquivos.FlatStyle = FlatStyle.Flat;
            btn_ProcurArquivos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ProcurArquivos.ForeColor = Color.White;
            btn_ProcurArquivos.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_ProcurArquivos.IconColor = Color.White;
            btn_ProcurArquivos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_ProcurArquivos.IconSize = 25;
            btn_ProcurArquivos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ProcurArquivos.Location = new Point(754, 141);
            btn_ProcurArquivos.Name = "btn_ProcurArquivos";
            btn_ProcurArquivos.Padding = new Padding(5, 0, 0, 0);
            btn_ProcurArquivos.Size = new Size(139, 29);
            btn_ProcurArquivos.TabIndex = 70;
            btn_ProcurArquivos.Text = "Procurar Arquivos";
            btn_ProcurArquivos.UseVisualStyleBackColor = false;
            // 
            // lblAdmUploadRegistros
            // 
            lblAdmUploadRegistros.Anchor = AnchorStyles.Top;
            lblAdmUploadRegistros.AutoSize = true;
            lblAdmUploadRegistros.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmUploadRegistros.Location = new Point(582, 145);
            lblAdmUploadRegistros.Name = "lblAdmUploadRegistros";
            lblAdmUploadRegistros.Size = new Size(156, 21);
            lblAdmUploadRegistros.TabIndex = 69;
            lblAdmUploadRegistros.Text = "Upload de arquivos:";
            // 
            // btn_LimparFiltros
            // 
            btn_LimparFiltros.Anchor = AnchorStyles.Top;
            btn_LimparFiltros.BackColor = Color.White;
            btn_LimparFiltros.FlatAppearance.BorderColor = Color.FromArgb(35, 68, 57);
            btn_LimparFiltros.FlatAppearance.BorderSize = 2;
            btn_LimparFiltros.FlatStyle = FlatStyle.Flat;
            btn_LimparFiltros.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_LimparFiltros.ForeColor = Color.FromArgb(35, 68, 57);
            btn_LimparFiltros.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_LimparFiltros.IconColor = Color.White;
            btn_LimparFiltros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_LimparFiltros.IconSize = 25;
            btn_LimparFiltros.ImageAlign = ContentAlignment.MiddleLeft;
            btn_LimparFiltros.Location = new Point(664, 559);
            btn_LimparFiltros.Name = "btn_LimparFiltros";
            btn_LimparFiltros.Padding = new Padding(5, 0, 0, 0);
            btn_LimparFiltros.Size = new Size(113, 41);
            btn_LimparFiltros.TabIndex = 71;
            btn_LimparFiltros.Text = "Limpar Filtros";
            btn_LimparFiltros.UseVisualStyleBackColor = false;
            btn_LimparFiltros.Click += btn_LimparFiltros_Click;
            // 
            // cb_Peso
            // 
            cb_Peso.Anchor = AnchorStyles.Top;
            cb_Peso.FlatStyle = FlatStyle.Flat;
            cb_Peso.FormattingEnabled = true;
            cb_Peso.Location = new Point(338, 146);
            cb_Peso.Name = "cb_Peso";
            cb_Peso.Size = new Size(109, 23);
            cb_Peso.TabIndex = 73;
            cb_Peso.KeyPress += cb_Peso_KeyPress;
            // 
            // btn_Salvar
            // 
            btn_Salvar.Anchor = AnchorStyles.Top;
            btn_Salvar.BackColor = Color.FromArgb(35, 68, 57);
            btn_Salvar.FlatStyle = FlatStyle.Flat;
            btn_Salvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Salvar.ForeColor = Color.White;
            btn_Salvar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btn_Salvar.IconColor = Color.White;
            btn_Salvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Salvar.IconSize = 25;
            btn_Salvar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Salvar.Location = new Point(788, 559);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Padding = new Padding(3, 0, 0, 0);
            btn_Salvar.Size = new Size(105, 41);
            btn_Salvar.TabIndex = 75;
            btn_Salvar.Text = "       Salvar ";
            btn_Salvar.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(338, 330);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(109, 23);
            comboBox1.TabIndex = 78;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(453, 332);
            label1.Name = "label1";
            label1.Size = new Size(26, 19);
            label1.TabIndex = 77;
            label1.Text = "Kg";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(287, 331);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 76;
            label2.Text = "Peso :";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(338, 390);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(109, 23);
            comboBox2.TabIndex = 81;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(453, 392);
            label3.Name = "label3";
            label3.Size = new Size(26, 19);
            label3.TabIndex = 80;
            label3.Text = "Kg";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(287, 391);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 79;
            label4.Text = "Peso :";
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Top;
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(338, 456);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(109, 23);
            comboBox3.TabIndex = 84;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(453, 458);
            label5.Name = "label5";
            label5.Size = new Size(26, 19);
            label5.TabIndex = 83;
            label5.Text = "Kg";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(287, 457);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 82;
            label6.Text = "Peso :";
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.Top;
            comboBox4.FlatStyle = FlatStyle.Flat;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(338, 518);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(109, 23);
            comboBox4.TabIndex = 87;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(453, 520);
            label7.Name = "label7";
            label7.Size = new Size(26, 19);
            label7.TabIndex = 86;
            label7.Text = "Kg";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(287, 519);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 85;
            label8.Text = "Peso :";
            // 
            // comboBox5
            // 
            comboBox5.Anchor = AnchorStyles.Top;
            comboBox5.FlatStyle = FlatStyle.Flat;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(338, 267);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(109, 23);
            comboBox5.TabIndex = 90;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(453, 269);
            label9.Name = "label9";
            label9.Size = new Size(26, 19);
            label9.TabIndex = 89;
            label9.Text = "Kg";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(287, 268);
            label10.Name = "label10";
            label10.Size = new Size(52, 21);
            label10.TabIndex = 88;
            label10.Text = "Peso :";
            // 
            // comboBox6
            // 
            comboBox6.Anchor = AnchorStyles.Top;
            comboBox6.FlatStyle = FlatStyle.Flat;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(338, 206);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(109, 23);
            comboBox6.TabIndex = 93;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label11.Location = new Point(453, 208);
            label11.Name = "label11";
            label11.Size = new Size(26, 19);
            label11.TabIndex = 92;
            label11.Text = "Kg";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(287, 207);
            label12.Name = "label12";
            label12.Size = new Size(52, 21);
            label12.TabIndex = 91;
            label12.Text = "Peso :";
            // 
            // UCAdm_Descartes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox6);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(comboBox5);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(comboBox4);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(comboBox3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btn_Salvar);
            Controls.Add(cb_Peso);
            Controls.Add(lbRegistros);
            Controls.Add(btn_LimparFiltros);
            Controls.Add(btn_ProcurArquivos);
            Controls.Add(lblAdmUploadRegistros);
            Controls.Add(cb_Destino);
            Controls.Add(lblAdmSeleData);
            Controls.Add(btn_EditarLista);
            Controls.Add(lblAdmKg);
            Controls.Add(textLixoOutrasInfo);
            Controls.Add(panelTiposdeDescartes);
            Controls.Add(dateTimeRegistros);
            Controls.Add(LblLixoOutrasInfo);
            Controls.Add(lblLixoDestino);
            Controls.Add(lbllixoReciclavel);
            Controls.Add(lblTiposdemateriais);
            Name = "UCAdm_Descartes";
            Size = new Size(978, 646);
            panelTiposdeDescartes.ResumeLayout(false);
            panelTiposdeDescartes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTiposdemateriais;
        private Label lbllixoReciclavel;
        private Label lblLixoDestino;
        private Label LblLixoOutrasInfo;
        private DateTimePicker dateTimeRegistros;
        private CheckBox cb_TipoVidro;
        private CheckBox cb_TipoMetal;
        private CheckBox cb_TipoEletronico;
        private CheckBox cb_TipoMedicamentos;
        private CheckBox cb_TipoPlastico;
        private CheckBox cb_TipoPapel;
        private Panel panelTiposdeDescartes;
        private TextBox textLixoOutrasInfo;
        private Label lblAdmKg;
        private FontAwesome.Sharp.IconButton btn_EditarLista;
        private Label lblAdmSeleData;
        private ComboBox cb_Destino;
        private Label lbRegistros;
        private FontAwesome.Sharp.IconButton btn_ProcurArquivos;
        private Label lblAdmUploadRegistros;
        private FontAwesome.Sharp.IconButton btn_LimparFiltros;
        private ComboBox cb_Peso;
        private CheckBox cb_TipoOrganico;
        private FontAwesome.Sharp.IconButton btn_Salvar;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox3;
        private Label label5;
        private Label label6;
        private ComboBox comboBox4;
        private Label label7;
        private Label label8;
        private ComboBox comboBox5;
        private Label label9;
        private Label label10;
        private ComboBox comboBox6;
        private Label label11;
        private Label label12;
    }
}
