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
    public partial class Cadastro_tela : Form
    {
        public Cadastro_tela()
        {
            InitializeComponent();
        }

        private void Cadastro_tela_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNameCadastro_Click(object sender, EventArgs e)
        {

        }

        private void LblOR_Click(object sender, EventArgs e)
        {

        }

        private void BttEnviarCadastro_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxbNameCadas.Text + "\n" + TxbEmailCadas + "\n" + TxbSenhaCadas + "\n" + TxbConfSenha);
        }
    }
}
