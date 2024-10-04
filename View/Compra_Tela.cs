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
    public partial class Compra_Tela : Form
    {
        public Compra_Tela()
        {
            InitializeComponent();
        }

        private void Compra_tela_Load(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PnlLayout1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblNomeLouçaNova_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecione uma imagem." );
        }

        private void PnlLayout1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblNomeEnjoy_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Nome:" + TxbNomeLoucaN.Text + 
                "\nCódigo:" + TxbCodLouca.Text +
                "\nTipo:" + CbxTipoLouca.Text +
                "\nMarca:" + TxbMarcaLouca.Text +
                "\nPreço:" + TxbPrecoLouca.Text +                
                "\nLiberar venda:" + CbxLiberarVenda.Text +
                "\nLoja virtual:" + CbxLojaVitual.Text +
                "\nEstoque disponivel:" + NudEstoqueProd.Text +
                "\n" +
                "\nProduto inserido com sucesso!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 telaForm1 = new Form1();

            this.Visible = false;

            telaForm1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cadastro_tela telaCadastro = new Cadastro_tela();

            this.Visible = false;

            telaCadastro.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
