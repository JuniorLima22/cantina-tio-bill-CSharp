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
            var id = Convert.ToInt32(dgvListagemCliente.Rows[dgvListagemCliente.CurrentCell.RowIndex].Cells[0].Value);
            
            FrmClientesAdicionarEditar frm = new FrmClientesAdicionarEditar(id);
            frm.ShowDialog();
        }

        private void btnAtualizarListagem_Click(object sender, EventArgs e)
        {
            listarClientes();
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

                    var sql = @"
                        SELECT c.*, b.nome AS nome_bairro FROM cliente AS c
                        LEFT JOIN bairro AS b
                        ON c.bairro_id=b.id_bairro
                    ";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvListagemCliente.DataSource = dt;
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

        private void dgvListagemCliente_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvListagemCliente.Columns["id_cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListagemCliente.Columns["numero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListagemCliente.Columns["uf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn coluna in dgvListagemCliente.Columns)
            {
                switch (coluna.Name)
                {
                    case "id_cliente":
                        coluna.HeaderText = "Código";
                        coluna.Width = 50;
                        break;
                    case "nome":
                        coluna.HeaderText = "Cliente";
                        coluna.Width = 120;
                        break;
                    case "telefone":
                        coluna.HeaderText = "Telefone";
                        break;
                    case "email":
                        coluna.HeaderText = "E-mail";
                        coluna.Width = 120;
                        break;
                    case "logradouro":
                        coluna.HeaderText = "Endereço";
                        break;
                    case "numero":
                        coluna.HeaderText = "Nº";
                        coluna.Width = 60;
                        break;
                    case "nome_bairro":
                        coluna.HeaderText = "Bairro";
                        coluna.DisplayIndex = 6;
                        break;
                    case "complemento":
                        coluna.HeaderText = "Complemento";
                        break;
                    case "ponto_referencia":
                        coluna.HeaderText = "Ponto de Referência";
                        coluna.Width = 140;
                        break;
                    case "cidade":
                        coluna.HeaderText = "Cidade";
                        break;
                    case "uf":
                        coluna.HeaderText = "UF";
                        coluna.Width = 50;
                        break;
                    case "observacao":
                        coluna.HeaderText = "Observação";
                        coluna.Width = 180;
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
