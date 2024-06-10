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
    public partial class RegistroCliente : Form {

        string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=kaique8523;Database=urbangrow;";
        string strSql;
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=kaique8523;Database=urbangrow;");
        public RegistroCliente() {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
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

            strSql = "insert into login(usuario, senha) values (@usuario, @senha)";

            using (var conn = new NpgsqlConnection(connectionString)) {
                try {
                    conn.Open();
                    int idl;

                    using (var comando = new NpgsqlCommand(strSql, conn)) {
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


                    //Registra Cliente
                    string srtSqlCliente = "insert into cliente(nome, endereco, email, cpf, dt_nascimento, id_login) values (@nome, @endereco, @email, @cpf, @dt_nascimento, @id_login)";
                    using (var comandoCliente = new NpgsqlCommand(srtSqlCliente, conn)) {
                        comandoCliente.Parameters.AddWithValue("@nome", txtNome.Text);
                        comandoCliente.Parameters.AddWithValue("@endereco", txtNome.Text);
                        comandoCliente.Parameters.AddWithValue("@email", txtNome.Text);
                        comandoCliente.Parameters.AddWithValue("@cpf", txtNome.Text);
                        comandoCliente.Parameters.AddWithValue("@dt_nascimento", dtNascimento.Value);
                        comandoCliente.Parameters.AddWithValue("@id_login", idl);
                        comandoCliente.ExecuteNonQuery();
                    }


                    MessageBox.Show("Registrado com sucesso!");
                    //clear text boxes
                    foreach (var controle in this.Controls) {
                        if (controle is TextBox) {
                            ((TextBox)controle).Clear();
                        }
                    }
                    Login form = new Login();
                    this.Hide();
                    form.Show();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
