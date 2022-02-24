namespace cantina_tio_bill_CSharp
{
    partial class FrmClientesListagem
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
            this.btnAdicionarNovoCliente = new System.Windows.Forms.Button();
            this.dgvListagemCliente = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.footerStatusLabelClienteListagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.footerStatusClienteListagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAtualizarListagem = new System.Windows.Forms.Button();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemCliente)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionarNovoCliente
            // 
            this.btnAdicionarNovoCliente.Location = new System.Drawing.Point(147, 387);
            this.btnAdicionarNovoCliente.Name = "btnAdicionarNovoCliente";
            this.btnAdicionarNovoCliente.Size = new System.Drawing.Size(99, 23);
            this.btnAdicionarNovoCliente.TabIndex = 0;
            this.btnAdicionarNovoCliente.Text = "Adicionar Cliente";
            this.btnAdicionarNovoCliente.UseVisualStyleBackColor = true;
            this.btnAdicionarNovoCliente.Click += new System.EventHandler(this.btnAdicionarNovoCliente_Click);
            // 
            // dgvListagemCliente
            // 
            this.dgvListagemCliente.AllowUserToAddRows = false;
            this.dgvListagemCliente.AllowUserToDeleteRows = false;
            this.dgvListagemCliente.AllowUserToOrderColumns = true;
            this.dgvListagemCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListagemCliente.Location = new System.Drawing.Point(13, 13);
            this.dgvListagemCliente.Name = "dgvListagemCliente";
            this.dgvListagemCliente.ReadOnly = true;
            this.dgvListagemCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListagemCliente.Size = new System.Drawing.Size(775, 347);
            this.dgvListagemCliente.TabIndex = 1;
            this.dgvListagemCliente.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvListagemCliente_DataBindingComplete);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.footerStatusLabelClienteListagem,
            this.footerStatusClienteListagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
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
            // btnAtualizarListagem
            // 
            this.btnAtualizarListagem.Location = new System.Drawing.Point(13, 387);
            this.btnAtualizarListagem.Name = "btnAtualizarListagem";
            this.btnAtualizarListagem.Size = new System.Drawing.Size(128, 23);
            this.btnAtualizarListagem.TabIndex = 3;
            this.btnAtualizarListagem.Text = "Atualizar Listagem";
            this.btnAtualizarListagem.UseVisualStyleBackColor = true;
            this.btnAtualizarListagem.Click += new System.EventHandler(this.btnAtualizarListagem_Click);
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Location = new System.Drawing.Point(252, 387);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(93, 23);
            this.btnAlterarCliente.TabIndex = 4;
            this.btnAlterarCliente.Text = "Alterar Cliente";
            this.btnAlterarCliente.UseVisualStyleBackColor = true;
            this.btnAlterarCliente.Click += new System.EventHandler(this.btnAlterarCliente_Click);
            // 
            // FrmClientesListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlterarCliente);
            this.Controls.Add(this.btnAtualizarListagem);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvListagemCliente);
            this.Controls.Add(this.btnAdicionarNovoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientesListagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Clientes";
            this.Activated += new System.EventHandler(this.FrmClientesListagem_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemCliente)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarNovoCliente;
        private System.Windows.Forms.DataGridView dgvListagemCliente;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusLabelClienteListagem;
        private System.Windows.Forms.Button btnAtualizarListagem;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusClienteListagem;
        private System.Windows.Forms.Button btnAlterarCliente;
    }
}