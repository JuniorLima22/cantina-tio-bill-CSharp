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
    public partial class FrmBairroListagem : Form
    {
        public FrmBairroListagem()
        {
            InitializeComponent();
        }

        private void btnAtualizarListagem_Click(object sender, EventArgs e)
        {
            listarBairros();
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

        /* Método responsavel por listar clientes */
        private void listarBairros()
        {
            footerStatusClienteListagem.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = @"SELECT 
                        id_bairro AS 'Codigo',
                        nome AS 'Nome',
                        taxa_entrega AS 'Taxa de Entrega'
                        FROM bairro
                    ";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }

                    footerStatusClienteListagem.Text = "Pronto.";
                    statusStrip1.Refresh();
                }
            }
            catch (SqlException ex)
            {
                mensagemErro("Erro ao listar bairro \n\n" + ex.Message);
                footerStatusClienteListagem.Text = "Erro.";
                statusStrip1.Refresh();
            }
        }

        private void FrmBairroListagem_Activated(object sender, EventArgs e)
        {
            listarBairros();
        }

        private void btnAdicionarNovoCliente_Click(object sender, EventArgs e)
        {
            FrmBairroAdicionarEditar frm = new FrmBairroAdicionarEditar(0);
            frm.ShowDialog();
        }
    }
}
