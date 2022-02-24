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
    public partial class FrmProdutosListagem : Form
    {
        public FrmProdutosListagem()
        {
            InitializeComponent();
        }

        private void FrmProdutosListagem_Activated(object sender, EventArgs e)
        {
            listarProdutos();
        }

        /* Método responsavel por listar produtos */
        private void listarProdutos()
        {
            footerStatusProdutoListagem.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = @"SELECT *
                        FROM produto
                    ";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvListagemProdutos.DataSource = dt;
                        }
                    }

                    footerStatusProdutoListagem.Text = "Pronto.";
                    statusStrip1.Refresh();
                }
            }
            catch (SqlException ex)
            {
                mensagemErro("Erro ao listar produto \n\n" + ex.Message);
                footerStatusProdutoListagem.Text = "Erro.";
                statusStrip1.Refresh();
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

        private void dgvListagemProdutos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvListagemProdutos.Columns["id_produto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListagemProdutos.Columns["preco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn coluna in dgvListagemProdutos.Columns)
            {
                switch (coluna.Name)
                {
                    case "id_produto":
                        coluna.HeaderText = "Código";
                        coluna.Width = 50;
                        break;
                    case "nome":
                        coluna.HeaderText = "Produto";
                        coluna.Width = 180;
                        break;
                    case "descricao":
                        coluna.HeaderText = "Descrição";
                        coluna.Width = 180;
                        break;
                    case "categoria":
                        coluna.HeaderText = "Categoria";
                        break;
                    case "preco":
                        coluna.HeaderText = "Preço";
                        coluna.Width = 70;
                        coluna.DefaultCellStyle.Format = "C2";
                        break;
                    case "data_cadastro":
                        coluna.HeaderText = "Data de Cadastro";
                        break;
                    case "data_edicao":
                        coluna.HeaderText = "Data de Edição";
                        break;
                    default:
                        coluna.Visible = false;
                        break;
                }
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            FrmProdutoAdicionarEditar frm = new FrmProdutoAdicionarEditar(0);
            frm.ShowDialog();
        }
    }
}
