namespace ECOInsight
{
    partial class SobreECOBoard
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SobreECOBoard));
            tableLayoutPanel = new TableLayoutPanel();
            logoPictureBox = new PictureBox();
            okButton = new Button();
            labelCompanyName = new Label();
            labelCopyright = new Label();
            labelVersion = new Label();
            labelProductName = new Label();
            textBoxDescription = new TextBox();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
            tableLayoutPanel.Controls.Add(logoPictureBox, 0, 0);
            tableLayoutPanel.Controls.Add(okButton, 1, 5);
            tableLayoutPanel.Controls.Add(labelCompanyName, 1, 3);
            tableLayoutPanel.Controls.Add(labelCopyright, 1, 2);
            tableLayoutPanel.Controls.Add(labelVersion, 1, 1);
            tableLayoutPanel.Controls.Add(labelProductName, 1, 0);
            tableLayoutPanel.Controls.Add(textBoxDescription, 1, 4);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(10, 10);
            tableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 6;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7491856F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 48.76543F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel.Size = new Size(585, 385);
            tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Dock = DockStyle.Fill;
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(4, 3);
            logoPictureBox.Margin = new Padding(4, 3, 4, 3);
            logoPictureBox.Name = "logoPictureBox";
            tableLayoutPanel.SetRowSpan(logoPictureBox, 6);
            logoPictureBox.Size = new Size(185, 379);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 12;
            logoPictureBox.TabStop = false;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.DialogResult = DialogResult.Cancel;
            okButton.Location = new Point(493, 355);
            okButton.Margin = new Padding(4, 3, 4, 3);
            okButton.Name = "okButton";
            okButton.Size = new Size(88, 27);
            okButton.TabIndex = 24;
            okButton.Text = "&OK";
            okButton.Click += okButton_Click_1;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Location = new Point(200, 114);
            labelCompanyName.Margin = new Padding(7, 0, 4, 0);
            labelCompanyName.MaximumSize = new Size(0, 20);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(329, 20);
            labelCompanyName.TabIndex = 22;
            labelCompanyName.Text = "EcoInsight";
            labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            labelCopyright.Location = new Point(200, 76);
            labelCopyright.Margin = new Padding(7, 0, 4, 0);
            labelCopyright.MaximumSize = new Size(0, 20);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(329, 20);
            labelCopyright.TabIndex = 21;
            labelCopyright.Text = "© 2025 EcoInsight. Todos os direitos reservados.";
            labelCopyright.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            labelVersion.Location = new Point(200, 38);
            labelVersion.Margin = new Padding(7, 0, 4, 0);
            labelVersion.MaximumSize = new Size(0, 20);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(329, 20);
            labelVersion.TabIndex = 0;
            labelVersion.Text = "Versão 1.0.0";
            labelVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelProductName
            // 
            labelProductName.Location = new Point(200, 0);
            labelProductName.Margin = new Padding(7, 0, 4, 0);
            labelProductName.MaximumSize = new Size(0, 20);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(329, 20);
            labelProductName.TabIndex = 19;
            labelProductName.Text = "EcoBoard";
            labelProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(200, 158);
            textBoxDescription.Margin = new Padding(7, 3, 4, 3);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.ScrollBars = ScrollBars.Both;
            textBoxDescription.Size = new Size(381, 151);
            textBoxDescription.TabIndex = 23;
            textBoxDescription.TabStop = false;
            textBoxDescription.Text = "Descrição: A aplicação oferece uma maneira de armazenar e organizar as informações sobre o descarte de lixo em geral, além de promover conscientização de seus usuários sobre sustentabilidade.";
            // 
            // SobreECOBoard
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 405);
            Controls.Add(tableLayoutPanel);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SobreECOBoard";
            Padding = new Padding(10);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sobre EcoBoard";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button okButton;
    }
}
