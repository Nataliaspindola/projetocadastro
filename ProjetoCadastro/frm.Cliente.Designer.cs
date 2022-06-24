
namespace ProjetoCadastro
{
    partial class frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm));
            this.bdCadastroDataSet = new ProjetoCadastro.bdCadastroDataSet();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClienteTableAdapter = new ProjetoCadastro.bdCadastroDataSetTableAdapters.tbClienteTableAdapter();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cd_ClienteTexBox = new System.Windows.Forms.TextBox();
            this.Cd_NomeTexBox = new System.Windows.Forms.TextBox();
            this.cd_clienteLabel = new System.Windows.Forms.Label();
            this.Nome_ClienteLabel = new System.Windows.Forms.Label();
            this.Endereco_ClienteLabel = new System.Windows.Forms.Label();
            this.endereco_clienteTexBox = new System.Windows.Forms.TextBox();
            this.Bairro_ClienteTexBox = new System.Windows.Forms.TextBox();
            this.Bairro_ClienteLabel = new System.Windows.Forms.Label();
            this.Cidade_ClienteLabel = new System.Windows.Forms.Label();
            this.Estado_ClienteLabel = new System.Windows.Forms.Label();
            this.Cep_ClienteLabel = new System.Windows.Forms.Label();
            this.Rg_ClienteLabel = new System.Windows.Forms.Label();
            this.Cidade_ClienteTexBox = new System.Windows.Forms.TextBox();
            this.Estado_ClienteTexBox = new System.Windows.Forms.TextBox();
            this.Cep_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.Rg_ClienteTexBox = new System.Windows.Forms.TextBox();
            this.Cpf_ClienteTxBox = new System.Windows.Forms.TextBox();
            this.Cpf_ClienteLabel = new System.Windows.Forms.Label();
            this.bnt_imprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.Location = new System.Drawing.Point(541, 421);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 30);
            this.button10.TabIndex = 52;
            this.button10.Text = "Sair";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.Location = new System.Drawing.Point(306, 421);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 30);
            this.button8.TabIndex = 50;
            this.button8.Text = "Pesquisar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Location = new System.Drawing.Point(74, 385);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 30);
            this.button7.TabIndex = 49;
            this.button7.Text = "Anterior";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(190, 385);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 30);
            this.button6.TabIndex = 48;
            this.button6.Text = "Proximo";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(306, 385);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 30);
            this.button5.TabIndex = 47;
            this.button5.Text = "Novo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(422, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 30);
            this.button4.TabIndex = 46;
            this.button4.Text = "Alterar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(541, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 30);
            this.button3.TabIndex = 45;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(74, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 44;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 43;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cd_ClienteTexBox
            // 
            this.cd_ClienteTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_ClienteTexBox.Location = new System.Drawing.Point(170, 12);
            this.cd_ClienteTexBox.MaxLength = 3;
            this.cd_ClienteTexBox.Name = "cd_ClienteTexBox";
            this.cd_ClienteTexBox.Size = new System.Drawing.Size(47, 30);
            this.cd_ClienteTexBox.TabIndex = 75;
            this.cd_ClienteTexBox.TextChanged += new System.EventHandler(this.cd_Cliente_TextChanged);
            // 
            // Cd_NomeTexBox
            // 
            this.Cd_NomeTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cd_NomeTexBox.Location = new System.Drawing.Point(140, 53);
            this.Cd_NomeTexBox.MaxLength = 50;
            this.Cd_NomeTexBox.Name = "Cd_NomeTexBox";
            this.Cd_NomeTexBox.Size = new System.Drawing.Size(325, 30);
            this.Cd_NomeTexBox.TabIndex = 76;
            this.Cd_NomeTexBox.TextChanged += new System.EventHandler(this.nm_cliente_TextChanged);
            // 
            // cd_clienteLabel
            // 
            this.cd_clienteLabel.AutoSize = true;
            this.cd_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_clienteLabel.Location = new System.Drawing.Point(57, 17);
            this.cd_clienteLabel.Name = "cd_clienteLabel";
            this.cd_clienteLabel.Size = new System.Drawing.Size(107, 25);
            this.cd_clienteLabel.TabIndex = 85;
            this.cd_clienteLabel.Text = "CD Cliente";
            // 
            // Nome_ClienteLabel
            // 
            this.Nome_ClienteLabel.AutoSize = true;
            this.Nome_ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_ClienteLabel.Location = new System.Drawing.Point(59, 56);
            this.Nome_ClienteLabel.Name = "Nome_ClienteLabel";
            this.Nome_ClienteLabel.Size = new System.Drawing.Size(64, 25);
            this.Nome_ClienteLabel.TabIndex = 86;
            this.Nome_ClienteLabel.Text = "Nome";
            // 
            // Endereco_ClienteLabel
            // 
            this.Endereco_ClienteLabel.AutoSize = true;
            this.Endereco_ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endereco_ClienteLabel.Location = new System.Drawing.Point(59, 93);
            this.Endereco_ClienteLabel.Name = "Endereco_ClienteLabel";
            this.Endereco_ClienteLabel.Size = new System.Drawing.Size(96, 25);
            this.Endereco_ClienteLabel.TabIndex = 87;
            this.Endereco_ClienteLabel.Text = "Endereço";
            // 
            // endereco_clienteTexBox
            // 
            this.endereco_clienteTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco_clienteTexBox.Location = new System.Drawing.Point(161, 93);
            this.endereco_clienteTexBox.MaxLength = 50;
            this.endereco_clienteTexBox.Name = "endereco_clienteTexBox";
            this.endereco_clienteTexBox.Size = new System.Drawing.Size(260, 30);
            this.endereco_clienteTexBox.TabIndex = 88;
            // 
            // Bairro_ClienteTexBox
            // 
            this.Bairro_ClienteTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bairro_ClienteTexBox.Location = new System.Drawing.Point(134, 129);
            this.Bairro_ClienteTexBox.MaxLength = 50;
            this.Bairro_ClienteTexBox.Name = "Bairro_ClienteTexBox";
            this.Bairro_ClienteTexBox.Size = new System.Drawing.Size(158, 30);
            this.Bairro_ClienteTexBox.TabIndex = 89;
            // 
            // Bairro_ClienteLabel
            // 
            this.Bairro_ClienteLabel.AutoSize = true;
            this.Bairro_ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bairro_ClienteLabel.Location = new System.Drawing.Point(60, 132);
            this.Bairro_ClienteLabel.Name = "Bairro_ClienteLabel";
            this.Bairro_ClienteLabel.Size = new System.Drawing.Size(63, 25);
            this.Bairro_ClienteLabel.TabIndex = 90;
            this.Bairro_ClienteLabel.Text = "Bairro";
            // 
            // Cidade_ClienteLabel
            // 
            this.Cidade_ClienteLabel.AutoSize = true;
            this.Cidade_ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cidade_ClienteLabel.Location = new System.Drawing.Point(57, 173);
            this.Cidade_ClienteLabel.Name = "Cidade_ClienteLabel";
            this.Cidade_ClienteLabel.Size = new System.Drawing.Size(75, 25);
            this.Cidade_ClienteLabel.TabIndex = 91;
            this.Cidade_ClienteLabel.Text = "Cidade";
            // 
            // Estado_ClienteLabel
            // 
            this.Estado_ClienteLabel.AutoSize = true;
            this.Estado_ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado_ClienteLabel.Location = new System.Drawing.Point(61, 212);
            this.Estado_ClienteLabel.Name = "Estado_ClienteLabel";
            this.Estado_ClienteLabel.Size = new System.Drawing.Size(73, 25);
            this.Estado_ClienteLabel.TabIndex = 92;
            this.Estado_ClienteLabel.Text = "Estado";
            // 
            // Cep_ClienteLabel
            // 
            this.Cep_ClienteLabel.AutoSize = true;
            this.Cep_ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cep_ClienteLabel.Location = new System.Drawing.Point(59, 251);
            this.Cep_ClienteLabel.Name = "Cep_ClienteLabel";
            this.Cep_ClienteLabel.Size = new System.Drawing.Size(53, 25);
            this.Cep_ClienteLabel.TabIndex = 93;
            this.Cep_ClienteLabel.Text = "CEP";
            // 
            // Rg_ClienteLabel
            // 
            this.Rg_ClienteLabel.AutoSize = true;
            this.Rg_ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rg_ClienteLabel.Location = new System.Drawing.Point(59, 298);
            this.Rg_ClienteLabel.Name = "Rg_ClienteLabel";
            this.Rg_ClienteLabel.Size = new System.Drawing.Size(40, 25);
            this.Rg_ClienteLabel.TabIndex = 94;
            this.Rg_ClienteLabel.Text = "RG";
            // 
            // Cidade_ClienteTexBox
            // 
            this.Cidade_ClienteTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cidade_ClienteTexBox.Location = new System.Drawing.Point(141, 173);
            this.Cidade_ClienteTexBox.MaxLength = 50;
            this.Cidade_ClienteTexBox.Name = "Cidade_ClienteTexBox";
            this.Cidade_ClienteTexBox.Size = new System.Drawing.Size(255, 30);
            this.Cidade_ClienteTexBox.TabIndex = 95;
            // 
            // Estado_ClienteTexBox
            // 
            this.Estado_ClienteTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado_ClienteTexBox.Location = new System.Drawing.Point(140, 212);
            this.Estado_ClienteTexBox.MaxLength = 2;
            this.Estado_ClienteTexBox.Name = "Estado_ClienteTexBox";
            this.Estado_ClienteTexBox.Size = new System.Drawing.Size(100, 30);
            this.Estado_ClienteTexBox.TabIndex = 96;
            // 
            // Cep_ClienteTextBox
            // 
            this.Cep_ClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cep_ClienteTextBox.Location = new System.Drawing.Point(119, 251);
            this.Cep_ClienteTextBox.MaxLength = 8;
            this.Cep_ClienteTextBox.Name = "Cep_ClienteTextBox";
            this.Cep_ClienteTextBox.Size = new System.Drawing.Size(182, 30);
            this.Cep_ClienteTextBox.TabIndex = 97;
            // 
            // Rg_ClienteTexBox
            // 
            this.Rg_ClienteTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rg_ClienteTexBox.Location = new System.Drawing.Point(117, 298);
            this.Rg_ClienteTexBox.MaxLength = 10;
            this.Rg_ClienteTexBox.Name = "Rg_ClienteTexBox";
            this.Rg_ClienteTexBox.Size = new System.Drawing.Size(138, 30);
            this.Rg_ClienteTexBox.TabIndex = 98;
            // 
            // Cpf_ClienteTxBox
            // 
            this.Cpf_ClienteTxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cpf_ClienteTxBox.Location = new System.Drawing.Point(117, 338);
            this.Cpf_ClienteTxBox.MaxLength = 11;
            this.Cpf_ClienteTxBox.Name = "Cpf_ClienteTxBox";
            this.Cpf_ClienteTxBox.Size = new System.Drawing.Size(138, 30);
            this.Cpf_ClienteTxBox.TabIndex = 100;
            // 
            // Cpf_ClienteLabel
            // 
            this.Cpf_ClienteLabel.AutoSize = true;
            this.Cpf_ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cpf_ClienteLabel.Location = new System.Drawing.Point(59, 338);
            this.Cpf_ClienteLabel.Name = "Cpf_ClienteLabel";
            this.Cpf_ClienteLabel.Size = new System.Drawing.Size(52, 25);
            this.Cpf_ClienteLabel.TabIndex = 99;
            this.Cpf_ClienteLabel.Text = "CPF";
            // 
            // bnt_imprimir
            // 
            this.bnt_imprimir.AutoSize = true;
            this.bnt_imprimir.Location = new System.Drawing.Point(422, 421);
            this.bnt_imprimir.Name = "bnt_imprimir";
            this.bnt_imprimir.Size = new System.Drawing.Size(90, 30);
            this.bnt_imprimir.TabIndex = 101;
            this.bnt_imprimir.Text = "Imprimir";
            this.bnt_imprimir.UseVisualStyleBackColor = true;
            this.bnt_imprimir.Click += new System.EventHandler(this.bnt_imprimir_Click);
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
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.ControlBox = false;
            this.Controls.Add(this.bnt_imprimir);
            this.Controls.Add(this.Cpf_ClienteTxBox);
            this.Controls.Add(this.Cpf_ClienteLabel);
            this.Controls.Add(this.Rg_ClienteTexBox);
            this.Controls.Add(this.Cep_ClienteTextBox);
            this.Controls.Add(this.Estado_ClienteTexBox);
            this.Controls.Add(this.Cidade_ClienteTexBox);
            this.Controls.Add(this.Rg_ClienteLabel);
            this.Controls.Add(this.Cep_ClienteLabel);
            this.Controls.Add(this.Estado_ClienteLabel);
            this.Controls.Add(this.Cidade_ClienteLabel);
            this.Controls.Add(this.Bairro_ClienteLabel);
            this.Controls.Add(this.Bairro_ClienteTexBox);
            this.Controls.Add(this.endereco_clienteTexBox);
            this.Controls.Add(this.Endereco_ClienteLabel);
            this.Controls.Add(this.Nome_ClienteLabel);
            this.Controls.Add(this.cd_clienteLabel);
            this.Controls.Add(this.Cd_NomeTexBox);
            this.Controls.Add(this.cd_ClienteTexBox);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frm";
            this.Text = "frm";
            this.Load += new System.EventHandler(this.frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private bdCadastroDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cd_ClienteTexBox;
        private System.Windows.Forms.TextBox Cd_NomeTexBox;
        private System.Windows.Forms.Label cd_clienteLabel;
        private System.Windows.Forms.Label Nome_ClienteLabel;
        private System.Windows.Forms.Label Endereco_ClienteLabel;
        private System.Windows.Forms.TextBox endereco_clienteTexBox;
        private System.Windows.Forms.TextBox Bairro_ClienteTexBox;
        private System.Windows.Forms.Label Bairro_ClienteLabel;
        private System.Windows.Forms.Label Cidade_ClienteLabel;
        private System.Windows.Forms.Label Estado_ClienteLabel;
        private System.Windows.Forms.Label Cep_ClienteLabel;
        private System.Windows.Forms.Label Rg_ClienteLabel;
        private System.Windows.Forms.TextBox Cidade_ClienteTexBox;
        private System.Windows.Forms.TextBox Estado_ClienteTexBox;
        private System.Windows.Forms.TextBox Cep_ClienteTextBox;
        private System.Windows.Forms.TextBox Rg_ClienteTexBox;
        private System.Windows.Forms.TextBox Cpf_ClienteTxBox;
        private System.Windows.Forms.Label Cpf_ClienteLabel;
        private System.Windows.Forms.Button bnt_imprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}