﻿using System;
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
    public partial class FrmPedidosAdicionarEditar : Form
    {
        private int id_pedido = 0;

        public FrmPedidosAdicionarEditar(int id)
        {
            InitializeComponent();

            this.id_pedido = id;

            if (this.id_pedido > 0)
            {
                getPedido(this.id_pedido);
            }

            botoes();
            manipulaCampos();
        }

        private void FrmPedidosAdicionarEditar_Load(object sender, EventArgs e)
        {
            this.cbxStatus.SelectedIndex = 0;
            listarClientes();
        }

        /* Método responsavel por listar clientes */
        private void listarClientes()
        {
            footerStatusPedidosAdicionarEditar.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = "SELECT id_cliente, nome FROM cliente";

                    using (SqlCommand cm = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cm.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            DataRow linha = dt.NewRow();
                            linha["nome"] = "Selecione...";
                            dt.Rows.InsertAt(linha, 0);
                            cbxClienteId.DataSource = dt;
                            cbxClienteId.ValueMember = "id_cliente";
                            cbxClienteId.DisplayMember = "nome";
                        }
                    }

                    footerStatusPedidosAdicionarEditar.Text = "Pronto.";
                    statusStrip1.Refresh();
                }
            }
            catch (SqlException ex)
            {
                mensagemErro("Erro ao listar cliente \n\n" + ex.Message);
                footerStatusPedidosAdicionarEditar.Text = "Erro.";
                statusStrip1.Refresh();
            }
        }

        /* Método responsavel por listar cliente pelo ID */
        private void getCliente(int id)
        {
            footerStatusPedidosAdicionarEditar.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = @"
                        SELECT c.*, b.nome AS bairro_nome, b.taxa_entrega 
                        FROM cliente AS c
                        LEFT JOIN bairro AS b 
                        ON c.bairro_id=b.id_bairro
                        WHERE c.id_cliente=@id
                    ";

                    using (SqlCommand cm = new SqlCommand(sql, cn))
                    {
                        cm.Parameters.AddWithValue("@id", id);
                        SqlDataReader dr = cm.ExecuteReader();

                        if (dr.Read())
                        {                         
                            var texto = "";

                            texto += "Código do Cliente: " + dr["id_cliente"].ToString() + "\n";
                            texto += "Nome: " + dr["nome"].ToString() + "\n";
                            texto += "Telefone: " + dr["telefone"].ToString() + "\n";
                            texto += "Endereço: " + dr["logradouro"].ToString() + "\n";
                            texto += "Nº: " + dr["numero"].ToString() + "\n";
                            texto += "Bairro: " + dr["bairro_nome"].ToString() + "\n";
                            texto += "Taxa de Entrega: R$ " + dr["taxa_entrega"] + "\n";
                            texto += "Complemento: " + dr["complemento"].ToString() + "\n";
                            texto += "Referência: " + dr["ponto_referencia"].ToString() + "\n";
                            texto += "Cidade: " + dr["cidade"].ToString() + "\n";
                            texto += "UF: " + dr["uf"].ToString() + "\n";
                            texto += "Observação: " + dr["observacao"].ToString() + "\n";

                            rtxDadosCliente.Text = texto;
                            rtxDadosCliente.Enabled = true;
                        }
                    }

                    footerStatusPedidosAdicionarEditar.Text = "Pronto.";
                    statusStrip1.Refresh();
                }
            }
            catch (SqlException ex)
            {
                mensagemErro("Erro ao listar cliente \n\n" + ex.Message);
                footerStatusPedidosAdicionarEditar.Text = "Erro.";
                statusStrip1.Refresh();
            }
        }

        private void cbxClienteId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxClienteId.SelectedIndex != 0)
            {
                var id = Convert.ToInt32(cbxClienteId.SelectedValue);

                footerStatusPedidosAdicionarEditar.Text = "Debug: " + id.ToString();
                statusStrip1.Refresh();

                getCliente(id);
                this.btnSalvar.Enabled = true;
            }
            else
            {
                rtxDadosCliente.Text = "";
                this.btnSalvar.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            footerStatusPedidosAdicionarEditar.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = @"
                        INSERT INTO pedido 
                        (cliente_id, observacao, motivo_cancelamento, status, data_cadastro)
                        OUTPUT INSERTED.id_pedido
                        VALUES
                        (@cliente_id, @observacao, @motivo_cancelamento, @status, @data_cadastro)
                    ";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        footerStatusPedidosAdicionarEditar.Text = "Salvando dados.";
                        statusStrip1.Refresh();

                        var cliente_id = Convert.ToInt32(cbxClienteId.SelectedValue);
                        DateTime dateTime = DateTime.Now;

                        cmd.Parameters.AddWithValue("@cliente_id", cliente_id);
                        cmd.Parameters.AddWithValue("@observacao", txtObservacao.Text);
                        cmd.Parameters.AddWithValue("@status", cbxStatus.Text);
                        cmd.Parameters.AddWithValue("@motivo_cancelamento", txtMotivoCancelamento.Text);
                        cmd.Parameters.AddWithValue("@data_cadastro", dateTime);

                        int id_pedido = (int)cmd.ExecuteScalar();
                        this.id_pedido = id_pedido;
                        getPedido(id_pedido);
                        botoes();
                        manipulaCampos();
                    }

                    footerStatusPedidosAdicionarEditar.Text = "Pronto.";
                    statusStrip1.Refresh();
                    mensagemOk("Pedido cadastrado com sucesso.");
                }
            }
            catch (SqlException ex)
            {
                mensagemErro("Erro ao cadastrar pedido \n\n" + ex.Message);
                footerStatusPedidosAdicionarEditar.Text = "Erro.";
                statusStrip1.Refresh();
            }
        }

        /* Método responsavel por listar cliente pelo ID */
        private void getPedido(int id)
        {
            footerStatusPedidosAdicionarEditar.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = "SELECT * FROM pedido WHERE id_pedido=" + id;

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        footerStatusPedidosAdicionarEditar.Text = "Buscando dados do cliente.";
                        statusStrip1.Refresh();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    txtPedidoId.Text = dr["id_pedido"].ToString();
                                    cbxClienteId.Text = dr["cliente_id"].ToString();
                                    cbxStatus.Text = dr["status"].ToString();
                                    txtMotivoCancelamento.Text = dr["motivo_cancelamento"].ToString();
                                    txtObservacao.Text = dr["observacao"].ToString();
                                }
                            }
                        }
                    }

                    footerStatusPedidosAdicionarEditar.Text = "Pronto.";
                    statusStrip1.Refresh();
                }
            }
            catch (SqlException ex)
            {
                mensagemErro("Erro ao buscar cliente \n\n" + ex.Message);
                footerStatusPedidosAdicionarEditar.Text = "Erro.";
                statusStrip1.Refresh();
            }
        }

        /* Método responsavel por limpar campos */
        private void limparCampos()
        {
            this.txtPedidoId.Text = string.Empty;
            this.cbxClienteId.Text = string.Empty;
            this.cbxStatus.Text = string.Empty;
            this.txtMotivoCancelamento.Text = string.Empty;
            this.txtObservacao.Text = string.Empty;
            this.rtxDadosCliente.Text = string.Empty;
            this.cbxProdutoId.Text = string.Empty;
            this.txtQuantidade.Text = string.Empty;
            this.txtQuantidade.Text = string.Empty;
        }

        /* Método responsavel por habilitar e desabilitar botões */
        private void botoes()
        {
            if (this.id_pedido > 0)
            {
                this.btnSalvar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnExcluir.Enabled = true;

                this.btnAdicionarItem.Enabled = true;
                this.btnAtualizarListagem.Enabled = true;
                this.btnExcluirItem.Enabled = true;
            }
            else
            {
                this.btnSalvar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnExcluir.Enabled = false;

                this.btnAdicionarItem.Enabled = false;
                this.btnAtualizarListagem.Enabled = false;
                this.btnExcluirItem.Enabled = false;
            }
        }

        /* Método responsavel por habilitar e desabilitar campos */
        private void manipulaCampos()
        {
            if (this.id_pedido > 0)
            {
                this.cbxProdutoId.Enabled = true;
                this.txtQuantidade.Enabled = true;

            }
            else
            {
                this.cbxProdutoId.Enabled = false;
                this.txtQuantidade.Enabled = false;
            }
        }

        /* Método responsavel por exibir mensagem de sucesso */
        private void mensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "Cantina Tio Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* Método responsavel por exibir mensagem de erro */
        private void mensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Cantina Tio Bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
