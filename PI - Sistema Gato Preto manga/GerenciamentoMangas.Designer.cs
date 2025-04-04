namespace PI___Sistema_Gato_Preto_manga
{
    partial class GerenciamentoMangas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciamentoMangas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxVolumes = new System.Windows.Forms.ComboBox();
            this.comboBoxClassificacaoIndicativa = new System.Windows.Forms.ComboBox();
            this.richTextBoxSinopse = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maskedTextAnoLancamento = new System.Windows.Forms.MaskedTextBox();
            this.buttonEscolherImg = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonLimparCampos = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvMangas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(246, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mangas ADD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gênero";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano de lançamento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Location = new System.Drawing.Point(7, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Volumes";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.Location = new System.Drawing.Point(12, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Classificação indicativa";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label8.Location = new System.Drawing.Point(301, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sinopse";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label9.Location = new System.Drawing.Point(12, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Autor";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label10.Location = new System.Drawing.Point(302, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Imagem";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxTitulo.Location = new System.Drawing.Point(135, 70);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(129, 20);
            this.textBoxTitulo.TabIndex = 1;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.textBoxTitulo_TextChanged);
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxAutor.Location = new System.Drawing.Point(135, 361);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(129, 20);
            this.textBoxAutor.TabIndex = 7;
            this.textBoxAutor.TextChanged += new System.EventHandler(this.textBoxAutor_TextChanged);
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "Shonen",
            "Shounen Ai",
            "shojo",
            "Shoujo Ai",
            "Yaoi",
            "Isekai",
            "Kodomomuke",
            "Slice of Life",
            "Seinen",
            "Mecha",
            "Josei",
            "Yuri",
            "Iyashikei",
            "Idol",
            "Ecchi",
            "Harem",
            "Reverse Harem",
            "Youkai",
            "Doujinshi or dōjinsh",
            "One Shot",
            "Hentai",
            "",
            ""});
            this.comboBoxGenero.Location = new System.Drawing.Point(135, 126);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(129, 21);
            this.comboBoxGenero.TabIndex = 2;
            this.comboBoxGenero.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenero_SelectedIndexChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Ativo ",
            "Hiato",
            "Cancelado ",
            "Concluido"});
            this.comboBoxStatus.Location = new System.Drawing.Point(135, 220);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(129, 21);
            this.comboBoxStatus.TabIndex = 4;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // comboBoxVolumes
            // 
            this.comboBoxVolumes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.comboBoxVolumes.FormattingEnabled = true;
            this.comboBoxVolumes.Location = new System.Drawing.Point(135, 266);
            this.comboBoxVolumes.Name = "comboBoxVolumes";
            this.comboBoxVolumes.Size = new System.Drawing.Size(129, 21);
            this.comboBoxVolumes.TabIndex = 5;
            this.comboBoxVolumes.SelectedIndexChanged += new System.EventHandler(this.comboBoxVolumes_SelectedIndexChanged);
            // 
            // comboBoxClassificacaoIndicativa
            // 
            this.comboBoxClassificacaoIndicativa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.comboBoxClassificacaoIndicativa.FormattingEnabled = true;
            this.comboBoxClassificacaoIndicativa.Items.AddRange(new object[] {
            "L",
            "10+",
            "12+",
            "",
            "16 +",
            "18 +"});
            this.comboBoxClassificacaoIndicativa.Location = new System.Drawing.Point(135, 310);
            this.comboBoxClassificacaoIndicativa.Name = "comboBoxClassificacaoIndicativa";
            this.comboBoxClassificacaoIndicativa.Size = new System.Drawing.Size(129, 21);
            this.comboBoxClassificacaoIndicativa.TabIndex = 6;
            this.comboBoxClassificacaoIndicativa.SelectedIndexChanged += new System.EventHandler(this.comboBoxClassificacaoIndicativa_SelectedIndexChanged);
            // 
            // richTextBoxSinopse
            // 
            this.richTextBoxSinopse.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.richTextBoxSinopse.Location = new System.Drawing.Point(354, 235);
            this.richTextBoxSinopse.Name = "richTextBoxSinopse";
            this.richTextBoxSinopse.Size = new System.Drawing.Size(134, 96);
            this.richTextBoxSinopse.TabIndex = 9;
            this.richTextBoxSinopse.Text = "";
            this.richTextBoxSinopse.TextChanged += new System.EventHandler(this.richTextBoxSinopse_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(354, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 83);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // maskedTextAnoLancamento
            // 
            this.maskedTextAnoLancamento.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.maskedTextAnoLancamento.Location = new System.Drawing.Point(135, 176);
            this.maskedTextAnoLancamento.Mask = "0000";
            this.maskedTextAnoLancamento.Name = "maskedTextAnoLancamento";
            this.maskedTextAnoLancamento.Size = new System.Drawing.Size(40, 20);
            this.maskedTextAnoLancamento.TabIndex = 3;
            this.maskedTextAnoLancamento.ValidatingType = typeof(System.DateTime);
            this.maskedTextAnoLancamento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextAnoLancamento_MaskInputRejected);
            // 
            // buttonEscolherImg
            // 
            this.buttonEscolherImg.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEscolherImg.Location = new System.Drawing.Point(354, 159);
            this.buttonEscolherImg.Name = "buttonEscolherImg";
            this.buttonEscolherImg.Size = new System.Drawing.Size(134, 23);
            this.buttonEscolherImg.TabIndex = 8;
            this.buttonEscolherImg.Text = "Escolher imagem";
            this.buttonEscolherImg.UseVisualStyleBackColor = false;
            this.buttonEscolherImg.Click += new System.EventHandler(this.buttonEscolherImg_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCadastrar.Location = new System.Drawing.Point(305, 380);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(117, 37);
            this.buttonCadastrar.TabIndex = 10;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonLimparCampos
            // 
            this.buttonLimparCampos.BackColor = System.Drawing.Color.IndianRed;
            this.buttonLimparCampos.Location = new System.Drawing.Point(453, 394);
            this.buttonLimparCampos.Name = "buttonLimparCampos";
            this.buttonLimparCampos.Size = new System.Drawing.Size(97, 23);
            this.buttonLimparCampos.TabIndex = 11;
            this.buttonLimparCampos.Text = "Limpar Campos";
            this.buttonLimparCampos.UseVisualStyleBackColor = false;
            this.buttonLimparCampos.Click += new System.EventHandler(this.buttonLimparCampos_Click);
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.IndianRed;
            this.Fechar.Location = new System.Drawing.Point(702, 415);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(75, 23);
            this.Fechar.TabIndex = 15;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(592, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Pesquisar Mangá";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(674, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Remover mangá";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvMangas
            // 
            this.dgvMangas.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvMangas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMangas.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMangas.Location = new System.Drawing.Point(592, 67);
            this.dgvMangas.Name = "dgvMangas";
            this.dgvMangas.Size = new System.Drawing.Size(200, 283);
            this.dgvMangas.TabIndex = 13;
            this.dgvMangas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GerenciamentoMangas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.dgvMangas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.buttonLimparCampos);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonEscolherImg);
            this.Controls.Add(this.maskedTextAnoLancamento);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBoxSinopse);
            this.Controls.Add(this.comboBoxClassificacaoIndicativa);
            this.Controls.Add(this.comboBoxVolumes);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "GerenciamentoMangas";
            this.Text = "GerenciamentoMangas";
            this.Load += new System.EventHandler(this.GerenciamentoMangas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxVolumes;
        private System.Windows.Forms.ComboBox comboBoxClassificacaoIndicativa;
        private System.Windows.Forms.RichTextBox richTextBoxSinopse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextAnoLancamento;
        private System.Windows.Forms.Button buttonEscolherImg;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonLimparCampos;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvMangas;
    }
}