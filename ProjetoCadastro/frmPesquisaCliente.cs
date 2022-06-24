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
    public partial class frmPesquisaCliente : Form
    {
        private int Codigo;


        public frmPesquisaCliente()
        {
            InitializeComponent();
        }



        public int getCodigo()
        {

            return Codigo;
        }


        private void tbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdCadastroDataSet);

        }

        private void frmPesquisaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.bdCadastroDataSet.tbCliente);

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntPesquiasr_Click(object sender, EventArgs e)
        {

            if (textNome.Text == "")
            {
                this.tbClienteTableAdapter.Fill(this.bdCadastroDataSet.tbCliente);
            }

            else
            {
                this.tbClienteTableAdapter.FillByCliente(this.bdCadastroDataSet.tbCliente, "%"+textNome.Text+"%");
            }


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbClienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbClienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            Codigo = Convert.ToInt32(tbClienteDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }
    }
}
