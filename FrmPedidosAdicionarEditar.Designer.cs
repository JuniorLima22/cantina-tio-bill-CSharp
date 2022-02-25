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
            this.footerStatusPedidosAdicionarEditar = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelClienteId = new System.Windows.Forms.Label();
            this.cbxClienteId = new System.Windows.Forms.ComboBox();
            this.txtPedidoId = new System.Windows.Forms.TextBox();
            this.labelPedidoId = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelMotivoCancelamento = new System.Windows.Forms.Label();
            this.labelObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBoxPedido = new System.Windows.Forms.GroupBox();
            this.groupBoxDadosCliente = new System.Windows.Forms.GroupBox();
            this.rtxDadosCliente = new System.Windows.Forms.RichTextBox();
            this.txtMotivoCancelamento = new System.Windows.Forms.TextBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.labelPreco = new System.Windows.Forms.Label();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.cbxProdutoId = new System.Windows.Forms.ComboBox();
            this.labelProduto = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.dgvProdutoPedido = new System.Windows.Forms.DataGridView();
            this.groupBoxItemListagem = new System.Windows.Forms.GroupBox();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.labelTotalBrutoItens = new System.Windows.Forms.Label();
            this.labelResultadoTotalBrutoItens = new System.Windows.Forms.Label();
            this.labelResultadoTotalDescontoItens = new System.Windows.Forms.Label();
            this.labelTotalDescontoItens = new System.Windows.Forms.Label();
            this.labelTotalLiquido = new System.Windows.Forms.Label();
            this.labelResultadoTotalLiquido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTaxaEntrega = new System.Windows.Forms.Label();
            this.labelResultadoTaxaEntrega = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBoxPedido.SuspendLayout();
            this.groupBoxDadosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoPedido)).BeginInit();
            this.groupBoxItemListagem.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(827, 22);
            this.statusStrip1.TabIndex = 50;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // footerStatusPedidosAdicionarEditar
            // 
            this.footerStatusPedidosAdicionarEditar.Name = "footerStatusPedidosAdicionarEditar";
            this.footerStatusPedidosAdicionarEditar.Size = new System.Drawing.Size(0, 17);
            // 
            // labelClienteId
            // 
            this.labelClienteId.AutoSize = true;
            this.labelClienteId.Location = new System.Drawing.Point(13, 10);
            this.labelClienteId.Name = "labelClienteId";
            this.labelClienteId.Size = new System.Drawing.Size(39, 13);
            this.labelClienteId.TabIndex = 28;
            this.labelClienteId.Text = "Cliente";
            // 
            // cbxClienteId
            // 
            this.cbxClienteId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClienteId.FormattingEnabled = true;
            this.cbxClienteId.Location = new System.Drawing.Point(17, 28);
            this.cbxClienteId.Name = "cbxClienteId";
            this.cbxClienteId.Size = new System.Drawing.Size(258, 21);
            this.cbxClienteId.TabIndex = 2;
            this.cbxClienteId.SelectedIndexChanged += new System.EventHandler(this.cbxClienteId_SelectedIndexChanged);
            // 
            // txtPedidoId
            // 
            this.txtPedidoId.Enabled = false;
            this.txtPedidoId.Location = new System.Drawing.Point(297, 29);
            this.txtPedidoId.MaxLength = 100;
            this.txtPedidoId.Name = "txtPedidoId";
            this.txtPedidoId.Size = new System.Drawing.Size(183, 20);
            this.txtPedidoId.TabIndex = 1;
            // 
            // labelPedidoId
            // 
            this.labelPedidoId.AutoSize = true;
            this.labelPedidoId.Location = new System.Drawing.Point(294, 10);
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
            this.cbxStatus.Location = new System.Drawing.Point(300, 76);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(386, 21);
            this.cbxStatus.TabIndex = 3;
            this.cbxStatus.SelectedIndexChanged += new System.EventHandler(this.cbxStatus_SelectedIndexChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(298, 60);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(88, 13);
            this.labelStatus.TabIndex = 38;
            this.labelStatus.Text = "Status do Pedido";
            // 
            // labelMotivoCancelamento
            // 
            this.labelMotivoCancelamento.AutoSize = true;
            this.labelMotivoCancelamento.Location = new System.Drawing.Point(298, 100);
            this.labelMotivoCancelamento.Name = "labelMotivoCancelamento";
            this.labelMotivoCancelamento.Size = new System.Drawing.Size(125, 13);
            this.labelMotivoCancelamento.TabIndex = 35;
            this.labelMotivoCancelamento.Text = "Motivo do Cancelamento";
            // 
            // labelObservacao
            // 
            this.labelObservacao.AutoSize = true;
            this.labelObservacao.Location = new System.Drawing.Point(298, 167);
            this.labelObservacao.Name = "labelObservacao";
            this.labelObservacao.Size = new System.Drawing.Size(116, 13);
            this.labelObservacao.TabIndex = 48;
            this.labelObservacao.Text = "Observação do Pedido";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(301, 182);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(387, 63);
            this.txtObservacao.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(7, 111);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(7, 35);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 41);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Iniciar Pedido";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(7, 82);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // groupBoxPedido
            // 
            this.groupBoxPedido.Controls.Add(this.groupBoxDadosCliente);
            this.groupBoxPedido.Controls.Add(this.txtMotivoCancelamento);
            this.groupBoxPedido.Controls.Add(this.labelPedidoId);
            this.groupBoxPedido.Controls.Add(this.labelClienteId);
            this.groupBoxPedido.Controls.Add(this.txtPedidoId);
            this.groupBoxPedido.Controls.Add(this.cbxStatus);
            this.groupBoxPedido.Controls.Add(this.txtObservacao);
            this.groupBoxPedido.Controls.Add(this.labelMotivoCancelamento);
            this.groupBoxPedido.Controls.Add(this.labelObservacao);
            this.groupBoxPedido.Controls.Add(this.labelStatus);
            this.groupBoxPedido.Controls.Add(this.cbxClienteId);
            this.groupBoxPedido.Controls.Add(this.txtClienteId);
            this.groupBoxPedido.Location = new System.Drawing.Point(23, -1);
            this.groupBoxPedido.Name = "groupBoxPedido";
            this.groupBoxPedido.Size = new System.Drawing.Size(698, 253);
            this.groupBoxPedido.TabIndex = 56;
            this.groupBoxPedido.TabStop = false;
            // 
            // groupBoxDadosCliente
            // 
            this.groupBoxDadosCliente.Controls.Add(this.rtxDadosCliente);
            this.groupBoxDadosCliente.Location = new System.Drawing.Point(6, 55);
            this.groupBoxDadosCliente.Name = "groupBoxDadosCliente";
            this.groupBoxDadosCliente.Size = new System.Drawing.Size(272, 193);
            this.groupBoxDadosCliente.TabIndex = 58;
            this.groupBoxDadosCliente.TabStop = false;
            this.groupBoxDadosCliente.Text = "Dados do Cliente";
            // 
            // rtxDadosCliente
            // 
            this.rtxDadosCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxDadosCliente.Enabled = false;
            this.rtxDadosCliente.Location = new System.Drawing.Point(3, 16);
            this.rtxDadosCliente.Name = "rtxDadosCliente";
            this.rtxDadosCliente.ReadOnly = true;
            this.rtxDadosCliente.Size = new System.Drawing.Size(266, 174);
            this.rtxDadosCliente.TabIndex = 6;
            this.rtxDadosCliente.Text = "";
            // 
            // txtMotivoCancelamento
            // 
            this.txtMotivoCancelamento.Enabled = false;
            this.txtMotivoCancelamento.Location = new System.Drawing.Point(301, 116);
            this.txtMotivoCancelamento.Multiline = true;
            this.txtMotivoCancelamento.Name = "txtMotivoCancelamento";
            this.txtMotivoCancelamento.Size = new System.Drawing.Size(385, 47);
            this.txtMotivoCancelamento.TabIndex = 4;
            // 
            // txtClienteId
            // 
            this.txtClienteId.Enabled = false;
            this.txtClienteId.Location = new System.Drawing.Point(17, 29);
            this.txtClienteId.MaxLength = 100;
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(217, 20);
            this.txtClienteId.TabIndex = 1;
            this.txtClienteId.Visible = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(278, 32);
            this.txtQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(141, 20);
            this.txtQuantidade.TabIndex = 12;
            this.txtQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(423, 15);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(35, 13);
            this.labelPreco.TabIndex = 35;
            this.labelPreco.Text = "Preço";
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(275, 16);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(62, 13);
            this.labelQuantidade.TabIndex = 35;
            this.labelQuantidade.Text = "Quantidade";
            // 
            // cbxProdutoId
            // 
            this.cbxProdutoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProdutoId.FormattingEnabled = true;
            this.cbxProdutoId.Location = new System.Drawing.Point(9, 31);
            this.cbxProdutoId.Name = "cbxProdutoId";
            this.cbxProdutoId.Size = new System.Drawing.Size(262, 21);
            this.cbxProdutoId.TabIndex = 11;
            this.cbxProdutoId.SelectedIndexChanged += new System.EventHandler(this.cbxProdutoId_SelectedIndexChanged);
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
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(425, 33);
            this.txtPreco.MaxLength = 100;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(133, 20);
            this.txtPreco.TabIndex = 13;
            // 
            // dgvProdutoPedido
            // 
            this.dgvProdutoPedido.AllowUserToAddRows = false;
            this.dgvProdutoPedido.AllowUserToDeleteRows = false;
            this.dgvProdutoPedido.AllowUserToOrderColumns = true;
            this.dgvProdutoPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutoPedido.Location = new System.Drawing.Point(32, 322);
            this.dgvProdutoPedido.Name = "dgvProdutoPedido";
            this.dgvProdutoPedido.ReadOnly = true;
            this.dgvProdutoPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutoPedido.Size = new System.Drawing.Size(777, 115);
            this.dgvProdutoPedido.TabIndex = 57;
            this.dgvProdutoPedido.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvProdutoPedido_DataBindingComplete);
            // 
            // groupBoxItemListagem
            // 
            this.groupBoxItemListagem.Controls.Add(this.btnExcluirProduto);
            this.groupBoxItemListagem.Controls.Add(this.btnAdicionarProduto);
            this.groupBoxItemListagem.Controls.Add(this.txtPreco);
            this.groupBoxItemListagem.Controls.Add(this.txtQuantidade);
            this.groupBoxItemListagem.Controls.Add(this.labelPreco);
            this.groupBoxItemListagem.Controls.Add(this.cbxProdutoId);
            this.groupBoxItemListagem.Controls.Add(this.labelProduto);
            this.groupBoxItemListagem.Controls.Add(this.labelQuantidade);
            this.groupBoxItemListagem.Location = new System.Drawing.Point(23, 258);
            this.groupBoxItemListagem.Name = "groupBoxItemListagem";
            this.groupBoxItemListagem.Size = new System.Drawing.Size(794, 185);
            this.groupBoxItemListagem.TabIndex = 58;
            this.groupBoxItemListagem.TabStop = false;
            this.groupBoxItemListagem.Text = "Itens do Pedido";
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Location = new System.Drawing.Point(680, 32);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(108, 23);
            this.btnExcluirProduto.TabIndex = 16;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(564, 32);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(108, 23);
            this.btnAdicionarProduto.TabIndex = 14;
            this.btnAdicionarProduto.Text = "Adicionar";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(7, 169);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(77, 23);
            this.btnImprimir.TabIndex = 17;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Location = new System.Drawing.Point(727, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 253);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(7, 140);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // labelTotalBrutoItens
            // 
            this.labelTotalBrutoItens.AutoSize = true;
            this.labelTotalBrutoItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBrutoItens.Location = new System.Drawing.Point(20, 454);
            this.labelTotalBrutoItens.Name = "labelTotalBrutoItens";
            this.labelTotalBrutoItens.Size = new System.Drawing.Size(146, 16);
            this.labelTotalBrutoItens.TabIndex = 60;
            this.labelTotalBrutoItens.Text = "Total Bruto de Itens:";
            // 
            // labelResultadoTotalBrutoItens
            // 
            this.labelResultadoTotalBrutoItens.AutoSize = true;
            this.labelResultadoTotalBrutoItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultadoTotalBrutoItens.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelResultadoTotalBrutoItens.Location = new System.Drawing.Point(172, 454);
            this.labelResultadoTotalBrutoItens.Name = "labelResultadoTotalBrutoItens";
            this.labelResultadoTotalBrutoItens.Size = new System.Drawing.Size(58, 16);
            this.labelResultadoTotalBrutoItens.TabIndex = 61;
            this.labelResultadoTotalBrutoItens.Text = "R$ 0.00";
            // 
            // labelResultadoTotalDescontoItens
            // 
            this.labelResultadoTotalDescontoItens.AutoSize = true;
            this.labelResultadoTotalDescontoItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultadoTotalDescontoItens.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelResultadoTotalDescontoItens.Location = new System.Drawing.Point(431, 454);
            this.labelResultadoTotalDescontoItens.Name = "labelResultadoTotalDescontoItens";
            this.labelResultadoTotalDescontoItens.Size = new System.Drawing.Size(58, 16);
            this.labelResultadoTotalDescontoItens.TabIndex = 63;
            this.labelResultadoTotalDescontoItens.Text = "R$ 0.00";
            // 
            // labelTotalDescontoItens
            // 
            this.labelTotalDescontoItens.AutoSize = true;
            this.labelTotalDescontoItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDescontoItens.Location = new System.Drawing.Point(253, 454);
            this.labelTotalDescontoItens.Name = "labelTotalDescontoItens";
            this.labelTotalDescontoItens.Size = new System.Drawing.Size(172, 16);
            this.labelTotalDescontoItens.TabIndex = 62;
            this.labelTotalDescontoItens.Text = "Total Desconto (2.15%):";
            // 
            // labelTotalLiquido
            // 
            this.labelTotalLiquido.AutoSize = true;
            this.labelTotalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalLiquido.Location = new System.Drawing.Point(700, 454);
            this.labelTotalLiquido.Name = "labelTotalLiquido";
            this.labelTotalLiquido.Size = new System.Drawing.Size(47, 16);
            this.labelTotalLiquido.TabIndex = 62;
            this.labelTotalLiquido.Text = "Total:";
            // 
            // labelResultadoTotalLiquido
            // 
            this.labelResultadoTotalLiquido.AutoSize = true;
            this.labelResultadoTotalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultadoTotalLiquido.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelResultadoTotalLiquido.Location = new System.Drawing.Point(751, 454);
            this.labelResultadoTotalLiquido.Name = "labelResultadoTotalLiquido";
            this.labelResultadoTotalLiquido.Size = new System.Drawing.Size(58, 16);
            this.labelResultadoTotalLiquido.TabIndex = 63;
            this.labelResultadoTotalLiquido.Text = "R$ 0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(263, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "* a partir de 5 quentinhas";
            // 
            // labelTaxaEntrega
            // 
            this.labelTaxaEntrega.AutoSize = true;
            this.labelTaxaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaxaEntrega.Location = new System.Drawing.Point(496, 454);
            this.labelTaxaEntrega.Name = "labelTaxaEntrega";
            this.labelTaxaEntrega.Size = new System.Drawing.Size(126, 16);
            this.labelTaxaEntrega.TabIndex = 62;
            this.labelTaxaEntrega.Text = "Taxa de Entrega:";
            // 
            // labelResultadoTaxaEntrega
            // 
            this.labelResultadoTaxaEntrega.AutoSize = true;
            this.labelResultadoTaxaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultadoTaxaEntrega.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelResultadoTaxaEntrega.Location = new System.Drawing.Point(628, 454);
            this.labelResultadoTaxaEntrega.Name = "labelResultadoTaxaEntrega";
            this.labelResultadoTaxaEntrega.Size = new System.Drawing.Size(58, 16);
            this.labelResultadoTaxaEntrega.TabIndex = 63;
            this.labelResultadoTaxaEntrega.Text = "R$ 0.00";
            // 
            // FrmPedidosAdicionarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResultadoTaxaEntrega);
            this.Controls.Add(this.labelResultadoTotalLiquido);
            this.Controls.Add(this.labelResultadoTotalDescontoItens);
            this.Controls.Add(this.labelTaxaEntrega);
            this.Controls.Add(this.labelTotalLiquido);
            this.Controls.Add(this.labelTotalDescontoItens);
            this.Controls.Add(this.labelResultadoTotalBrutoItens);
            this.Controls.Add(this.labelTotalBrutoItens);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProdutoPedido);
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
            this.groupBoxDadosCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoPedido)).EndInit();
            this.groupBoxItemListagem.ResumeLayout(false);
            this.groupBoxItemListagem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBoxPedido;
        private System.Windows.Forms.TextBox txtMotivoCancelamento;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.ComboBox cbxProdutoId;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.DataGridView dgvProdutoPedido;
        private System.Windows.Forms.GroupBox groupBoxItemListagem;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBoxDadosCliente;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.RichTextBox rtxDadosCliente;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusPedidosAdicionarEditar;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Label labelTotalBrutoItens;
        private System.Windows.Forms.Label labelResultadoTotalBrutoItens;
        private System.Windows.Forms.Label labelResultadoTotalDescontoItens;
        private System.Windows.Forms.Label labelTotalDescontoItens;
        private System.Windows.Forms.Label labelTotalLiquido;
        private System.Windows.Forms.Label labelResultadoTotalLiquido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTaxaEntrega;
        private System.Windows.Forms.Label labelResultadoTaxaEntrega;
    }
}