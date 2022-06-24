using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class FormProduto : Form
    {

        public void Habilita()
        {
            cd_produtoTextBox.Enabled = false;
            nm_produtoTextBox.Enabled = true;
            sg_unidadeTextBox.Enabled = true;
            vl_custoTextBox.Enabled = true;
            vl_vendaTextBox.Enabled = true;
            qt_estoqueTextBox.Enabled = true;

            button2.Enabled = true;
            button1.Enabled = true;
            button7.Enabled = false;
            button6.Enabled = false;
            button5.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = false;
            button8.Enabled = false;
            bnt_imprimir.Enabled = false;
            button10.Enabled = false;
        }

        public void Desabilita()
        {
            cd_produtoTextBox.Enabled = true;
            nm_produtoTextBox.Enabled = false;
            sg_unidadeTextBox.Enabled = false;
            vl_custoTextBox.Enabled = false;
            vl_vendaTextBox.Enabled = false;
            qt_estoqueTextBox.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            button7.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = true;
            button4.Enabled = true;
            button3.Enabled = true;
            button8.Enabled = true;
            bnt_imprimir.Enabled = true;
            button10.Enabled = true;
        }

        public FormProduto()
        {
            InitializeComponent();
        }

        private void tbProdutoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutoTableAdapter.Fill(this.bdCadastroDataSet.tbProduto);
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutoTableAdapter.Fill(this.bdCadastroDataSet.tbProduto);

        }

        private void cd_produtoLabel_Click(object sender, EventArgs e)
        {

        }

        private void cd_produtoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_produtoLabel_Click(object sender, EventArgs e)
        {

        }

        private void nm_produtoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sg_unidadeLabel_Click(object sender, EventArgs e)
        {

        }

        private void sg_unidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vl_custoLabel_Click(object sender, EventArgs e)
        {

        }

        private void vl_custoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vl_vendaLabel_Click(object sender, EventArgs e)
        {

        }

        private void vl_vendaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void qt_estoqueLabel_Click(object sender, EventArgs e)
        {

        }

        private void qt_estoqueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            tbProdutoBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbProdutoBindingSource.Count > 0)
            {
                Habilita();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.RemoveCurrent();
            tbProdutoTableAdapter.Update(bdCadastroDataSet.tbProduto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.EndEdit();
            Validate();
            tbProdutoTableAdapter.Update(bdCadastroDataSet.tbProduto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbProdutoBindingSource.CancelEdit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int cod, reg;
            FormPesquisaProduto fpu = new FormPesquisaProduto();
            fpu.ShowDialog();
            cod = fpu.getCodigo();




            if (cod > 0)
            {
                reg = tbProdutoBindingSource.Find("cd_Produto", cod);
                tbProdutoBindingSource.Position = reg;
                tbProdutoBindingSource.Position = reg;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE PRODUTO" + (char)10 + (char)10;
            strDados = strDados + "Codigo:" + cd_produtoTextBox + (char)10 + (char)10;
            strDados = strDados + "Nome:" + nm_produtoTextBox + (char)10 + (char)10;
            strDados = strDados + "Endereço:" + sg_unidadeTextBox + (char)10 + (char)10;
            strDados = strDados + "bairro:" + vl_custoTextBox + (char)10 + (char)10;
            strDados = strDados + "Cidade:" + vl_vendaTextBox + (char)10 + (char)10;
            strDados = strDados + "Estado:" + qt_estoqueTextBox;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);

        }


        private void bnt_imprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }



        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


    }
