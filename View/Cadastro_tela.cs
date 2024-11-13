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
                " Mês: " + CbxMês.Text +
                " Ano: " + TxbAnoNasc.Text +
                "\nCódigo (acesso):" + TxbCodAcesso.Text +
                "\nCPF:" + TxbCPF.Text +
                "\nRG:" + TxbRG.Text +
                "\nTelefone:" + TxbTelefone.Text +
                "\nGênero:" + CbxGenero.Text );
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

            this.Visible = false;
            telainicial.ShowDialog();
        }

        private void BttEnter_Click(object sender, EventArgs e)
        {
            
        }

        private void TxbSenhaLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblCpf_Click(object sender, EventArgs e)
        {

        }

        private void TxbCodAcesso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxbCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxbRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxbAnoNasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxbTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void BtnCadasFun_Click(object sender, EventArgs e)
        {

        }

        private void BtnCaadasLouca_Click(object sender, EventArgs e)
        {
            Compra_Tela telaCadastroCompra = new Compra_Tela();

            this.Visible = false;

            telaCadastroCompra.ShowDialog();
        }

        private void BtnTelaIni_Click(object sender, EventArgs e)
        {
            Form1 telainicial = new Form1();

            this.Visible = false;

            telainicial.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void PnlCadastro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblTitleRegistratio_Click(object sender, EventArgs e)
        {

        }
    }
}
