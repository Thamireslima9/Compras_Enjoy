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
            MessageBox.Show(
                "Nome: " + TxbNameCadas.Text + 
                "\nEmail: " + TxbEmailCadas.Text + 
                "\nDia: " + CbxDiaNasci.Text + 
                "\nMês: " + CbxMês.Text +
                "\nAno: " + TxbAnoNasc.Text);
        }

        private void LblEmailCadastro_Click(object sender, EventArgs e)
        {

        }

        private void lblSenhaCadastro_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 telainicial = new Form1();

            telainicial.ShowDialog();
        }

        private void BttEnter_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Nome: " + TxbEmailLogin.Text +
               "\nEmail: " + TxbSenhaLogin);
               
        }

        private void TxbSenhaLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
