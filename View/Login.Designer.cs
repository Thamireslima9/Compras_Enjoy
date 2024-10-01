namespace Compras_Enjoy
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.BtnEntrarLogin = new System.Windows.Forms.Button();
            this.LblLogin1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbkEmailLogin = new System.Windows.Forms.Label();
            this.LblSenhaLogin = new System.Windows.Forms.Label();
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.TxbSenhaLogin = new System.Windows.Forms.TextBox();
            this.TxbEmailLogin = new System.Windows.Forms.TextBox();
            this.LblEnjoyLogin = new System.Windows.Forms.Label();
            this.PnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEntrarLogin
            // 
            this.BtnEntrarLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEntrarLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnEntrarLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnEntrarLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrarLogin.ForeColor = System.Drawing.Color.DimGray;
            this.BtnEntrarLogin.Location = new System.Drawing.Point(208, 360);
            this.BtnEntrarLogin.Name = "BtnEntrarLogin";
            this.BtnEntrarLogin.Size = new System.Drawing.Size(238, 62);
            this.BtnEntrarLogin.TabIndex = 1;
            this.BtnEntrarLogin.Text = "ENTRAR";
            this.BtnEntrarLogin.UseVisualStyleBackColor = false;
            this.BtnEntrarLogin.Click += new System.EventHandler(this.BtnEntrarLogin_Click);
            // 
            // LblLogin1
            // 
            this.LblLogin1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblLogin1.AutoSize = true;
            this.LblLogin1.BackColor = System.Drawing.Color.Transparent;
            this.LblLogin1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblLogin1.Location = new System.Drawing.Point(250, 40);
            this.LblLogin1.Name = "LblLogin1";
            this.LblLogin1.Size = new System.Drawing.Size(168, 41);
            this.LblLogin1.TabIndex = 2;
            this.LblLogin1.Text = "Fazer login";
            this.LblLogin1.Click += new System.EventHandler(this.LblLogin1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(752, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 54);
            this.label1.TabIndex = 3;
            // 
            // LbkEmailLogin
            // 
            this.LbkEmailLogin.AutoSize = true;
            this.LbkEmailLogin.BackColor = System.Drawing.Color.Transparent;
            this.LbkEmailLogin.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbkEmailLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbkEmailLogin.Location = new System.Drawing.Point(67, 137);
            this.LbkEmailLogin.Name = "LbkEmailLogin";
            this.LbkEmailLogin.Size = new System.Drawing.Size(56, 22);
            this.LbkEmailLogin.TabIndex = 5;
            this.LbkEmailLogin.Text = "Email:";
            // 
            // LblSenhaLogin
            // 
            this.LblSenhaLogin.AutoSize = true;
            this.LblSenhaLogin.BackColor = System.Drawing.Color.Transparent;
            this.LblSenhaLogin.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenhaLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblSenhaLogin.Location = new System.Drawing.Point(67, 213);
            this.LblSenhaLogin.Name = "LblSenhaLogin";
            this.LblSenhaLogin.Size = new System.Drawing.Size(62, 22);
            this.LblSenhaLogin.TabIndex = 6;
            this.LblSenhaLogin.Text = "Senha:";
            // 
            // PnlLogin
            // 
            this.PnlLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PnlLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlLogin.BackgroundImage")));
            this.PnlLogin.Controls.Add(this.TxbEmailLogin);
            this.PnlLogin.Controls.Add(this.LblLogin1);
            this.PnlLogin.Controls.Add(this.LbkEmailLogin);
            this.PnlLogin.Controls.Add(this.TxbSenhaLogin);
            this.PnlLogin.Controls.Add(this.LblSenhaLogin);
            this.PnlLogin.Controls.Add(this.BtnEntrarLogin);
            this.PnlLogin.Location = new System.Drawing.Point(525, 264);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(663, 498);
            this.PnlLogin.TabIndex = 8;
            // 
            // TxbSenhaLogin
            // 
            this.TxbSenhaLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxbSenhaLogin.Location = new System.Drawing.Point(106, 262);
            this.TxbSenhaLogin.Name = "TxbSenhaLogin";
            this.TxbSenhaLogin.Size = new System.Drawing.Size(388, 22);
            this.TxbSenhaLogin.TabIndex = 8;
            // 
            // TxbEmailLogin
            // 
            this.TxbEmailLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxbEmailLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxbEmailLogin.Location = new System.Drawing.Point(106, 179);
            this.TxbEmailLogin.Name = "TxbEmailLogin";
            this.TxbEmailLogin.Size = new System.Drawing.Size(388, 22);
            this.TxbEmailLogin.TabIndex = 9;
            this.TxbEmailLogin.TextChanged += new System.EventHandler(this.TxbEmailLogin_TextChanged);
            // 
            // LblEnjoyLogin
            // 
            this.LblEnjoyLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblEnjoyLogin.AutoSize = true;
            this.LblEnjoyLogin.BackColor = System.Drawing.Color.Transparent;
            this.LblEnjoyLogin.Font = new System.Drawing.Font("Castellar", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnjoyLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblEnjoyLogin.Location = new System.Drawing.Point(659, 194);
            this.LblEnjoyLogin.Name = "LblEnjoyLogin";
            this.LblEnjoyLogin.Size = new System.Drawing.Size(345, 44);
            this.LblEnjoyLogin.TabIndex = 9;
            this.LblEnjoyLogin.Text = "Enjoy louças";
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1651, 864);
            this.Controls.Add(this.LblEnjoyLogin);
            this.Controls.Add(this.PnlLogin);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TelaLogin";
            this.Text = "Login Enjoy Louças";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.PnlLogin.ResumeLayout(false);
            this.PnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEntrarLogin;
        private System.Windows.Forms.Label LblLogin1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbkEmailLogin;
        private System.Windows.Forms.Label LblSenhaLogin;
        private System.Windows.Forms.Panel PnlLogin;
        private System.Windows.Forms.TextBox TxbSenhaLogin;
        private System.Windows.Forms.TextBox TxbEmailLogin;
        private System.Windows.Forms.Label LblEnjoyLogin;
    }
}