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
    public partial class FrmClientesListagem : Form
    {
        public FrmClientesListagem()
        {
            InitializeComponent();
        }

        private void btnAdicionarNovoCliente_Click(object sender, EventArgs e)
        {
            FrmClientesAdicionarEditar frm = new FrmClientesAdicionarEditar(0);
            frm.ShowDialog();
        }
        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            
            FrmClientesAdicionarEditar frm = new FrmClientesAdicionarEditar(id);
            frm.ShowDialog();
        }

        private void btnAtualizarListagem_Click(object sender, EventArgs e)
        {
            listarClientes();
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
        private void listarClientes()
        {
            footerStatusClienteListagem.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = "SELECT * FROM cliente";

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
                mensagemErro("Erro ao listar cliente \n\n" + ex.Message);
                footerStatusClienteListagem.Text = "Erro.";
                statusStrip1.Refresh();
            }
        }

        private void FrmClientesListagem_Activated(object sender, EventArgs e)
        {
            listarClientes();
        }       
    }
}
