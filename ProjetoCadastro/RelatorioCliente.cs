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
    public partial class RelatorioCliente : Form
    {
        public RelatorioCliente()
        {
            InitializeComponent();
        }

        private void RelatorioCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.bdCadastroDataSet.tbCliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
