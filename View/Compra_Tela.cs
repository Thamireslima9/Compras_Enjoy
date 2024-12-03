using Compras_Enjoy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Compras_Enjoy
{
    public partial class Compra_Tela : Form
    {
        private int code = -1;
        public Compra_Tela()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            TxbNomeLouca.Clear();
            TxbCodLouca.Clear();
            TxbMarcaLouca.Clear();
            TxbPrecoLouca.Clear();
            TxbDescLouca.Clear();
        }

        private void UpdateListView()
        {
            LtvLouca.Items.Clear();

            LoucaDAO loucaDAO = new LoucaDAO();
            List<Louca> loucas = loucaDAO.ListarTodasLoucas();

            //This code part access all brokers received from database and iterate by them.
            foreach (Louca louca in loucas)
            {
                //Creating a fully line of listview with items from database.
                ListViewItem item = new ListViewItem(louca.NomeLouca);
                item.SubItems.Add(louca.CodLouca.ToString());
                item.SubItems.Add(louca.Tipolouca);
                item.SubItems.Add(louca.DescricaoLouca);
                item.SubItems.Add(louca.Marca);     
                item.SubItems.Add(louca.Preco.ToString());
                item.SubItems.Add(louca.Estoque.ToString());
                
                //Adding the fully line to the listview.
                LtvLouca.Items.Add(item);
            }
        }
      
        private void Compra_tela_Load(object sender, EventArgs e)
        {
            UpdateListView();
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

        private void lblNomeEnjoy_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

                    float Preco = float.Parse(TxbPrecoLouca.Text);
                    string Tipo = CbxTipoLouca.Text;
                    string Nome = TxbNomeLouca.Text;
                    string Descricao = TxbDescLouca.Text;
                    string Marca = TxbMarcaLouca.Text;
                    int Estoque = int.Parse(NudEstoqueProd.Text);

           

                    //Cria objeto do tipo da entidade manipulada.
                    Louca louca = new Louca(Nome, Tipo, Descricao, Preco, Estoque, Marca);

                    //Cria objeto para interação com o banco de dados.
                    LoucaDAO loucaDAO = new LoucaDAO();

                    //Chama o insert
                    loucaDAO.Insert(louca);


                    MessageBox.Show(
                        "Nome:" + TxbNomeLouca.Text +
                        "\nCódigo:" + TxbCodLouca.Text +
                        "\nTipo:" + CbxTipoLouca.Text +
                        "\nMarca:" + TxbMarcaLouca.Text +
                        "\nPreço:" + TxbPrecoLouca.Text +
                        "\nLiberar venda:" + CbxLiberarVenda.Text +
                        "\nLoja virtual:" + CbxLojaVitual.Text +
                        "\nEstoque disponivel:" + NudEstoqueProd.Text +
                        "\n" +
                        "\nProduto inserido com sucesso!");

            UpdateListView();
            ClearFields();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
          
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
 
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LtvLouca_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = LtvLouca.FocusedItem.Index;              
                TxbNomeLouca.Text = LtvLouca.Items[index].SubItems[0].Text;
                TxbCodLouca.Text = LtvLouca.Items[index].SubItems[1].Text;
                CbxTipoLouca.Text = LtvLouca.Items[index].SubItems[2].Text;
                TxbDescLouca.Text = LtvLouca.Items[index].SubItems[3].Text;
                TxbPrecoLouca.Text = LtvLouca.Items[index].SubItems[5].Text;
                NudEstoqueProd.Text = LtvLouca.Items[index].SubItems[6].Text;
                TxbMarcaLouca.Text = LtvLouca.Items[index].SubItems[4].Text;
            }

            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            LoucaDAO loucaDao = new LoucaDAO();


            DialogResult resultado = MessageBox.Show("Tem certeza" +
            " que deseja excluir?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    loucaDao.Excluir(int.Parse(TxbCodLouca.Text));
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            
            
                try
                {
                    //Capture inputed text from fields.
                    new LoucaDAO().Atualizar(new Louca(
                    int.Parse(TxbCodLouca.Text),
                     TxbNomeLouca.Text,
                     CbxTipoLouca.Text,
                     TxbDescLouca.Text,
                     float.Parse(TxbPrecoLouca.Text),
                     int.Parse(NudEstoqueProd.Text),
                     TxbMarcaLouca.Text));
                    MessageBox.Show("Louca atualizada!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();

        }

   
        private void LtvLouca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PnlVendaLoucas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
