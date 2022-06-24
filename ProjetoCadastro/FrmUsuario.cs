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
    public partial class FrmUsuario : Form
    {
        public void Habilita()
        {
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = true;
            sg_nivelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            cd_senhaTextBox.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnpesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }

        public void Desabilita()
        {
            cd_usuarioTextBox.Enabled = true;
            nm_usuarioTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            cd_senhaTextBox.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnpesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdCadastroDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.bdCadastroDataSet.tbUsuario);

        }

        private void cd_usuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void cd_usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_usuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void nm_usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sg_nivelLabel_Click(object sender, EventArgs e)
        {

        }

        private void sg_nivelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void nm_loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cd_senhaLabel_Click(object sender, EventArgs e)
        {

        }

        private void cd_senhaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {   
      
            tbUsuarioBindingSource.MovePrevious();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbUsuarioBindingSource.Count > 0)
            {
                Habilita();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.RemoveCurrent();
            tbUsuarioTableAdapter.Update(bdCadastroDataSet.tbUsuario);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.EndEdit();
            Validate();
            tbUsuarioTableAdapter.Update(bdCadastroDataSet.tbUsuario);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.CancelEdit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmPesquisaUsuario fpu = new frmPesquisaUsuario();
            fpu.ShowDialog();
            int cod = fpu.Codigo;
            if (cod > 0)
            {
                int reg = tbUsuarioBindingSource.Find("cd_usuario", cod);
                tbUsuarioBindingSource.Position = reg;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE USUARIO" + (char)10 + (char)10;
            strDados=strDados+ "Codigo:" + cd_usuarioTextBox + (char)10 + (char)10;
            strDados = strDados + "Nome:" + nm_usuarioTextBox + (char)10 + (char)10;
            strDados = strDados + "Nivel:" + sg_nivelTextBox + (char)10 + (char)10;
            strDados = strDados + "Login:" + nm_loginTextBox;

            objImpressao.DrawString(strDados, new Font("Arial", 12,FontStyle.Bold),Brushes.Black, 50,50);


        }
    }
}
