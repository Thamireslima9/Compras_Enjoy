﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalveImage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NudUniProd2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PtBxCeramicaDoceira_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido realizado!");
        }

        private void BtnCadasFun_Click(object sender, EventArgs e)
        {
            Cadastro_tela telaCadastroFun = new Cadastro_tela();

            this.Visible = false;

            telaCadastroFun.ShowDialog();
        }

        private void BtnCaadasLouca_Click(object sender, EventArgs e)
        {
            Compra_Tela telaCadastroCompra = new Compra_Tela();

            this.Visible = false;

            telaCadastroCompra.ShowDialog();
        }

        private void BtnTelaIni_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LblCodCopoCristal_Click(object sender, EventArgs e)
        {

        }
    }
}
