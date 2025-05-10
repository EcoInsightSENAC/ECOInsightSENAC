namespace ECOInsight.UserControls
{
    partial class UCAdm_Usuarios
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
            txtCadNome = new TextBox();
            lblPerfilCad = new Label();
            txtCadPerfil = new ComboBox();
            cbCadStatus = new ComboBox();
            label3 = new Label();
            btn_CadNovoUsuario = new FontAwesome.Sharp.IconButton();
            btn_CadExcluirUsuario = new FontAwesome.Sharp.IconButton();
            btn_CadSalvar = new FontAwesome.Sharp.IconButton();
            btn_CadCancelar = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            btn_CadEditarUsuario = new FontAwesome.Sharp.IconButton();
            lblConfirSenhaCad = new Label();
            txtCadConfirSenha = new TextBox();
            lblUsuarioCad = new Label();
            lblNomeCad = new Label();
            txtCadTelef = new TextBox();
            txtCadEmail = new TextBox();
            txtCadSenha = new TextBox();
            lblSenhaCad = new Label();
            lblEmailCad = new Label();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            txtCadTurno = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            btn_CadBuscarUsuario = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            comboBox2 = new ComboBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            btn_CadGerarPDF = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            lblAdmUsuarios = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // txtCadNome
            // 
            txtCadNome.Anchor = AnchorStyles.Top;
            txtCadNome.Location = new Point(17, 52);
            txtCadNome.Name = "txtCadNome";
            txtCadNome.Size = new Size(526, 23);
            txtCadNome.TabIndex = 0;
            // 
            // lblPerfilCad
            // 
            lblPerfilCad.Anchor = AnchorStyles.Top;
            lblPerfilCad.AutoSize = true;
            lblPerfilCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerfilCad.Location = new Point(18, 291);
            lblPerfilCad.Name = "lblPerfilCad";
            lblPerfilCad.Size = new Size(47, 21);
            lblPerfilCad.TabIndex = 20;
            lblPerfilCad.Text = "Perfil";
            // 
            // txtCadPerfil
            // 
            txtCadPerfil.Anchor = AnchorStyles.Top;
            txtCadPerfil.FlatStyle = FlatStyle.Flat;
            txtCadPerfil.FormattingEnabled = true;
            txtCadPerfil.Location = new Point(17, 316);
            txtCadPerfil.Name = "txtCadPerfil";
            txtCadPerfil.Size = new Size(312, 23);
            txtCadPerfil.TabIndex = 7;
            // 
            // cbCadStatus
            // 
            cbCadStatus.Anchor = AnchorStyles.Top;
            cbCadStatus.FlatStyle = FlatStyle.Flat;
            cbCadStatus.FormattingEnabled = true;
            cbCadStatus.Location = new Point(389, 316);
            cbCadStatus.Name = "cbCadStatus";
            cbCadStatus.Size = new Size(312, 23);
            cbCadStatus.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(390, 291);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 22;
            label3.Text = "Status";
            // 
            // btn_CadNovoUsuario
            // 
            btn_CadNovoUsuario.Anchor = AnchorStyles.Top;
            btn_CadNovoUsuario.BackColor = Color.FromArgb(35, 68, 57);
            btn_CadNovoUsuario.FlatStyle = FlatStyle.Flat;
            btn_CadNovoUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CadNovoUsuario.ForeColor = Color.White;
            btn_CadNovoUsuario.IconChar = FontAwesome.Sharp.IconChar.Add;
            btn_CadNovoUsuario.IconColor = Color.White;
            btn_CadNovoUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_CadNovoUsuario.IconSize = 25;
            btn_CadNovoUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CadNovoUsuario.Location = new Point(140, 458);
            btn_CadNovoUsuario.Name = "btn_CadNovoUsuario";
            btn_CadNovoUsuario.Size = new Size(128, 41);
            btn_CadNovoUsuario.TabIndex = 12;
            btn_CadNovoUsuario.Text = "Novo Usuário";
            btn_CadNovoUsuario.TextAlign = ContentAlignment.MiddleRight;
            btn_CadNovoUsuario.UseVisualStyleBackColor = false;
            // 
            // btn_CadExcluirUsuario
            // 
            btn_CadExcluirUsuario.Anchor = AnchorStyles.Top;
            btn_CadExcluirUsuario.BackColor = Color.FromArgb(35, 68, 57);
            btn_CadExcluirUsuario.FlatStyle = FlatStyle.Flat;
            btn_CadExcluirUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CadExcluirUsuario.ForeColor = Color.White;
            btn_CadExcluirUsuario.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            btn_CadExcluirUsuario.IconColor = Color.White;
            btn_CadExcluirUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_CadExcluirUsuario.IconSize = 25;
            btn_CadExcluirUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CadExcluirUsuario.Location = new Point(287, 458);
            btn_CadExcluirUsuario.Name = "btn_CadExcluirUsuario";
            btn_CadExcluirUsuario.Size = new Size(137, 41);
            btn_CadExcluirUsuario.TabIndex = 13;
            btn_CadExcluirUsuario.Text = "Excluir Usuário";
            btn_CadExcluirUsuario.TextAlign = ContentAlignment.MiddleRight;
            btn_CadExcluirUsuario.UseVisualStyleBackColor = false;
            // 
            // btn_CadSalvar
            // 
            btn_CadSalvar.Anchor = AnchorStyles.Top;
            btn_CadSalvar.BackColor = Color.FromArgb(35, 68, 57);
            btn_CadSalvar.FlatStyle = FlatStyle.Flat;
            btn_CadSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CadSalvar.ForeColor = Color.White;
            btn_CadSalvar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btn_CadSalvar.IconColor = Color.White;
            btn_CadSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_CadSalvar.IconSize = 25;
            btn_CadSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CadSalvar.Location = new Point(736, 458);
            btn_CadSalvar.Name = "btn_CadSalvar";
            btn_CadSalvar.Padding = new Padding(3, 0, 0, 0);
            btn_CadSalvar.Size = new Size(105, 41);
            btn_CadSalvar.TabIndex = 11;
            btn_CadSalvar.Text = "       Salvar ";
            btn_CadSalvar.UseVisualStyleBackColor = false;
            btn_CadSalvar.Click += btn_CadSalvar_Click;
            // 
            // btn_CadCancelar
            // 
            btn_CadCancelar.Anchor = AnchorStyles.Top;
            btn_CadCancelar.BackColor = Color.White;
            btn_CadCancelar.FlatAppearance.BorderSize = 2;
            btn_CadCancelar.FlatStyle = FlatStyle.Flat;
            btn_CadCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CadCancelar.ForeColor = Color.FromArgb(35, 68, 57);
            btn_CadCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btn_CadCancelar.IconColor = Color.FromArgb(35, 68, 57);
            btn_CadCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_CadCancelar.IconSize = 25;
            btn_CadCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CadCancelar.Location = new Point(608, 458);
            btn_CadCancelar.Name = "btn_CadCancelar";
            btn_CadCancelar.Padding = new Padding(3, 0, 0, 0);
            btn_CadCancelar.Size = new Size(105, 41);
            btn_CadCancelar.TabIndex = 37;
            btn_CadCancelar.Text = "Cancelar ";
            btn_CadCancelar.TextAlign = ContentAlignment.MiddleRight;
            btn_CadCancelar.UseVisualStyleBackColor = false;
            btn_CadCancelar.Click += btnCadCancelar_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Location = new Point(123, 431);
            panel4.Name = "panel4";
            panel4.Size = new Size(733, 90);
            panel4.TabIndex = 30;
            // 
            // btn_CadEditarUsuario
            // 
            btn_CadEditarUsuario.Anchor = AnchorStyles.Top;
            btn_CadEditarUsuario.BackColor = Color.FromArgb(35, 68, 57);
            btn_CadEditarUsuario.FlatStyle = FlatStyle.Flat;
            btn_CadEditarUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CadEditarUsuario.ForeColor = Color.White;
            btn_CadEditarUsuario.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btn_CadEditarUsuario.IconColor = Color.White;
            btn_CadEditarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_CadEditarUsuario.IconSize = 25;
            btn_CadEditarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CadEditarUsuario.Location = new Point(449, 458);
            btn_CadEditarUsuario.Name = "btn_CadEditarUsuario";
            btn_CadEditarUsuario.Padding = new Padding(5, 0, 0, 0);
            btn_CadEditarUsuario.Size = new Size(137, 41);
            btn_CadEditarUsuario.TabIndex = 14;
            btn_CadEditarUsuario.Text = "Editar Usuário";
            btn_CadEditarUsuario.TextAlign = ContentAlignment.MiddleRight;
            btn_CadEditarUsuario.UseVisualStyleBackColor = false;
            // 
            // lblConfirSenhaCad
            // 
            lblConfirSenhaCad.Anchor = AnchorStyles.Top;
            lblConfirSenhaCad.AutoSize = true;
            lblConfirSenhaCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirSenhaCad.Location = new Point(390, 161);
            lblConfirSenhaCad.Name = "lblConfirSenhaCad";
            lblConfirSenhaCad.Size = new Size(131, 21);
            lblConfirSenhaCad.TabIndex = 22;
            lblConfirSenhaCad.Text = "Confirmar Senha";
            // 
            // txtCadConfirSenha
            // 
            txtCadConfirSenha.Anchor = AnchorStyles.Top;
            txtCadConfirSenha.Location = new Point(390, 186);
            txtCadConfirSenha.Name = "txtCadConfirSenha";
            txtCadConfirSenha.Size = new Size(312, 23);
            txtCadConfirSenha.TabIndex = 4;
            // 
            // lblUsuarioCad
            // 
            lblUsuarioCad.Anchor = AnchorStyles.Top;
            lblUsuarioCad.AutoSize = true;
            lblUsuarioCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioCad.Location = new Point(390, 95);
            lblUsuarioCad.Name = "lblUsuarioCad";
            lblUsuarioCad.Size = new Size(73, 21);
            lblUsuarioCad.TabIndex = 21;
            lblUsuarioCad.Text = "Telefone";
            // 
            // lblNomeCad
            // 
            lblNomeCad.Anchor = AnchorStyles.Top;
            lblNomeCad.AutoSize = true;
            lblNomeCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeCad.Location = new Point(17, 21);
            lblNomeCad.Name = "lblNomeCad";
            lblNomeCad.Size = new Size(55, 21);
            lblNomeCad.TabIndex = 2;
            lblNomeCad.Text = "Nome";
            // 
            // txtCadTelef
            // 
            txtCadTelef.Anchor = AnchorStyles.Top;
            txtCadTelef.Location = new Point(390, 121);
            txtCadTelef.Name = "txtCadTelef";
            txtCadTelef.Size = new Size(312, 23);
            txtCadTelef.TabIndex = 2;
            // 
            // txtCadEmail
            // 
            txtCadEmail.Anchor = AnchorStyles.Top;
            txtCadEmail.Location = new Point(17, 121);
            txtCadEmail.Name = "txtCadEmail";
            txtCadEmail.Size = new Size(312, 23);
            txtCadEmail.TabIndex = 1;
            // 
            // txtCadSenha
            // 
            txtCadSenha.Anchor = AnchorStyles.Top;
            txtCadSenha.Location = new Point(18, 186);
            txtCadSenha.Name = "txtCadSenha";
            txtCadSenha.Size = new Size(312, 23);
            txtCadSenha.TabIndex = 3;
            // 
            // lblSenhaCad
            // 
            lblSenhaCad.Anchor = AnchorStyles.Top;
            lblSenhaCad.AutoSize = true;
            lblSenhaCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenhaCad.Location = new Point(18, 161);
            lblSenhaCad.Name = "lblSenhaCad";
            lblSenhaCad.Size = new Size(54, 21);
            lblSenhaCad.TabIndex = 4;
            lblSenhaCad.Text = "Senha";
            // 
            // lblEmailCad
            // 
            lblEmailCad.Anchor = AnchorStyles.Top;
            lblEmailCad.AutoSize = true;
            lblEmailCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailCad.Location = new Point(17, 96);
            lblEmailCad.Name = "lblEmailCad";
            lblEmailCad.Size = new Size(54, 21);
            lblEmailCad.TabIndex = 19;
            lblEmailCad.Text = "E-mail";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtCadTurno);
            panel1.Controls.Add(cbCadStatus);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCadPerfil);
            panel1.Controls.Add(lblPerfilCad);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCadNome);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_CadBuscarUsuario);
            panel1.Controls.Add(lblEmailCad);
            panel1.Controls.Add(lblSenhaCad);
            panel1.Controls.Add(txtCadSenha);
            panel1.Controls.Add(txtCadEmail);
            panel1.Controls.Add(txtCadTelef);
            panel1.Controls.Add(lblNomeCad);
            panel1.Controls.Add(lblUsuarioCad);
            panel1.Controls.Add(txtCadConfirSenha);
            panel1.Controls.Add(lblConfirSenhaCad);
            panel1.Location = new Point(123, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 362);
            panel1.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(556, 249);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(146, 23);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.Value = new DateTime(2025, 4, 26, 14, 27, 7, 0);
            // 
            // txtCadTurno
            // 
            txtCadTurno.Anchor = AnchorStyles.Top;
            txtCadTurno.FlatStyle = FlatStyle.Flat;
            txtCadTurno.FormattingEnabled = true;
            txtCadTurno.Location = new Point(18, 252);
            txtCadTurno.Name = "txtCadTurno";
            txtCadTurno.Size = new Size(312, 23);
            txtCadTurno.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(390, 249);
            label4.Name = "label4";
            label4.Size = new Size(160, 21);
            label4.TabIndex = 74;
            label4.Text = "Data De Contratação";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 227);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 72;
            label5.Text = "Turno";
            // 
            // btn_CadBuscarUsuario
            // 
            btn_CadBuscarUsuario.Anchor = AnchorStyles.Top;
            btn_CadBuscarUsuario.BackColor = Color.FromArgb(35, 68, 57);
            btn_CadBuscarUsuario.FlatAppearance.BorderColor = Color.FromArgb(35, 68, 57);
            btn_CadBuscarUsuario.FlatAppearance.BorderSize = 0;
            btn_CadBuscarUsuario.FlatStyle = FlatStyle.Flat;
            btn_CadBuscarUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CadBuscarUsuario.ForeColor = Color.White;
            btn_CadBuscarUsuario.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_CadBuscarUsuario.IconColor = Color.White;
            btn_CadBuscarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_CadBuscarUsuario.IconSize = 25;
            btn_CadBuscarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CadBuscarUsuario.Location = new Point(568, 48);
            btn_CadBuscarUsuario.Name = "btn_CadBuscarUsuario";
            btn_CadBuscarUsuario.Padding = new Padding(5, 0, 0, 0);
            btn_CadBuscarUsuario.Size = new Size(133, 27);
            btn_CadBuscarUsuario.TabIndex = 10;
            btn_CadBuscarUsuario.Text = "Buscar Usuário";
            btn_CadBuscarUsuario.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(comboBox2);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(btn_CadGerarPDF);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(123, 526);
            panel5.Name = "panel5";
            panel5.Size = new Size(733, 91);
            panel5.TabIndex = 40;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(439, 35);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(132, 23);
            comboBox2.TabIndex = 16;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(379, 36);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 43;
            label2.Text = "Status";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(221, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 23);
            comboBox1.TabIndex = 15;
            // 
            // btn_CadGerarPDF
            // 
            btn_CadGerarPDF.Anchor = AnchorStyles.Top;
            btn_CadGerarPDF.BackColor = Color.FromArgb(35, 68, 57);
            btn_CadGerarPDF.FlatStyle = FlatStyle.Flat;
            btn_CadGerarPDF.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_CadGerarPDF.ForeColor = Color.White;
            btn_CadGerarPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btn_CadGerarPDF.IconColor = Color.White;
            btn_CadGerarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_CadGerarPDF.IconSize = 25;
            btn_CadGerarPDF.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CadGerarPDF.Location = new Point(594, 26);
            btn_CadGerarPDF.Name = "btn_CadGerarPDF";
            btn_CadGerarPDF.Padding = new Padding(5, 0, 0, 0);
            btn_CadGerarPDF.Size = new Size(113, 41);
            btn_CadGerarPDF.TabIndex = 17;
            btn_CadGerarPDF.Text = "Gerar PDF";
            btn_CadGerarPDF.TextAlign = ContentAlignment.MiddleRight;
            btn_CadGerarPDF.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 36);
            label1.Name = "label1";
            label1.Size = new Size(192, 21);
            label1.TabIndex = 21;
            label1.Text = "Lista de usuários do tipo ";
            // 
            // lblAdmUsuarios
            // 
            lblAdmUsuarios.Anchor = AnchorStyles.Top;
            lblAdmUsuarios.AutoSize = true;
            lblAdmUsuarios.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmUsuarios.ForeColor = Color.FromArgb(35, 68, 57);
            lblAdmUsuarios.Location = new Point(84, 52);
            lblAdmUsuarios.Name = "lblAdmUsuarios";
            lblAdmUsuarios.Size = new Size(111, 25);
            lblAdmUsuarios.TabIndex = 68;
            lblAdmUsuarios.Text = "USUÁRIOS";
            // 
            // UCAdm_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblAdmUsuarios);
            Controls.Add(panel5);
            Controls.Add(btn_CadSalvar);
            Controls.Add(btn_CadCancelar);
            Controls.Add(btn_CadEditarUsuario);
            Controls.Add(btn_CadExcluirUsuario);
            Controls.Add(btn_CadNovoUsuario);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "UCAdm_Usuarios";
            Size = new Size(978, 646);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCadNome;
        private Label lblPerfilCad;
        private ComboBox txtCadPerfil;
        private FontAwesome.Sharp.IconButton btn_CadNovoUsuario;
        private FontAwesome.Sharp.IconButton btn_CadExcluirUsuario;
        private FontAwesome.Sharp.IconButton btn_CadSalvar;
        private FontAwesome.Sharp.IconButton btn_CadCancelar;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btn_CadEditarUsuario;
        private Label lblConfirSenhaCad;
        private TextBox txtCadConfirSenha;
        private Label lblUsuarioCad;
        private Label lblNomeCad;
        private TextBox txtCadTelef;
        private TextBox txtCadEmail;
        private TextBox txtCadSenha;
        private Label lblSenhaCad;
        private Label lblEmailCad;
        private Panel panel1;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton btn_CadGerarPDF;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox cbCadStatus;
        private Label label3;
        private ComboBox comboBox2;
        private Label label2;
        private FontAwesome.Sharp.IconButton btn_CadBuscarUsuario;
        private Label lblAdmUsuarios;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox txtCadTurno;
    }
}
