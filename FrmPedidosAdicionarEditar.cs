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
    public partial class FrmPedidosAdicionarEditar : Form
    {
        public FrmPedidosAdicionarEditar()
        {
            InitializeComponent();
        }

        private void FrmPedidosAdicionarEditar_Load(object sender, EventArgs e)
        {
            this.cbxStatus.SelectedIndex = 0;
            listarClientes();
        }

        /* Método responsavel por listar clientes */
        private void listarClientes()
        {
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
                }
            }
            catch (SqlException ex)
            {
                mensagemErro("Erro ao listar cliente \n\n" + ex.Message);
            }
        }

        /* Método responsavel por listar cliente pelo ID */
        private void getCliente(int id)
        {
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
                }
            }
            catch (SqlException ex)
            {
                mensagemErro("Erro ao listar cliente \n\n" + ex.Message);
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

        private void cbxClienteId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Não é possível converter um objeto do tipo 'System.Data.DataRowView' no tipo 'System.IConvertible'.
            //var id = Convert.ToInt32(cbxClienteId.SelectedValue);

            //mensagemOk(cbxClienteId.SelectedIndex.ToString());
            if (cbxClienteId.SelectedIndex != 0)
            {
                var id = Convert.ToInt32(cbxClienteId.SelectedValue);

                footerStatusPedidosAdicionarEditar.Text = "Debug: " + id.ToString();
                statusStrip1.Refresh();

                getCliente(id);
            }
            else
            {
                rtxDadosCliente.Text = "";
            }
        }
    }
}
