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
    public partial class FormPesquisaProduto : Form
    {
        private int Codigo;


        public FormPesquisaProduto()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {

            return Codigo;
        }


        private void tbProdutoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbProdutoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdCadastroDataSet);

        }

        private void FormPesquisaProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutoTableAdapter.Fill(this.bdCadastroDataSet.tbProduto);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntPesquiasr_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                this.tbProdutoTableAdapter.Fill(this.bdCadastroDataSet.tbProduto);
            }

            else
            {
                this.tbProdutoTableAdapter.FillByProduto(this.bdCadastroDataSet.tbCliente, "%" + textBox1.Text + "%");
            }


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TbProdutoeDataGridView_CellcontentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbProdutoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            Codigo = Convert.ToInt32(tbProdutoDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }
    }
}
