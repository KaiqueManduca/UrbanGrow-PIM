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
    public partial class Estoque : Form {

        string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=kaique8523;Database=urbangrow;";
        string strSql;
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=kaique8523;Database=urbangrow;");




        public Estoque() {
            InitializeComponent();
            tabEstoque.DataSource = List();
            tabEstoque.Columns["id_fornecedor"].Visible = false;
        }


        public System.Data.DataTable List() {
            string query = "SELECT * FROM produto";
            NpgsqlCommand c2 = new NpgsqlCommand(query, conn);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

            System.Data.DataTable table = new System.Data.DataTable();
            da.Fill(table);
            return table;
        }



        private void lblName_Click(object sender, EventArgs e) {
            strSql = "select * from produto;";


        }

        private void tabEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnAtt_Click(object sender, EventArgs e) {
            tabEstoque.DataSource = List();
        }

        private void btnInserir_Click(object sender, EventArgs e) {
            strSql = "INSERT INTO produto (nome, descricao, valor, estoque) VALUES (@nome, @descricao, @valor, @estoque)";

            using (var conn = new NpgsqlConnection(connectionString)) {
                try {
                    conn.Open();

                    using (var comando = new NpgsqlCommand(strSql, conn)) {
                        comando.Parameters.AddWithValue("@nome", txtNome.Text);
                        comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                        comando.Parameters.AddWithValue("@valor", Convert.ToSingle(txtValor.Text));
                        comando.Parameters.AddWithValue("@estoque", Convert.ToInt32(txtEstoque.Text));


                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Produto adicionado com sucesso!");
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e) {
            strSql = "update produto set nome=@nome, descricao=@descricao, valor=@valor, estoque=@estoque where id_produto = @txtBuscarID";
            var conn = new NpgsqlConnection(connectionString);
            NpgsqlCommand comando = new NpgsqlCommand(strSql, conn);

            comando.Parameters.Add("@txtBuscarID", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(txtBuscarID.Text);

            comando.Parameters.AddWithValue("@nome", txtNome.Text);
            comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);
            comando.Parameters.AddWithValue("@valor", Convert.ToSingle(txtValor.Text));
            comando.Parameters.AddWithValue("@estoque", Convert.ToInt32(txtEstoque.Text));

            try {
                conn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto atualizado com sucesso!");
                //clear text boxes
                foreach (var controle in this.Controls) {
                    if (controle is TextBox) {
                        ((TextBox)controle).Clear();
                    }
                }
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
            finally {
                conn.Close();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            strSql = "select * from produto where id_produto=@id";
            var conn = new NpgsqlConnection(connectionString);
            NpgsqlCommand comando = new NpgsqlCommand(strSql, conn);

            comando.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(txtBuscarID.Text);

            try {
                if (txtBuscarID.Text == string.Empty) {
                    throw new Exception("Você precisa digitar um ID!");
                }
                conn.Open();

                NpgsqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false) {
                    throw new Exception("ID não cadastrado!");
                }
                dr.Read();

                txtBuscarID.Text = Convert.ToString(dr["id_produto"]);
                txtNome.Text = Convert.ToString(dr["nome"]);
                txtDescricao.Text = Convert.ToString(dr["descricao"]);
                txtValor.Text = Convert.ToString(dr["valor"]);
                txtEstoque.Text = Convert.ToString(dr["estoque"]);


            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

            finally { conn.Close(); }
        }

        private void btnDeletar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Deseja realmente excluir este produto?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) {
                MessageBox.Show("Operação cancelada!");
            }
            else {
                strSql = "delete from produto where id_produto=@id";
                var conn = new NpgsqlConnection(connectionString);
                NpgsqlCommand comando = new NpgsqlCommand(strSql, conn);

                comando.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(txtBuscarID.Text);

                try {
                    conn.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Produto deletado com sucesso!");
                    //clear text boxes
                    foreach (var controle in this.Controls) {
                        if (controle is TextBox) {
                            ((TextBox)controle).Clear();
                        }
                    }


                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
        }
    }
}
