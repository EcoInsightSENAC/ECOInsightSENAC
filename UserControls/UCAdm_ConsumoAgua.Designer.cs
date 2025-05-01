namespace ECOInsight.UserControls
{
    partial class UCAdm_ConsumoAgua
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
            lblAdmConsumoAgua = new Label();
            textTotalLitros = new TextBox();
            textTotalGarrafas = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            textAguaOutrasInfo = new TextBox();
            btn_LimparFiltrosAgua = new FontAwesome.Sharp.IconButton();
            textIdBebedouro = new TextBox();
            label6 = new Label();
            btn_Salvar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // lblAdmConsumoAgua
            // 
            lblAdmConsumoAgua.Anchor = AnchorStyles.Top;
            lblAdmConsumoAgua.AutoSize = true;
            lblAdmConsumoAgua.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmConsumoAgua.ForeColor = Color.FromArgb(35, 68, 57);
            lblAdmConsumoAgua.Location = new Point(84, 52);
            lblAdmConsumoAgua.Name = "lblAdmConsumoAgua";
            lblAdmConsumoAgua.Size = new Size(203, 25);
            lblAdmConsumoAgua.TabIndex = 68;
            lblAdmConsumoAgua.Text = "CONSUMO DE ÁGUA";
            // 
            // textTotalLitros
            // 
            textTotalLitros.Anchor = AnchorStyles.Top;
            textTotalLitros.Location = new Point(257, 322);
            textTotalLitros.Name = "textTotalLitros";
            textTotalLitros.Size = new Size(100, 23);
            textTotalLitros.TabIndex = 66;
            textTotalLitros.KeyPress += textTotalLitros_KeyPress;
            // 
            // textTotalGarrafas
            // 
            textTotalGarrafas.Anchor = AnchorStyles.Top;
            textTotalGarrafas.Location = new Point(326, 260);
            textTotalGarrafas.Name = "textTotalGarrafas";
            textTotalGarrafas.Size = new Size(100, 23);
            textTotalGarrafas.TabIndex = 65;
            textTotalGarrafas.KeyPress += textTotalGarrafas_KeyPress;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 11F);
            dateTimePicker1.Location = new Point(267, 132);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(251, 23);
            dateTimePicker1.TabIndex = 64;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(96, 323);
            label3.Name = "label3";
            label3.Size = new Size(162, 21);
            label3.TabIndex = 63;
            label3.Text = "Total de litros usados :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(93, 261);
            label2.Name = "label2";
            label2.Size = new Size(234, 21);
            label2.TabIndex = 62;
            label2.Text = "Total de garrafas economizadas :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 133);
            label1.Name = "label1";
            label1.Size = new Size(168, 21);
            label1.TabIndex = 61;
            label1.Text = "Data da troca do filtro :";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(91, 387);
            label7.Name = "label7";
            label7.Size = new Size(161, 21);
            label7.TabIndex = 68;
            label7.Text = "Outras informações: ";
            // 
            // textAguaOutrasInfo
            // 
            textAguaOutrasInfo.Anchor = AnchorStyles.Top;
            textAguaOutrasInfo.Location = new Point(93, 421);
            textAguaOutrasInfo.Multiline = true;
            textAguaOutrasInfo.Name = "textAguaOutrasInfo";
            textAguaOutrasInfo.Size = new Size(801, 97);
            textAguaOutrasInfo.TabIndex = 67;
            // 
            // btn_LimparFiltrosAgua
            // 
            btn_LimparFiltrosAgua.Anchor = AnchorStyles.Top;
            btn_LimparFiltrosAgua.BackColor = Color.White;
            btn_LimparFiltrosAgua.FlatAppearance.BorderColor = Color.FromArgb(35, 68, 57);
            btn_LimparFiltrosAgua.FlatAppearance.BorderSize = 2;
            btn_LimparFiltrosAgua.FlatStyle = FlatStyle.Flat;
            btn_LimparFiltrosAgua.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_LimparFiltrosAgua.ForeColor = Color.FromArgb(35, 68, 57);
            btn_LimparFiltrosAgua.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_LimparFiltrosAgua.IconColor = Color.White;
            btn_LimparFiltrosAgua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_LimparFiltrosAgua.IconSize = 25;
            btn_LimparFiltrosAgua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_LimparFiltrosAgua.Location = new Point(659, 538);
            btn_LimparFiltrosAgua.Name = "btn_LimparFiltrosAgua";
            btn_LimparFiltrosAgua.Padding = new Padding(5, 0, 0, 0);
            btn_LimparFiltrosAgua.Size = new Size(113, 41);
            btn_LimparFiltrosAgua.TabIndex = 69;
            btn_LimparFiltrosAgua.Text = "Limpar Dados";
            btn_LimparFiltrosAgua.UseVisualStyleBackColor = false;
            btn_LimparFiltrosAgua.Click += btn_LimparFiltrosAgua_Click;
            // 
            // textIdBebedouro
            // 
            textIdBebedouro.Anchor = AnchorStyles.Top;
            textIdBebedouro.Location = new Point(308, 196);
            textIdBebedouro.Name = "textIdBebedouro";
            textIdBebedouro.Size = new Size(100, 23);
            textIdBebedouro.TabIndex = 73;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(96, 198);
            label6.Name = "label6";
            label6.Size = new Size(206, 21);
            label6.TabIndex = 72;
            label6.Text = "Identificação do bebedouro :";
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
            btn_Salvar.Location = new Point(789, 538);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Padding = new Padding(3, 0, 0, 0);
            btn_Salvar.Size = new Size(105, 41);
            btn_Salvar.TabIndex = 74;
            btn_Salvar.Text = "       Salvar ";
            btn_Salvar.UseVisualStyleBackColor = false;
            // 
            // UCAdm_ConsumoAgua
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Salvar);
            Controls.Add(textIdBebedouro);
            Controls.Add(label6);
            Controls.Add(lblAdmConsumoAgua);
            Controls.Add(btn_LimparFiltrosAgua);
            Controls.Add(label7);
            Controls.Add(textAguaOutrasInfo);
            Controls.Add(textTotalLitros);
            Controls.Add(textTotalGarrafas);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCAdm_ConsumoAgua";
            Size = new Size(978, 646);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdmConsumoAgua;
        private TextBox textTotalLitros;
        private TextBox textTotalGarrafas;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox textAguaOutrasInfo;
        private FontAwesome.Sharp.IconButton btn_LimparFiltrosAgua;
        private TextBox textIdBebedouro;
        private Label label6;
        private FontAwesome.Sharp.IconButton btn_Salvar;
    }
}
