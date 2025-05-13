
using ECOInsight.DataAccess;
using ECOInsight.Modelos;
using System.Windows.Media.Media3D;

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
            lbl_PesoOrganic = new Label();
            lblLocalColeta = new Label();
            LblLixoOutrasInfo = new Label();
            dateTimeDescartess = new DateTimePicker();
            cb_TipoVidro = new CheckBox();
            cb_TipoMetal = new CheckBox();
            cb_TipoEletronico = new CheckBox();
            cb_TipoMedicamentos = new CheckBox();
            cb_TipoPlastico = new CheckBox();
            cb_TipoPapel = new CheckBox();
            panelTiposdeDescartes = new Panel();
            cb_TipoOrganico = new CheckBox();
            txt_DescartesOutrasInfo = new TextBox();
            lblAdmKg = new Label();
            btn_EditarLista = new FontAwesome.Sharp.IconButton();
            lblAdmSeleData = new Label();
            lbRegistros = new Label();
            btn_ProcurArquivos = new FontAwesome.Sharp.IconButton();
            lblAdmUploadRegistros = new Label();
            btn_LimparFiltros = new FontAwesome.Sharp.IconButton();
            btn_Salvar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            lbl_PesoVidro = new Label();
            label3 = new Label();
            lbl_PesoMetal = new Label();
            label5 = new Label();
            lbl_PesoEletronico = new Label();
            label7 = new Label();
            lbl_PesoMedicamentos = new Label();
            label9 = new Label();
            lbl_PesoPlastico = new Label();
            label11 = new Label();
            lbl_PesoPapel = new Label();
            txt_TipoOrganico = new TextBox();
            txt_TipoPapel = new TextBox();
            txt_TipoPlastico = new TextBox();
            txt_TipoVidro = new TextBox();
            txt_TipoMetal = new TextBox();
            txt_TipoEletronico = new TextBox();
            txt_TipoMedicamentos = new TextBox();
            lblAdmFuncionario = new Label();
            cb_Funcionario = new ComboBox();
            cb_MaterialReciclavel = new ComboBox();
            lblAdmMaterReciclavel = new Label();
            lblAdmDestinoColeta = new Label();
            txt_LocalColeta = new TextBox();
            txt_DestinoColeta = new TextBox();
            txt_Quantidade = new TextBox();
            lblAdmQuantidade = new Label();
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
            // lbl_PesoOrganic
            // 
            lbl_PesoOrganic.Anchor = AnchorStyles.Top;
            lbl_PesoOrganic.AutoSize = true;
            lbl_PesoOrganic.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PesoOrganic.Location = new Point(287, 143);
            lbl_PesoOrganic.Name = "lbl_PesoOrganic";
            lbl_PesoOrganic.Size = new Size(52, 21);
            lbl_PesoOrganic.TabIndex = 29;
            lbl_PesoOrganic.Text = "Peso :";
            // 
            // lblLocalColeta
            // 
            lblLocalColeta.Anchor = AnchorStyles.Top;
            lblLocalColeta.AutoSize = true;
            lblLocalColeta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocalColeta.Location = new Point(581, 273);
            lblLocalColeta.Name = "lblLocalColeta";
            lblLocalColeta.Size = new Size(129, 21);
            lblLocalColeta.TabIndex = 37;
            lblLocalColeta.Text = "Local da Coleta :";
            // 
            // LblLixoOutrasInfo
            // 
            LblLixoOutrasInfo.Anchor = AnchorStyles.Top;
            LblLixoOutrasInfo.AutoSize = true;
            LblLixoOutrasInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLixoOutrasInfo.Location = new Point(581, 480);
            LblLixoOutrasInfo.Name = "LblLixoOutrasInfo";
            LblLixoOutrasInfo.Size = new Size(158, 21);
            LblLixoOutrasInfo.TabIndex = 38;
            LblLixoOutrasInfo.Text = "Outras Informações ";
            // 
            // dateTimeDescartess
            // 
            dateTimeDescartess.Anchor = AnchorStyles.Top;
            dateTimeDescartess.Font = new Font("Segoe UI", 11F);
            dateTimeDescartess.Format = DateTimePickerFormat.Short;
            dateTimeDescartess.Location = new Point(714, 382);
            dateTimeDescartess.Name = "dateTimeDescartess";
            dateTimeDescartess.Size = new Size(179, 27);
            dateTimeDescartess.TabIndex = 39;
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
            cb_TipoVidro.CheckedChanged += cb_TipoVidro_CheckedChanged_1;
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
            cb_TipoMetal.CheckedChanged += cb_TipoMetal_CheckedChanged_1;
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
            cb_TipoEletronico.CheckedChanged += cb_TipoEletronico_CheckedChanged_1;
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
            cb_TipoMedicamentos.CheckedChanged += cb_TipoMedicamentos_CheckedChanged_1;
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
            cb_TipoPlastico.CheckedChanged += cb_TipoPlastico_CheckedChanged;
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
            cb_TipoPapel.CheckedChanged += cb_TipoPapel_CheckedChanged;
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
            cb_TipoOrganico.CheckedChanged += cb_TipoOrganico_CheckedChanged_1;
            // 
            // txt_DescartesOutrasInfo
            // 
            txt_DescartesOutrasInfo.Anchor = AnchorStyles.Top;
            txt_DescartesOutrasInfo.Location = new Point(583, 504);
            txt_DescartesOutrasInfo.Multiline = true;
            txt_DescartesOutrasInfo.Name = "txt_DescartesOutrasInfo";
            txt_DescartesOutrasInfo.Size = new Size(310, 44);
            txt_DescartesOutrasInfo.TabIndex = 44;
            txt_DescartesOutrasInfo.TextChanged += txt_DescartesOutrasInfo_TextChanged;
            // 
            // lblAdmKg
            // 
            lblAdmKg.Anchor = AnchorStyles.Top;
            lblAdmKg.AutoSize = true;
            lblAdmKg.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblAdmKg.Location = new Point(442, 144);
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
            btn_EditarLista.Location = new Point(86, 557);
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
            lblAdmSeleData.Location = new Point(582, 385);
            lblAdmSeleData.Name = "lblAdmSeleData";
            lblAdmSeleData.Size = new Size(126, 21);
            lblAdmSeleData.TabIndex = 59;
            lblAdmSeleData.Text = "Selecionar data:";
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
            btn_ProcurArquivos.Location = new Point(754, 433);
            btn_ProcurArquivos.Name = "btn_ProcurArquivos";
            btn_ProcurArquivos.Padding = new Padding(5, 0, 0, 0);
            btn_ProcurArquivos.Size = new Size(139, 29);
            btn_ProcurArquivos.TabIndex = 70;
            btn_ProcurArquivos.Text = "Procurar Arquivos";
            btn_ProcurArquivos.UseVisualStyleBackColor = false;
            btn_ProcurArquivos.Click += btn_ProcurArquivos_Click;
            // 
            // lblAdmUploadRegistros
            // 
            lblAdmUploadRegistros.Anchor = AnchorStyles.Top;
            lblAdmUploadRegistros.AutoSize = true;
            lblAdmUploadRegistros.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmUploadRegistros.Location = new Point(582, 437);
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
            btn_LimparFiltros.Location = new Point(664, 554);
            btn_LimparFiltros.Name = "btn_LimparFiltros";
            btn_LimparFiltros.Padding = new Padding(5, 0, 0, 0);
            btn_LimparFiltros.Size = new Size(113, 41);
            btn_LimparFiltros.TabIndex = 71;
            btn_LimparFiltros.Text = "Limpar Filtros";
            btn_LimparFiltros.UseVisualStyleBackColor = false;
            btn_LimparFiltros.Click += btn_LimparFiltros_Click;
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
            btn_Salvar.Location = new Point(788, 554);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Padding = new Padding(3, 0, 0, 0);
            btn_Salvar.Size = new Size(105, 41);
            btn_Salvar.TabIndex = 75;
            btn_Salvar.Text = "       Salvar ";
            btn_Salvar.UseVisualStyleBackColor = false;
            btn_Salvar.Click += this.btn_Salvar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(441, 331);
            label1.Name = "label1";
            label1.Size = new Size(26, 19);
            label1.TabIndex = 77;
            label1.Text = "Kg";
            // 
            // lbl_PesoVidro
            // 
            lbl_PesoVidro.Anchor = AnchorStyles.Top;
            lbl_PesoVidro.AutoSize = true;
            lbl_PesoVidro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PesoVidro.Location = new Point(287, 330);
            lbl_PesoVidro.Name = "lbl_PesoVidro";
            lbl_PesoVidro.Size = new Size(52, 21);
            lbl_PesoVidro.TabIndex = 76;
            lbl_PesoVidro.Text = "Peso :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(441, 393);
            label3.Name = "label3";
            label3.Size = new Size(26, 19);
            label3.TabIndex = 80;
            label3.Text = "Kg";
            // 
            // lbl_PesoMetal
            // 
            lbl_PesoMetal.Anchor = AnchorStyles.Top;
            lbl_PesoMetal.AutoSize = true;
            lbl_PesoMetal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PesoMetal.Location = new Point(287, 392);
            lbl_PesoMetal.Name = "lbl_PesoMetal";
            lbl_PesoMetal.Size = new Size(52, 21);
            lbl_PesoMetal.TabIndex = 79;
            lbl_PesoMetal.Text = "Peso :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(441, 455);
            label5.Name = "label5";
            label5.Size = new Size(26, 19);
            label5.TabIndex = 83;
            label5.Text = "Kg";
            // 
            // lbl_PesoEletronico
            // 
            lbl_PesoEletronico.Anchor = AnchorStyles.Top;
            lbl_PesoEletronico.AutoSize = true;
            lbl_PesoEletronico.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PesoEletronico.Location = new Point(287, 454);
            lbl_PesoEletronico.Name = "lbl_PesoEletronico";
            lbl_PesoEletronico.Size = new Size(52, 21);
            lbl_PesoEletronico.TabIndex = 82;
            lbl_PesoEletronico.Text = "Peso :";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(441, 515);
            label7.Name = "label7";
            label7.Size = new Size(26, 19);
            label7.TabIndex = 86;
            label7.Text = "Kg";
            // 
            // lbl_PesoMedicamentos
            // 
            lbl_PesoMedicamentos.Anchor = AnchorStyles.Top;
            lbl_PesoMedicamentos.AutoSize = true;
            lbl_PesoMedicamentos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PesoMedicamentos.Location = new Point(287, 514);
            lbl_PesoMedicamentos.Name = "lbl_PesoMedicamentos";
            lbl_PesoMedicamentos.Size = new Size(52, 21);
            lbl_PesoMedicamentos.TabIndex = 85;
            lbl_PesoMedicamentos.Text = "Peso :";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.Location = new Point(441, 269);
            label9.Name = "label9";
            label9.Size = new Size(26, 19);
            label9.TabIndex = 89;
            label9.Text = "Kg";
            // 
            // lbl_PesoPlastico
            // 
            lbl_PesoPlastico.Anchor = AnchorStyles.Top;
            lbl_PesoPlastico.AutoSize = true;
            lbl_PesoPlastico.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PesoPlastico.Location = new Point(287, 268);
            lbl_PesoPlastico.Name = "lbl_PesoPlastico";
            lbl_PesoPlastico.Size = new Size(52, 21);
            lbl_PesoPlastico.TabIndex = 88;
            lbl_PesoPlastico.Text = "Peso :";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label11.Location = new Point(441, 208);
            label11.Name = "label11";
            label11.Size = new Size(26, 19);
            label11.TabIndex = 92;
            label11.Text = "Kg";
            // 
            // lbl_PesoPapel
            // 
            lbl_PesoPapel.Anchor = AnchorStyles.Top;
            lbl_PesoPapel.AutoSize = true;
            lbl_PesoPapel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PesoPapel.Location = new Point(287, 207);
            lbl_PesoPapel.Name = "lbl_PesoPapel";
            lbl_PesoPapel.Size = new Size(52, 21);
            lbl_PesoPapel.TabIndex = 91;
            lbl_PesoPapel.Text = "Peso :";
            // 
            // txt_TipoOrganico
            // 
            txt_TipoOrganico.Anchor = AnchorStyles.Top;
            txt_TipoOrganico.Location = new Point(336, 142);
            txt_TipoOrganico.Name = "txt_TipoOrganico";
            txt_TipoOrganico.Size = new Size(100, 23);
            txt_TipoOrganico.TabIndex = 93;
            // 
            // txt_TipoPapel
            // 
            txt_TipoPapel.Anchor = AnchorStyles.Top;
            txt_TipoPapel.Location = new Point(336, 206);
            txt_TipoPapel.Name = "txt_TipoPapel";
            txt_TipoPapel.Size = new Size(100, 23);
            txt_TipoPapel.TabIndex = 94;
            // 
            // txt_TipoPlastico
            // 
            txt_TipoPlastico.Anchor = AnchorStyles.Top;
            txt_TipoPlastico.Location = new Point(336, 267);
            txt_TipoPlastico.Name = "txt_TipoPlastico";
            txt_TipoPlastico.Size = new Size(100, 23);
            txt_TipoPlastico.TabIndex = 95;
            // 
            // txt_TipoVidro
            // 
            txt_TipoVidro.Anchor = AnchorStyles.Top;
            txt_TipoVidro.Location = new Point(336, 329);
            txt_TipoVidro.Name = "txt_TipoVidro";
            txt_TipoVidro.Size = new Size(100, 23);
            txt_TipoVidro.TabIndex = 96;
            // 
            // txt_TipoMetal
            // 
            txt_TipoMetal.Anchor = AnchorStyles.Top;
            txt_TipoMetal.Location = new Point(336, 391);
            txt_TipoMetal.Name = "txt_TipoMetal";
            txt_TipoMetal.Size = new Size(100, 23);
            txt_TipoMetal.TabIndex = 97;
            // 
            // txt_TipoEletronico
            // 
            txt_TipoEletronico.Anchor = AnchorStyles.Top;
            txt_TipoEletronico.Location = new Point(336, 453);
            txt_TipoEletronico.Name = "txt_TipoEletronico";
            txt_TipoEletronico.Size = new Size(100, 23);
            txt_TipoEletronico.TabIndex = 98;
            // 
            // txt_TipoMedicamentos
            // 
            txt_TipoMedicamentos.Anchor = AnchorStyles.Top;
            txt_TipoMedicamentos.Location = new Point(336, 513);
            txt_TipoMedicamentos.Name = "txt_TipoMedicamentos";
            txt_TipoMedicamentos.Size = new Size(100, 23);
            txt_TipoMedicamentos.TabIndex = 99;
            // 
            // lblAdmFuncionario
            // 
            lblAdmFuncionario.Anchor = AnchorStyles.Top;
            lblAdmFuncionario.AutoSize = true;
            lblAdmFuncionario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmFuncionario.Location = new Point(581, 124);
            lblAdmFuncionario.Name = "lblAdmFuncionario";
            lblAdmFuncionario.Size = new Size(107, 21);
            lblAdmFuncionario.TabIndex = 100;
            lblAdmFuncionario.Text = "Funcionário : ";
            // 
            // cb_Funcionario
            // 
            cb_Funcionario.FlatStyle = FlatStyle.Flat;
            cb_Funcionario.FormattingEnabled = true;
            cb_Funcionario.Location = new Point(683, 123);
            cb_Funcionario.Name = "cb_Funcionario";
            cb_Funcionario.Size = new Size(209, 23);
            cb_Funcionario.TabIndex = 101;
            // 
            // cb_MaterialReciclavel
            // 
            cb_MaterialReciclavel.FlatStyle = FlatStyle.Flat;
            cb_MaterialReciclavel.FormattingEnabled = true;
            cb_MaterialReciclavel.Location = new Point(730, 170);
            cb_MaterialReciclavel.Name = "cb_MaterialReciclavel";
            cb_MaterialReciclavel.Size = new Size(163, 23);
            cb_MaterialReciclavel.TabIndex = 103;
            // 
            // lblAdmMaterReciclavel
            // 
            lblAdmMaterReciclavel.Anchor = AnchorStyles.Top;
            lblAdmMaterReciclavel.AutoSize = true;
            lblAdmMaterReciclavel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmMaterReciclavel.Location = new Point(583, 171);
            lblAdmMaterReciclavel.Name = "lblAdmMaterReciclavel";
            lblAdmMaterReciclavel.Size = new Size(158, 21);
            lblAdmMaterReciclavel.TabIndex = 102;
            lblAdmMaterReciclavel.Text = "Material Reciclável : ";
            // 
            // lblAdmDestinoColeta
            // 
            lblAdmDestinoColeta.Anchor = AnchorStyles.Top;
            lblAdmDestinoColeta.AutoSize = true;
            lblAdmDestinoColeta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmDestinoColeta.Location = new Point(581, 327);
            lblAdmDestinoColeta.Name = "lblAdmDestinoColeta";
            lblAdmDestinoColeta.Size = new Size(147, 21);
            lblAdmDestinoColeta.TabIndex = 104;
            lblAdmDestinoColeta.Text = "Destino da Coleta :";
            // 
            // txt_LocalColeta
            // 
            txt_LocalColeta.Location = new Point(711, 272);
            txt_LocalColeta.Name = "txt_LocalColeta";
            txt_LocalColeta.Size = new Size(181, 23);
            txt_LocalColeta.TabIndex = 106;
            // 
            // txt_DestinoColeta
            // 
            txt_DestinoColeta.Location = new Point(730, 326);
            txt_DestinoColeta.Name = "txt_DestinoColeta";
            txt_DestinoColeta.Size = new Size(163, 23);
            txt_DestinoColeta.TabIndex = 107;
            // 
            // txt_Quantidade
            // 
            txt_Quantidade.Location = new Point(683, 221);
            txt_Quantidade.Name = "txt_Quantidade";
            txt_Quantidade.Size = new Size(209, 23);
            txt_Quantidade.TabIndex = 109;
            // 
            // lblAdmQuantidade
            // 
            lblAdmQuantidade.Anchor = AnchorStyles.Top;
            lblAdmQuantidade.AutoSize = true;
            lblAdmQuantidade.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmQuantidade.Location = new Point(581, 222);
            lblAdmQuantidade.Name = "lblAdmQuantidade";
            lblAdmQuantidade.Size = new Size(103, 21);
            lblAdmQuantidade.TabIndex = 108;
            lblAdmQuantidade.Text = "Quantidade :";
            // 
            // UCAdm_Descartes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txt_Quantidade);
            Controls.Add(lblAdmQuantidade);
            Controls.Add(txt_DestinoColeta);
            Controls.Add(txt_LocalColeta);
            Controls.Add(lblAdmDestinoColeta);
            Controls.Add(cb_MaterialReciclavel);
            Controls.Add(lblAdmMaterReciclavel);
            Controls.Add(cb_Funcionario);
            Controls.Add(lblAdmFuncionario);
            Controls.Add(txt_TipoMedicamentos);
            Controls.Add(txt_TipoEletronico);
            Controls.Add(txt_TipoMetal);
            Controls.Add(txt_TipoVidro);
            Controls.Add(txt_TipoPlastico);
            Controls.Add(txt_TipoPapel);
            Controls.Add(txt_TipoOrganico);
            Controls.Add(label11);
            Controls.Add(lbl_PesoPapel);
            Controls.Add(label9);
            Controls.Add(lbl_PesoPlastico);
            Controls.Add(label7);
            Controls.Add(lbl_PesoMedicamentos);
            Controls.Add(label5);
            Controls.Add(lbl_PesoEletronico);
            Controls.Add(label3);
            Controls.Add(lbl_PesoMetal);
            Controls.Add(label1);
            Controls.Add(lbl_PesoVidro);
            Controls.Add(btn_Salvar);
            Controls.Add(lbRegistros);
            Controls.Add(btn_LimparFiltros);
            Controls.Add(btn_ProcurArquivos);
            Controls.Add(lblAdmUploadRegistros);
            Controls.Add(lblAdmSeleData);
            Controls.Add(btn_EditarLista);
            Controls.Add(lblAdmKg);
            Controls.Add(txt_DescartesOutrasInfo);
            Controls.Add(panelTiposdeDescartes);
            Controls.Add(dateTimeDescartess);
            Controls.Add(LblLixoOutrasInfo);
            Controls.Add(lblLocalColeta);
            Controls.Add(lbl_PesoOrganic);
            Controls.Add(lblTiposdemateriais);
            Name = "UCAdm_Descartes";
            Size = new Size(978, 646);
            Load += UCAdm_Descartes_Load;
            panelTiposdeDescartes.ResumeLayout(false);
            panelTiposdeDescartes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

       

       


        #endregion
        private Label lblTiposdemateriais;
        private Label lbl_PesoOrganic;
        private Label lblLocalColeta;
        private Label LblLixoOutrasInfo;
        private DateTimePicker dateTimeDescartess;
        private CheckBox cb_TipoVidro;
        private CheckBox cb_TipoMetal;
        private CheckBox cb_TipoEletronico;
        private CheckBox cb_TipoMedicamentos;
        private CheckBox cb_TipoPlastico;
        private CheckBox cb_TipoPapel;
        private Panel panelTiposdeDescartes;
        private TextBox txt_DescartesOutrasInfo;
        private Label lblAdmKg;
        private FontAwesome.Sharp.IconButton btn_EditarLista;
        private Label lblAdmSeleData;
        private Label lbRegistros;
        private FontAwesome.Sharp.IconButton btn_ProcurArquivos;
        private Label lblAdmUploadRegistros;
        private FontAwesome.Sharp.IconButton btn_LimparFiltros;
        private CheckBox cb_TipoOrganico;
        private FontAwesome.Sharp.IconButton btn_Salvar;
        private Label label1;
        private Label lbl_PesoVidro;
        private Label label3;
        private Label lbl_PesoMetal;
        private Label label5;
        private Label lbl_PesoEletronico;
        private Label label7;
        private Label lbl_PesoMedicamentos;
        private Label label9;
        private Label lbl_PesoPlastico;
        private Label label11;
        private Label lbl_PesoPapel;
        private TextBox txt_TipoOrganico;
        private TextBox txt_TipoPapel;
        private TextBox txt_TipoPlastico;
        private TextBox txt_TipoVidro;
        private TextBox txt_TipoMetal;
        private TextBox txt_TipoEletronico;
        private TextBox txt_TipoMedicamentos;
        private Label lblAdmFuncionario;
        private ComboBox cb_Funcionario;
        private ComboBox cb_MaterialReciclavel;
        private Label lblAdmMaterReciclavel;
        private Label lblAdmDestinoColeta;
        private TextBox txt_LocalColeta;
        private TextBox txt_DestinoColeta;
        private TextBox txt_Quantidade;
        private Label lblAdmQuantidade;
    }
}
