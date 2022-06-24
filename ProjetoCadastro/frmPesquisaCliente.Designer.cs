
namespace ProjetoCadastro
{
    partial class frmPesquisaCliente
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
            this.btnSair = new System.Windows.Forms.Button();
            this.bntPesquiasr = new System.Windows.Forms.Button();
            this.LabelNome = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.bdCadastroDataSet = new ProjetoCadastro.bdCadastroDataSet();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClienteTableAdapter = new ProjetoCadastro.bdCadastroDataSetTableAdapters.tbClienteTableAdapter();
            this.tableAdapterManager = new ProjetoCadastro.bdCadastroDataSetTableAdapters.TableAdapterManager();
            this.tbClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(368, 383);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(87, 35);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // bntPesquiasr
            // 
            this.bntPesquiasr.AutoSize = true;
            this.bntPesquiasr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPesquiasr.Location = new System.Drawing.Point(589, 73);
            this.bntPesquiasr.Name = "bntPesquiasr";
            this.bntPesquiasr.Size = new System.Drawing.Size(109, 35);
            this.bntPesquiasr.TabIndex = 1;
            this.bntPesquiasr.Text = "Pesquisar";
            this.bntPesquiasr.UseVisualStyleBackColor = true;
            this.bntPesquiasr.Click += new System.EventHandler(this.bntPesquiasr_Click);
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNome.Location = new System.Drawing.Point(89, 73);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(64, 25);
            this.LabelNome.TabIndex = 2;
            this.LabelNome.Text = "Nome";
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(159, 73);
            this.textNome.MaxLength = 50;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(424, 30);
            this.textNome.TabIndex = 3;
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // bdCadastroDataSet
            // 
            this.bdCadastroDataSet.DataSetName = "bdCadastroDataSet";
            this.bdCadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "tbCliente";
            this.tbClienteBindingSource.DataSource = this.bdCadastroDataSet;
            // 
            // tbClienteTableAdapter
            // 
            this.tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = this.tbClienteTableAdapter;
            this.tableAdapterManager.tbFornecedorTableAdapter = null;
            this.tableAdapterManager.tbProdutoTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoCadastro.bdCadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbClienteDataGridView
            // 
            this.tbClienteDataGridView.AutoGenerateColumns = false;
            this.tbClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tbClienteDataGridView.DataSource = this.tbClienteBindingSource;
            this.tbClienteDataGridView.Location = new System.Drawing.Point(94, 133);
            this.tbClienteDataGridView.Name = "tbClienteDataGridView";
            this.tbClienteDataGridView.Size = new System.Drawing.Size(604, 221);
            this.tbClienteDataGridView.TabIndex = 5;
            this.tbClienteDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbClienteDataGridView_CellContentClick);
            this.tbClienteDataGridView.DoubleClick += new System.EventHandler(this.tbClienteDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_cliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nm_cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 450;
            // 
            // frmPesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbClienteDataGridView);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.LabelNome);
            this.Controls.Add(this.bntPesquiasr);
            this.Controls.Add(this.btnSair);
            this.Name = "frmPesquisaCliente";
            this.Text = "frmPesquisaCliente";
            this.Load += new System.EventHandler(this.frmPesquisaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button bntPesquiasr;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.TextBox textNome;
        private bdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private bdCadastroDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private bdCadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbClienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}