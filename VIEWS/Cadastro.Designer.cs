namespace ECOInsight
{
    partial class CadastroTela
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSuperiorCad = new Panel();
            iconMinim = new FontAwesome.Sharp.IconButton();
            lblCad = new Label();
            iconMax = new FontAwesome.Sharp.IconButton();
            iconX = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            lblNomeCad = new Label();
            lblEmailCad = new Label();
            lblSenhaCad = new Label();
            lblPerfilCad = new Label();
            lblUsuarioCad = new Label();
            lblConfirSenhaCad = new Label();
            txtNomeCad = new TextBox();
            txtEmailCad = new TextBox();
            txtTelefCad = new TextBox();
            txtSenhaCad = new TextBox();
            txtConfirSenhaCad = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            cbSelecao = new ComboBox();
            comboBox1 = new ComboBox();
            panel3 = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnSalvar = new FontAwesome.Sharp.IconButton();
            panelSuperiorCad.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperiorCad
            // 
            panelSuperiorCad.BackColor = Color.FromArgb(32, 65, 57);
            panelSuperiorCad.Controls.Add(iconMinim);
            panelSuperiorCad.Controls.Add(lblCad);
            panelSuperiorCad.Controls.Add(iconMax);
            panelSuperiorCad.Controls.Add(iconX);
            panelSuperiorCad.Controls.Add(panel4);
            panelSuperiorCad.Dock = DockStyle.Top;
            panelSuperiorCad.Location = new Point(0, 0);
            panelSuperiorCad.Name = "panelSuperiorCad";
            panelSuperiorCad.Size = new Size(1064, 40);
            panelSuperiorCad.TabIndex = 1;
            // 
            // iconMinim
            // 
            iconMinim.Anchor = AnchorStyles.Right;
            iconMinim.FlatAppearance.BorderSize = 0;
            iconMinim.FlatStyle = FlatStyle.Flat;
            iconMinim.ForeColor = Color.Transparent;
            iconMinim.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            iconMinim.IconColor = Color.White;
            iconMinim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMinim.IconSize = 20;
            iconMinim.Location = new Point(922, 3);
            iconMinim.Name = "iconMinim";
            iconMinim.Size = new Size(39, 37);
            iconMinim.TabIndex = 22;
            iconMinim.UseVisualStyleBackColor = true;
            iconMinim.Click += iconMinim_Click;
            // 
            // lblCad
            // 
            lblCad.AutoSize = true;
            lblCad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCad.ForeColor = SystemColors.ButtonHighlight;
            lblCad.Location = new Point(12, 9);
            lblCad.Name = "lblCad";
            lblCad.Size = new Size(112, 25);
            lblCad.TabIndex = 0;
            lblCad.Text = "CADASTRO";
            // 
            // iconMax
            // 
            iconMax.Anchor = AnchorStyles.Right;
            iconMax.FlatAppearance.BorderSize = 0;
            iconMax.FlatStyle = FlatStyle.Flat;
            iconMax.ForeColor = Color.Transparent;
            iconMax.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            iconMax.IconColor = Color.White;
            iconMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMax.IconSize = 20;
            iconMax.Location = new Point(967, 3);
            iconMax.Name = "iconMax";
            iconMax.Size = new Size(39, 37);
            iconMax.TabIndex = 21;
            iconMax.UseVisualStyleBackColor = true;
            iconMax.Click += iconMax_Click;
            // 
            // iconX
            // 
            iconX.Anchor = AnchorStyles.Right;
            iconX.FlatAppearance.BorderSize = 0;
            iconX.FlatStyle = FlatStyle.Flat;
            iconX.ForeColor = Color.Transparent;
            iconX.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconX.IconColor = Color.White;
            iconX.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconX.IconSize = 20;
            iconX.Location = new Point(1012, 3);
            iconX.Name = "iconX";
            iconX.Size = new Size(39, 37);
            iconX.TabIndex = 19;
            iconX.UseVisualStyleBackColor = true;
            iconX.Click += iconX_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Right;
            panel4.Location = new Point(915, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(148, 40);
            panel4.TabIndex = 20;
            // 
            // lblNomeCad
            // 
            lblNomeCad.Anchor = AnchorStyles.Top;
            lblNomeCad.AutoSize = true;
            lblNomeCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeCad.Location = new Point(34, 45);
            lblNomeCad.Name = "lblNomeCad";
            lblNomeCad.Size = new Size(55, 21);
            lblNomeCad.TabIndex = 2;
            lblNomeCad.Text = "Nome";
            // 
            // lblEmailCad
            // 
            lblEmailCad.Anchor = AnchorStyles.Top;
            lblEmailCad.AutoSize = true;
            lblEmailCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailCad.Location = new Point(195, 221);
            lblEmailCad.Name = "lblEmailCad";
            lblEmailCad.Size = new Size(54, 21);
            lblEmailCad.TabIndex = 3;
            lblEmailCad.Text = "E-mail";
            // 
            // lblSenhaCad
            // 
            lblSenhaCad.Anchor = AnchorStyles.Top;
            lblSenhaCad.AutoSize = true;
            lblSenhaCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenhaCad.Location = new Point(35, 204);
            lblSenhaCad.Name = "lblSenhaCad";
            lblSenhaCad.Size = new Size(54, 21);
            lblSenhaCad.TabIndex = 4;
            lblSenhaCad.Text = "Senha";
            // 
            // lblPerfilCad
            // 
            lblPerfilCad.Anchor = AnchorStyles.Top;
            lblPerfilCad.AutoSize = true;
            lblPerfilCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerfilCad.Location = new Point(195, 385);
            lblPerfilCad.Name = "lblPerfilCad";
            lblPerfilCad.Size = new Size(47, 21);
            lblPerfilCad.TabIndex = 5;
            lblPerfilCad.Text = "Perfil";
            // 
            // lblUsuarioCad
            // 
            lblUsuarioCad.Anchor = AnchorStyles.Top;
            lblUsuarioCad.AutoSize = true;
            lblUsuarioCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioCad.Location = new Point(533, 221);
            lblUsuarioCad.Name = "lblUsuarioCad";
            lblUsuarioCad.Size = new Size(73, 21);
            lblUsuarioCad.TabIndex = 6;
            lblUsuarioCad.Text = "Telefone";
            // 
            // lblConfirSenhaCad
            // 
            lblConfirSenhaCad.Anchor = AnchorStyles.Top;
            lblConfirSenhaCad.AutoSize = true;
            lblConfirSenhaCad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirSenhaCad.Location = new Point(533, 302);
            lblConfirSenhaCad.Name = "lblConfirSenhaCad";
            lblConfirSenhaCad.Size = new Size(131, 21);
            lblConfirSenhaCad.TabIndex = 7;
            lblConfirSenhaCad.Text = "Confirmar Senha";
            // 
            // txtNomeCad
            // 
            txtNomeCad.Anchor = AnchorStyles.Top;
            txtNomeCad.Location = new Point(195, 179);
            txtNomeCad.Name = "txtNomeCad";
            txtNomeCad.Size = new Size(634, 23);
            txtNomeCad.TabIndex = 8;
            // 
            // txtEmailCad
            // 
            txtEmailCad.Anchor = AnchorStyles.Top;
            txtEmailCad.Location = new Point(195, 260);
            txtEmailCad.Name = "txtEmailCad";
            txtEmailCad.Size = new Size(296, 23);
            txtEmailCad.TabIndex = 9;
            // 
            // txtTelefCad
            // 
            txtTelefCad.Anchor = AnchorStyles.Top;
            txtTelefCad.Location = new Point(533, 260);
            txtTelefCad.Name = "txtTelefCad";
            txtTelefCad.Size = new Size(296, 23);
            txtTelefCad.TabIndex = 10;
            // 
            // txtSenhaCad
            // 
            txtSenhaCad.Anchor = AnchorStyles.Top;
            txtSenhaCad.Location = new Point(35, 243);
            txtSenhaCad.Name = "txtSenhaCad";
            txtSenhaCad.Size = new Size(296, 23);
            txtSenhaCad.TabIndex = 11;
            // 
            // txtConfirSenhaCad
            // 
            txtConfirSenhaCad.Anchor = AnchorStyles.Top;
            txtConfirSenhaCad.Location = new Point(533, 341);
            txtConfirSenhaCad.Name = "txtConfirSenhaCad";
            txtConfirSenhaCad.Size = new Size(296, 23);
            txtConfirSenhaCad.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSenhaCad);
            panel1.Controls.Add(txtSenhaCad);
            panel1.Controls.Add(lblNomeCad);
            panel1.Location = new Point(160, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 276);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbSelecao);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(160, 370);
            panel2.Name = "panel2";
            panel2.Size = new Size(354, 133);
            panel2.TabIndex = 17;
            // 
            // cbSelecao
            // 
            cbSelecao.FormattingEnabled = true;
            cbSelecao.Location = new Point(35, 54);
            cbSelecao.Name = "cbSelecao";
            cbSelecao.Size = new Size(296, 23);
            cbSelecao.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(35, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(296, 23);
            comboBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnSalvar);
            panel3.Location = new Point(511, 370);
            panel3.Name = "panel3";
            panel3.Size = new Size(338, 133);
            panel3.TabIndex = 18;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(30, 66, 57);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btnCancelar.IconColor = Color.White;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(66, 31);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 86);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalvar.BackColor = Color.FromArgb(30, 66, 57);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSalvar.IconColor = Color.White;
            btnSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalvar.Location = new Point(186, 31);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(87, 86);
            btnSalvar.TabIndex = 19;
            btnSalvar.Text = "SALVAR";
            btnSalvar.TextAlign = ContentAlignment.BottomCenter;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // CadastroTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 633);
            Controls.Add(txtConfirSenhaCad);
            Controls.Add(txtTelefCad);
            Controls.Add(txtEmailCad);
            Controls.Add(txtNomeCad);
            Controls.Add(lblConfirSenhaCad);
            Controls.Add(lblUsuarioCad);
            Controls.Add(lblPerfilCad);
            Controls.Add(lblEmailCad);
            Controls.Add(panelSuperiorCad);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "CadastroTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            panelSuperiorCad.ResumeLayout(false);
            panelSuperiorCad.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSuperiorCad;
        private Label lblCad;
        private Label lblNomeCad;
        private Label lblEmailCad;
        private Label lblSenhaCad;
        private Label lblPerfilCad;
        private Label lblUsuarioCad;
        private Label lblConfirSenhaCad;
        private TextBox txtNomeCad;
        private TextBox txtEmailCad;
        private TextBox txtTelefCad;
        private TextBox txtSenhaCad;
        private TextBox txtConfirSenhaCad;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconMinim;
        private FontAwesome.Sharp.IconButton iconMax;
        private FontAwesome.Sharp.IconButton iconX;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnSalvar;
        private ComboBox comboBox1;
        private ComboBox cbSelecao;
    }
}