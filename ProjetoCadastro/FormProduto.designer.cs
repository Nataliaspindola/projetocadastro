
namespace ProjetoCadastro
{
    partial class FormProduto
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
            System.Windows.Forms.Label cd_produtoLabel;
            System.Windows.Forms.Label nm_produtoLabel;
            System.Windows.Forms.Label sg_unidadeLabel;
            System.Windows.Forms.Label vl_custoLabel;
            System.Windows.Forms.Label vl_vendaLabel;
            System.Windows.Forms.Label qt_estoqueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduto));
            this.bdCadastroDataSet = new ProjetoCadastro.bdCadastroDataSet();
            this.tbProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProdutoTableAdapter = new ProjetoCadastro.bdCadastroDataSetTableAdapters.tbProdutoTableAdapter();
            this.cd_produtoTextBox = new System.Windows.Forms.TextBox();
            this.nm_produtoTextBox = new System.Windows.Forms.TextBox();
            this.sg_unidadeTextBox = new System.Windows.Forms.TextBox();
            this.vl_custoTextBox = new System.Windows.Forms.TextBox();
            this.vl_vendaTextBox = new System.Windows.Forms.TextBox();
            this.qt_estoqueTextBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
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
            cd_produtoLabel = new System.Windows.Forms.Label();
            nm_produtoLabel = new System.Windows.Forms.Label();
            sg_unidadeLabel = new System.Windows.Forms.Label();
            vl_custoLabel = new System.Windows.Forms.Label();
            vl_vendaLabel = new System.Windows.Forms.Label();
            qt_estoqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).BeginInit();
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
            // cd_produtoLabel
            // 
            cd_produtoLabel.AutoSize = true;
            cd_produtoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_produtoLabel.Location = new System.Drawing.Point(97, 31);
            cd_produtoLabel.Name = "cd_produtoLabel";
            cd_produtoLabel.Size = new System.Drawing.Size(175, 25);
            cd_produtoLabel.TabIndex = 111;
            cd_produtoLabel.Text = "Codigo do Produto";
            cd_produtoLabel.Click += new System.EventHandler(this.cd_produtoLabel_Click);
            // 
            // cd_produtoTextBox
            // 
            this.cd_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "cd_produto", true));
            this.cd_produtoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_produtoTextBox.Location = new System.Drawing.Point(262, 28);
            this.cd_produtoTextBox.MaxLength = 5;
            this.cd_produtoTextBox.Name = "cd_produtoTextBox";
            this.cd_produtoTextBox.Size = new System.Drawing.Size(100, 30);
            this.cd_produtoTextBox.TabIndex = 112;
            this.cd_produtoTextBox.TextChanged += new System.EventHandler(this.cd_produtoTextBox_TextChanged);
            // 
            // nm_produtoLabel
            // 
            nm_produtoLabel.AutoSize = true;
            nm_produtoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_produtoLabel.Location = new System.Drawing.Point(97, 79);
            nm_produtoLabel.Name = "nm_produtoLabel";
            nm_produtoLabel.Size = new System.Drawing.Size(64, 25);
            nm_produtoLabel.TabIndex = 113;
            nm_produtoLabel.Text = "Nome";
            nm_produtoLabel.Click += new System.EventHandler(this.nm_produtoLabel_Click);
            // 
            // nm_produtoTextBox
            // 
            this.nm_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "nm_produto", true));
            this.nm_produtoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_produtoTextBox.Location = new System.Drawing.Point(167, 76);
            this.nm_produtoTextBox.MaxLength = 50;
            this.nm_produtoTextBox.Name = "nm_produtoTextBox";
            this.nm_produtoTextBox.Size = new System.Drawing.Size(449, 30);
            this.nm_produtoTextBox.TabIndex = 114;
            this.nm_produtoTextBox.TextChanged += new System.EventHandler(this.nm_produtoTextBox_TextChanged);
            // 
            // sg_unidadeLabel
            // 
            sg_unidadeLabel.AutoSize = true;
            sg_unidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_unidadeLabel.Location = new System.Drawing.Point(97, 124);
            sg_unidadeLabel.Name = "sg_unidadeLabel";
            sg_unidadeLabel.Size = new System.Drawing.Size(85, 25);
            sg_unidadeLabel.TabIndex = 115;
            sg_unidadeLabel.Text = "Unidade";
            sg_unidadeLabel.Click += new System.EventHandler(this.sg_unidadeLabel_Click);
            // 
            // sg_unidadeTextBox
            // 
            this.sg_unidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "sg_unidade", true));
            this.sg_unidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sg_unidadeTextBox.Location = new System.Drawing.Point(188, 119);
            this.sg_unidadeTextBox.MaxLength = 100;
            this.sg_unidadeTextBox.Name = "sg_unidadeTextBox";
            this.sg_unidadeTextBox.Size = new System.Drawing.Size(100, 30);
            this.sg_unidadeTextBox.TabIndex = 116;
            this.sg_unidadeTextBox.TextChanged += new System.EventHandler(this.sg_unidadeTextBox_TextChanged);
            // 
            // vl_custoLabel
            // 
            vl_custoLabel.AutoSize = true;
            vl_custoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_custoLabel.Location = new System.Drawing.Point(97, 175);
            vl_custoLabel.Name = "vl_custoLabel";
            vl_custoLabel.Size = new System.Drawing.Size(64, 25);
            vl_custoLabel.TabIndex = 117;
            vl_custoLabel.Text = "Custo";
            vl_custoLabel.Click += new System.EventHandler(this.vl_custoLabel_Click);
            // 
            // vl_custoTextBox
            // 
            this.vl_custoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "vl_custo", true));
            this.vl_custoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vl_custoTextBox.Location = new System.Drawing.Point(172, 170);
            this.vl_custoTextBox.MaxLength = 1000;
            this.vl_custoTextBox.Name = "vl_custoTextBox";
            this.vl_custoTextBox.Size = new System.Drawing.Size(100, 30);
            this.vl_custoTextBox.TabIndex = 118;
            this.vl_custoTextBox.TextChanged += new System.EventHandler(this.vl_custoTextBox_TextChanged);
            // 
            // vl_vendaLabel
            // 
            vl_vendaLabel.AutoSize = true;
            vl_vendaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_vendaLabel.Location = new System.Drawing.Point(97, 225);
            vl_vendaLabel.Name = "vl_vendaLabel";
            vl_vendaLabel.Size = new System.Drawing.Size(148, 25);
            vl_vendaLabel.TabIndex = 119;
            vl_vendaLabel.Text = "Valor de Venda";
            vl_vendaLabel.Click += new System.EventHandler(this.vl_vendaLabel_Click);
            // 
            // vl_vendaTextBox
            // 
            this.vl_vendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "vl_venda", true));
            this.vl_vendaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vl_vendaTextBox.Location = new System.Drawing.Point(251, 222);
            this.vl_vendaTextBox.MaxLength = 1000;
            this.vl_vendaTextBox.Name = "vl_vendaTextBox";
            this.vl_vendaTextBox.Size = new System.Drawing.Size(100, 30);
            this.vl_vendaTextBox.TabIndex = 120;
            this.vl_vendaTextBox.TextChanged += new System.EventHandler(this.vl_vendaTextBox_TextChanged);
            // 
            // qt_estoqueLabel
            // 
            qt_estoqueLabel.AutoSize = true;
            qt_estoqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qt_estoqueLabel.Location = new System.Drawing.Point(97, 273);
            qt_estoqueLabel.Name = "qt_estoqueLabel";
            qt_estoqueLabel.Size = new System.Drawing.Size(84, 25);
            qt_estoqueLabel.TabIndex = 121;
            qt_estoqueLabel.Text = "Estoque";
            qt_estoqueLabel.Click += new System.EventHandler(this.qt_estoqueLabel_Click);
            // 
            // qt_estoqueTextBox
            // 
            this.qt_estoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbProdutoBindingSource, "qt_estoque", true));
            this.qt_estoqueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qt_estoqueTextBox.Location = new System.Drawing.Point(187, 268);
            this.qt_estoqueTextBox.MaxLength = 100;
            this.qt_estoqueTextBox.Name = "qt_estoqueTextBox";
            this.qt_estoqueTextBox.Size = new System.Drawing.Size(100, 30);
            this.qt_estoqueTextBox.TabIndex = 122;
            this.qt_estoqueTextBox.TextChanged += new System.EventHandler(this.qt_estoqueTextBox_TextChanged);
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
            // bnt_imprimir
            // 
            this.bnt_imprimir.AutoSize = true;
            this.bnt_imprimir.Location = new System.Drawing.Point(457, 376);
            this.bnt_imprimir.Name = "bnt_imprimir";
            this.bnt_imprimir.Size = new System.Drawing.Size(90, 30);
            this.bnt_imprimir.TabIndex = 132;
            this.bnt_imprimir.Text = "Imprimir";
            this.bnt_imprimir.UseVisualStyleBackColor = true;
            this.bnt_imprimir.Click += new System.EventHandler(this.bnt_imprimir_Click);
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.Location = new System.Drawing.Point(576, 376);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 30);
            this.button10.TabIndex = 131;
            this.button10.Text = "Sair";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.Location = new System.Drawing.Point(341, 376);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 30);
            this.button8.TabIndex = 130;
            this.button8.Text = "Pesquisar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Location = new System.Drawing.Point(109, 340);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 30);
            this.button7.TabIndex = 129;
            this.button7.Text = "Anterior";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(225, 340);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 30);
            this.button6.TabIndex = 128;
            this.button6.Text = "Proximo";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(341, 340);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 30);
            this.button5.TabIndex = 127;
            this.button5.Text = "Novo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(457, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 30);
            this.button4.TabIndex = 126;
            this.button4.Text = "Alterar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(576, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 30);
            this.button3.TabIndex = 125;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(109, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 124;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 123;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(cd_produtoLabel);
            this.Controls.Add(this.cd_produtoTextBox);
            this.Controls.Add(nm_produtoLabel);
            this.Controls.Add(this.nm_produtoTextBox);
            this.Controls.Add(sg_unidadeLabel);
            this.Controls.Add(this.sg_unidadeTextBox);
            this.Controls.Add(vl_custoLabel);
            this.Controls.Add(this.vl_custoTextBox);
            this.Controls.Add(vl_vendaLabel);
            this.Controls.Add(this.vl_vendaTextBox);
            this.Controls.Add(qt_estoqueLabel);
            this.Controls.Add(this.qt_estoqueTextBox);
            this.Name = "FormProduto";
            this.Text = "FormProduto";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdCadastroDataSet bdCadastroDataSet;
        private bdCadastroDataSetTableAdapters.tbProdutoTableAdapter tbProdutoTableAdapter;
        private System.Windows.Forms.BindingSource tbProdutoBindingSource;
        private System.Windows.Forms.TextBox cd_produtoTextBox;
        private System.Windows.Forms.TextBox nm_produtoTextBox;
        private System.Windows.Forms.TextBox sg_unidadeTextBox;
        private System.Windows.Forms.TextBox vl_custoTextBox;
        private System.Windows.Forms.TextBox vl_vendaTextBox;
        private System.Windows.Forms.TextBox qt_estoqueTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
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
    }
}