namespace ECOInsight.UserControls
{
    partial class UCAdm_Destaques
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
            lblDestaques = new Label();
            pictureBoxDestaques = new PictureBox();
            btnInserirImagem = new FontAwesome.Sharp.IconButton();
            txtMensagem = new TextBox();
            lblMensagem = new Label();
            btnSalvar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            lblFuncionarioHome = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDestaques).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDestaques
            // 
            lblDestaques.Anchor = AnchorStyles.Top;
            lblDestaques.AutoSize = true;
            lblDestaques.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestaques.Location = new Point(52, 51);
            lblDestaques.Name = "lblDestaques";
            lblDestaques.Size = new Size(163, 37);
            lblDestaques.TabIndex = 27;
            lblDestaques.Text = "Destaques!";
            // 
            // pictureBoxDestaques
            // 
            pictureBoxDestaques.Anchor = AnchorStyles.Top;
            pictureBoxDestaques.BackColor = SystemColors.ControlLight;
            pictureBoxDestaques.Location = new Point(52, 104);
            pictureBoxDestaques.Name = "pictureBoxDestaques";
            pictureBoxDestaques.Size = new Size(874, 205);
            pictureBoxDestaques.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDestaques.TabIndex = 28;
            pictureBoxDestaques.TabStop = false;
            // 
            // btnInserirImagem
            // 
            btnInserirImagem.Anchor = AnchorStyles.Top;
            btnInserirImagem.BackColor = Color.FromArgb(35, 68, 57);
            btnInserirImagem.FlatStyle = FlatStyle.Flat;
            btnInserirImagem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserirImagem.ForeColor = Color.White;
            btnInserirImagem.IconChar = FontAwesome.Sharp.IconChar.Image;
            btnInserirImagem.IconColor = Color.White;
            btnInserirImagem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInserirImagem.IconSize = 25;
            btnInserirImagem.ImageAlign = ContentAlignment.MiddleLeft;
            btnInserirImagem.Location = new Point(784, 320);
            btnInserirImagem.Name = "btnInserirImagem";
            btnInserirImagem.Padding = new Padding(3, 0, 0, 0);
            btnInserirImagem.Size = new Size(142, 41);
            btnInserirImagem.TabIndex = 49;
            btnInserirImagem.Text = "Inserir Imagem";
            btnInserirImagem.TextAlign = ContentAlignment.MiddleRight;
            btnInserirImagem.UseVisualStyleBackColor = false;
            // 
            // txtMensagem
            // 
            txtMensagem.Anchor = AnchorStyles.Top;
            txtMensagem.Location = new Point(52, 421);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(874, 146);
            txtMensagem.TabIndex = 50;
            // 
            // lblMensagem
            // 
            lblMensagem.Anchor = AnchorStyles.Top;
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagem.Location = new Point(52, 368);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(162, 37);
            lblMensagem.TabIndex = 51;
            lblMensagem.Text = "Mensagem";
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top;
            btnSalvar.BackColor = Color.FromArgb(35, 68, 57);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSalvar.IconColor = Color.White;
            btnSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalvar.IconSize = 25;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(821, 573);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(3, 0, 0, 0);
            btnSalvar.Size = new Size(105, 41);
            btnSalvar.TabIndex = 52;
            btnSalvar.Text = "       Salvar ";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(iconButton8);
            panel1.Controls.Add(lblFuncionarioHome);
            panel1.Controls.Add(iconButton4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 39);
            panel1.TabIndex = 53;
            // 
            // iconButton8
            // 
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            iconButton8.IconColor = Color.Black;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 25;
            iconButton8.Location = new Point(48, 2);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(39, 34);
            iconButton8.TabIndex = 74;
            iconButton8.UseVisualStyleBackColor = true;
            // 
            // lblFuncionarioHome
            // 
            lblFuncionarioHome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFuncionarioHome.AutoSize = true;
            lblFuncionarioHome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuncionarioHome.ForeColor = Color.Black;
            lblFuncionarioHome.Location = new Point(455, 7);
            lblFuncionarioHome.Name = "lblFuncionarioHome";
            lblFuncionarioHome.Size = new Size(69, 25);
            lblFuncionarioHome.TabIndex = 68;
            lblFuncionarioHome.Text = "HOME";
            // 
            // iconButton4
            // 
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 25;
            iconButton4.Location = new Point(3, 3);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(39, 34);
            iconButton4.TabIndex = 73;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // UCAdm_Destaques
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(btnSalvar);
            Controls.Add(lblMensagem);
            Controls.Add(txtMensagem);
            Controls.Add(btnInserirImagem);
            Controls.Add(pictureBoxDestaques);
            Controls.Add(lblDestaques);
            Name = "UCAdm_Destaques";
            Size = new Size(978, 646);
            ((System.ComponentModel.ISupportInitialize)pictureBoxDestaques).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDestaques;
        private PictureBox pictureBoxDestaques;
        private FontAwesome.Sharp.IconButton btnInserirImagem;
        private TextBox txtMensagem;
        private Label lblMensagem;
        private FontAwesome.Sharp.IconButton btnSalvar;
        private Panel panel1;
        private Label lblFuncionarioHome;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}
