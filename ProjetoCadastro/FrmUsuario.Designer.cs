
namespace ProjetoCadastro
{
    partial class FrmUsuario
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
            System.Windows.Forms.Label cd_usuarioLabel;
            System.Windows.Forms.Label nm_usuarioLabel;
            System.Windows.Forms.Label sg_nivelLabel;
            System.Windows.Forms.Label nm_loginLabel;
            System.Windows.Forms.Label cd_senhaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.bdCadastroDataSet = new ProjetoCadastro.bdCadastroDataSet();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuarioTableAdapter = new ProjetoCadastro.bdCadastroDataSetTableAdapters.tbUsuarioTableAdapter();
            this.cd_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.nm_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.sg_nivelTextBox = new System.Windows.Forms.TextBox();
            this.nm_loginTextBox = new System.Windows.Forms.TextBox();
            this.cd_senhaTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            cd_usuarioLabel = new System.Windows.Forms.Label();
            nm_usuarioLabel = new System.Windows.Forms.Label();
            sg_nivelLabel = new System.Windows.Forms.Label();
            nm_loginLabel = new System.Windows.Forms.Label();
            cd_senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_usuarioLabel
            // 
            cd_usuarioLabel.AutoSize = true;
            cd_usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_usuarioLabel.Location = new System.Drawing.Point(97, 43);
            cd_usuarioLabel.Name = "cd_usuarioLabel";
            cd_usuarioLabel.Size = new System.Drawing.Size(80, 25);
            cd_usuarioLabel.TabIndex = 1;
            cd_usuarioLabel.Text = "Codigo";
            cd_usuarioLabel.Click += new System.EventHandler(this.cd_usuarioLabel_Click);
            // 
            // nm_usuarioLabel
            // 
            nm_usuarioLabel.AutoSize = true;
            nm_usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_usuarioLabel.Location = new System.Drawing.Point(97, 101);
            nm_usuarioLabel.Name = "nm_usuarioLabel";
            nm_usuarioLabel.Size = new System.Drawing.Size(68, 25);
            nm_usuarioLabel.TabIndex = 3;
            nm_usuarioLabel.Text = "Nome";
            nm_usuarioLabel.Click += new System.EventHandler(this.nm_usuarioLabel_Click);
            // 
            // sg_nivelLabel
            // 
            sg_nivelLabel.AutoSize = true;
            sg_nivelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_nivelLabel.Location = new System.Drawing.Point(97, 159);
            sg_nivelLabel.Name = "sg_nivelLabel";
            sg_nivelLabel.Size = new System.Drawing.Size(60, 25);
            sg_nivelLabel.TabIndex = 5;
            sg_nivelLabel.Text = "Nivel";
            sg_nivelLabel.Click += new System.EventHandler(this.sg_nivelLabel_Click);
            // 
            // nm_loginLabel
            // 
            nm_loginLabel.AutoSize = true;
            nm_loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_loginLabel.Location = new System.Drawing.Point(97, 217);
            nm_loginLabel.Name = "nm_loginLabel";
            nm_loginLabel.Size = new System.Drawing.Size(64, 25);
            nm_loginLabel.TabIndex = 7;
            nm_loginLabel.Text = "login:";
            nm_loginLabel.Click += new System.EventHandler(this.nm_loginLabel_Click);
            // 
            // cd_senhaLabel
            // 
            cd_senhaLabel.AutoSize = true;
            cd_senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_senhaLabel.Location = new System.Drawing.Point(97, 275);
            cd_senhaLabel.Name = "cd_senhaLabel";
            cd_senhaLabel.Size = new System.Drawing.Size(83, 25);
            cd_senhaLabel.TabIndex = 9;
            cd_senhaLabel.Text = " senha:";
            cd_senhaLabel.Click += new System.EventHandler(this.cd_senhaLabel_Click);
            // 
            // bdCadastroDataSet
            // 
            this.bdCadastroDataSet.DataSetName = "bdCadastroDataSet";
            this.bdCadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.bdCadastroDataSet;
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // cd_usuarioTextBox
            // 
            this.cd_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "cd_usuario", true));
            this.cd_usuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_usuarioTextBox.Location = new System.Drawing.Point(194, 40);
            this.cd_usuarioTextBox.Name = "cd_usuarioTextBox";
            this.cd_usuarioTextBox.Size = new System.Drawing.Size(53, 31);
            this.cd_usuarioTextBox.TabIndex = 2;
            this.cd_usuarioTextBox.TextChanged += new System.EventHandler(this.cd_usuarioTextBox_TextChanged);
            // 
            // nm_usuarioTextBox
            // 
            this.nm_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "nm_usuario", true));
            this.nm_usuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_usuarioTextBox.Location = new System.Drawing.Point(194, 98);
            this.nm_usuarioTextBox.MaxLength = 40;
            this.nm_usuarioTextBox.Name = "nm_usuarioTextBox";
            this.nm_usuarioTextBox.Size = new System.Drawing.Size(480, 31);
            this.nm_usuarioTextBox.TabIndex = 4;
            this.nm_usuarioTextBox.TextChanged += new System.EventHandler(this.nm_usuarioTextBox_TextChanged);
            // 
            // sg_nivelTextBox
            // 
            this.sg_nivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "sg_nivel", true));
            this.sg_nivelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sg_nivelTextBox.Location = new System.Drawing.Point(194, 159);
            this.sg_nivelTextBox.MaxLength = 1;
            this.sg_nivelTextBox.Name = "sg_nivelTextBox";
            this.sg_nivelTextBox.Size = new System.Drawing.Size(53, 31);
            this.sg_nivelTextBox.TabIndex = 6;
            this.sg_nivelTextBox.TextChanged += new System.EventHandler(this.sg_nivelTextBox_TextChanged);
            // 
            // nm_loginTextBox
            // 
            this.nm_loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "nm_login", true));
            this.nm_loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_loginTextBox.Location = new System.Drawing.Point(194, 214);
            this.nm_loginTextBox.MaxLength = 15;
            this.nm_loginTextBox.Name = "nm_loginTextBox";
            this.nm_loginTextBox.Size = new System.Drawing.Size(100, 31);
            this.nm_loginTextBox.TabIndex = 8;
            this.nm_loginTextBox.TextChanged += new System.EventHandler(this.nm_loginTextBox_TextChanged);
            // 
            // cd_senhaTextBox
            // 
            this.cd_senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "cd_senha", true));
            this.cd_senhaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_senhaTextBox.Location = new System.Drawing.Point(194, 275);
            this.cd_senhaTextBox.MaxLength = 15;
            this.cd_senhaTextBox.Name = "cd_senhaTextBox";
            this.cd_senhaTextBox.Size = new System.Drawing.Size(100, 31);
            this.cd_senhaTextBox.TabIndex = 10;
            this.cd_senhaTextBox.UseSystemPasswordChar = true;
            this.cd_senhaTextBox.TextChanged += new System.EventHandler(this.cd_senhaTextBox_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(221, 401);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 30);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.AutoSize = true;
            this.btnpesquisar.Location = new System.Drawing.Point(346, 401);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(89, 30);
            this.btnpesquisar.TabIndex = 18;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.Location = new System.Drawing.Point(96, 401);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 30);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.Location = new System.Drawing.Point(585, 353);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 30);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.Location = new System.Drawing.Point(471, 353);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(89, 30);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Location = new System.Drawing.Point(346, 353);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(89, 30);
            this.btnNovo.TabIndex = 15;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.Location = new System.Drawing.Point(221, 353);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(89, 30);
            this.btnProximo.TabIndex = 16;
            this.btnProximo.Text = "Proximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.Location = new System.Drawing.Point(96, 356);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(89, 30);
            this.btnAnterior.TabIndex = 17;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.Location = new System.Drawing.Point(471, 401);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(89, 30);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.Text = "Imprimir ";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Location = new System.Drawing.Point(593, 401);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 30);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button10_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(cd_usuarioLabel);
            this.Controls.Add(this.cd_usuarioTextBox);
            this.Controls.Add(nm_usuarioLabel);
            this.Controls.Add(this.nm_usuarioTextBox);
            this.Controls.Add(sg_nivelLabel);
            this.Controls.Add(this.sg_nivelTextBox);
            this.Controls.Add(nm_loginLabel);
            this.Controls.Add(this.nm_loginTextBox);
            this.Controls.Add(cd_senhaLabel);
            this.Controls.Add(this.cd_senhaTextBox);
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdCadastroDataSet bdCadastroDataSet;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private bdCadastroDataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private System.Windows.Forms.TextBox cd_usuarioTextBox;
        private System.Windows.Forms.TextBox nm_usuarioTextBox;
        private System.Windows.Forms.TextBox sg_nivelTextBox;
        private System.Windows.Forms.TextBox nm_loginTextBox;
        private System.Windows.Forms.TextBox cd_senhaTextBox;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}