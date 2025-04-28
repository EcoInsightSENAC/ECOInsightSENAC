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
            panelTiposdeDescartes.SuspendLayout();
            SuspendLayout();
            // 
            // lblTiposdemateriais
            // 
            lblTiposdemateriais.Anchor = AnchorStyles.Top;
            lblTiposdemateriais.AutoSize = true;
            lblTiposdemateriais.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiposdemateriais.Location = new Point(88, 118);
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
            lbllixoReciclavel.Location = new Point(92, 286);
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
            lblLixoDestino.Location = new Point(523, 337);
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
            LblLixoOutrasInfo.Location = new Point(90, 337);
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
            dateTimeRegistros.Location = new Point(757, 419);
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
            cb_TipoVidro.Location = new Point(331, 14);
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
            cb_TipoMetal.Location = new Point(416, 14);
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
            cb_TipoEletronico.Location = new Point(503, 14);
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
            cb_TipoMedicamentos.Location = new Point(624, 14);
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
            cb_TipoPlastico.Location = new Point(228, 14);
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
            cb_TipoPapel.Location = new Point(142, 14);
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
            panelTiposdeDescartes.Controls.Add(cb_TipoOrganico);
            panelTiposdeDescartes.Controls.Add(cb_TipoPapel);
            panelTiposdeDescartes.Controls.Add(cb_TipoPlastico);
            panelTiposdeDescartes.Controls.Add(cb_TipoMedicamentos);
            panelTiposdeDescartes.Controls.Add(cb_TipoEletronico);
            panelTiposdeDescartes.Controls.Add(cb_TipoMetal);
            panelTiposdeDescartes.Controls.Add(cb_TipoVidro);
            panelTiposdeDescartes.Location = new Point(88, 154);
            panelTiposdeDescartes.Name = "panelTiposdeDescartes";
            panelTiposdeDescartes.Size = new Size(801, 55);
            panelTiposdeDescartes.TabIndex = 43;
            // 
            // cb_TipoOrganico
            // 
            cb_TipoOrganico.Anchor = AnchorStyles.Top;
            cb_TipoOrganico.AutoSize = true;
            cb_TipoOrganico.FlatStyle = FlatStyle.Flat;
            cb_TipoOrganico.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cb_TipoOrganico.Location = new Point(29, 14);
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
            textLixoOutrasInfo.Location = new Point(90, 371);
            textLixoOutrasInfo.Multiline = true;
            textLixoOutrasInfo.Name = "textLixoOutrasInfo";
            textLixoOutrasInfo.Size = new Size(366, 76);
            textLixoOutrasInfo.TabIndex = 44;
            // 
            // lblAdmKg
            // 
            lblAdmKg.Anchor = AnchorStyles.Top;
            lblAdmKg.AutoSize = true;
            lblAdmKg.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblAdmKg.Location = new Point(326, 287);
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
            btn_EditarLista.Location = new Point(806, 215);
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
            lblAdmSeleData.Location = new Point(625, 423);
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
            cb_Destino.Location = new Point(525, 371);
            cb_Destino.Name = "cb_Destino";
            cb_Destino.Size = new Size(366, 23);
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
            btn_ProcurArquivos.Location = new Point(736, 281);
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
            lblAdmUploadRegistros.Location = new Point(564, 285);
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
            btn_LimparFiltros.Location = new Point(660, 488);
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
            cb_Peso.Location = new Point(143, 285);
            cb_Peso.Name = "cb_Peso";
            cb_Peso.Size = new Size(179, 23);
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
            btn_Salvar.Location = new Point(784, 488);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Padding = new Padding(3, 0, 0, 0);
            btn_Salvar.Size = new Size(105, 41);
            btn_Salvar.TabIndex = 75;
            btn_Salvar.Text = "       Salvar ";
            btn_Salvar.UseVisualStyleBackColor = false;
            // 
            // UCAdm_Descartes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
