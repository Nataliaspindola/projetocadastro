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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void saiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario fu = new FrmUsuario();
            fu.ShowDialog();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioUsuario fu = new RelatorioUsuario();
            fu.ShowDialog();

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           RelatorioCliente fu = new RelatorioCliente();
            fu.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RelatorioFornecedorcs fu = new RelatorioFornecedorcs();
            fu.ShowDialog();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RelatorioProduto fu = new RelatorioProduto();
            fu.ShowDialog();
        }
    }
}
