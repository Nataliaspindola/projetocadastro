
namespace ProjetoCadastro
{
    partial class frmFornecedor
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
            System.Windows.Forms.Label cd_fornecedorLabel;
            System.Windows.Forms.Label nm_fornecedorLabel;
            System.Windows.Forms.Label ds_enderecoLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label cd_cnpjLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedor));
            this.bnt_imprimir = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bdCadastroDataSet1 = new ProjetoCadastro.bdCadastroDataSet();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.tbFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFornecedorTableAdapter = new ProjetoCadastro.bdCadastroDataSetTableAdapters.tbFornecedorTableAdapter();
            this.cd_FornecedorTexBox = new System.Windows.Forms.TextBox();
            this.nm_FornecedorTexBox = new System.Windows.Forms.TextBox();
            this.endereco_FornecedorTexBox = new System.Windows.Forms.TextBox();
            this.Bairro_FornecedorTexBox = new System.Windows.Forms.TextBox();
            this.Cidade_FornecedorTexBox = new System.Windows.Forms.TextBox();
            this.Estado_FornecedorTexBox = new System.Windows.Forms.TextBox();
            this.Cep_FornecedorTextBox = new System.Windows.Forms.TextBox();
            this.Cnpj_FornecedorTxBox = new System.Windows.Forms.TextBox();
            cd_fornecedorLabel = new System.Windows.Forms.Label();
            nm_fornecedorLabel = new System.Windows.Forms.Label();
            ds_enderecoLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            cd_cnpjLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_fornecedorLabel
            // 
            cd_fornecedorLabel.AutoSize = true;
            cd_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_fornecedorLabel.Location = new System.Drawing.Point(123, 51);
            cd_fornecedorLabel.Name = "cd_fornecedorLabel";
            cd_fornecedorLabel.Size = new System.Drawing.Size(75, 25);
            cd_fornecedorLabel.TabIndex = 112;
            cd_fornecedorLabel.Text = "Codigo";
            // 
            // nm_fornecedorLabel
            // 
            nm_fornecedorLabel.AutoSize = true;
            nm_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_fornecedorLabel.Location = new System.Drawing.Point(123, 87);
            nm_fornecedorLabel.Name = "nm_fornecedorLabel";
            nm_fornecedorLabel.Size = new System.Drawing.Size(64, 25);
            nm_fornecedorLabel.TabIndex = 114;
            nm_fornecedorLabel.Text = "Nome";
            // 
            // ds_enderecoLabel
            // 
            ds_enderecoLabel.AutoSize = true;
            ds_enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_enderecoLabel.Location = new System.Drawing.Point(123, 123);
            ds_enderecoLabel.Name = "ds_enderecoLabel";
            ds_enderecoLabel.Size = new System.Drawing.Size(96, 25);
            ds_enderecoLabel.TabIndex = 116;
            ds_enderecoLabel.Text = "Endereço";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_bairroLabel.Location = new System.Drawing.Point(123, 159);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(63, 25);
            nm_bairroLabel.TabIndex = 118;
            nm_bairroLabel.Text = "Bairro";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_cidadeLabel.Location = new System.Drawing.Point(123, 195);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(75, 25);
            nm_cidadeLabel.TabIndex = 120;
            nm_cidadeLabel.Text = "Cidade";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_estadoLabel.Location = new System.Drawing.Point(123, 231);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(73, 25);
            sg_estadoLabel.TabIndex = 122;
            sg_estadoLabel.Text = "Estado";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cepLabel.Location = new System.Drawing.Point(123, 267);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(49, 25);
            cd_cepLabel.TabIndex = 124;
            cd_cepLabel.Text = "Cep";
            // 
            // cd_cnpjLabel
            // 
            cd_cnpjLabel.AutoSize = true;
            cd_cnpjLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cnpjLabel.Location = new System.Drawing.Point(122, 306);
            cd_cnpjLabel.Name = "cd_cnpjLabel";
            cd_cnpjLabel.Size = new System.Drawing.Size(65, 25);
            cd_cnpjLabel.TabIndex = 126;
            cd_cnpjLabel.Text = "CNPJ";
            // 
            // bnt_imprimir
            // 
            this.bnt_imprimir.AutoSize = true;
            this.bnt_imprimir.Location = new System.Drawing.Point(493, 400);
            this.bnt_imprimir.Name = "bnt_imprimir";
            this.bnt_imprimir.Size = new System.Drawing.Size(90, 30);
            this.bnt_imprimir.TabIndex = 111;
            this.bnt_imprimir.Text = "Imprimir";
            this.bnt_imprimir.UseVisualStyleBackColor = true;
            this.bnt_imprimir.Click += new System.EventHandler(this.bnt_imprimir_Click);
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.Location = new System.Drawing.Point(612, 400);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 30);
            this.button10.TabIndex = 110;
            this.button10.Text = "Sair";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.Location = new System.Drawing.Point(377, 400);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 30);
            this.button8.TabIndex = 109;
            this.button8.Text = "Pesquisar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Location = new System.Drawing.Point(145, 364);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 30);
            this.button7.TabIndex = 108;
            this.button7.Text = "Anterior";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(261, 364);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 30);
            this.button6.TabIndex = 107;
            this.button6.Text = "Proximo";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(377, 364);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 30);
            this.button5.TabIndex = 106;
            this.button5.Text = "Novo";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(493, 364);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 30);
            this.button4.TabIndex = 105;
            this.button4.Text = "Alterar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(612, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 30);
            this.button3.TabIndex = 104;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(145, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 103;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 102;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bdCadastroDataSet1
            // 
            this.bdCadastroDataSet1.DataSetName = "bdCadastroDataSet";
            this.bdCadastroDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            this.printPreviewDialog2.Load += new System.EventHandler(this.printPreviewDialog2_Load);
            // 
            // tbFornecedorBindingSource
            // 
            this.tbFornecedorBindingSource.DataMember = "tbFornecedor";
            this.tbFornecedorBindingSource.DataSource = this.bdCadastroDataSet1;
            // 
            // tbFornecedorTableAdapter
            // 
            this.tbFornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // cd_FornecedorTexBox
            // 
            this.cd_FornecedorTexBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "cd_fornecedor", true));
            this.cd_FornecedorTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_FornecedorTexBox.Location = new System.Drawing.Point(201, 48);
            this.cd_FornecedorTexBox.Name = "cd_FornecedorTexBox";
            this.cd_FornecedorTexBox.Size = new System.Drawing.Size(100, 30);
            this.cd_FornecedorTexBox.TabIndex = 113;
            // 
            // nm_FornecedorTexBox
            // 
            this.nm_FornecedorTexBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "nm_fornecedor", true));
            this.nm_FornecedorTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_FornecedorTexBox.Location = new System.Drawing.Point(196, 84);
            this.nm_FornecedorTexBox.Name = "nm_FornecedorTexBox";
            this.nm_FornecedorTexBox.Size = new System.Drawing.Size(366, 30);
            this.nm_FornecedorTexBox.TabIndex = 115;
            // 
            // endereco_FornecedorTexBox
            // 
            this.endereco_FornecedorTexBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "ds_endereco", true));
            this.endereco_FornecedorTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco_FornecedorTexBox.Location = new System.Drawing.Point(231, 120);
            this.endereco_FornecedorTexBox.Name = "endereco_FornecedorTexBox";
            this.endereco_FornecedorTexBox.Size = new System.Drawing.Size(310, 30);
            this.endereco_FornecedorTexBox.TabIndex = 117;
            // 
            // Bairro_FornecedorTexBox
            // 
            this.Bairro_FornecedorTexBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "nm_bairro", true));
            this.Bairro_FornecedorTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bairro_FornecedorTexBox.Location = new System.Drawing.Point(201, 156);
            this.Bairro_FornecedorTexBox.Name = "Bairro_FornecedorTexBox";
            this.Bairro_FornecedorTexBox.Size = new System.Drawing.Size(306, 30);
            this.Bairro_FornecedorTexBox.TabIndex = 119;
            // 
            // Cidade_FornecedorTexBox
            // 
            this.Cidade_FornecedorTexBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "nm_cidade", true));
            this.Cidade_FornecedorTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cidade_FornecedorTexBox.Location = new System.Drawing.Point(205, 192);
            this.Cidade_FornecedorTexBox.Name = "Cidade_FornecedorTexBox";
            this.Cidade_FornecedorTexBox.Size = new System.Drawing.Size(302, 30);
            this.Cidade_FornecedorTexBox.TabIndex = 121;
            // 
            // Estado_FornecedorTexBox
            // 
            this.Estado_FornecedorTexBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "sg_estado", true));
            this.Estado_FornecedorTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado_FornecedorTexBox.Location = new System.Drawing.Point(206, 228);
            this.Estado_FornecedorTexBox.Name = "Estado_FornecedorTexBox";
            this.Estado_FornecedorTexBox.Size = new System.Drawing.Size(100, 30);
            this.Estado_FornecedorTexBox.TabIndex = 123;
            // 
            // Cep_FornecedorTextBox
            // 
            this.Cep_FornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "cd_cep", true));
            this.Cep_FornecedorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cep_FornecedorTextBox.Location = new System.Drawing.Point(187, 264);
            this.Cep_FornecedorTextBox.Name = "Cep_FornecedorTextBox";
            this.Cep_FornecedorTextBox.Size = new System.Drawing.Size(100, 30);
            this.Cep_FornecedorTextBox.TabIndex = 125;
            // 
            // Cnpj_FornecedorTxBox
            // 
            this.Cnpj_FornecedorTxBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbFornecedorBindingSource, "cd_cnpj", true));
            this.Cnpj_FornecedorTxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cnpj_FornecedorTxBox.Location = new System.Drawing.Point(187, 300);
            this.Cnpj_FornecedorTxBox.Name = "Cnpj_FornecedorTxBox";
            this.Cnpj_FornecedorTxBox.Size = new System.Drawing.Size(201, 30);
            this.Cnpj_FornecedorTxBox.TabIndex = 127;
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(cd_fornecedorLabel);
            this.Controls.Add(this.cd_FornecedorTexBox);
            this.Controls.Add(nm_fornecedorLabel);
            this.Controls.Add(this.nm_FornecedorTexBox);
            this.Controls.Add(ds_enderecoLabel);
            this.Controls.Add(this.endereco_FornecedorTexBox);
            this.Controls.Add(nm_bairroLabel);
            this.Controls.Add(this.Bairro_FornecedorTexBox);
            this.Controls.Add(nm_cidadeLabel);
            this.Controls.Add(this.Cidade_FornecedorTexBox);
            this.Controls.Add(sg_estadoLabel);
            this.Controls.Add(this.Estado_FornecedorTexBox);
            this.Controls.Add(cd_cepLabel);
            this.Controls.Add(this.Cep_FornecedorTextBox);
            this.Controls.Add(cd_cnpjLabel);
            this.Controls.Add(this.Cnpj_FornecedorTxBox);
            this.Controls.Add(this.bnt_imprimir);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmFornecedor";
            this.Text = "frmFornecedor";
            this.Load += new System.EventHandler(this.frmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bnt_imprimir;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private bdCadastroDataSet bdCadastroDataSet1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Windows.Forms.BindingSource tbFornecedorBindingSource;
        private bdCadastroDataSetTableAdapters.tbFornecedorTableAdapter tbFornecedorTableAdapter;
        private System.Windows.Forms.TextBox cd_FornecedorTexBox;
        private System.Windows.Forms.TextBox nm_FornecedorTexBox;
        private System.Windows.Forms.TextBox endereco_FornecedorTexBox;
        private System.Windows.Forms.TextBox Bairro_FornecedorTexBox;
        private System.Windows.Forms.TextBox Cidade_FornecedorTexBox;
        private System.Windows.Forms.TextBox Estado_FornecedorTexBox;
        private System.Windows.Forms.TextBox Cep_FornecedorTextBox;
        private System.Windows.Forms.TextBox Cnpj_FornecedorTxBox;
    }
}