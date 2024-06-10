using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrbanGrow;

namespace UrbanGrow.Forms {
    public partial class Fornecedores : Form {

        string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=kaique8523;Database=urbangrow;";
        string strSql;
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=kaique8523;Database=urbangrow;");


        
        public Fornecedores() {


            InitializeComponent();
            tabFornecedor.DataSource = List();


        }

        public System.Data.DataTable List() {
            string query = "SELECT * FROM fornecedor";
            NpgsqlCommand c2 = new NpgsqlCommand(query, con);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

            System.Data.DataTable table = new System.Data.DataTable();
            da.Fill(table);
            return table;
        }

        

        



        private void label5_Click(object sender, EventArgs e) {

        }


        private void btnExibir_Click(object sender, EventArgs e) {

        }


        private void btnAtualizar_Click(object sender, EventArgs e) {
            strSql = "update fornecedor set nome=@nome, email=@email, endereco=@endereco, cnpj=@cnpj, produto=@produto where id = @txtBuscarID";
            var conn = new NpgsqlConnection(connectionString);
            NpgsqlCommand comando = new NpgsqlCommand(strSql, conn);

            comando.Parameters.Add("@txtBuscarID", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(txtBuscarID.Text);

            comando.Parameters.AddWithValue("@nome", txtNome.Text);
            comando.Parameters.AddWithValue("@email", txtEmail.Text);
            comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            comando.Parameters.AddWithValue("@cnpj", txtCnpj.Text);
            comando.Parameters.AddWithValue("@produto", txtProduto.Text);

            try {
                conn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro atualizado com sucesso!");
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




        private void btnInserir_Click(object sender, EventArgs e) {
            Globals.IsCnpj(txtCnpj.Text);
            if (!Globals.IsCnpj(txtCnpj.Text)) {
                // Limpar campos
                foreach (var controle in this.Controls) {
                    if (controle is TextBox) {
                        ((TextBox)controle).Clear();
                    }
                }
                //
                return;
            }

            strSql = "INSERT INTO fornecedor (nome, email, endereco, cnpj, produto) VALUES (@nome, @email, @endereco, @cnpj, @produto)";

            using (var conn = new NpgsqlConnection(connectionString)) {
                try {
                    conn.Open();

                    using (var comando = new NpgsqlCommand(strSql, conn)) {
                        
                        comando.Parameters.AddWithValue("@nome", txtNome.Text);
                        comando.Parameters.AddWithValue("@email", txtEmail.Text);
                        comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        comando.Parameters.AddWithValue("@cnpj", txtCnpj.Text);
                        comando.Parameters.AddWithValue("@produto", txtProduto.Text);

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            } // A conexão será automaticamente fechada aqui
        }



        private void btnBuscar_Click(object sender, EventArgs e) {
            strSql = "select * from fornecedor where id=@id";
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

                txtBuscarID.Text = Convert.ToString(dr["id"]);
                txtNome.Text = Convert.ToString(dr["nome"]);
                txtEmail.Text = Convert.ToString(dr["email"]);
                txtEndereco.Text = Convert.ToString(dr["endereco"]);
                txtCnpj.Text = Convert.ToString(dr["cnpj"]);
                txtProduto.Text = Convert.ToString(dr["produto"]);

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

            finally { conn.Close(); }



        }

        private void btnDeletar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Deseja realmente excluir este fornecedor?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) {
                MessageBox.Show("Operação cancelada!");
            }
            else {
                strSql = "delete from fornecedor where id=@id";
                var conn = new NpgsqlConnection(connectionString);
                NpgsqlCommand comando = new NpgsqlCommand(strSql, conn);

                comando.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(txtBuscarID.Text);

                try {
                    conn.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Fornecedor deletado com sucesso!");
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

        

        private void iconButton1_Click(object sender, EventArgs e) {
            tabFornecedor.DataSource = List();
        }

        private void tabFornecedor_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                DataGridViewRow linha = tabFornecedor.Rows[e.RowIndex];
                txtNome.Text = linha.Cells["nome"].Value.ToString();
                txtEmail.Text = linha.Cells["email"].Value.ToString();
                txtEndereco.Text = linha.Cells["endereco"].Value.ToString();
                txtCnpj.Text = linha.Cells["cnpj"].Value.ToString();
                txtProduto.Text = linha.Cells["produto"].Value.ToString();
            }

        }
    }
}
