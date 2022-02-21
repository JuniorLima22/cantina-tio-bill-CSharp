namespace cantina_tio_bill_CSharp
{
    partial class FrmClientesAdicionarEditar
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
            this.labelNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLogradouro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.cbxBairro = new System.Windows.Forms.ComboBox();
            this.labelUf = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.labelReferencia = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.labelObservacao = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.footerStatusClienteAdicionarEditar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(70, 15);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(73, 31);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(439, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(268, 91);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(70, 66);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(49, 13);
            this.labelTelefone.TabIndex = 2;
            this.labelTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(73, 91);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(165, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(265, 66);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "E-mail";
            // 
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Location = new System.Drawing.Point(70, 124);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(53, 13);
            this.labelLogradouro.TabIndex = 7;
            this.labelLogradouro.Text = "Endereço";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(73, 140);
            this.txtLogradouro.MaxLength = 100;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(165, 20);
            this.txtLogradouro.TabIndex = 6;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(265, 124);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(19, 13);
            this.labelNumero.TabIndex = 9;
            this.labelNumero.Text = "Nº";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(268, 140);
            this.txtNumero.MaxLength = 50;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(68, 20);
            this.txtNumero.TabIndex = 8;
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Location = new System.Drawing.Point(265, 174);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(71, 13);
            this.labelComplemento.TabIndex = 13;
            this.labelComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(268, 191);
            this.txtComplemento.MaxLength = 50;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(243, 20);
            this.txtComplemento.TabIndex = 12;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(71, 174);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(34, 13);
            this.labelBairro.TabIndex = 11;
            this.labelBairro.Text = "Bairro";
            // 
            // cbxBairro
            // 
            this.cbxBairro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBairro.FormattingEnabled = true;
            this.cbxBairro.Items.AddRange(new object[] {
            "teste1",
            "teste2",
            "teste3"});
            this.cbxBairro.Location = new System.Drawing.Point(73, 190);
            this.cbxBairro.Name = "cbxBairro";
            this.cbxBairro.Size = new System.Drawing.Size(165, 21);
            this.cbxBairro.TabIndex = 14;
            // 
            // labelUf
            // 
            this.labelUf.AutoSize = true;
            this.labelUf.Location = new System.Drawing.Point(264, 266);
            this.labelUf.Name = "labelUf";
            this.labelUf.Size = new System.Drawing.Size(21, 13);
            this.labelUf.TabIndex = 18;
            this.labelUf.Text = "UF";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(267, 282);
            this.txtUf.MaxLength = 2;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(68, 20);
            this.txtUf.TabIndex = 17;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(69, 266);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(40, 13);
            this.labelCidade.TabIndex = 16;
            this.labelCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(72, 282);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(165, 20);
            this.txtCidade.TabIndex = 15;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(73, 237);
            this.txtReferencia.MaxLength = 100;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(439, 20);
            this.txtReferencia.TabIndex = 20;
            // 
            // labelReferencia
            // 
            this.labelReferencia.AutoSize = true;
            this.labelReferencia.Location = new System.Drawing.Point(70, 221);
            this.labelReferencia.Name = "labelReferencia";
            this.labelReferencia.Size = new System.Drawing.Size(105, 13);
            this.labelReferencia.TabIndex = 19;
            this.labelReferencia.Text = "Ponto de Referência";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(72, 328);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(439, 52);
            this.txtObservacao.TabIndex = 22;
            // 
            // labelObservacao
            // 
            this.labelObservacao.AutoSize = true;
            this.labelObservacao.Location = new System.Drawing.Point(69, 312);
            this.labelObservacao.Name = "labelObservacao";
            this.labelObservacao.Size = new System.Drawing.Size(65, 13);
            this.labelObservacao.TabIndex = 21;
            this.labelObservacao.Text = "Observação";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.footerStatusClienteAdicionarEditar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(565, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // footerStatusClienteAdicionarEditar
            // 
            this.footerStatusClienteAdicionarEditar.Name = "footerStatusClienteAdicionarEditar";
            this.footerStatusClienteAdicionarEditar.Size = new System.Drawing.Size(0, 17);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(118, 398);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(209, 398);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(303, 398);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(392, 398);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 27;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // FrmClientesAdicionarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.labelObservacao);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.labelReferencia);
            this.Controls.Add(this.labelUf);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.cbxBairro);
            this.Controls.Add(this.labelComplemento);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.labelLogradouro);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelNome);
            this.Name = "FrmClientesAdicionarEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLogradouro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label labelComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.ComboBox cbxBairro;
        private System.Windows.Forms.Label labelUf;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label labelReferencia;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label labelObservacao;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel footerStatusClienteAdicionarEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
    }
}