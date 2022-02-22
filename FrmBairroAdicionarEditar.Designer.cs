namespace cantina_tio_bill_CSharp
{
    partial class FrmBairroAdicionarEditar
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
            this.labelTaxaEntrega = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.txtTaxaEntrega = new System.Windows.Forms.TextBox();
            this.footerStatusBairroAdicionarEditar = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(434, 91);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 54;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(251, 91);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 52;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(160, 91);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 51;
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
            this.btnCancelar.Location = new System.Drawing.Point(345, 91);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.footerStatusClienteAdicionarEditar,
            this.footerStatusBairro,
            this.footerStatusBairroAdicionarEditar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 153);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(634, 22);
            this.statusStrip1.TabIndex = 50;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // footerStatusBairro
            // 
            this.footerStatusBairro.Name = "footerStatusBairro";
            this.footerStatusBairro.Size = new System.Drawing.Size(0, 17);
            // 
            // labelTaxaEntrega
            // 
            this.labelTaxaEntrega.AutoSize = true;
            this.labelTaxaEntrega.Location = new System.Drawing.Point(439, 9);
            this.labelTaxaEntrega.Name = "labelTaxaEntrega";
            this.labelTaxaEntrega.Size = new System.Drawing.Size(85, 13);
            this.labelTaxaEntrega.TabIndex = 30;
            this.labelTaxaEntrega.Text = "Taxa de entrega";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(73, 24);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(305, 20);
            this.txtNome.TabIndex = 29;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(70, 8);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(34, 13);
            this.labelNome.TabIndex = 28;
            this.labelNome.Text = "Bairro";
            // 
            // txtTaxaEntrega
            // 
            this.txtTaxaEntrega.Location = new System.Drawing.Point(442, 25);
            this.txtTaxaEntrega.MaxLength = 100;
            this.txtTaxaEntrega.Name = "txtTaxaEntrega";
            this.txtTaxaEntrega.Size = new System.Drawing.Size(120, 20);
            this.txtTaxaEntrega.TabIndex = 56;
            this.txtTaxaEntrega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxaEntrega_KeyPress);
            this.txtTaxaEntrega.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTaxaEntrega_KeyUp);
            this.txtTaxaEntrega.Leave += new System.EventHandler(this.txtTaxaEntrega_Leave);
            // 
            // footerStatusBairroAdicionarEditar
            // 
            this.footerStatusBairroAdicionarEditar.Name = "footerStatusBairroAdicionarEditar";
            this.footerStatusBairroAdicionarEditar.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmBairroAdicionarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 175);
            this.Controls.Add(this.txtTaxaEntrega);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelTaxaEntrega);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBairroAdicionarEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Bairros";
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
        private System.Windows.Forms.Label labelTaxaEntrega;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtTaxaEntrega;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusBairro;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusBairroAdicionarEditar;
    }
}