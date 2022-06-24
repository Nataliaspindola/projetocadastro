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
    public partial class frmPesquisarFornecedor : Form
    {
        private int codigo;
        public frmPesquisarFornecedor()
        {
            InitializeComponent();
        }

        public int getcodigo()
        {
            return codigo;
        }

        private void frmPesquisarFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFornecedorTableAdapter.Fill(this.bdCadastroDataSet.tbFornecedor);

        }
            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void tbFornecedorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {
            this.tbFornecedorTableAdapter.Fill(this.bdCadastroDataSet.tbFornecedor);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (textNome.Text == "")
            {
                this.tbFornecedorTableAdapter.Fill(this.bdCadastroDataSet.tbFornecedor);
            }
            else
            {
                this.tbFornecedorTableAdapter.FillByFornecedor(this.bdCadastroDataSet.tbFornecedor, "%"+ textNome.Text+"%");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Close()
        {
            throw new NotImplementedException();
        }

        private void tbFornecedorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tbFornecedorDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }
    }
}
