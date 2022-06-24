
namespace ProjetoCadastro
{
    partial class frmPesquisarFornecedor
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarFornecedor));
            this.labelPesquisar = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.bdCadastroDataSet = new ProjetoCadastro.bdCadastroDataSet();
            this.tbFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFornecedorTableAdapter = new ProjetoCadastro.bdCadastroDataSetTableAdapters.tbFornecedorTableAdapter();
            this.tbFornecedorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFornecedorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPesquisar
            // 
            this.labelPesquisar.AutoSize = true;
            this.labelPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisar.Location = new System.Drawing.Point(106, 66);
            this.labelPesquisar.Name = "labelPesquisar";
            this.labelPesquisar.Size = new System.Drawing.Size(64, 25);
            this.labelPesquisar.TabIndex = 2;
            this.labelPesquisar.Text = "Nome";
            this.labelPesquisar.Click += new System.EventHandler(this.labelPesquisar_Click);
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(191, 66);
            this.textNome.MaxLength = 50;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(387, 30);
            this.textNome.TabIndex = 3;
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(596, 66);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(109, 35);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(352, 413);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(87, 35);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // bdCadastroDataSet
            // 
            this.bdCadastroDataSet.DataSetName = "bdCadastroDataSet";
            this.bdCadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFornecedorBindingSource
            // 
            this.tbFornecedorBindingSource.DataMember = "tbFornecedor";
            this.tbFornecedorBindingSource.DataSource = this.bdCadastroDataSet;
            // 
            // tbFornecedorTableAdapter
            // 
            this.tbFornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tbFornecedorDataGridView
            // 
            this.tbFornecedorDataGridView.AutoGenerateColumns = false;
            this.tbFornecedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbFornecedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tbFornecedorDataGridView.DataSource = this.tbFornecedorBindingSource;
            this.tbFornecedorDataGridView.Location = new System.Drawing.Point(152, 129);
            this.tbFornecedorDataGridView.Name = "tbFornecedorDataGridView";
            this.tbFornecedorDataGridView.Size = new System.Drawing.Size(544, 258);
            this.tbFornecedorDataGridView.TabIndex = 6;
            this.tbFornecedorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbFornecedorDataGridView_CellContentClick);
            this.tbFornecedorDataGridView.DoubleClick += new System.EventHandler(this.tbFornecedorDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_fornecedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nm_fornecedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fornecedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 390;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmPesquisarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 453);
            this.Controls.Add(this.tbFornecedorDataGridView);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.labelPesquisar);
            this.Name = "frmPesquisarFornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFornecedorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPesquisar;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private bdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tbFornecedorBindingSource;
        private bdCadastroDataSetTableAdapters.tbFornecedorTableAdapter tbFornecedorTableAdapter;
        private System.Windows.Forms.DataGridView tbFornecedorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
