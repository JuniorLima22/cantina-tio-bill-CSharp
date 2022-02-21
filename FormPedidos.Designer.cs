namespace cantina_tio_bill_CSharp
{
    partial class frmPedido
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
            this.bntTesteDB = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.footerStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntTesteDB
            // 
            this.bntTesteDB.Location = new System.Drawing.Point(287, 279);
            this.bntTesteDB.Name = "bntTesteDB";
            this.bntTesteDB.Size = new System.Drawing.Size(109, 23);
            this.bntTesteDB.TabIndex = 0;
            this.bntTesteDB.Text = "TesteConexaoDB";
            this.bntTesteDB.UseVisualStyleBackColor = true;
            this.bntTesteDB.Click += new System.EventHandler(this.bntTesteDB_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.footerStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // footerStatusLabel
            // 
            this.footerStatusLabel.Name = "footerStatusLabel";
            this.footerStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.footerStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bntTesteDB);
            this.Name = "frmPedido";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntTesteDB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusLabel;
    }
}

