namespace cantina_tio_bill_CSharp
{
    partial class FrmProdutosListagem
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.footerStatusLabelClienteListagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.footerStatusClienteListagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.footerStatusProdutoListagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvListagemProdutos = new System.Windows.Forms.DataGridView();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.btnAlterarProduto = new System.Windows.Forms.Button();
            this.btnAtualizarListagem = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.footerStatusLabelClienteListagem,
            this.footerStatusClienteListagem,
            this.footerStatusProdutoListagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // footerStatusLabelClienteListagem
            // 
            this.footerStatusLabelClienteListagem.Name = "footerStatusLabelClienteListagem";
            this.footerStatusLabelClienteListagem.Size = new System.Drawing.Size(0, 17);
            // 
            // footerStatusClienteListagem
            // 
            this.footerStatusClienteListagem.Name = "footerStatusClienteListagem";
            this.footerStatusClienteListagem.Size = new System.Drawing.Size(0, 17);
            // 
            // footerStatusProdutoListagem
            // 
            this.footerStatusProdutoListagem.Name = "footerStatusProdutoListagem";
            this.footerStatusProdutoListagem.Size = new System.Drawing.Size(0, 17);
            // 
            // dgvListagemProdutos
            // 
            this.dgvListagemProdutos.AllowUserToAddRows = false;
            this.dgvListagemProdutos.AllowUserToDeleteRows = false;
            this.dgvListagemProdutos.AllowUserToOrderColumns = true;
            this.dgvListagemProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListagemProdutos.Location = new System.Drawing.Point(13, 4);
            this.dgvListagemProdutos.Name = "dgvListagemProdutos";
            this.dgvListagemProdutos.ReadOnly = true;
            this.dgvListagemProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListagemProdutos.Size = new System.Drawing.Size(775, 347);
            this.dgvListagemProdutos.TabIndex = 11;
            this.dgvListagemProdutos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvListagemProdutos_DataBindingComplete);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(147, 378);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(105, 23);
            this.btnAdicionarProduto.TabIndex = 10;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // btnAlterarProduto
            // 
            this.btnAlterarProduto.Location = new System.Drawing.Point(258, 378);
            this.btnAlterarProduto.Name = "btnAlterarProduto";
            this.btnAlterarProduto.Size = new System.Drawing.Size(90, 23);
            this.btnAlterarProduto.TabIndex = 14;
            this.btnAlterarProduto.Text = "Alterar Produto";
            this.btnAlterarProduto.UseVisualStyleBackColor = true;
            this.btnAlterarProduto.Click += new System.EventHandler(this.btnAlterarProduto_Click);
            // 
            // btnAtualizarListagem
            // 
            this.btnAtualizarListagem.Location = new System.Drawing.Point(13, 378);
            this.btnAtualizarListagem.Name = "btnAtualizarListagem";
            this.btnAtualizarListagem.Size = new System.Drawing.Size(128, 23);
            this.btnAtualizarListagem.TabIndex = 13;
            this.btnAtualizarListagem.Text = "Atualizar Listagem";
            this.btnAtualizarListagem.UseVisualStyleBackColor = true;
            // 
            // FrmProdutosListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvListagemProdutos);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.btnAlterarProduto);
            this.Controls.Add(this.btnAtualizarListagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProdutosListagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Produtos";
            this.Activated += new System.EventHandler(this.FrmProdutosListagem_Activated);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusLabelClienteListagem;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusClienteListagem;
        private System.Windows.Forms.DataGridView dgvListagemProdutos;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Button btnAlterarProduto;
        private System.Windows.Forms.Button btnAtualizarListagem;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusProdutoListagem;
    }
}