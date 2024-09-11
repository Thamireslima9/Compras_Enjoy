namespace Compras_Enjoy
{
    partial class Compra_tela
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PnlLayout1 = new System.Windows.Forms.Panel();
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.lblNomeEnjoy = new System.Windows.Forms.Label();
            this.PnlLayout1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(995, 107);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(117, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // PnlLayout1
            // 
            this.PnlLayout1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlLayout1.BackColor = System.Drawing.Color.Maroon;
            this.PnlLayout1.Controls.Add(this.BtnCadastro);
            this.PnlLayout1.Controls.Add(this.lblNomeEnjoy);
            this.PnlLayout1.Location = new System.Drawing.Point(0, 1);
            this.PnlLayout1.Name = "PnlLayout1";
            this.PnlLayout1.Size = new System.Drawing.Size(1304, 48);
            this.PnlLayout1.TabIndex = 16;
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCadastro.BackColor = System.Drawing.Color.Maroon;
            this.BtnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCadastro.Location = new System.Drawing.Point(1101, 10);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(102, 23);
            this.BtnCadastro.TabIndex = 16;
            this.BtnCadastro.TabStop = false;
            this.BtnCadastro.Text = "Cadastrar/login";
            this.BtnCadastro.UseVisualStyleBackColor = false;
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
            // Compra_tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 649);
            this.Controls.Add(this.PnlLayout1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Compra_tela";
            this.Text = "Compra_tela";
            this.Load += new System.EventHandler(this.Compra_tela_Load);
            this.PnlLayout1.ResumeLayout(false);
            this.PnlLayout1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel PnlLayout1;
        private System.Windows.Forms.Button BtnCadastro;
        private System.Windows.Forms.Label lblNomeEnjoy;
    }
}