namespace PI___Sistema_Gato_Preto_manga
{
    partial class GerenciamentoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciamentoClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonLimparCampo = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonConsultarCliente = new System.Windows.Forms.Button();
            this.buttonExcluirCliente = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmail = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonEscolherImg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.labelAlert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(5, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(5, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nasc";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(5, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(5, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(5, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Endereço";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(5, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cidade";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCadastrar.Location = new System.Drawing.Point(280, 367);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(109, 37);
            this.buttonCadastrar.TabIndex = 8;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonLimparCampo
            // 
            this.buttonLimparCampo.BackColor = System.Drawing.Color.IndianRed;
            this.buttonLimparCampo.Location = new System.Drawing.Point(414, 367);
            this.buttonLimparCampo.Name = "buttonLimparCampo";
            this.buttonLimparCampo.Size = new System.Drawing.Size(101, 37);
            this.buttonLimparCampo.TabIndex = 9;
            this.buttonLimparCampo.Text = "Limpar Campos";
            this.buttonLimparCampo.UseVisualStyleBackColor = false;
            this.buttonLimparCampo.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonFechar.Location = new System.Drawing.Point(644, 389);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(116, 34);
            this.buttonFechar.TabIndex = 10;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonConsultarCliente
            // 
            this.buttonConsultarCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonConsultarCliente.Location = new System.Drawing.Point(460, 25);
            this.buttonConsultarCliente.Name = "buttonConsultarCliente";
            this.buttonConsultarCliente.Size = new System.Drawing.Size(106, 46);
            this.buttonConsultarCliente.TabIndex = 11;
            this.buttonConsultarCliente.Text = "Consultar Cliente";
            this.buttonConsultarCliente.UseVisualStyleBackColor = false;
            this.buttonConsultarCliente.Click += new System.EventHandler(this.buttonConsultarCliente_Click);
            // 
            // buttonExcluirCliente
            // 
            this.buttonExcluirCliente.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExcluirCliente.Location = new System.Drawing.Point(460, 96);
            this.buttonExcluirCliente.Name = "buttonExcluirCliente";
            this.buttonExcluirCliente.Size = new System.Drawing.Size(106, 23);
            this.buttonExcluirCliente.TabIndex = 12;
            this.buttonExcluirCliente.Text = "Excluir Cliente";
            this.buttonExcluirCliente.UseVisualStyleBackColor = false;
            this.buttonExcluirCliente.Click += new System.EventHandler(this.buttonExcluirCliente_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNome.Location = new System.Drawing.Point(85, 70);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 13;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(5, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Estado";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(5, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cep";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(214, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Pais";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(218, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "CPF";
            // 
            // maskedDataNascimento
            // 
            this.maskedDataNascimento.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maskedDataNascimento.Location = new System.Drawing.Point(85, 153);
            this.maskedDataNascimento.Mask = "00/00/0000";
            this.maskedDataNascimento.Name = "maskedDataNascimento";
            this.maskedDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.maskedDataNascimento.TabIndex = 18;
            this.maskedDataNascimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedDataNascimento_MaskInputRejected);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxEmail.Location = new System.Drawing.Point(85, 194);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 19;
            this.textBoxEmail.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textBoxEmail_MaskInputRejected);
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(85, 234);
            this.maskedTextBoxTelefone.Mask = "(99) 00000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTelefone.TabIndex = 20;
            this.maskedTextBoxTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxEndereco.Location = new System.Drawing.Point(85, 269);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(100, 20);
            this.textBoxEndereco.TabIndex = 21;
            this.textBoxEndereco.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCidade.Location = new System.Drawing.Point(85, 306);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(100, 20);
            this.textBoxCidade.TabIndex = 22;
            this.textBoxCidade.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxEstado.Location = new System.Drawing.Point(85, 344);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(100, 20);
            this.textBoxEstado.TabIndex = 23;
            this.textBoxEstado.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(259, 111);
            this.maskedTextBoxCPF.Mask = "000.000.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(142, 20);
            this.maskedTextBoxCPF.TabIndex = 25;
            // 
            // textBoxPais
            // 
            this.textBoxPais.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPais.Location = new System.Drawing.Point(259, 70);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(142, 20);
            this.textBoxPais.TabIndex = 26;
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvClientes.Location = new System.Drawing.Point(572, 21);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(200, 283);
            this.dgvClientes.TabIndex = 27;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(275, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Cliente ADD";
            // 
            // buttonEscolherImg
            // 
            this.buttonEscolherImg.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEscolherImg.Location = new System.Drawing.Point(280, 285);
            this.buttonEscolherImg.Name = "buttonEscolherImg";
            this.buttonEscolherImg.Size = new System.Drawing.Size(137, 23);
            this.buttonEscolherImg.TabIndex = 31;
            this.buttonEscolherImg.Text = "Escolher imagem";
            this.buttonEscolherImg.UseVisualStyleBackColor = false;
            this.buttonEscolherImg.Click += new System.EventHandler(this.buttonEscolherImg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(280, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 83);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(277, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Imagem";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(5, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Senha";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSenha.Location = new System.Drawing.Point(85, 111);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(100, 20);
            this.textBoxSenha.TabIndex = 33;
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBoxSenha_TextChanged);
            // 
            // maskedTextBoxCEP
            // 
            this.maskedTextBoxCEP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maskedTextBoxCEP.Location = new System.Drawing.Point(85, 379);
            this.maskedTextBoxCEP.Mask = "00000-999";
            this.maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            this.maskedTextBoxCEP.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCEP.TabIndex = 34;
            this.maskedTextBoxCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxCEP_MaskInputRejected);
            // 
            // labelAlert
            // 
            this.labelAlert.AutoSize = true;
            this.labelAlert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAlert.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelAlert.Location = new System.Drawing.Point(411, 135);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(0, 13);
            this.labelAlert.TabIndex = 37;
            // 
            // GerenciamentoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAlert);
            this.Controls.Add(this.maskedTextBoxCEP);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonEscolherImg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.maskedTextBoxCPF);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.maskedDataNascimento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonExcluirCliente);
            this.Controls.Add(this.buttonConsultarCliente);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonLimparCampo);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GerenciamentoClientes";
            this.Text = "GerenciamentoClientes";
            this.Load += new System.EventHandler(this.GerenciamentoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonLimparCampo;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonConsultarCliente;
        private System.Windows.Forms.Button buttonExcluirCliente;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox maskedDataNascimento;
        private System.Windows.Forms.MaskedTextBox textBoxEmail;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonEscolherImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCEP;
        private System.Windows.Forms.Label labelAlert;
    }
}