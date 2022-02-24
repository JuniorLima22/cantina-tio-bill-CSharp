namespace cantina_tio_bill_CSharp
{
    partial class FrmProdutoAdicionarEditar
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.footerStatusClienteAdicionarEditar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.footerStatusBairro = new System.Windows.Forms.ToolStripStatusLabel();
            this.footerStatusBairroAdicionarEditar = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelProduto = new System.Windows.Forms.Label();
            this.txtProdutoId = new System.Windows.Forms.TextBox();
            this.labelProdutoId = new System.Windows.Forms.Label();
            this.footerStatusProdutoAdicionarEditar = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.labelPreco = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(426, 187);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 64;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(243, 187);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 62;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(152, 187);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 61;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // footerStatusClienteAdicionarEditar
            // 
            this.footerStatusClienteAdicionarEditar.Name = "footerStatusClienteAdicionarEditar";
            this.footerStatusClienteAdicionarEditar.Size = new System.Drawing.Size(0, 17);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(337, 187);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 63;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.footerStatusClienteAdicionarEditar,
            this.footerStatusBairro,
            this.footerStatusBairroAdicionarEditar,
            this.footerStatusProdutoAdicionarEditar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 223);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(634, 22);
            this.statusStrip1.TabIndex = 60;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // footerStatusBairro
            // 
            this.footerStatusBairro.Name = "footerStatusBairro";
            this.footerStatusBairro.Size = new System.Drawing.Size(0, 17);
            // 
            // footerStatusBairroAdicionarEditar
            // 
            this.footerStatusBairroAdicionarEditar.Name = "footerStatusBairroAdicionarEditar";
            this.footerStatusBairroAdicionarEditar.Size = new System.Drawing.Size(0, 17);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(297, 25);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 20);
            this.txtNome.TabIndex = 65;
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Location = new System.Drawing.Point(294, 8);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(44, 13);
            this.labelProduto.TabIndex = 59;
            this.labelProduto.Text = "Produto";
            // 
            // txtProdutoId
            // 
            this.txtProdutoId.Enabled = false;
            this.txtProdutoId.Location = new System.Drawing.Point(73, 24);
            this.txtProdutoId.MaxLength = 100;
            this.txtProdutoId.Name = "txtProdutoId";
            this.txtProdutoId.Size = new System.Drawing.Size(201, 20);
            this.txtProdutoId.TabIndex = 58;
            // 
            // labelProdutoId
            // 
            this.labelProdutoId.AutoSize = true;
            this.labelProdutoId.Location = new System.Drawing.Point(70, 8);
            this.labelProdutoId.Name = "labelProdutoId";
            this.labelProdutoId.Size = new System.Drawing.Size(40, 13);
            this.labelProdutoId.TabIndex = 57;
            this.labelProdutoId.Text = "Código";
            // 
            // footerStatusProdutoAdicionarEditar
            // 
            this.footerStatusProdutoAdicionarEditar.Name = "footerStatusProdutoAdicionarEditar";
            this.footerStatusProdutoAdicionarEditar.Size = new System.Drawing.Size(0, 17);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(297, 71);
            this.txtPreco.MaxLength = 100;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(122, 20);
            this.txtPreco.TabIndex = 69;
            this.txtPreco.Text = "0";
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            this.txtPreco.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPreco_KeyUp);
            this.txtPreco.Leave += new System.EventHandler(this.txtPreco_Leave);
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(294, 54);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(35, 13);
            this.labelPreco.TabIndex = 68;
            this.labelPreco.Text = "Preço";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(73, 119);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(489, 59);
            this.txtDescricao.TabIndex = 67;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(70, 103);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(55, 13);
            this.labelDescricao.TabIndex = 66;
            this.labelDescricao.Text = "Descrição";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(70, 55);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(52, 13);
            this.labelCategoria.TabIndex = 70;
            this.labelCategoria.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Selecione...",
            "Bebida",
            "Salada",
            "Sobremesa",
            "Quentinha",
            "Outros"});
            this.cbxCategoria.Location = new System.Drawing.Point(73, 70);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(201, 21);
            this.cbxCategoria.TabIndex = 72;
            // 
            // FrmProdutoAdicionarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 245);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelProduto);
            this.Controls.Add(this.txtProdutoId);
            this.Controls.Add(this.labelProdutoId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProdutoAdicionarEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusClienteAdicionarEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusBairro;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusBairroAdicionarEditar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.TextBox txtProdutoId;
        private System.Windows.Forms.Label labelProdutoId;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusProdutoAdicionarEditar;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.ComboBox cbxCategoria;
    }
}