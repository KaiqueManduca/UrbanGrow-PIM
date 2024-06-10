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
    public partial class Usuarios : Form {

        string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=kaique8523;Database=urbangrow;";
        string strSql;
        string strSql2;
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=kaique8523;Database=urbangrow;");


        public Usuarios() {
            InitializeComponent();
            tabFuncionario.DataSource = List();
        }

        public System.Data.DataTable List() {
            string query = "SELECT * FROM funcionario";
            NpgsqlCommand c2 = new NpgsqlCommand(query, conn);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

            System.Data.DataTable table = new System.Data.DataTable();
            da.Fill(table);
            return table;
        }

        private void btnInserir_Click(object sender, EventArgs e) {
            Globals.ValidateCpf(txtCpf.Text);
            if (!Globals.ValidateCpf(txtCpf.Text)) {
                // Limpar campos
                foreach (var controle in this.Controls) {
                    if (controle is TextBox) {
                        ((TextBox)controle).Clear();
                    }
                }
                //
                return;
            }


            ///////////////////////////////////////////////
            strSql = "INSERT INTO funcionario (nome, email, endereco, cpf, salario, dt_nascimento, dt_admissao) VALUES (@nome, @email, @endereco, @cpf, @salario, @dt_nascimento, @dt_admissao)";
            strSql2 = "insert into login(usuario, senha) values (@usuario, @senha)";

            using (var conn = new NpgsqlConnection(connectionString)) {
                try {
                    conn.Open();
                    int idl;

                    using (var comando = new NpgsqlCommand(strSql2, conn)) {
                        // Registra login
                        comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                        comando.Parameters.AddWithValue("@senha", txtSenha.Text);
                        comando.ExecuteNonQuery();
                        //Salva ID Login
                        string strSqlSelectId = "SELECT lastval()";
                        using (var comandoSelectId = new NpgsqlCommand(strSqlSelectId, conn)) {
                            int idLogin = Convert.ToInt32(comandoSelectId.ExecuteScalar());
                            idl = idLogin;
                        }
                    }

                    using (var comando = new NpgsqlCommand(strSql, conn)) {
                        comando.Parameters.AddWithValue("@nome", txtNome.Text);
                        comando.Parameters.AddWithValue("@email", txtEmail.Text);
                        comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        comando.Parameters.AddWithValue("@cpf", txtCpf.Text);
                        comando.Parameters.AddWithValue("@salario", Convert.ToSingle(txtSalario.Text));
                        comando.Parameters.AddWithValue("@dt_nascimento", dtNascimento.Value);
                        comando.Parameters.AddWithValue("@dt_admissao", dtEntrada.Value);
                        comando.Parameters.AddWithValue("@id_login", idl);
                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Funcionário adicionado com sucesso!");
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
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Deseja realmente excluir este funcionário?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) {
                MessageBox.Show("Operação cancelada!");
            }
            else {
                strSql = "delete from funcionario where id_funcionario=@id";
                var conn = new NpgsqlConnection(connectionString);
                NpgsqlCommand comando = new NpgsqlCommand(strSql, conn);

                comando.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(txtBuscarID.Text);

                try {
                    conn.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Funcionario deletado com sucesso!");
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


        private void btnBuscar_Click(object sender, EventArgs e) {
            strSql = "select * from funcionario where id_funcionario=@id";
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

                txtBuscarID.Text = Convert.ToString(dr["id_funcionario"]);
                txtNome.Text = Convert.ToString(dr["nome"]);
                txtEmail.Text = Convert.ToString(dr["email"]);
                txtEndereco.Text = Convert.ToString(dr["endereco"]);
                txtCpf.Text = Convert.ToString(dr["cpf"]);
                txtSalario.Text = Convert.ToString(dr["salario"]);
                // Supondo que o nome da coluna no banco de dados seja "data_entrada"
                DateTime dataEntrada = Convert.ToDateTime(dr["dt_admissao"]);
                dtEntrada.Value = dataEntrada;
                DateTime dataNascimento = Convert.ToDateTime(dr["dt_nascimento"]);
                dtEntrada.Value = dataNascimento;



            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

            finally { conn.Close(); }
        }

        private void btnAtt_Click(object sender, EventArgs e) {
            tabFuncionario.DataSource = List();
        }

        private void btnAtualizar_Click(object sender, EventArgs e) {
            strSql = "update funcionario set nome=@nome, endereco=@endereco, email=@email, cpf=@cpf, dt_nascimento=@dt_nascimento, dt_admissao=@dt_admissao, salario=@salario where id_funcionario = @txtBuscarID";
            var conn = new NpgsqlConnection(connectionString);
            NpgsqlCommand comando = new NpgsqlCommand(strSql, conn);

            comando.Parameters.Add("@txtBuscarID", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(txtBuscarID.Text);
            comando.Parameters.AddWithValue("@nome", txtNome.Text);
            comando.Parameters.AddWithValue("@email", txtEmail.Text);
            comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            comando.Parameters.AddWithValue("@cpf", txtCpf.Text);
            comando.Parameters.AddWithValue("@salario", Convert.ToSingle(txtSalario.Text));
            comando.Parameters.AddWithValue("@dt_nascimento", dtNascimento.Value);
            comando.Parameters.AddWithValue("@dt_admissao", dtEntrada.Value);

            try {
                conn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Funcionario atualizado com sucesso!");
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
    }
}

