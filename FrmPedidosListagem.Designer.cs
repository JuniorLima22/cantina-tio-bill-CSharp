namespace cantina_tio_bill_CSharp
{
    partial class frmPedidosListagem
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntAtualizarListagem = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.footerStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeBairroETaxaDeEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAlterarPedido = new System.Windows.Forms.Button();
            this.btnAdicionarPedido = new System.Windows.Forms.Button();
            this.footerStatusPedidoListagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntAtualizarListagem
            // 
            this.bntAtualizarListagem.Location = new System.Drawing.Point(12, 392);
            this.bntAtualizarListagem.Name = "bntAtualizarListagem";
            this.bntAtualizarListagem.Size = new System.Drawing.Size(109, 23);
            this.bntAtualizarListagem.TabIndex = 0;
            this.bntAtualizarListagem.Text = "Atualizar Listagem";
            this.bntAtualizarListagem.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.footerStatusLabel,
            this.footerStatusPedidoListagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // footerStatusLabel
            // 
            this.footerStatusLabel.Name = "footerStatusLabel";
            this.footerStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroDeClienteToolStripMenuItem
            // 
            this.cadastroDeClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem,
            this.cadastroDeBairroETaxaDeEntregaToolStripMenuItem});
            this.cadastroDeClienteToolStripMenuItem.Name = "cadastroDeClienteToolStripMenuItem";
            this.cadastroDeClienteToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastroDeClienteToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.cadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes";
            this.cadastroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem_Click);
            // 
            // cadastroDeBairroETaxaDeEntregaToolStripMenuItem
            // 
            this.cadastroDeBairroETaxaDeEntregaToolStripMenuItem.Name = "cadastroDeBairroETaxaDeEntregaToolStripMenuItem";
            this.cadastroDeBairroETaxaDeEntregaToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.cadastroDeBairroETaxaDeEntregaToolStripMenuItem.Text = "Cadastro de bairro e taxa de entrega";
            this.cadastroDeBairroETaxaDeEntregaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeBairroETaxaDeEntregaToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 347);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnAlterarPedido
            // 
            this.btnAlterarPedido.Location = new System.Drawing.Point(208, 392);
            this.btnAlterarPedido.Name = "btnAlterarPedido";
            this.btnAlterarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarPedido.TabIndex = 6;
            this.btnAlterarPedido.Text = "Alterar";
            this.btnAlterarPedido.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarPedido
            // 
            this.btnAdicionarPedido.Location = new System.Drawing.Point(127, 392);
            this.btnAdicionarPedido.Name = "btnAdicionarPedido";
            this.btnAdicionarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarPedido.TabIndex = 5;
            this.btnAdicionarPedido.Text = "Adicionar";
            this.btnAdicionarPedido.UseVisualStyleBackColor = true;
            this.btnAdicionarPedido.Click += new System.EventHandler(this.btnAdicionarPedido_Click);
            // 
            // footerStatusPedidoListagem
            // 
            this.footerStatusPedidoListagem.Name = "footerStatusPedidoListagem";
            this.footerStatusPedidoListagem.Size = new System.Drawing.Size(0, 17);
            // 
            // frmPedidosListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlterarPedido);
            this.Controls.Add(this.btnAdicionarPedido);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bntAtualizarListagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedidosListagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Pedidos";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntAtualizarListagem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeBairroETaxaDeEntregaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAlterarPedido;
        private System.Windows.Forms.Button btnAdicionarPedido;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusPedidoListagem;
    }
}

