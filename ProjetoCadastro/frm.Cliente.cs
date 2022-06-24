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


    public partial class frm : Form
    {

        public void Habilita()
        {
            cd_ClienteTexBox.Enabled = false;
            Cd_NomeTexBox.Enabled = true;
            endereco_clienteTexBox.Enabled = true;
            Bairro_ClienteTexBox.Enabled = true;
            Cidade_ClienteTexBox.Enabled = true;
            Estado_ClienteTexBox.Enabled = true;
            Cep_ClienteTextBox.Enabled = true;
            Rg_ClienteTexBox.Enabled = true;
            Cpf_ClienteTxBox.Enabled = true;

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
            cd_ClienteTexBox.Enabled = true;
            Cd_NomeTexBox.Enabled = false;
            endereco_clienteTexBox.Enabled = false;
            Bairro_ClienteTexBox.Enabled = false;
            Cidade_ClienteTexBox.Enabled = false;
            Estado_ClienteTexBox.Enabled = false;
            Cep_ClienteTextBox.Enabled = false;
            Rg_ClienteTexBox.Enabled = false;
            Cpf_ClienteTxBox.Enabled = false;

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
        public frm()
        {
            InitializeComponent();
        }

        private void tbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.bdCadastroDataSet.tbCliente);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cd_usuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void nm_usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.AddNew();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ( tbClienteBindingSource.Count > 0)
            {
                Habilita();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.RemoveCurrent();
            tbClienteTableAdapter.Update(bdCadastroDataSet.tbCliente);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.EndEdit();
            Validate();
            tbClienteTableAdapter.Update(bdCadastroDataSet.tbCliente);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.CancelEdit();
        }

        private void cd_usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cd_Cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void endereco_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bairro_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cidade_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cep_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpf_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void rg_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisaCliente fpu = new frmPesquisaCliente();
            fpu.ShowDialog();
            cod = fpu.getCodigo();


            if (cod > 0)
            {
               reg = tbClienteBindingSource.Find("cd_cliente", cod);
               tbClienteBindingSource.Position = reg;
                tbClienteBindingSource.Position = reg;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
                string strDados;
                Graphics objImpressao = e.Graphics;

                strDados = "FICHA DE CLIENTE" + (char)10 + (char)10;
                strDados = strDados + "Codigo:" + cd_ClienteTexBox + (char)10 + (char)10;
                strDados = strDados + "Nome:" + Cd_NomeTexBox + (char)10 + (char)10;
                strDados = strDados + "Endereço:" + endereco_clienteTexBox + (char)10 + (char)10;
                strDados = strDados + "bairro:" + Bairro_ClienteTexBox + (char)10 + (char)10;
                strDados = strDados + "Cidade:" + Cidade_ClienteTexBox + (char)10 + (char)10;
                strDados = strDados + "Estado:" + Estado_ClienteTexBox + (char)10 + (char)10;
                strDados = strDados + "CEP:" + Cep_ClienteTextBox + (char)10 + (char)10;
                strDados = strDados + "RG:" + Rg_ClienteTexBox + (char)10 + (char)10;
                strDados = strDados + "cpf:" + Cpf_ClienteTxBox;

                objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);

        }
             private void bnt_imprimir_Click(object sender, EventArgs e)
            {
                printPreviewDialog1.ShowDialog();
            }



    }
}



