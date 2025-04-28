namespace ECOInsight.UserControls
{
    partial class UCAdm_MeuPerfil
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
            btnAdm_SalvarImagem = new Button();
            txtAdm_PerfilTelefone = new TextBox();
            txtAdm_PerfilSobrenome = new TextBox();
            label4 = new Label();
            btnAdm_PerfilSalvar = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label9 = new Label();
            txtAdm_PerfilSenhaAtual = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtAdm_PerfilNovSenhaConfir = new TextBox();
            txtAdm_PerfilNovSenha = new TextBox();
            textBox6 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtAdm_PerfilEmail = new TextBox();
            label3 = new Label();
            txtAdm_PerfilNome = new TextBox();
            lblAdm_PerfilNome = new Label();
            pictureBox1 = new PictureBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            lblAlunoAulas = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdm_SalvarImagem
            // 
            btnAdm_SalvarImagem.Anchor = AnchorStyles.Top;
            btnAdm_SalvarImagem.BackColor = SystemColors.ControlDarkDark;
            btnAdm_SalvarImagem.FlatAppearance.BorderSize = 0;
            btnAdm_SalvarImagem.FlatStyle = FlatStyle.Flat;
            btnAdm_SalvarImagem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdm_SalvarImagem.ForeColor = Color.White;
            btnAdm_SalvarImagem.Location = new Point(96, 272);
            btnAdm_SalvarImagem.Name = "btnAdm_SalvarImagem";
            btnAdm_SalvarImagem.Size = new Size(120, 23);
            btnAdm_SalvarImagem.TabIndex = 33;
            btnAdm_SalvarImagem.Text = "Buscar Imagem";
            btnAdm_SalvarImagem.UseVisualStyleBackColor = false;
            // 
            // txtAdm_PerfilTelefone
            // 
            txtAdm_PerfilTelefone.Anchor = AnchorStyles.Top;
            txtAdm_PerfilTelefone.Location = new Point(632, 232);
            txtAdm_PerfilTelefone.Name = "txtAdm_PerfilTelefone";
            txtAdm_PerfilTelefone.Size = new Size(271, 23);
            txtAdm_PerfilTelefone.TabIndex = 31;
            txtAdm_PerfilTelefone.KeyPress += txtAdm_PerfilTelefone_KeyPress;
            // 
            // txtAdm_PerfilSobrenome
            // 
            txtAdm_PerfilSobrenome.Anchor = AnchorStyles.Top;
            txtAdm_PerfilSobrenome.Location = new Point(632, 153);
            txtAdm_PerfilSobrenome.Name = "txtAdm_PerfilSobrenome";
            txtAdm_PerfilSobrenome.Size = new Size(271, 23);
            txtAdm_PerfilSobrenome.TabIndex = 28;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(632, 197);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 32;
            label4.Text = "Telefone:";
            // 
            // btnAdm_PerfilSalvar
            // 
            btnAdm_PerfilSalvar.Anchor = AnchorStyles.Top;
            btnAdm_PerfilSalvar.BackColor = Color.FromArgb(35, 68, 57);
            btnAdm_PerfilSalvar.FlatAppearance.BorderSize = 0;
            btnAdm_PerfilSalvar.FlatStyle = FlatStyle.Flat;
            btnAdm_PerfilSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdm_PerfilSalvar.ForeColor = Color.White;
            btnAdm_PerfilSalvar.Location = new Point(443, 512);
            btnAdm_PerfilSalvar.Name = "btnAdm_PerfilSalvar";
            btnAdm_PerfilSalvar.Size = new Size(93, 35);
            btnAdm_PerfilSalvar.TabIndex = 29;
            btnAdm_PerfilSalvar.Text = "Salvar ";
            btnAdm_PerfilSalvar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(632, 116);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 24;
            label2.Text = "Sobrenome:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtAdm_PerfilSenhaAtual);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtAdm_PerfilNovSenhaConfir);
            groupBox1.Controls.Add(txtAdm_PerfilNovSenha);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(62, 339);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(855, 142);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editar Senha";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(11, 38);
            label9.Name = "label9";
            label9.Size = new Size(97, 21);
            label9.TabIndex = 30;
            label9.Text = "Senha atual:";
            // 
            // txtAdm_PerfilSenhaAtual
            // 
            txtAdm_PerfilSenhaAtual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAdm_PerfilSenhaAtual.Location = new Point(117, 36);
            txtAdm_PerfilSenhaAtual.Name = "txtAdm_PerfilSenhaAtual";
            txtAdm_PerfilSenhaAtual.Size = new Size(282, 23);
            txtAdm_PerfilSenhaAtual.TabIndex = 28;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(11, 88);
            label7.Name = "label7";
            label7.Size = new Size(100, 21);
            label7.TabIndex = 26;
            label7.Text = "Nova Senha:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(421, 88);
            label8.Name = "label8";
            label8.Size = new Size(135, 21);
            label8.TabIndex = 27;
            label8.Text = "Confirmar Senha:";
            // 
            // txtAdm_PerfilNovSenhaConfir
            // 
            txtAdm_PerfilNovSenhaConfir.Anchor = AnchorStyles.Top;
            txtAdm_PerfilNovSenhaConfir.Location = new Point(562, 87);
            txtAdm_PerfilNovSenhaConfir.Name = "txtAdm_PerfilNovSenhaConfir";
            txtAdm_PerfilNovSenhaConfir.Size = new Size(281, 23);
            txtAdm_PerfilNovSenhaConfir.TabIndex = 25;
            // 
            // txtAdm_PerfilNovSenha
            // 
            txtAdm_PerfilNovSenha.Anchor = AnchorStyles.Top;
            txtAdm_PerfilNovSenha.Location = new Point(117, 87);
            txtAdm_PerfilNovSenha.Name = "txtAdm_PerfilNovSenha";
            txtAdm_PerfilNovSenha.Size = new Size(282, 23);
            txtAdm_PerfilNovSenha.TabIndex = 24;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top;
            textBox6.Location = new Point(887, 25);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(281, 23);
            textBox6.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(1319, 65);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 1;
            label5.Text = "Nova Senha:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(1729, 65);
            label6.Name = "label6";
            label6.Size = new Size(135, 21);
            label6.TabIndex = 2;
            label6.Text = "Confirmar Senha:";
            // 
            // txtAdm_PerfilEmail
            // 
            txtAdm_PerfilEmail.Anchor = AnchorStyles.Top;
            txtAdm_PerfilEmail.Location = new Point(283, 232);
            txtAdm_PerfilEmail.Name = "txtAdm_PerfilEmail";
            txtAdm_PerfilEmail.Size = new Size(271, 23);
            txtAdm_PerfilEmail.TabIndex = 30;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(283, 197);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 27;
            label3.Text = "Email:";
            // 
            // txtAdm_PerfilNome
            // 
            txtAdm_PerfilNome.Anchor = AnchorStyles.Top;
            txtAdm_PerfilNome.Location = new Point(283, 153);
            txtAdm_PerfilNome.Name = "txtAdm_PerfilNome";
            txtAdm_PerfilNome.Size = new Size(271, 23);
            txtAdm_PerfilNome.TabIndex = 23;
            // 
            // lblAdm_PerfilNome
            // 
            lblAdm_PerfilNome.Anchor = AnchorStyles.Top;
            lblAdm_PerfilNome.AutoSize = true;
            lblAdm_PerfilNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAdm_PerfilNome.Location = new Point(283, 116);
            lblAdm_PerfilNome.Name = "lblAdm_PerfilNome";
            lblAdm_PerfilNome.Size = new Size(59, 21);
            lblAdm_PerfilNome.TabIndex = 22;
            lblAdm_PerfilNome.Text = "Nome:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(71, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 166);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
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
            iconButton1.Location = new Point(797, 272);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(5, 0, 0, 0);
            iconButton1.Size = new Size(106, 41);
            iconButton1.TabIndex = 58;
            iconButton1.Text = "Editar dados";
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // lblAlunoAulas
            // 
            lblAlunoAulas.Anchor = AnchorStyles.Top;
            lblAlunoAulas.AutoSize = true;
            lblAlunoAulas.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlunoAulas.ForeColor = Color.FromArgb(35, 68, 57);
            lblAlunoAulas.Location = new Point(84, 52);
            lblAlunoAulas.Name = "lblAlunoAulas";
            lblAlunoAulas.Size = new Size(122, 25);
            lblAlunoAulas.TabIndex = 68;
            lblAlunoAulas.Text = "MEU PERFIL";
            // 
            // UCAdm_MeuPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(lblAlunoAulas);
            Controls.Add(iconButton1);
            Controls.Add(btnAdm_SalvarImagem);
            Controls.Add(txtAdm_PerfilTelefone);
            Controls.Add(txtAdm_PerfilSobrenome);
            Controls.Add(label4);
            Controls.Add(btnAdm_PerfilSalvar);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(txtAdm_PerfilEmail);
            Controls.Add(label3);
            Controls.Add(txtAdm_PerfilNome);
            Controls.Add(lblAdm_PerfilNome);
            Controls.Add(pictureBox1);
            Name = "UCAdm_MeuPerfil";
            Size = new Size(978, 646);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdm_SalvarImagem;
        private TextBox txtAdm_PerfilTelefone;
        private TextBox txtAdm_PerfilSobrenome;
        private Label label4;
        private Button btnAdm_PerfilSalvar;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox textBox6;
        private Label label5;
        private Label label6;
        private TextBox txtAdm_PerfilEmail;
        private Label label3;
        private TextBox txtAdm_PerfilNome;
        private Label lblAdm_PerfilNome;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
        private TextBox txtAdm_PerfilNovSenhaConfir;
        private TextBox txtAdm_PerfilNovSenha;
        private Label label9;
        private TextBox txtAdm_PerfilSenhaAtual;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label lblAlunoAulas;
    }
}
