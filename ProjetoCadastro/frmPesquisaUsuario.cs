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
    public partial class frmPesquisaUsuario : Form

    {
        private int codigo = 0;
        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void frmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.bdCadastroDataSet.tbUsuario);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbUsuarioTableAdapter.Fill(this.bdCadastroDataSet.tbUsuario);
            }

            else
            {
                this.tbUsuarioTableAdapter.FillByNome(this.bdCadastroDataSet.tbUsuario, "%" + txtNome.Text + "%");
            }
        }

        public int Codigo
        {
            get { return codigo; }
        }

       private void tbUsuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = int.Parse(tbUsuarioDataGridView.Rows[tbUsuarioBindingSource.Position].Cells[0].Value.ToString());
        }

        private void tbUsuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
