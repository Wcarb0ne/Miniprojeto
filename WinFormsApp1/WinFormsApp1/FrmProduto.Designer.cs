namespace WinFormsApp1
{
    partial class FrmProduto
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btoPesquisa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btoCadastro = new System.Windows.Forms.Button();
            this.btoAlterar = new System.Windows.Forms.Button();
            this.btoExcluir = new System.Windows.Forms.Button();
            this.btolimpar = new System.Windows.Forms.Button();
            this.btoSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtVcusto = new System.Windows.Forms.TextBox();
            this.txtVvenda = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.cboIdProduto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataCadastro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btoPesquisa
            // 
            this.btoPesquisa.Location = new System.Drawing.Point(118, 35);
            this.btoPesquisa.Name = "btoPesquisa";
            this.btoPesquisa.Size = new System.Drawing.Size(27, 23);
            this.btoPesquisa.TabIndex = 1;
            this.btoPesquisa.Text = "...";
            this.btoPesquisa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // btoCadastro
            // 
            this.btoCadastro.Location = new System.Drawing.Point(12, 315);
            this.btoCadastro.Name = "btoCadastro";
            this.btoCadastro.Size = new System.Drawing.Size(83, 23);
            this.btoCadastro.TabIndex = 1;
            this.btoCadastro.Text = "&Cadastrar";
            this.btoCadastro.UseVisualStyleBackColor = true;
            // 
            // btoAlterar
            // 
            this.btoAlterar.Location = new System.Drawing.Point(105, 315);
            this.btoAlterar.Name = "btoAlterar";
            this.btoAlterar.Size = new System.Drawing.Size(83, 23);
            this.btoAlterar.TabIndex = 1;
            this.btoAlterar.Text = "&Alterar";
            this.btoAlterar.UseVisualStyleBackColor = true;
            // 
            // btoExcluir
            // 
            this.btoExcluir.Location = new System.Drawing.Point(195, 315);
            this.btoExcluir.Name = "btoExcluir";
            this.btoExcluir.Size = new System.Drawing.Size(83, 23);
            this.btoExcluir.TabIndex = 1;
            this.btoExcluir.Text = "&Excluir";
            this.btoExcluir.UseVisualStyleBackColor = true;
            // 
            // btolimpar
            // 
            this.btolimpar.Location = new System.Drawing.Point(285, 315);
            this.btolimpar.Name = "btolimpar";
            this.btolimpar.Size = new System.Drawing.Size(83, 23);
            this.btolimpar.TabIndex = 1;
            this.btolimpar.Text = "&Limpar";
            this.btolimpar.UseVisualStyleBackColor = true;
            this.btolimpar.Click += new System.EventHandler(this.btolimpar_Click);
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(378, 315);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(83, 23);
            this.btoSair.TabIndex = 1;
            this.btoSair.Text = "&Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor de custo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor de venda";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Observação";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 93);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(322, 23);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtVcusto
            // 
            this.txtVcusto.Location = new System.Drawing.Point(127, 138);
            this.txtVcusto.Name = "txtVcusto";
            this.txtVcusto.Size = new System.Drawing.Size(100, 23);
            this.txtVcusto.TabIndex = 0;
            this.txtVcusto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtVvenda
            // 
            this.txtVvenda.Location = new System.Drawing.Point(233, 138);
            this.txtVvenda.Name = "txtVvenda";
            this.txtVvenda.Size = new System.Drawing.Size(100, 23);
            this.txtVvenda.TabIndex = 0;
            this.txtVvenda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(12, 256);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(449, 53);
            this.txtObs.TabIndex = 0;
            this.txtObs.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboIdProduto
            // 
            this.cboIdProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdProduto.FormattingEnabled = true;
            this.cboIdProduto.Location = new System.Drawing.Point(340, 93);
            this.cboIdProduto.Name = "cboIdProduto";
            this.cboIdProduto.Size = new System.Drawing.Size(121, 23);
            this.cboIdProduto.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Id Produto";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 182);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(449, 53);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Descrição";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(340, 35);
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(121, 23);
            this.txtDataCadastro.TabIndex = 0;
            this.txtDataCadastro.Text = "      __ /__ /____";
            this.txtDataCadastro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Data de Cadastro";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Quantidade";
            this.label13.Click += new System.EventHandler(this.label4_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Em Estoque",
            "Em Falta"});
            this.cboStatus.Location = new System.Drawing.Point(340, 138);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 23);
            this.cboStatus.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(340, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Status";
            this.label14.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(14, 138);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(107, 23);
            this.txtQtde.TabIndex = 6;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 358);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboIdProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btoSair);
            this.Controls.Add(this.btoAlterar);
            this.Controls.Add(this.btolimpar);
            this.Controls.Add(this.btoExcluir);
            this.Controls.Add(this.btoCadastro);
            this.Controls.Add(this.btoPesquisa);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtDataCadastro);
            this.Controls.Add(this.txtVvenda);
            this.Controls.Add(this.txtVcusto);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Name = "FrmProduto";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCodigo;
        private Button btoPesquisa;
        private Label label1;
        private Button btoCadastro;
        private Button btoAlterar;
        private Button btoExcluir;
        private Button btolimpar;
        private Button btoSair;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNome;
        private TextBox txtVcusto;
        private TextBox txtVvenda;
        private TextBox txtObs;
        private ComboBox cboIdProduto;
        private Label label6;
        private TextBox txtDescricao;
        private Label label7;
        private TextBox txtDataCadastro;
        private Label label10;
        private Label label13;
        private ComboBox cboStatus;
        private Label label14;
        private TextBox txtQtde;
    }
}