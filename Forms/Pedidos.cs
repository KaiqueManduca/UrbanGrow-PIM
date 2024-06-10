using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrbanGrow.Forms {
    public partial class Pedidos : Form {

        string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=kaique8523;Database=urbangrow;";
        string strSql;
        string strSql2;
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=kaique8523;Database=urbangrow;");

        public Pedidos() {
            InitializeComponent();
            tabProdutos.DataSource = List();
            tabProdutos.Columns["id_fornecedor"].Visible = false;
        }

        public System.Data.DataTable List() {
            string query = "SELECT * FROM produto";
            NpgsqlCommand c2 = new NpgsqlCommand(query, conn);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

            System.Data.DataTable table = new System.Data.DataTable();
            da.Fill(table);
            return table;
        }

        private void btnComprar_Click(object sender, EventArgs e) {
            strSql = "insert into itensvenda(id_produto, qnt_vendida) values (@id_produto, @qnt_vendida)";
            
            string nomeproduto;
            using (var conn = new NpgsqlConnection(connectionString)) {
                try {
                    conn.Open();

                    using (var comando = new NpgsqlCommand(strSql, conn)) {
                        comando.Parameters.AddWithValue("@id_produto", Convert.ToInt32(txtId.Text));
                        comando.Parameters.AddWithValue("@qnt_vendida", Convert.ToInt32(txtQnt.Text));
                        

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Produto(s) comprado(s) com sucesso!");
                    MessageBox.Show("Compareça na loja para retirada da sua compra. Apresente o comprovante que foi enviado ao seu email.", "Sucesso na compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAtt_Click(object sender, EventArgs e) {
            tabProdutos.DataSource = List();

        }
    }
}
