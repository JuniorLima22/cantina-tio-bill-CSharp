namespace cantina_tio_bill_CSharp
{
    partial class FrmPedidosAdicionarEditar
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
            this.footerStatusClienteAdicionarEditar = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelClienteId = new System.Windows.Forms.Label();
            this.cbxClienteId = new System.Windows.Forms.ComboBox();
            this.txtPedidoId = new System.Windows.Forms.TextBox();
            this.labelPedidoId = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelMotivoCancelamento = new System.Windows.Forms.Label();
            this.labelObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.btnSalvarPedido = new System.Windows.Forms.Button();
            this.btnEditarPedido = new System.Windows.Forms.Button();
            this.groupBoxPedido = new System.Windows.Forms.GroupBox();
            this.txtPreco = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPreco = new System.Windows.Forms.Label();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.cbxProdutoId = new System.Windows.Forms.ComboBox();
            this.labelProduto = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxItemListagem = new System.Windows.Forms.GroupBox();
            this.btnAtualizarListagem = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.groupBoxBtn2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluirPedido = new System.Windows.Forms.Button();
            this.groupBoxDadosCliente = new System.Windows.Forms.GroupBox();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.rtxDadosCliente = new System.Windows.Forms.RichTextBox();
            this.footerStatusPedidosAdicionarEditar = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.groupBoxPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxItemListagem.SuspendLayout();
            this.groupBoxBtn2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxDadosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // footerStatusClienteAdicionarEditar
            // 
            this.footerStatusClienteAdicionarEditar.Name = "footerStatusClienteAdicionarEditar";
            this.footerStatusClienteAdicionarEditar.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.footerStatusClienteAdicionarEditar,
            this.footerStatusPedidosAdicionarEditar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(827, 22);
            this.statusStrip1.TabIndex = 50;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelClienteId
            // 
            this.labelClienteId.AutoSize = true;
            this.labelClienteId.Location = new System.Drawing.Point(175, 13);
            this.labelClienteId.Name = "labelClienteId";
            this.labelClienteId.Size = new System.Drawing.Size(39, 13);
            this.labelClienteId.TabIndex = 28;
            this.labelClienteId.Text = "Cliente";
            // 
            // cbxClienteId
            // 
            this.cbxClienteId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClienteId.FormattingEnabled = true;
            this.cbxClienteId.Location = new System.Drawing.Point(179, 31);
            this.cbxClienteId.Name = "cbxClienteId";
            this.cbxClienteId.Size = new System.Drawing.Size(217, 21);
            this.cbxClienteId.TabIndex = 2;
            this.cbxClienteId.SelectedIndexChanged += new System.EventHandler(this.cbxClienteId_SelectedIndexChanged);
            // 
            // txtPedidoId
            // 
            this.txtPedidoId.Enabled = false;
            this.txtPedidoId.Location = new System.Drawing.Point(8, 32);
            this.txtPedidoId.MaxLength = 100;
            this.txtPedidoId.Name = "txtPedidoId";
            this.txtPedidoId.Size = new System.Drawing.Size(165, 20);
            this.txtPedidoId.TabIndex = 1;
            // 
            // labelPedidoId
            // 
            this.labelPedidoId.AutoSize = true;
            this.labelPedidoId.Location = new System.Drawing.Point(5, 13);
            this.labelPedidoId.Name = "labelPedidoId";
            this.labelPedidoId.Size = new System.Drawing.Size(91, 13);
            this.labelPedidoId.TabIndex = 35;
            this.labelPedidoId.Text = "Código do Pedido";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Pendente",
            "Concluído",
            "Cancelado"});
            this.cbxStatus.Location = new System.Drawing.Point(11, 79);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(386, 21);
            this.cbxStatus.TabIndex = 3;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(9, 63);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(88, 13);
            this.labelStatus.TabIndex = 38;
            this.labelStatus.Text = "Status do Pedido";
            // 
            // labelMotivoCancelamento
            // 
            this.labelMotivoCancelamento.AutoSize = true;
            this.labelMotivoCancelamento.Location = new System.Drawing.Point(9, 103);
            this.labelMotivoCancelamento.Name = "labelMotivoCancelamento";
            this.labelMotivoCancelamento.Size = new System.Drawing.Size(125, 13);
            this.labelMotivoCancelamento.TabIndex = 35;
            this.labelMotivoCancelamento.Text = "Motivo do Cancelamento";
            // 
            // labelObservacao
            // 
            this.labelObservacao.AutoSize = true;
            this.labelObservacao.Location = new System.Drawing.Point(9, 169);
            this.labelObservacao.Name = "labelObservacao";
            this.labelObservacao.Size = new System.Drawing.Size(65, 13);
            this.labelObservacao.TabIndex = 48;
            this.labelObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(12, 185);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(387, 63);
            this.txtObservacao.TabIndex = 5;
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Location = new System.Drawing.Point(7, 93);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarPedido.TabIndex = 9;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            // 
            // btnSalvarPedido
            // 
            this.btnSalvarPedido.Location = new System.Drawing.Point(7, 35);
            this.btnSalvarPedido.Name = "btnSalvarPedido";
            this.btnSalvarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarPedido.TabIndex = 7;
            this.btnSalvarPedido.Text = "Salvar";
            this.btnSalvarPedido.UseVisualStyleBackColor = true;
            // 
            // btnEditarPedido
            // 
            this.btnEditarPedido.Location = new System.Drawing.Point(7, 64);
            this.btnEditarPedido.Name = "btnEditarPedido";
            this.btnEditarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnEditarPedido.TabIndex = 8;
            this.btnEditarPedido.Text = "Editar";
            this.btnEditarPedido.UseVisualStyleBackColor = true;
            // 
            // groupBoxPedido
            // 
            this.groupBoxPedido.Controls.Add(this.groupBoxDadosCliente);
            this.groupBoxPedido.Controls.Add(this.textBox1);
            this.groupBoxPedido.Controls.Add(this.labelPedidoId);
            this.groupBoxPedido.Controls.Add(this.cbxClienteId);
            this.groupBoxPedido.Controls.Add(this.labelClienteId);
            this.groupBoxPedido.Controls.Add(this.txtPedidoId);
            this.groupBoxPedido.Controls.Add(this.cbxStatus);
            this.groupBoxPedido.Controls.Add(this.txtObservacao);
            this.groupBoxPedido.Controls.Add(this.labelMotivoCancelamento);
            this.groupBoxPedido.Controls.Add(this.labelObservacao);
            this.groupBoxPedido.Controls.Add(this.labelStatus);
            this.groupBoxPedido.Location = new System.Drawing.Point(23, -1);
            this.groupBoxPedido.Name = "groupBoxPedido";
            this.groupBoxPedido.Size = new System.Drawing.Size(698, 253);
            this.groupBoxPedido.TabIndex = 56;
            this.groupBoxPedido.TabStop = false;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(245, 32);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(164, 20);
            this.txtPreco.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 119);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 47);
            this.textBox1.TabIndex = 4;
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(416, 15);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(35, 13);
            this.labelPreco.TabIndex = 35;
            this.labelPreco.Text = "Preço";
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(242, 16);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(62, 13);
            this.labelQuantidade.TabIndex = 35;
            this.labelQuantidade.Text = "Quantidade";
            // 
            // cbxProdutoId
            // 
            this.cbxProdutoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProdutoId.FormattingEnabled = true;
            this.cbxProdutoId.Location = new System.Drawing.Point(10, 32);
            this.cbxProdutoId.Name = "cbxProdutoId";
            this.cbxProdutoId.Size = new System.Drawing.Size(229, 21);
            this.cbxProdutoId.TabIndex = 11;
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Location = new System.Drawing.Point(8, 16);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(44, 13);
            this.labelProduto.TabIndex = 28;
            this.labelProduto.Text = "Produto";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(419, 32);
            this.textBox3.MaxLength = 100;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 20);
            this.textBox3.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(655, 92);
            this.dataGridView1.TabIndex = 57;
            // 
            // groupBoxItemListagem
            // 
            this.groupBoxItemListagem.Controls.Add(this.btnAdicionarItem);
            this.groupBoxItemListagem.Controls.Add(this.textBox3);
            this.groupBoxItemListagem.Controls.Add(this.txtPreco);
            this.groupBoxItemListagem.Controls.Add(this.labelPreco);
            this.groupBoxItemListagem.Controls.Add(this.cbxProdutoId);
            this.groupBoxItemListagem.Controls.Add(this.labelProduto);
            this.groupBoxItemListagem.Controls.Add(this.labelQuantidade);
            this.groupBoxItemListagem.Location = new System.Drawing.Point(23, 258);
            this.groupBoxItemListagem.Name = "groupBoxItemListagem";
            this.groupBoxItemListagem.Size = new System.Drawing.Size(670, 162);
            this.groupBoxItemListagem.TabIndex = 58;
            this.groupBoxItemListagem.TabStop = false;
            this.groupBoxItemListagem.Text = "Items do Pedido";
            // 
            // btnAtualizarListagem
            // 
            this.btnAtualizarListagem.Location = new System.Drawing.Point(9, 45);
            this.btnAtualizarListagem.Name = "btnAtualizarListagem";
            this.btnAtualizarListagem.Size = new System.Drawing.Size(103, 23);
            this.btnAtualizarListagem.TabIndex = 15;
            this.btnAtualizarListagem.Text = "Atualizar Listagem";
            this.btnAtualizarListagem.UseVisualStyleBackColor = true;
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Location = new System.Drawing.Point(9, 74);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(103, 23);
            this.btnExcluirItem.TabIndex = 16;
            this.btnExcluirItem.Text = "Excluir";
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(9, 103);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(103, 23);
            this.btnImprimir.TabIndex = 17;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // groupBoxBtn2
            // 
            this.groupBoxBtn2.Controls.Add(this.btnAtualizarListagem);
            this.groupBoxBtn2.Controls.Add(this.btnImprimir);
            this.groupBoxBtn2.Controls.Add(this.btnExcluirItem);
            this.groupBoxBtn2.Location = new System.Drawing.Point(699, 258);
            this.groupBoxBtn2.Name = "groupBoxBtn2";
            this.groupBoxBtn2.Size = new System.Drawing.Size(118, 163);
            this.groupBoxBtn2.TabIndex = 59;
            this.groupBoxBtn2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalvarPedido);
            this.groupBox1.Controls.Add(this.btnEditarPedido);
            this.groupBox1.Controls.Add(this.btnExcluirPedido);
            this.groupBox1.Controls.Add(this.btnCancelarPedido);
            this.groupBox1.Location = new System.Drawing.Point(727, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 253);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // btnExcluirPedido
            // 
            this.btnExcluirPedido.Location = new System.Drawing.Point(7, 122);
            this.btnExcluirPedido.Name = "btnExcluirPedido";
            this.btnExcluirPedido.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirPedido.TabIndex = 10;
            this.btnExcluirPedido.Text = "Excluir";
            this.btnExcluirPedido.UseVisualStyleBackColor = true;
            // 
            // groupBoxDadosCliente
            // 
            this.groupBoxDadosCliente.Controls.Add(this.rtxDadosCliente);
            this.groupBoxDadosCliente.Location = new System.Drawing.Point(411, 31);
            this.groupBoxDadosCliente.Name = "groupBoxDadosCliente";
            this.groupBoxDadosCliente.Size = new System.Drawing.Size(272, 213);
            this.groupBoxDadosCliente.TabIndex = 58;
            this.groupBoxDadosCliente.TabStop = false;
            this.groupBoxDadosCliente.Text = "Dados do Cliente";
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(549, 31);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(115, 23);
            this.btnAdicionarItem.TabIndex = 14;
            this.btnAdicionarItem.Text = "Adicionar";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            // 
            // rtxDadosCliente
            // 
            this.rtxDadosCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxDadosCliente.Enabled = false;
            this.rtxDadosCliente.Location = new System.Drawing.Point(3, 16);
            this.rtxDadosCliente.Name = "rtxDadosCliente";
            this.rtxDadosCliente.ReadOnly = true;
            this.rtxDadosCliente.Size = new System.Drawing.Size(266, 194);
            this.rtxDadosCliente.TabIndex = 6;
            this.rtxDadosCliente.Text = "";
            // 
            // footerStatusPedidosAdicionarEditar
            // 
            this.footerStatusPedidosAdicionarEditar.Name = "footerStatusPedidosAdicionarEditar";
            this.footerStatusPedidosAdicionarEditar.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmPedidosAdicionarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxBtn2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxPedido);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxItemListagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedidosAdicionarEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pedidos";
            this.Load += new System.EventHandler(this.FrmPedidosAdicionarEditar_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxPedido.ResumeLayout(false);
            this.groupBoxPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxItemListagem.ResumeLayout(false);
            this.groupBoxItemListagem.PerformLayout();
            this.groupBoxBtn2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxDadosCliente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripStatusLabel footerStatusClienteAdicionarEditar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label labelClienteId;
        private System.Windows.Forms.ComboBox cbxClienteId;
        private System.Windows.Forms.TextBox txtPedidoId;
        private System.Windows.Forms.Label labelPedidoId;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelMotivoCancelamento;
        private System.Windows.Forms.Label labelObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnSalvarPedido;
        private System.Windows.Forms.Button btnEditarPedido;
        private System.Windows.Forms.GroupBox groupBoxPedido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown txtPreco;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.ComboBox cbxProdutoId;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxItemListagem;
        private System.Windows.Forms.Button btnAtualizarListagem;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox groupBoxBtn2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcluirPedido;
        private System.Windows.Forms.GroupBox groupBoxDadosCliente;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.RichTextBox rtxDadosCliente;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusPedidosAdicionarEditar;
    }
}