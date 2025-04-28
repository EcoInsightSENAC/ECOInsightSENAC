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
            cbCadPerfil = new ComboBox();
            cbCadStatus = new ComboBox();
            label3 = new Label();
            btnCadNovoUsuario = new FontAwesome.Sharp.IconButton();
            btnCadExcluirUsuario = new FontAwesome.Sharp.IconButton();
            btnCadSalvar = new FontAwesome.Sharp.IconButton();
            btnCadCancelar = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            btnCadEditarUsuario = new FontAwesome.Sharp.IconButton();
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
            cbCadTurno = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            comboBox2 = new ComboBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            btnCadGerarPDF = new FontAwesome.Sharp.IconButton();
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
            // cbCadPerfil
            // 
            cbCadPerfil.Anchor = AnchorStyles.Top;
            cbCadPerfil.FlatStyle = FlatStyle.Flat;
            cbCadPerfil.FormattingEnabled = true;
            cbCadPerfil.Location = new Point(17, 316);
            cbCadPerfil.Name = "cbCadPerfil";
            cbCadPerfil.Size = new Size(312, 23);
            cbCadPerfil.TabIndex = 7;
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
            // btnCadNovoUsuario
            // 
            btnCadNovoUsuario.Anchor = AnchorStyles.Top;
            btnCadNovoUsuario.BackColor = Color.FromArgb(35, 68, 57);
            btnCadNovoUsuario.FlatStyle = FlatStyle.Flat;
            btnCadNovoUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadNovoUsuario.ForeColor = Color.White;
            btnCadNovoUsuario.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnCadNovoUsuario.IconColor = Color.White;
            btnCadNovoUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCadNovoUsuario.IconSize = 25;
            btnCadNovoUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadNovoUsuario.Location = new Point(140, 458);
            btnCadNovoUsuario.Name = "btnCadNovoUsuario";
            btnCadNovoUsuario.Size = new Size(128, 41);
            btnCadNovoUsuario.TabIndex = 12;
            btnCadNovoUsuario.Text = "Novo Usuário";
            btnCadNovoUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnCadNovoUsuario.UseVisualStyleBackColor = false;
            // 
            // btnCadExcluirUsuario
            // 
            btnCadExcluirUsuario.Anchor = AnchorStyles.Top;
            btnCadExcluirUsuario.BackColor = Color.FromArgb(35, 68, 57);
            btnCadExcluirUsuario.FlatStyle = FlatStyle.Flat;
            btnCadExcluirUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadExcluirUsuario.ForeColor = Color.White;
            btnCadExcluirUsuario.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            btnCadExcluirUsuario.IconColor = Color.White;
            btnCadExcluirUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCadExcluirUsuario.IconSize = 25;
            btnCadExcluirUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadExcluirUsuario.Location = new Point(287, 458);
            btnCadExcluirUsuario.Name = "btnCadExcluirUsuario";
            btnCadExcluirUsuario.Size = new Size(137, 41);
            btnCadExcluirUsuario.TabIndex = 13;
            btnCadExcluirUsuario.Text = "Excluir Usuário";
            btnCadExcluirUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnCadExcluirUsuario.UseVisualStyleBackColor = false;
            // 
            // btnCadSalvar
            // 
            btnCadSalvar.Anchor = AnchorStyles.Top;
            btnCadSalvar.BackColor = Color.FromArgb(35, 68, 57);
            btnCadSalvar.FlatStyle = FlatStyle.Flat;
            btnCadSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadSalvar.ForeColor = Color.White;
            btnCadSalvar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnCadSalvar.IconColor = Color.White;
            btnCadSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCadSalvar.IconSize = 25;
            btnCadSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadSalvar.Location = new Point(736, 458);
            btnCadSalvar.Name = "btnCadSalvar";
            btnCadSalvar.Padding = new Padding(3, 0, 0, 0);
            btnCadSalvar.Size = new Size(105, 41);
            btnCadSalvar.TabIndex = 11;
            btnCadSalvar.Text = "       Salvar ";
            btnCadSalvar.UseVisualStyleBackColor = false;
            // 
            // btnCadCancelar
            // 
            btnCadCancelar.Anchor = AnchorStyles.Top;
            btnCadCancelar.BackColor = Color.White;
            btnCadCancelar.FlatAppearance.BorderSize = 2;
            btnCadCancelar.FlatStyle = FlatStyle.Flat;
            btnCadCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadCancelar.ForeColor = Color.FromArgb(35, 68, 57);
            btnCadCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btnCadCancelar.IconColor = Color.FromArgb(35, 68, 57);
            btnCadCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCadCancelar.IconSize = 25;
            btnCadCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadCancelar.Location = new Point(608, 458);
            btnCadCancelar.Name = "btnCadCancelar";
            btnCadCancelar.Padding = new Padding(3, 0, 0, 0);
            btnCadCancelar.Size = new Size(105, 41);
            btnCadCancelar.TabIndex = 37;
            btnCadCancelar.Text = "Cancelar ";
            btnCadCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCadCancelar.UseVisualStyleBackColor = false;
            btnCadCancelar.Click += btnCadCancelar_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Location = new Point(123, 431);
            panel4.Name = "panel4";
            panel4.Size = new Size(733, 90);
            panel4.TabIndex = 30;
            // 
            // btnCadEditarUsuario
            // 
            btnCadEditarUsuario.Anchor = AnchorStyles.Top;
            btnCadEditarUsuario.BackColor = Color.FromArgb(35, 68, 57);
            btnCadEditarUsuario.FlatStyle = FlatStyle.Flat;
            btnCadEditarUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadEditarUsuario.ForeColor = Color.White;
            btnCadEditarUsuario.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnCadEditarUsuario.IconColor = Color.White;
            btnCadEditarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCadEditarUsuario.IconSize = 25;
            btnCadEditarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadEditarUsuario.Location = new Point(449, 458);
            btnCadEditarUsuario.Name = "btnCadEditarUsuario";
            btnCadEditarUsuario.Padding = new Padding(5, 0, 0, 0);
            btnCadEditarUsuario.Size = new Size(137, 41);
            btnCadEditarUsuario.TabIndex = 14;
            btnCadEditarUsuario.Text = "Editar Usuário";
            btnCadEditarUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnCadEditarUsuario.UseVisualStyleBackColor = false;
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
            panel1.Controls.Add(cbCadTurno);
            panel1.Controls.Add(cbCadStatus);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbCadPerfil);
            panel1.Controls.Add(lblPerfilCad);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCadNome);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(iconButton7);
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
            // cbCadTurno
            // 
            cbCadTurno.Anchor = AnchorStyles.Top;
            cbCadTurno.FlatStyle = FlatStyle.Flat;
            cbCadTurno.FormattingEnabled = true;
            cbCadTurno.Location = new Point(18, 252);
            cbCadTurno.Name = "cbCadTurno";
            cbCadTurno.Size = new Size(312, 23);
            cbCadTurno.TabIndex = 5;
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
            // iconButton7
            // 
            iconButton7.Anchor = AnchorStyles.Top;
            iconButton7.BackColor = Color.FromArgb(35, 68, 57);
            iconButton7.FlatAppearance.BorderColor = Color.FromArgb(35, 68, 57);
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton7.ForeColor = Color.White;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton7.IconColor = Color.White;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.IconSize = 25;
            iconButton7.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton7.Location = new Point(568, 48);
            iconButton7.Name = "iconButton7";
            iconButton7.Padding = new Padding(5, 0, 0, 0);
            iconButton7.Size = new Size(133, 27);
            iconButton7.TabIndex = 10;
            iconButton7.Text = "Buscar Usuário";
            iconButton7.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(comboBox2);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(btnCadGerarPDF);
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
            // btnCadGerarPDF
            // 
            btnCadGerarPDF.Anchor = AnchorStyles.Top;
            btnCadGerarPDF.BackColor = Color.FromArgb(35, 68, 57);
            btnCadGerarPDF.FlatStyle = FlatStyle.Flat;
            btnCadGerarPDF.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadGerarPDF.ForeColor = Color.White;
            btnCadGerarPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnCadGerarPDF.IconColor = Color.White;
            btnCadGerarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCadGerarPDF.IconSize = 25;
            btnCadGerarPDF.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadGerarPDF.Location = new Point(594, 26);
            btnCadGerarPDF.Name = "btnCadGerarPDF";
            btnCadGerarPDF.Padding = new Padding(5, 0, 0, 0);
            btnCadGerarPDF.Size = new Size(113, 41);
            btnCadGerarPDF.TabIndex = 17;
            btnCadGerarPDF.Text = "Gerar PDF";
            btnCadGerarPDF.TextAlign = ContentAlignment.MiddleRight;
            btnCadGerarPDF.UseVisualStyleBackColor = false;
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
            Controls.Add(btnCadSalvar);
            Controls.Add(btnCadCancelar);
            Controls.Add(btnCadEditarUsuario);
            Controls.Add(btnCadExcluirUsuario);
            Controls.Add(btnCadNovoUsuario);
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
        private ComboBox cbCadPerfil;
        private FontAwesome.Sharp.IconButton btnCadNovoUsuario;
        private FontAwesome.Sharp.IconButton btnCadExcluirUsuario;
        private FontAwesome.Sharp.IconButton btnCadSalvar;
        private FontAwesome.Sharp.IconButton btnCadCancelar;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btnCadEditarUsuario;
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
        private FontAwesome.Sharp.IconButton btnCadGerarPDF;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox cbCadStatus;
        private Label label3;
        private ComboBox comboBox2;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton7;
        private Label lblAdmUsuarios;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbCadTurno;
    }
}
