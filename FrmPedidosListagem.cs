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

                    var sql = "SELECT * FROM pedido";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
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

        private void frmPedido_Load(object sender, EventArgs e)
        {
            listarPedidos();
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
    }
}
