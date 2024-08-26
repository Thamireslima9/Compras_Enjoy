namespace Compras_Enjoy
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblCod1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CbxFiltro = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.PnlCeramica = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalveImage1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblPrice1 = new System.Windows.Forms.Label();
            this.PcBxCeramica = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbDescrição1 = new System.Windows.Forms.TextBox();
            this.LblDescriçaõ1 = new System.Windows.Forms.Label();
            this.PnlJardim = new System.Windows.Forms.Panel();
            this.BtnSalveImage2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LblPrice2 = new System.Windows.Forms.Label();
            this.PcBxJardim = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LblCod2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.LblDescriçao2 = new System.Windows.Forms.Label();
            this.TxbDescrição2 = new System.Windows.Forms.TextBox();
            this.PnlLayout1 = new System.Windows.Forms.Panel();
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.lblNomeEnjoy = new System.Windows.Forms.Label();
            this.BtnFinish = new System.Windows.Forms.Button();
            this.PnlCeramica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcBxCeramica)).BeginInit();
            this.PnlJardim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcBxJardim)).BeginInit();
            this.PnlLayout1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblCod1
            // 
            this.LblCod1.AccessibleName = "lblcode";
            this.LblCod1.AutoSize = true;
            this.LblCod1.Location = new System.Drawing.Point(16, 181);
            this.LblCod1.Name = "LblCod1";
            this.LblCod1.Size = new System.Drawing.Size(40, 13);
            this.LblCod1.TabIndex = 1;
            this.LblCod1.Text = "Código";
            this.LblCod1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "txbcode";
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(64, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CbxFiltro
            // 
            this.CbxFiltro.FormattingEnabled = true;
            this.CbxFiltro.Items.AddRange(new object[] {
            "Mais recentes",
            "Promoção",
            "Preço do maior para o menor",
            "Preço do menor para o maior"});
            this.CbxFiltro.Location = new System.Drawing.Point(110, 88);
            this.CbxFiltro.Name = "CbxFiltro";
            this.CbxFiltro.Size = new System.Drawing.Size(143, 21);
            this.CbxFiltro.TabIndex = 3;
            this.CbxFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AccessibleName = "lblcode";
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(12, 91);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(88, 13);
            this.lblFiltro.TabIndex = 4;
            this.lblFiltro.Text = "Classificar e filtrar";
            this.lblFiltro.Click += new System.EventHandler(this.label2_Click);
            // 
            // PnlCeramica
            // 
            this.PnlCeramica.BackColor = System.Drawing.SystemColors.Menu;
            this.PnlCeramica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCeramica.Controls.Add(this.label1);
            this.PnlCeramica.Controls.Add(this.BtnSalveImage1);
            this.PnlCeramica.Controls.Add(this.label5);
            this.PnlCeramica.Controls.Add(this.textBox2);
            this.PnlCeramica.Controls.Add(this.LblPrice1);
            this.PnlCeramica.Controls.Add(this.PcBxCeramica);
            this.PnlCeramica.Controls.Add(this.label2);
            this.PnlCeramica.Controls.Add(this.LblCod1);
            this.PnlCeramica.Controls.Add(this.textBox1);
            this.PnlCeramica.Location = new System.Drawing.Point(40, 152);
            this.PnlCeramica.Name = "PnlCeramica";
            this.PnlCeramica.Size = new System.Drawing.Size(189, 329);
            this.PnlCeramica.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AccessibleName = "LblPri";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Preço";
            // 
            // BtnSalveImage1
            // 
            this.BtnSalveImage1.Location = new System.Drawing.Point(50, 302);
            this.BtnSalveImage1.Name = "BtnSalveImage1";
            this.BtnSalveImage1.Size = new System.Drawing.Size(77, 22);
            this.BtnSalveImage1.TabIndex = 16;
            this.BtnSalveImage1.Text = "Salvar";
            this.BtnSalveImage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cerâmica artesanal";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // LblPrice1
            // 
            this.LblPrice1.AccessibleName = "LblPri";
            this.LblPrice1.AutoSize = true;
            this.LblPrice1.Location = new System.Drawing.Point(16, 211);
            this.LblPrice1.Name = "LblPrice1";
            this.LblPrice1.Size = new System.Drawing.Size(35, 13);
            this.LblPrice1.TabIndex = 11;
            this.LblPrice1.Text = "Preço";
            // 
            // PcBxCeramica
            // 
            this.PcBxCeramica.BackgroundImage = global::Compras_Enjoy.Properties.Resources.Mídia;
            this.PcBxCeramica.Image = global::Compras_Enjoy.Properties.Resources.Mídia_123;
            this.PcBxCeramica.Location = new System.Drawing.Point(15, 38);
            this.PcBxCeramica.Name = "PcBxCeramica";
            this.PcBxCeramica.Size = new System.Drawing.Size(100, 120);
            this.PcBxCeramica.TabIndex = 10;
            this.PcBxCeramica.TabStop = false;
            this.PcBxCeramica.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AccessibleName = "lblcode";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // TxbDescrição1
            // 
            this.TxbDescrição1.Location = new System.Drawing.Point(40, 512);
            this.TxbDescrição1.Multiline = true;
            this.TxbDescrição1.Name = "TxbDescrição1";
            this.TxbDescrição1.Size = new System.Drawing.Size(206, 46);
            this.TxbDescrição1.TabIndex = 10;
            // 
            // LblDescriçaõ1
            // 
            this.LblDescriçaõ1.AutoSize = true;
            this.LblDescriçaõ1.Location = new System.Drawing.Point(37, 496);
            this.LblDescriçaõ1.Name = "LblDescriçaõ1";
            this.LblDescriçaõ1.Size = new System.Drawing.Size(55, 13);
            this.LblDescriçaõ1.TabIndex = 11;
            this.LblDescriçaõ1.Text = "Descrição";
            this.LblDescriçaõ1.Click += new System.EventHandler(this.label6_Click);
            // 
            // PnlJardim
            // 
            this.PnlJardim.BackColor = System.Drawing.SystemColors.Menu;
            this.PnlJardim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlJardim.CausesValidation = false;
            this.PnlJardim.Controls.Add(this.BtnSalveImage2);
            this.PnlJardim.Controls.Add(this.label7);
            this.PnlJardim.Controls.Add(this.textBox4);
            this.PnlJardim.Controls.Add(this.LblPrice2);
            this.PnlJardim.Controls.Add(this.PcBxJardim);
            this.PnlJardim.Controls.Add(this.label9);
            this.PnlJardim.Controls.Add(this.LblCod2);
            this.PnlJardim.Controls.Add(this.textBox5);
            this.PnlJardim.Location = new System.Drawing.Point(327, 152);
            this.PnlJardim.Name = "PnlJardim";
            this.PnlJardim.Size = new System.Drawing.Size(189, 329);
            this.PnlJardim.TabIndex = 12;
            // 
            // BtnSalveImage2
            // 
            this.BtnSalveImage2.Location = new System.Drawing.Point(51, 302);
            this.BtnSalveImage2.Name = "BtnSalveImage2";
            this.BtnSalveImage2.Size = new System.Drawing.Size(77, 22);
            this.BtnSalveImage2.TabIndex = 17;
            this.BtnSalveImage2.Text = "Salva";
            this.BtnSalveImage2.UseVisualStyleBackColor = true;
            this.BtnSalveImage2.Click += new System.EventHandler(this.BtnSalveImage2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Jardim secreto coleção";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(58, 211);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // LblPrice2
            // 
            this.LblPrice2.AccessibleName = "LblPri";
            this.LblPrice2.AutoSize = true;
            this.LblPrice2.Location = new System.Drawing.Point(12, 211);
            this.LblPrice2.Name = "LblPrice2";
            this.LblPrice2.Size = new System.Drawing.Size(35, 13);
            this.LblPrice2.TabIndex = 11;
            this.LblPrice2.Text = "Preço";
            // 
            // PcBxJardim
            // 
            this.PcBxJardim.BackgroundImage = global::Compras_Enjoy.Properties.Resources.Mídia;
            this.PcBxJardim.Image = global::Compras_Enjoy.Properties.Resources.Jardim_Secreto;
            this.PcBxJardim.Location = new System.Drawing.Point(15, 38);
            this.PcBxJardim.Name = "PcBxJardim";
            this.PcBxJardim.Size = new System.Drawing.Size(102, 120);
            this.PcBxJardim.TabIndex = 10;
            this.PcBxJardim.TabStop = false;
            // 
            // label9
            // 
            this.label9.AccessibleName = "lblcode";
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 9;
            // 
            // LblCod2
            // 
            this.LblCod2.AccessibleName = "lblcode";
            this.LblCod2.AutoSize = true;
            this.LblCod2.Location = new System.Drawing.Point(12, 181);
            this.LblCod2.Name = "LblCod2";
            this.LblCod2.Size = new System.Drawing.Size(40, 13);
            this.LblCod2.TabIndex = 1;
            this.LblCod2.Text = "Código";
            // 
            // textBox5
            // 
            this.textBox5.AccessibleName = "txbcode";
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(58, 178);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(45, 20);
            this.textBox5.TabIndex = 2;
            // 
            // LblDescriçao2
            // 
            this.LblDescriçao2.AutoSize = true;
            this.LblDescriçao2.Location = new System.Drawing.Point(325, 496);
            this.LblDescriçao2.Name = "LblDescriçao2";
            this.LblDescriçao2.Size = new System.Drawing.Size(55, 13);
            this.LblDescriçao2.TabIndex = 13;
            this.LblDescriçao2.Text = "Descrição";
            // 
            // TxbDescrição2
            // 
            this.TxbDescrição2.Location = new System.Drawing.Point(327, 512);
            this.TxbDescrição2.Multiline = true;
            this.TxbDescrição2.Name = "TxbDescrição2";
            this.TxbDescrição2.Size = new System.Drawing.Size(206, 46);
            this.TxbDescrição2.TabIndex = 14;
            // 
            // PnlLayout1
            // 
            this.PnlLayout1.BackColor = System.Drawing.Color.Maroon;
            this.PnlLayout1.Controls.Add(this.BtnCadastro);
            this.PnlLayout1.Controls.Add(this.lblNomeEnjoy);
            this.PnlLayout1.Location = new System.Drawing.Point(0, -1);
            this.PnlLayout1.Name = "PnlLayout1";
            this.PnlLayout1.Size = new System.Drawing.Size(1124, 56);
            this.PnlLayout1.TabIndex = 15;
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.BackColor = System.Drawing.Color.Maroon;
            this.BtnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCadastro.Location = new System.Drawing.Point(921, 24);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(102, 23);
            this.BtnCadastro.TabIndex = 16;
            this.BtnCadastro.TabStop = false;
            this.BtnCadastro.Text = "Cadastrar/login";
            this.BtnCadastro.UseVisualStyleBackColor = false;
            this.BtnCadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNomeEnjoy
            // 
            this.lblNomeEnjoy.AutoSize = true;
            this.lblNomeEnjoy.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEnjoy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomeEnjoy.Location = new System.Drawing.Point(15, 10);
            this.lblNomeEnjoy.Name = "lblNomeEnjoy";
            this.lblNomeEnjoy.Size = new System.Drawing.Size(198, 37);
            this.lblNomeEnjoy.TabIndex = 0;
            this.lblNomeEnjoy.Text = "Enjoy Louças";
            // 
            // BtnFinish
            // 
            this.BtnFinish.Location = new System.Drawing.Point(1017, 586);
            this.BtnFinish.Name = "BtnFinish";
            this.BtnFinish.Size = new System.Drawing.Size(77, 22);
            this.BtnFinish.TabIndex = 17;
            this.BtnFinish.Text = "button3";
            this.BtnFinish.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1120, 620);
            this.Controls.Add(this.BtnFinish);
            this.Controls.Add(this.PnlLayout1);
            this.Controls.Add(this.TxbDescrição2);
            this.Controls.Add(this.LblDescriçao2);
            this.Controls.Add(this.PnlJardim);
            this.Controls.Add(this.LblDescriçaõ1);
            this.Controls.Add(this.TxbDescrição1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PnlCeramica);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.CbxFiltro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enjoy Louças";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlCeramica.ResumeLayout(false);
            this.PnlCeramica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcBxCeramica)).EndInit();
            this.PnlJardim.ResumeLayout(false);
            this.PnlJardim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcBxJardim)).EndInit();
            this.PnlLayout1.ResumeLayout(false);
            this.PnlLayout1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblCod1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox CbxFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Panel PnlCeramica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPrice1;
        private System.Windows.Forms.PictureBox PcBxCeramica;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbDescrição1;
        private System.Windows.Forms.Label LblDescriçaõ1;
        private System.Windows.Forms.Panel PnlJardim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label LblPrice2;
        private System.Windows.Forms.PictureBox PcBxJardim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblCod2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label LblDescriçao2;
        private System.Windows.Forms.TextBox TxbDescrição2;
        private System.Windows.Forms.Panel PnlLayout1;
        private System.Windows.Forms.Label lblNomeEnjoy;
        private System.Windows.Forms.Button BtnCadastro;
        private System.Windows.Forms.Button BtnSalveImage1;
        private System.Windows.Forms.Button BtnSalveImage2;
        private System.Windows.Forms.Button BtnFinish;
        private System.Windows.Forms.Label label1;
    }
}

