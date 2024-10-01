using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compras_Enjoy
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void LblLogin1_Click(object sender, EventArgs e)
        {

        }

        private void BtnEntrarLogin_Click(object sender, EventArgs e)

        {
            MessageBox.Show("Entrada com sucessso!");
            
            
            Form1 telaPrincipal = new Form1();

            this.Visible = false;

            telaPrincipal.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbEmailLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
