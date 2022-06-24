
using System;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    partial class FormPesquisaProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bdCadastroDataSet = new ProjetoCadastro.bdCadastroDataSet();
            this.tbProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProdutoTableAdapter = new ProjetoCadastro.bdCadastroDataSetTableAdapters.tbProdutoTableAdapter();
            this.tbProdutoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new ProjetoCadastro.bdCadastroDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bdCadastroDataSet
            // 
            this.bdCadastroDataSet.DataSetName = "bdCadastroDataSet";
            this.bdCadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProdutoBindingSource
            // 
            this.tbProdutoBindingSource.DataMember = "tbProduto";
            this.tbProdutoBindingSource.DataSource = this.bdCadastroDataSet;
            // 
            // tbProdutoTableAdapter
            // 
            this.tbProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tbProdutoDataGridView
            // 
            this.tbProdutoDataGridView.AutoGenerateColumns = false;
            this.tbProdutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbProdutoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tbProdutoDataGridView.DataSource = this.tbProdutoBindingSource;
            this.tbProdutoDataGridView.Location = new System.Drawing.Point(63, 119);
            this.tbProdutoDataGridView.Name = "tbProdutoDataGridView";
            this.tbProdutoDataGridView.Size = new System.Drawing.Size(657, 251);
            this.tbProdutoDataGridView.TabIndex = 1;
            this.tbProdutoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbProdutoDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_produto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nm_produto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(611, 67);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(109, 35);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(365, 393);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 35);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(58, 67);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(164, 25);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome do Produto";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(228, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 30);
            this.textBox1.TabIndex = 5;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbFornecedorTableAdapter = null;
            this.tableAdapterManager.tbProdutoTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoCadastro.bdCadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormPesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.tbProdutoDataGridView);
            this.Name = "FormPesquisaProduto";
            this.Text = "FormPesquisaProduto";
            this.Load += new System.EventHandler(this.FormPesquisaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tbProdutoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private bdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tbProdutoBindingSource;
        private bdCadastroDataSetTableAdapters.tbProdutoTableAdapter tbProdutoTableAdapter;
        private System.Windows.Forms.DataGridView tbProdutoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBox1;
        private bdCadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}