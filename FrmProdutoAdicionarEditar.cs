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
    public partial class FrmProdutoAdicionarEditar : Form
    {
        private int id_produto = 0;
        string valor;

        public FrmProdutoAdicionarEditar(int id)
        {
            InitializeComponent();

            this.id_produto = id;
            cbxCategoria.SelectedIndex = 0;

            if (this.id_produto > 0)
            {
                getProduto(id);
            }

            botoes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {
                footerStatusProdutoAdicionarEditar.Text = "Conectando, aguarde...";
                statusStrip1.Refresh();

                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        var sql = @"
                        INSERT INTO produto 
                        (nome, descricao, categoria, preco, data_cadastro) 
                        VALUES
                        (@nome, @descricao, @categoria, @preco, @data_cadastro)
                    ";

                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            footerStatusProdutoAdicionarEditar.Text = "Salvando dados.";
                            statusStrip1.Refresh();

                            DateTime dateTime = DateTime.Now;

                            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                            cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                            cmd.Parameters.AddWithValue("@categoria", cbxCategoria.Text);
                            cmd.Parameters.AddWithValue("@preco", Convert.ToDouble(this.valor));
                            cmd.Parameters.AddWithValue("@data_cadastro", dateTime);

                            cmd.ExecuteNonQuery();
                        }

                        footerStatusProdutoAdicionarEditar.Text = "Pronto.";
                        statusStrip1.Refresh();
                        limparCampos();
                        resetaLabel();
                        mensagemOk("Produto cadastrado com sucesso.");
                    }
                }
                catch (SqlException ex)
                {
                    mensagemErro("Erro ao cadastrar produto \n\n" + ex.Message);
                    footerStatusProdutoAdicionarEditar.Text = "Erro.";
                    statusStrip1.Refresh();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {
                footerStatusProdutoAdicionarEditar.Text = "Conectando, aguarde...";
                statusStrip1.Refresh();

                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        var sql = @"
                            UPDATE produto SET
                            nome=@nome, descricao=@descricao, categoria=@categoria, preco=@preco, data_edicao=@data_edicao
                            WHERE id_produto=
                        " + this.id_produto;

                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            footerStatusProdutoAdicionarEditar.Text = "Salvando dados do produto.";
                            statusStrip1.Refresh();

                            DateTime dateTime = DateTime.Now;

                            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                            cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                            cmd.Parameters.AddWithValue("@categoria", cbxCategoria.Text);
                            cmd.Parameters.AddWithValue("@preco", Convert.ToDouble(this.valor));
                            cmd.Parameters.AddWithValue("@data_edicao", dateTime);

                            cmd.ExecuteNonQuery();
                        }

                        footerStatusProdutoAdicionarEditar.Text = "Pronto.";
                        statusStrip1.Refresh();
                        mensagemOk("Produto atualizado com sucesso.");
                    }
                }
                catch (SqlException ex)
                {
                    mensagemErro("Erro ao atualizar bairro \n\n" + ex.Message);
                    footerStatusProdutoAdicionarEditar.Text = "Erro.";
                    statusStrip1.Refresh();
                }
            }
        }

        /* Método responsavel por listar produto pelo ID */
        private void getProduto(int id)
        {
            footerStatusProdutoAdicionarEditar.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = "SELECT * FROM produto WHERE id_produto=" + id;

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        footerStatusProdutoAdicionarEditar.Text = "Buscando dados do produto.";
                        statusStrip1.Refresh();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    txtProdutoId.Text = dr["id_produto"].ToString();
                                    txtNome.Text = dr["nome"].ToString();
                                    txtPreco.Text = dr["preco"].ToString();
                                    txtDescricao.Text = dr["descricao"].ToString();

                                    int cbx_categoria = cbxCategoria.FindString(dr["categoria"].ToString());
                                    cbxCategoria.SelectedIndex = Convert.ToInt32(cbx_categoria);

                                    this.valor = dr["preco"].ToString();
                                }
                            }
                        }
                    }

                    footerStatusProdutoAdicionarEditar.Text = "Pronto.";
                    statusStrip1.Refresh();
                }
            }
            catch (SqlException ex)
            {
                mensagemErro("Erro ao buscar produto \n\n" + ex.Message);
                footerStatusProdutoAdicionarEditar.Text = "Erro.";
                statusStrip1.Refresh();
            }
        }

        /* Método responsavel por validar campos requiridos */
        private Boolean validaDados()
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text))
            {
                labelProduto.ForeColor = Color.Red;
                mensagemErro("Campo Produto deve ser preenchido");
                return false;
            }
            if (String.IsNullOrEmpty(cbxCategoria.Text) || cbxCategoria.Text == "Selecione...")
            {
                labelCategoria.ForeColor = Color.Red;
                mensagemErro("Campo Categoria deve ser selecionado");
                return false;
            }
            if (txtPreco.Text == "0" || txtPreco.Text == "R$ 0,00")
            {
                labelPreco.ForeColor = Color.Red;
                mensagemErro("Campo Preço deve ser preenchido");
                return false;
            }

            return true;
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

        /* Método responsavel por limpar campos */
        private void limparCampos()
        {
            txtProdutoId.Text = string.Empty;
            txtNome.Text = string.Empty;
            cbxCategoria.SelectedIndex = 0;
            txtPreco.Text = string.Empty;
            txtDescricao.Text = string.Empty;
        }

        /* Método responsavel por setar cor da fonte do label */
        private void resetaLabel()
        {
            labelProduto.ForeColor = Color.Black;
            labelCategoria.ForeColor = Color.Black;
            labelPreco.ForeColor = Color.Black;
        }

        /* Método responsavel por habilitar e desabilitar botões */
        private void botoes()
        {
            if (this.id_produto > 0)
            {
                this.btnSalvar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnExcluir.Enabled = true;
            }
            else
            {
                this.btnSalvar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnExcluir.Enabled = false;
            }
        }

        /* Método responsavel por formatar em Moeda campo TextBox */
        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtPreco.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        /* Método responsavel por formatar em Moeda campo TextBox */
        private void txtPreco_Leave(object sender, EventArgs e)
        {
            valor = txtPreco.Text.Replace("R$", "");
            txtPreco.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        /* Método responsavel por formatar em Moeda campo TextBox */
        private void txtPreco_KeyUp(object sender, KeyEventArgs e)
        {
            valor = txtPreco.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtPreco.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txtPreco.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtPreco.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtPreco.Text.StartsWith("0,"))
                {
                    txtPreco.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtPreco.Text.Contains("00,"))
                {
                    txtPreco.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtPreco.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtPreco.Text;
            txtPreco.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtPreco.Select(txtPreco.Text.Length, 0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            this.Close();
        }
    }
}
