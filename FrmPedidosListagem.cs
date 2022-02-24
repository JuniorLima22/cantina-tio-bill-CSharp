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
    public partial class frmPedidosListagem : Form
    {
        public frmPedidosListagem()
        {
            InitializeComponent();
        }

        /* Método responsavel por listar pedidos */
        private void listarPedidos()
        {
            footerStatusPedidoListagem.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = @"
                        SELECT p.*, c.*, b.nome AS nome_bairro FROM pedido AS p
                        LEFT JOIN cliente AS c
                        ON p.cliente_id=c.id_cliente
                        LEFT JOIN bairro AS b
                        ON c.bairro_id=b.id_bairro
                    ";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvListagemPedidos.DataSource = dt;
                        }
                    }

                    footerStatusPedidoListagem.Text = "Pronto.";
                    statusStrip1.Refresh();
                }
            }
            catch (SqlException ex)
            {
                mensagemErro("Erro ao listar pedidos \n\n" + ex.Message);
                footerStatusPedidoListagem.Text = "Erro.";
                statusStrip1.Refresh();
            }
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientesListagem frm = new FrmClientesListagem();
            frm.ShowDialog();
        }

        private void cadastroDeBairroETaxaDeEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBairroListagem frm = new FrmBairroListagem();
            frm.ShowDialog();
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

        private void btnAdicionarPedido_Click(object sender, EventArgs e)
        {
            FrmPedidosAdicionarEditar frm = new FrmPedidosAdicionarEditar(0);
            frm.ShowDialog();
        }

        private void bntAtualizarListagem_Click(object sender, EventArgs e)
        {
            listarPedidos();
        }

        private void btnAlterarPedido_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvListagemPedidos.Rows[dgvListagemPedidos.CurrentCell.RowIndex].Cells[0].Value);

            FrmPedidosAdicionarEditar frm = new FrmPedidosAdicionarEditar(id);
            frm.ShowDialog();
        }

        private void frmPedidosListagem_Activated(object sender, EventArgs e)
        {
            listarPedidos();
        }

        private void dgvListagemPedidos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvListagemPedidos.Columns["id_pedido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListagemPedidos.Columns["status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn coluna in dgvListagemPedidos.Columns)
            {
                switch (coluna.Name)
                {
                    case "id_pedido":
                        coluna.HeaderText = "Código";
                        coluna.Width = 50;
                        break;
                    case "nome":
                        coluna.HeaderText = "Cliente";
                        coluna.Width = 120;
                        coluna.DisplayIndex = 1;
                        break;
                    case "telefone":
                        coluna.HeaderText = "Telefone";
                        //coluna.Width = 120;
                        coluna.DisplayIndex = 2;
                        break;
                    case "nome_bairro":
                        coluna.HeaderText = "Bairro";
                        coluna.DisplayIndex = 3;
                        break;
                    case "observacao":
                        coluna.HeaderText = "Observação";
                        coluna.Width = 180;
                        //coluna.DisplayIndex = 2;
                        break;
                    case "status":
                        coluna.HeaderText = "Status";
                        coluna.Width = 65;
                        //coluna.DisplayIndex = 1;
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
    }
}
