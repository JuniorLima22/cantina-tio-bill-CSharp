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
    public partial class FrmBairroAdicionarEditar : Form
    {
        private int id;
        string valor;

        public FrmBairroAdicionarEditar(int id)
        {
            InitializeComponent();

            this.id = id;

            if (this.id > 0)
            {
                //getBairro(id);
            }

            botoes();
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
            this.txtNome.Text = string.Empty;
            this.txtTaxaEntrega.Text = string.Empty;
        }

        /* Método responsavel por habilitar e desabilitar botões */
        private void botoes()
        {
            if (this.id > 0)
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
        private void txtTaxaEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtTaxaEntrega.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        /* Método responsavel por formatar em Moeda campo TextBox */
        private void txtTaxaEntrega_Leave(object sender, EventArgs e)
        {
            valor = txtTaxaEntrega.Text.Replace("R$", "");
            txtTaxaEntrega.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        /* Método responsavel por formatar em Moeda campo TextBox */
        private void txtTaxaEntrega_KeyUp(object sender, KeyEventArgs e)
        {
            valor = txtTaxaEntrega.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtTaxaEntrega.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txtTaxaEntrega.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtTaxaEntrega.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtTaxaEntrega.Text.StartsWith("0,"))
                {
                    txtTaxaEntrega.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtTaxaEntrega.Text.Contains("00,"))
                {
                    txtTaxaEntrega.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtTaxaEntrega.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtTaxaEntrega.Text;
            txtTaxaEntrega.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtTaxaEntrega.Select(txtTaxaEntrega.Text.Length, 0);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            footerStatusBairroAdicionarEditar.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();

            //mensagemOk(txtTaxaEntrega.Text + " - " + this.valor);
            
            
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = @"
                        INSERT INTO bairro 
                        (nome, taxa_entrega) 
                        VALUES
                        (@nome, @taxa_entrega)
                    ";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        footerStatusBairroAdicionarEditar.Text = "Salvando dados.";
                        statusStrip1.Refresh();

                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@taxa_entrega", Convert.ToDouble(this.valor));

                        cmd.ExecuteNonQuery();
                    }

                    footerStatusBairroAdicionarEditar.Text = "Pronto.";
                    statusStrip1.Refresh();
                    limparCampos();
                    mensagemOk("Bairro cadastrado com sucesso.");
                }
            }
            catch (SqlException ex)
            {
                mensagemErro("Erro ao cadastrar bairro \n\n" + ex.Message);
                footerStatusBairroAdicionarEditar.Text = "Erro.";
                statusStrip1.Refresh();
            }
        }
    }
}
