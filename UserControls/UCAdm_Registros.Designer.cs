namespace ECOInsight.UserControls
{
    partial class UCAdm_Registros
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
            lblAdmAte = new Label();
            dateTimePicker2 = new DateTimePicker();
            btn_GerarPDF = new FontAwesome.Sharp.IconButton();
            dateTimePicker3 = new DateTimePicker();
            lblAdmGerarRelat = new Label();
            lbRegistros = new Label();
            lblAdmCategoria = new Label();
            lblAdmTipoDescarte = new Label();
            cb_Categoria = new ComboBox();
            cb_TipoDescarte = new ComboBox();
            lblAdmDestino = new Label();
            cb_Destino = new ComboBox();
            lblAdmGarrafasEcono = new Label();
            cb_GarrafasEcono = new ComboBox();
            btn_LimparFiltros = new FontAwesome.Sharp.IconButton();
            cb_Pesototal = new ComboBox();
            lblAdmPesoTotal = new Label();
            cb_Bebedouro = new ComboBox();
            lblAdmBebedouro = new Label();
            cb_TotalLitros = new ComboBox();
            lblAdmTotalLitros = new Label();
            label12 = new Label();
            lblAdmHumusColetado = new Label();
            lblAdmTipodeMinhoca = new Label();
            lblAdmMinhocarioN = new Label();
            gb_Descartes = new GroupBox();
            gb_ConsumodeAgua = new GroupBox();
            gb_Minhocario = new GroupBox();
            cb_HumusColetado = new ComboBox();
            cb_TipoMinhoca = new ComboBox();
            cb_Minhocario = new ComboBox();
            btn_RegistrosPesquisar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            gb_Descartes.SuspendLayout();
            gb_ConsumodeAgua.SuspendLayout();
            gb_Minhocario.SuspendLayout();
            SuspendLayout();
            // 
            // lblAdmAte
            // 
            lblAdmAte.Anchor = AnchorStyles.Top;
            lblAdmAte.AutoSize = true;
            lblAdmAte.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmAte.Location = new Point(359, 544);
            lblAdmAte.Name = "lblAdmAte";
            lblAdmAte.Size = new Size(44, 21);
            lblAdmAte.TabIndex = 51;
            lblAdmAte.Text = "Até: ";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Top;
            dateTimePicker2.Font = new Font("Segoe UI", 11F);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(240, 541);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(100, 27);
            dateTimePicker2.TabIndex = 55;
            dateTimePicker2.Value = new DateTime(2025, 4, 20, 22, 40, 38, 0);
            // 
            // btn_GerarPDF
            // 
            btn_GerarPDF.Anchor = AnchorStyles.Top;
            btn_GerarPDF.BackColor = Color.FromArgb(35, 68, 57);
            btn_GerarPDF.FlatStyle = FlatStyle.Flat;
            btn_GerarPDF.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_GerarPDF.ForeColor = Color.White;
            btn_GerarPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btn_GerarPDF.IconColor = Color.White;
            btn_GerarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_GerarPDF.IconSize = 25;
            btn_GerarPDF.ImageAlign = ContentAlignment.MiddleLeft;
            btn_GerarPDF.Location = new Point(776, 534);
            btn_GerarPDF.Name = "btn_GerarPDF";
            btn_GerarPDF.Padding = new Padding(5, 0, 0, 0);
            btn_GerarPDF.Size = new Size(113, 41);
            btn_GerarPDF.TabIndex = 53;
            btn_GerarPDF.Text = "Gerar PDF";
            btn_GerarPDF.TextAlign = ContentAlignment.MiddleRight;
            btn_GerarPDF.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Anchor = AnchorStyles.Top;
            dateTimePicker3.Font = new Font("Segoe UI", 11F);
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(404, 541);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(100, 27);
            dateTimePicker3.TabIndex = 52;
            dateTimePicker3.Value = new DateTime(2025, 4, 20, 22, 40, 38, 0);
            // 
            // lblAdmGerarRelat
            // 
            lblAdmGerarRelat.Anchor = AnchorStyles.Top;
            lblAdmGerarRelat.AutoSize = true;
            lblAdmGerarRelat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmGerarRelat.Location = new Point(91, 544);
            lblAdmGerarRelat.Name = "lblAdmGerarRelat";
            lblAdmGerarRelat.Size = new Size(152, 21);
            lblAdmGerarRelat.TabIndex = 54;
            lblAdmGerarRelat.Text = "Gerar Relatório de: ";
            // 
            // lbRegistros
            // 
            lbRegistros.Anchor = AnchorStyles.Top;
            lbRegistros.AutoSize = true;
            lbRegistros.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRegistros.ForeColor = Color.FromArgb(35, 68, 57);
            lbRegistros.Location = new Point(84, 52);
            lbRegistros.Name = "lbRegistros";
            lbRegistros.Size = new Size(118, 25);
            lbRegistros.TabIndex = 69;
            lbRegistros.Text = "REGISTROS";
            // 
            // lblAdmCategoria
            // 
            lblAdmCategoria.Anchor = AnchorStyles.Top;
            lblAdmCategoria.AutoSize = true;
            lblAdmCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmCategoria.Location = new Point(102, 124);
            lblAdmCategoria.Name = "lblAdmCategoria";
            lblAdmCategoria.Size = new Size(84, 21);
            lblAdmCategoria.TabIndex = 83;
            lblAdmCategoria.Text = "Categoria :";
            // 
            // lblAdmTipoDescarte
            // 
            lblAdmTipoDescarte.Anchor = AnchorStyles.Top;
            lblAdmTipoDescarte.AutoSize = true;
            lblAdmTipoDescarte.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmTipoDescarte.Location = new Point(13, 41);
            lblAdmTipoDescarte.Name = "lblAdmTipoDescarte";
            lblAdmTipoDescarte.Size = new Size(130, 21);
            lblAdmTipoDescarte.TabIndex = 84;
            lblAdmTipoDescarte.Text = "Tipo de descarte :";
            // 
            // cb_Categoria
            // 
            cb_Categoria.Anchor = AnchorStyles.Top;
            cb_Categoria.FormattingEnabled = true;
            cb_Categoria.Location = new Point(192, 123);
            cb_Categoria.Name = "cb_Categoria";
            cb_Categoria.Size = new Size(121, 23);
            cb_Categoria.TabIndex = 85;
            // 
            // cb_TipoDescarte
            // 
            cb_TipoDescarte.Anchor = AnchorStyles.Top;
            cb_TipoDescarte.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_TipoDescarte.FormattingEnabled = true;
            cb_TipoDescarte.Location = new Point(149, 37);
            cb_TipoDescarte.Name = "cb_TipoDescarte";
            cb_TipoDescarte.Size = new Size(121, 29);
            cb_TipoDescarte.TabIndex = 86;
            // 
            // lblAdmDestino
            // 
            lblAdmDestino.Anchor = AnchorStyles.Top;
            lblAdmDestino.AutoSize = true;
            lblAdmDestino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmDestino.Location = new Point(322, 41);
            lblAdmDestino.Name = "lblAdmDestino";
            lblAdmDestino.Size = new Size(70, 21);
            lblAdmDestino.TabIndex = 87;
            lblAdmDestino.Text = "Destino :";
            // 
            // cb_Destino
            // 
            cb_Destino.Anchor = AnchorStyles.Top;
            cb_Destino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_Destino.FormattingEnabled = true;
            cb_Destino.Location = new Point(398, 37);
            cb_Destino.Name = "cb_Destino";
            cb_Destino.Size = new Size(121, 29);
            cb_Destino.TabIndex = 88;
            // 
            // lblAdmGarrafasEcono
            // 
            lblAdmGarrafasEcono.Anchor = AnchorStyles.Top;
            lblAdmGarrafasEcono.AutoSize = true;
            lblAdmGarrafasEcono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmGarrafasEcono.Location = new Point(247, 41);
            lblAdmGarrafasEcono.Name = "lblAdmGarrafasEcono";
            lblAdmGarrafasEcono.Size = new Size(179, 21);
            lblAdmGarrafasEcono.TabIndex = 89;
            lblAdmGarrafasEcono.Text = "Garrafas economizadas :";
            // 
            // cb_GarrafasEcono
            // 
            cb_GarrafasEcono.Anchor = AnchorStyles.Top;
            cb_GarrafasEcono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_GarrafasEcono.FormattingEnabled = true;
            cb_GarrafasEcono.Location = new Point(432, 37);
            cb_GarrafasEcono.Name = "cb_GarrafasEcono";
            cb_GarrafasEcono.Size = new Size(121, 29);
            cb_GarrafasEcono.TabIndex = 90;
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
            btn_LimparFiltros.Location = new Point(529, 534);
            btn_LimparFiltros.Name = "btn_LimparFiltros";
            btn_LimparFiltros.Padding = new Padding(5, 0, 0, 0);
            btn_LimparFiltros.Size = new Size(113, 41);
            btn_LimparFiltros.TabIndex = 95;
            btn_LimparFiltros.Text = "Limpar Filtros";
            btn_LimparFiltros.UseVisualStyleBackColor = false;
            btn_LimparFiltros.Click += btn_LimparFiltros_Click;
            // 
            // cb_Pesototal
            // 
            cb_Pesototal.Anchor = AnchorStyles.Top;
            cb_Pesototal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_Pesototal.FormattingEnabled = true;
            cb_Pesototal.Location = new Point(642, 37);
            cb_Pesototal.Name = "cb_Pesototal";
            cb_Pesototal.Size = new Size(121, 29);
            cb_Pesototal.TabIndex = 97;
            // 
            // lblAdmPesoTotal
            // 
            lblAdmPesoTotal.Anchor = AnchorStyles.Top;
            lblAdmPesoTotal.AutoSize = true;
            lblAdmPesoTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmPesoTotal.Location = new Point(556, 41);
            lblAdmPesoTotal.Name = "lblAdmPesoTotal";
            lblAdmPesoTotal.Size = new Size(84, 21);
            lblAdmPesoTotal.TabIndex = 96;
            lblAdmPesoTotal.Text = "Peso total :";
            // 
            // cb_Bebedouro
            // 
            cb_Bebedouro.Anchor = AnchorStyles.Top;
            cb_Bebedouro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_Bebedouro.FormattingEnabled = true;
            cb_Bebedouro.Location = new Point(113, 37);
            cb_Bebedouro.Name = "cb_Bebedouro";
            cb_Bebedouro.Size = new Size(121, 29);
            cb_Bebedouro.TabIndex = 99;
            // 
            // lblAdmBebedouro
            // 
            lblAdmBebedouro.Anchor = AnchorStyles.Top;
            lblAdmBebedouro.AutoSize = true;
            lblAdmBebedouro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmBebedouro.Location = new Point(14, 41);
            lblAdmBebedouro.Name = "lblAdmBebedouro";
            lblAdmBebedouro.Size = new Size(93, 21);
            lblAdmBebedouro.TabIndex = 98;
            lblAdmBebedouro.Text = "Bebedouro :";
            // 
            // cb_TotalLitros
            // 
            cb_TotalLitros.Anchor = AnchorStyles.Top;
            cb_TotalLitros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_TotalLitros.FormattingEnabled = true;
            cb_TotalLitros.Location = new Point(652, 37);
            cb_TotalLitros.Name = "cb_TotalLitros";
            cb_TotalLitros.Size = new Size(121, 29);
            cb_TotalLitros.TabIndex = 101;
            // 
            // lblAdmTotalLitros
            // 
            lblAdmTotalLitros.Anchor = AnchorStyles.Top;
            lblAdmTotalLitros.AutoSize = true;
            lblAdmTotalLitros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmTotalLitros.Location = new Point(564, 41);
            lblAdmTotalLitros.Name = "lblAdmTotalLitros";
            lblAdmTotalLitros.Size = new Size(88, 21);
            lblAdmTotalLitros.TabIndex = 100;
            lblAdmTotalLitros.Text = "Total litros :";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(762, 40);
            label12.Name = "label12";
            label12.Size = new Size(27, 17);
            label12.TabIndex = 108;
            label12.Text = "Kg.";
            // 
            // lblAdmHumusColetado
            // 
            lblAdmHumusColetado.Anchor = AnchorStyles.Top;
            lblAdmHumusColetado.AutoSize = true;
            lblAdmHumusColetado.Font = new Font("Segoe UI", 12F);
            lblAdmHumusColetado.Location = new Point(543, 38);
            lblAdmHumusColetado.Name = "lblAdmHumusColetado";
            lblAdmHumusColetado.Size = new Size(133, 21);
            lblAdmHumusColetado.TabIndex = 106;
            lblAdmHumusColetado.Text = "Húmus Coletado :";
            // 
            // lblAdmTipodeMinhoca
            // 
            lblAdmTipodeMinhoca.Anchor = AnchorStyles.Top;
            lblAdmTipodeMinhoca.AutoSize = true;
            lblAdmTipodeMinhoca.Font = new Font("Segoe UI", 12F);
            lblAdmTipodeMinhoca.Location = new Point(295, 38);
            lblAdmTipodeMinhoca.Name = "lblAdmTipodeMinhoca";
            lblAdmTipodeMinhoca.Size = new Size(132, 21);
            lblAdmTipodeMinhoca.TabIndex = 104;
            lblAdmTipodeMinhoca.Text = "Tipo de Minhoca :";
            // 
            // lblAdmMinhocarioN
            // 
            lblAdmMinhocarioN.Anchor = AnchorStyles.Top;
            lblAdmMinhocarioN.AutoSize = true;
            lblAdmMinhocarioN.Font = new Font("Segoe UI", 12F);
            lblAdmMinhocarioN.Location = new Point(14, 38);
            lblAdmMinhocarioN.Name = "lblAdmMinhocarioN";
            lblAdmMinhocarioN.Size = new Size(155, 21);
            lblAdmMinhocarioN.TabIndex = 102;
            lblAdmMinhocarioN.Text = "Minhocario número :";
            // 
            // gb_Descartes
            // 
            gb_Descartes.Anchor = AnchorStyles.Top;
            gb_Descartes.Controls.Add(label1);
            gb_Descartes.Controls.Add(cb_Destino);
            gb_Descartes.Controls.Add(lblAdmTipoDescarte);
            gb_Descartes.Controls.Add(cb_TipoDescarte);
            gb_Descartes.Controls.Add(lblAdmDestino);
            gb_Descartes.Controls.Add(lblAdmPesoTotal);
            gb_Descartes.Controls.Add(cb_Pesototal);
            gb_Descartes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_Descartes.Location = new Point(89, 180);
            gb_Descartes.Name = "gb_Descartes";
            gb_Descartes.Size = new Size(800, 76);
            gb_Descartes.TabIndex = 112;
            gb_Descartes.TabStop = false;
            gb_Descartes.Text = "DESCARTES";
            // 
            // gb_ConsumodeAgua
            // 
            gb_ConsumodeAgua.Anchor = AnchorStyles.Top;
            gb_ConsumodeAgua.Controls.Add(label2);
            gb_ConsumodeAgua.Controls.Add(cb_GarrafasEcono);
            gb_ConsumodeAgua.Controls.Add(lblAdmGarrafasEcono);
            gb_ConsumodeAgua.Controls.Add(lblAdmBebedouro);
            gb_ConsumodeAgua.Controls.Add(cb_Bebedouro);
            gb_ConsumodeAgua.Controls.Add(lblAdmTotalLitros);
            gb_ConsumodeAgua.Controls.Add(cb_TotalLitros);
            gb_ConsumodeAgua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_ConsumodeAgua.Location = new Point(89, 284);
            gb_ConsumodeAgua.Name = "gb_ConsumodeAgua";
            gb_ConsumodeAgua.Size = new Size(800, 76);
            gb_ConsumodeAgua.TabIndex = 113;
            gb_ConsumodeAgua.TabStop = false;
            gb_ConsumodeAgua.Text = "CONSUMO DE ÁGUA";
            // 
            // gb_Minhocario
            // 
            gb_Minhocario.Anchor = AnchorStyles.Top;
            gb_Minhocario.Controls.Add(cb_HumusColetado);
            gb_Minhocario.Controls.Add(cb_TipoMinhoca);
            gb_Minhocario.Controls.Add(cb_Minhocario);
            gb_Minhocario.Controls.Add(lblAdmHumusColetado);
            gb_Minhocario.Controls.Add(lblAdmMinhocarioN);
            gb_Minhocario.Controls.Add(lblAdmTipodeMinhoca);
            gb_Minhocario.Controls.Add(label12);
            gb_Minhocario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_Minhocario.Location = new Point(89, 390);
            gb_Minhocario.Name = "gb_Minhocario";
            gb_Minhocario.Size = new Size(800, 76);
            gb_Minhocario.TabIndex = 114;
            gb_Minhocario.TabStop = false;
            gb_Minhocario.Text = "MINHOCARIO";
            // 
            // cb_HumusColetado
            // 
            cb_HumusColetado.Anchor = AnchorStyles.Top;
            cb_HumusColetado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_HumusColetado.FormattingEnabled = true;
            cb_HumusColetado.Location = new Point(673, 34);
            cb_HumusColetado.Name = "cb_HumusColetado";
            cb_HumusColetado.Size = new Size(83, 29);
            cb_HumusColetado.TabIndex = 111;
            // 
            // cb_TipoMinhoca
            // 
            cb_TipoMinhoca.Anchor = AnchorStyles.Top;
            cb_TipoMinhoca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_TipoMinhoca.FormattingEnabled = true;
            cb_TipoMinhoca.Location = new Point(432, 34);
            cb_TipoMinhoca.Name = "cb_TipoMinhoca";
            cb_TipoMinhoca.Size = new Size(105, 29);
            cb_TipoMinhoca.TabIndex = 110;
            // 
            // cb_Minhocario
            // 
            cb_Minhocario.Anchor = AnchorStyles.Top;
            cb_Minhocario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_Minhocario.FormattingEnabled = true;
            cb_Minhocario.Location = new Point(168, 34);
            cb_Minhocario.Name = "cb_Minhocario";
            cb_Minhocario.Size = new Size(118, 29);
            cb_Minhocario.TabIndex = 109;
            // 
            // btn_RegistrosPesquisar
            // 
            btn_RegistrosPesquisar.Anchor = AnchorStyles.Top;
            btn_RegistrosPesquisar.BackColor = Color.FromArgb(35, 68, 57);
            btn_RegistrosPesquisar.FlatStyle = FlatStyle.Flat;
            btn_RegistrosPesquisar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_RegistrosPesquisar.ForeColor = Color.White;
            btn_RegistrosPesquisar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btn_RegistrosPesquisar.IconColor = Color.White;
            btn_RegistrosPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_RegistrosPesquisar.IconSize = 25;
            btn_RegistrosPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_RegistrosPesquisar.Location = new Point(653, 534);
            btn_RegistrosPesquisar.Name = "btn_RegistrosPesquisar";
            btn_RegistrosPesquisar.Padding = new Padding(5, 0, 0, 0);
            btn_RegistrosPesquisar.Size = new Size(113, 41);
            btn_RegistrosPesquisar.TabIndex = 115;
            btn_RegistrosPesquisar.Text = "Pesquisar";
            btn_RegistrosPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btn_RegistrosPesquisar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(767, 45);
            label1.Name = "label1";
            label1.Size = new Size(27, 17);
            label1.TabIndex = 109;
            label1.Text = "Kg.";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(775, 46);
            label2.Name = "label2";
            label2.Size = new Size(17, 17);
            label2.TabIndex = 112;
            label2.Text = "L.";
            // 
            // UCAdm_Registros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_RegistrosPesquisar);
            Controls.Add(lblAdmAte);
            Controls.Add(gb_Minhocario);
            Controls.Add(dateTimePicker2);
            Controls.Add(gb_ConsumodeAgua);
            Controls.Add(btn_GerarPDF);
            Controls.Add(dateTimePicker3);
            Controls.Add(gb_Descartes);
            Controls.Add(lblAdmGerarRelat);
            Controls.Add(btn_LimparFiltros);
            Controls.Add(cb_Categoria);
            Controls.Add(lblAdmCategoria);
            Controls.Add(lbRegistros);
            Name = "UCAdm_Registros";
            Size = new Size(978, 646);
            gb_Descartes.ResumeLayout(false);
            gb_Descartes.PerformLayout();
            gb_ConsumodeAgua.ResumeLayout(false);
            gb_ConsumodeAgua.PerformLayout();
            gb_Minhocario.ResumeLayout(false);
            gb_Minhocario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAdmAte;
        private DateTimePicker dateTimePicker2;
        private FontAwesome.Sharp.IconButton btn_GerarPDF;
        private DateTimePicker dateTimePicker3;
        private Label lblAdmGerarRelat;
        private Label lbRegistros;
        private Label lblAdmCategoria;
        private Label lblAdmTipoDescarte;
        private ComboBox cb_Categoria;
        private ComboBox cb_TipoDescarte;
        private Label lblAdmDestino;
        private ComboBox cb_Destino;
        private Label lblAdmGarrafasEcono;
        private ComboBox cb_GarrafasEcono;
        private FontAwesome.Sharp.IconButton btn_LimparFiltros;
        private ComboBox cb_Pesototal;
        private Label lblAdmPesoTotal;
        private ComboBox cb_Bebedouro;
        private Label lblAdmBebedouro;
        private ComboBox cb_TotalLitros;
        private Label lblAdmTotalLitros;
        private Label label12;
        private Label lblAdmHumusColetado;
        private Label lblAdmTipodeMinhoca;
        private Label lblAdmMinhocarioN;
        private GroupBox gb_Descartes;
        private GroupBox gb_ConsumodeAgua;
        private GroupBox gb_Minhocario;
        private ComboBox cb_HumusColetado;
        private ComboBox cb_TipoMinhoca;
        private ComboBox cb_Minhocario;
        private FontAwesome.Sharp.IconButton btn_RegistrosPesquisar;
        private Label label1;
        private Label label2;
    }
}
