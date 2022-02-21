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
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void bntTesteDB_Click(object sender, EventArgs e)
        {
            footerStatusLabel.Text = "Conectando, aguarde...";
            statusStrip1.Refresh();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    MessageBox.Show("Conectado ao Banco de Dados com sucesso.");
                    footerStatusLabel.Text = "Conectado.";
                    statusStrip1.Refresh();
                }
            }catch (SqlException ex)
            {
                footerStatusLabel.Text = "Falha.";
                statusStrip1.Refresh();
                MessageBox.Show("Falha ao conectar ao Banco de Dados\n\n" + ex.Message); 
            }
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            footerStatusLabel.Text = "";
        }
    }
}
