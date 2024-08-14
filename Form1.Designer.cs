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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CbxRank = new System.Windows.Forms.ComboBox();
            this.lblrank = new System.Windows.Forms.Label();
            this.LblCtg = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PnlCeramica = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PnlJardim = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNomeEnjoy = new System.Windows.Forms.Label();
            this.PnlCeramica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlJardim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "lblcode";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // CbxRank
            // 
            this.CbxRank.FormattingEnabled = true;
            this.CbxRank.Items.AddRange(new object[] {
            "Mais recentes",
            "Preço do maior para o menor",
            "Preço do menor para o maior",
            "Faixas de preço"});
            this.CbxRank.Location = new System.Drawing.Point(110, 88);
            this.CbxRank.Name = "CbxRank";
            this.CbxRank.Size = new System.Drawing.Size(143, 21);
            this.CbxRank.TabIndex = 3;
            this.CbxRank.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblrank
            // 
            this.lblrank.AccessibleName = "lblcode";
            this.lblrank.AutoSize = true;
            this.lblrank.Location = new System.Drawing.Point(12, 91);
            this.lblrank.Name = "lblrank";
            this.lblrank.Size = new System.Drawing.Size(88, 13);
            this.lblrank.TabIndex = 4;
            this.lblrank.Text = "Classificar e filtrar";
            this.lblrank.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblCtg
            // 
            this.LblCtg.AccessibleName = "lblcode";
            this.LblCtg.AutoSize = true;
            this.LblCtg.Location = new System.Drawing.Point(272, 91);
            this.LblCtg.Name = "LblCtg";
            this.LblCtg.Size = new System.Drawing.Size(57, 13);
            this.LblCtg.TabIndex = 5;
            this.LblCtg.Text = "Categorias";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Estoque",
            "Coleções",
            "Promoção",
            "Todos os produtos"});
            this.comboBox1.Location = new System.Drawing.Point(349, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // PnlCeramica
            // 
            this.PnlCeramica.BackColor = System.Drawing.SystemColors.Menu;
            this.PnlCeramica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCeramica.Controls.Add(this.label5);
            this.PnlCeramica.Controls.Add(this.textBox2);
            this.PnlCeramica.Controls.Add(this.label3);
            this.PnlCeramica.Controls.Add(this.pictureBox1);
            this.PnlCeramica.Controls.Add(this.label2);
            this.PnlCeramica.Controls.Add(this.label1);
            this.PnlCeramica.Controls.Add(this.textBox1);
            this.PnlCeramica.Location = new System.Drawing.Point(64, 152);
            this.PnlCeramica.Name = "PnlCeramica";
            this.PnlCeramica.Size = new System.Drawing.Size(189, 277);
            this.PnlCeramica.TabIndex = 8;
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
            // label3
            // 
            this.label3.AccessibleName = "LblPri";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Preço";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Compras_Enjoy.Properties.Resources.Mídia;
            this.pictureBox1.Image = global::Compras_Enjoy.Properties.Resources.Mídia_123;
            this.pictureBox1.Location = new System.Drawing.Point(15, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 120);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(64, 469);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 46);
            this.textBox3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Descrição";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // PnlJardim
            // 
            this.PnlJardim.BackColor = System.Drawing.SystemColors.Menu;
            this.PnlJardim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlJardim.CausesValidation = false;
            this.PnlJardim.Controls.Add(this.label7);
            this.PnlJardim.Controls.Add(this.textBox4);
            this.PnlJardim.Controls.Add(this.label8);
            this.PnlJardim.Controls.Add(this.pictureBox3);
            this.PnlJardim.Controls.Add(this.label9);
            this.PnlJardim.Controls.Add(this.label10);
            this.PnlJardim.Controls.Add(this.textBox5);
            this.PnlJardim.Location = new System.Drawing.Point(327, 152);
            this.PnlJardim.Name = "PnlJardim";
            this.PnlJardim.Size = new System.Drawing.Size(189, 277);
            this.PnlJardim.TabIndex = 12;
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
            // label8
            // 
            this.label8.AccessibleName = "LblPri";
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Preço";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Compras_Enjoy.Properties.Resources.Mídia;
            this.pictureBox3.Image = global::Compras_Enjoy.Properties.Resources.Jardim_Secreto;
            this.pictureBox3.Location = new System.Drawing.Point(15, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 120);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
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
            // label10
            // 
            this.label10.AccessibleName = "lblcode";
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Código";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 453);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Descrição";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(327, 469);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(206, 46);
            this.textBox6.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblNomeEnjoy);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 56);
            this.panel1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1033, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.TabStop = false;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1120, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PnlJardim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PnlCeramica);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LblCtg);
            this.Controls.Add(this.lblrank);
            this.Controls.Add(this.CbxRank);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Enjoy Louças";
            this.PnlCeramica.ResumeLayout(false);
            this.PnlCeramica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlJardim.ResumeLayout(false);
            this.PnlJardim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox CbxRank;
        private System.Windows.Forms.Label lblrank;
        private System.Windows.Forms.Label LblCtg;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel PnlCeramica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PnlJardim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNomeEnjoy;
        private System.Windows.Forms.Button button1;
    }
}

