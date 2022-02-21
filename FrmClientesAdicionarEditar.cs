using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cantina_tio_bill_CSharp
{
    public partial class FrmClientesAdicionarEditar : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;

        public FrmClientesAdicionarEditar()
        {
            InitializeComponent();
        }

        /* Método responsavel por exibir mensagem de sucesso */
        private void mensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem,"Cantina Tio Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* Método responsavel por exibir mensagem de erro */
        private void mensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Cantina Tio Bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /* Método responsavel por limpar campos */
        private void limparCampos()
        {
            this.txtNome.Text = string.Empty;
            this.txtTelefone.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtLogradouro.Text = string.Empty;
            this.txtNumero.Text = string.Empty;
            this.cbxBairro.Text = string.Empty;
            this.txtComplemento.Text = string.Empty;
            this.txtReferencia.Text = string.Empty;
            this.txtCidade.Text = string.Empty;
            this.txtUf.Text = string.Empty;
            this.txtObservacao.Text = string.Empty;
        }

        /* Método responsavel por habilitar e desabilitar botões */
        private void botoes()
        {
            if(this.eNovo || this.eEditar)
            {
                this.btnSalvar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
                this.btnExcluir.Enabled = false;
            }else{
                this.btnSalvar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
                this.btnExcluir.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            footerStatusClienteAdicionarEditar.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = @"
                        INSERT INTO cliente 
                        (nome, telefone, email, logradouro, numero, bairro_id, complemento, ponto_referencia, cidade, uf, observacao, data_cadastro) 
                        VALUES
                        (@nome, @telefone, @email, @logradouro, @numero, @bairro_id, @complemento, @ponto_referencia, @cidade, @uf, @observacao, @data_cadastro)
                    ";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        footerStatusClienteAdicionarEditar.Text = "Salvando dados.";
                        statusStrip1.Refresh();

                        var bairro_id = 5;

                        DateTime dateTime = DateTime.Now;

                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@logradouro", txtLogradouro.Text);
                        cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                        cmd.Parameters.AddWithValue("@bairro_id", bairro_id);
                        cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                        cmd.Parameters.AddWithValue("@ponto_referencia", txtReferencia.Text);
                        cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                        cmd.Parameters.AddWithValue("@uf", txtUf.Text);
                        cmd.Parameters.AddWithValue("@observacao", txtObservacao.Text);
                        cmd.Parameters.AddWithValue("@data_cadastro", dateTime);

                        cmd.ExecuteNonQuery();
                    }

                    footerStatusClienteAdicionarEditar.Text = "Pronto.";
                    statusStrip1.Refresh();
                    limparCampos();
                    mensagemOk("Cliente cadastrado com sucesso.");
                }
            }
            catch (SqlException ex)
            {
                mensagemErro("Erro ao cadastrar cliente \n\n" + ex.Message);
                footerStatusClienteAdicionarEditar.Text = "Erro.";
                statusStrip1.Refresh();
            }
        }
    }
}
