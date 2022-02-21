namespace cantina_tio_bill_CSharp
{
    partial class FrmBairroListagem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdicionarNovoCliente = new System.Windows.Forms.Button();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.btnAtualizarListagem = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.footerStatusLabelClienteListagem,
            this.footerStatusClienteListagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 7;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 347);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnAdicionarNovoCliente
            // 
            this.btnAdicionarNovoCliente.Location = new System.Drawing.Point(147, 381);
            this.btnAdicionarNovoCliente.Name = "btnAdicionarNovoCliente";
            this.btnAdicionarNovoCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarNovoCliente.TabIndex = 5;
            this.btnAdicionarNovoCliente.Text = "Adicionar";
            this.btnAdicionarNovoCliente.UseVisualStyleBackColor = true;
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Location = new System.Drawing.Point(228, 381);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCliente.TabIndex = 9;
            this.btnAlterarCliente.Text = "Alterar";
            this.btnAlterarCliente.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarListagem
            // 
            this.btnAtualizarListagem.Location = new System.Drawing.Point(13, 381);
            this.btnAtualizarListagem.Name = "btnAtualizarListagem";
            this.btnAtualizarListagem.Size = new System.Drawing.Size(128, 23);
            this.btnAtualizarListagem.TabIndex = 8;
            this.btnAtualizarListagem.Text = "Atualizar Listagem";
            this.btnAtualizarListagem.UseVisualStyleBackColor = true;
            this.btnAtualizarListagem.Click += new System.EventHandler(this.btnAtualizarListagem_Click);
            // 
            // FrmBairroListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdicionarNovoCliente);
            this.Controls.Add(this.btnAlterarCliente);
            this.Controls.Add(this.btnAtualizarListagem);
            this.Name = "FrmBairroListagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem dos Bairros";
            this.Activated += new System.EventHandler(this.FrmBairroListagem_Activated);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusLabelClienteListagem;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusClienteListagem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdicionarNovoCliente;
        private System.Windows.Forms.Button btnAlterarCliente;
        private System.Windows.Forms.Button btnAtualizarListagem;
    }
}