using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class frmFornecedor : Form
    {
        private object printPreviewDialog1;

        public void Habilita()
        {
            cd_FornecedorTexBox.Enabled = false;
            nm_FornecedorTexBox.Enabled = true;
            endereco_FornecedorTexBox.Enabled = true;
            Bairro_FornecedorTexBox.Enabled = true;
            Cidade_FornecedorTexBox.Enabled = true;
            Estado_FornecedorTexBox.Enabled = true;
            Cep_FornecedorTextBox.Enabled = true;
            Cnpj_FornecedorTxBox.Enabled = true;

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
            cd_FornecedorTexBox.Enabled = true;
            nm_FornecedorTexBox.Enabled = false;
            endereco_FornecedorTexBox.Enabled = false;
            Bairro_FornecedorTexBox.Enabled = false;
            Cidade_FornecedorTexBox.Enabled = false;
            Estado_FornecedorTexBox.Enabled = false;
            Cep_FornecedorTextBox.Enabled = false;
            Cnpj_FornecedorTxBox.Enabled = false;

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



        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void tbFornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet1.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFornecedorTableAdapter.Fill(this.bdCadastroDataSet1.tbFornecedor);
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFornecedorTableAdapter.Fill(this.bdCadastroDataSet1.tbFornecedor);

        }

        private void cd_fornecedorLabel_Click(object sender, EventArgs e)
        {

        }

        private void cd_fornecedorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_fornecedorLabel_Click(object sender, EventArgs e)
        {

        }

        private void nm_fornecedorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ds_enderecoLabel_Click(object sender, EventArgs e)
        {

        }

        private void ds_enderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_bairroLabel_Click(object sender, EventArgs e)
        {

        }

        private void nm_bairroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_cidadeLabel_Click(object sender, EventArgs e)
        {

        }

        private void nm_cidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sg_estadoLabel_Click(object sender, EventArgs e)
        {

        }

        private void sg_estadoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cd_cepLabel_Click(object sender, EventArgs e)
        {

        }

        private void cd_cepTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cd_cnpjLabel_Click(object sender, EventArgs e)
        {

        }

        private void cd_cnpjTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cd_inserestLabel_Click(object sender, EventArgs e)
        {

        }

        private void cd_inserestTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.RemoveCurrent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.CancelEdit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.MoveNext();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.AddNew();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            tbFornecedorBindingSource.EndEdit();
            Validate();
            tbFornecedorTableAdapter.Update(bdCadastroDataSet1.tbFornecedor);
          
        }

        private void cd_usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cd_NomeTexBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cd_FornecedorTexBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_FornecedorTexBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cnpj_FornecedorTxBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCnpj_Click(object sender, EventArgs e)
        {

        }

        private void Bairro_FornecedorTexBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisarFornecedor fpu = new frmPesquisarFornecedor();
            fpu.ShowDialog();
            cod = fpu.getcodigo();


            if (cod > 0)
            {
                reg = tbFornecedorBindingSource.Find("cd_FornecedorTexBox", cod);
                tbFornecedorBindingSource.Position = reg;
                tbFornecedorBindingSource.Position = reg;
            }
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE PRODUTO" + (char)10 + (char)10;
            strDados = strDados + "Codigo:" + cd_FornecedorTexBox + (char)10 + (char)10;
            strDados = strDados + "Nome:" + nm_FornecedorTexBox + (char)10 + (char)10;
            strDados = strDados + "Endereço:" + endereco_FornecedorTexBox + (char)10 + (char)10;
            strDados = strDados + "bairro:" + Bairro_FornecedorTexBox + (char)10 + (char)10;
            strDados = strDados + "Cidade:" + Cidade_FornecedorTexBox + (char)10 + (char)10;
            strDados = strDados + "Estado:" + Estado_FornecedorTexBox + (char)10 + (char)10;
            strDados = strDados + "CEP:" + Cep_FornecedorTextBox + (char)10 + (char)10;
            strDados = strDados + "Cnpj:" + Cnpj_FornecedorTxBox;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);

        }
        private void bnt_imprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog2.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog2_Load(object sender, EventArgs e)
        {

        }

        private void tbFornecedorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
        }
    }
}
