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
        private int id = 0;


        public FrmClientesAdicionarEditar(int id)
        {
            InitializeComponent();
            this.id = id;

            if (this.id > 0)
            {
                getCliente(id);
            }

            botoes();
        }

        /* Método responsavel por listar cliente pelo ID */
        private void getCliente(int id)
        {
            footerStatusClienteAdicionarEditar.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = "SELECT * FROM cliente WHERE id_cliente=" + id;

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        footerStatusClienteAdicionarEditar.Text = "Buscando dados do cliente.";
                        statusStrip1.Refresh();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    txtNome.Text = dr["nome"].ToString();
                                    txtTelefone.Text = dr["telefone"].ToString();
                                    txtEmail.Text = dr["email"].ToString();
                                    txtLogradouro.Text = dr["logradouro"].ToString();
                                    txtNumero.Text = dr["numero"].ToString();
                                    cbxBairro.Text = dr["bairro_id"].ToString();
                                    txtComplemento.Text = dr["complemento"].ToString();
                                    txtReferencia.Text = dr["ponto_referencia"].ToString();
                                    txtCidade.Text = dr["cidade"].ToString();
                                    txtUf.Text = dr["uf"].ToString();
                                    txtObservacao.Text = dr["observacao"].ToString();
                                }
                            }
                        }
                    }

                    footerStatusClienteAdicionarEditar.Text = "Pronto.";
                    statusStrip1.Refresh();
                }
            }
            catch (SqlException ex)
            {
                mensagemErro("Erro ao buscar cliente \n\n" + ex.Message);
                footerStatusClienteAdicionarEditar.Text = "Erro.";
                statusStrip1.Refresh();
            }
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
            if(this.id > 0)
            {
                this.btnSalvar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnExcluir.Enabled = true;
            }else{
                this.btnSalvar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnExcluir.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            this.Close();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            footerStatusClienteAdicionarEditar.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = @"
                        UPDATE cliente SET
                        nome=@nome, telefone=@telefone, email=@email, logradouro=@logradouro, 
                        numero=@numero, bairro_id=@bairro_id, complemento=@complemento, 
                        ponto_referencia=@ponto_referencia, cidade=@cidade, uf=@uf, observacao=@observacao,
                        data_edicao=@data_edicao
                        WHERE id_cliente=
                    "+this.id;

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
                        cmd.Parameters.AddWithValue("@data_edicao", dateTime);

                        cmd.ExecuteNonQuery();
                    }

                    footerStatusClienteAdicionarEditar.Text = "Pronto.";
                    statusStrip1.Refresh();
                    mensagemOk("Cliente atualizado com sucesso.");
                }
            }
            catch (SqlException ex)
            {
                mensagemErro("Erro ao atualizar cliente \n\n" + ex.Message);
                footerStatusClienteAdicionarEditar.Text = "Erro.";
                statusStrip1.Refresh();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            footerStatusClienteAdicionarEditar.Text = "Conectando, aguarde..."+ this.id;
            statusStrip1.Refresh();
            
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir o registro?", "Cantina Tio Billo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {

                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        var sql = @"
                            DELETE FROM cliente
                            WHERE id_cliente=@id
                        ";

                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            footerStatusClienteAdicionarEditar.Text = "Excluindo dados.";
                            statusStrip1.Refresh();

                            cmd.Parameters.AddWithValue("@id", this.id);

                            cmd.ExecuteNonQuery();
                        }

                        footerStatusClienteAdicionarEditar.Text = "Pronto.";
                        statusStrip1.Refresh();
                        mensagemOk("Cliente excluido com sucesso.");
                        limparCampos();
                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                mensagemErro("Erro ao excluir cliente \n\n" + ex.Message);
                footerStatusClienteAdicionarEditar.Text = "Erro.";
                statusStrip1.Refresh();
            }
        }
    }
}
