using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace UrbanGrow.Forms {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void labelLoginText_Click(object sender, EventArgs e) {

        }

        private void btnLogin_Click(object sender, EventArgs e) {

            //Creating connection to the database
            string server = "localhost";
            string database = "urbangrow";
            string user = "postgres";
            string password = "kaique8523";
            string connectionString = $"Server={server};Port=5432;User Id={user};Password={password};Database={database};";

            try {
                using (var conn = new NpgsqlConnection(connectionString)) {

                    var comand = conn.CreateCommand();
                    NpgsqlCommand query = new NpgsqlCommand("select count(*) from login where usuario = '" + txtUsuario.Text + "' and senha = '" + txtSenha.Text + "'", conn);
                    conn.Open();
                    DataTable dataTale = new DataTable();
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query);
                    da.Fill(dataTale);

                    foreach (DataRow list in dataTale.Rows) {
                        if (Convert.ToInt32(list.ItemArray[0]) > 0) {
                            MessageBox.Show("Usuário validado", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            NpgsqlCommand queryIdLogin = new NpgsqlCommand("Select id_login from login where usuario = '" + txtUsuario.Text + "'", conn);
                            int idLogin = Convert.ToInt32(queryIdLogin.ExecuteScalar());
                            NpgsqlCommand queryFuncionario = new NpgsqlCommand("select count(*) from funcionario where id_login = " + idLogin, conn);
                            int funcionarioCount = Convert.ToInt32(queryFuncionario.ExecuteScalar());

                            //
                            if (txtUsuario.Text == Globals.usuario && txtSenha.Text == Globals.senha)
                                Globals.EhSupervisor = true;
                                   
                            //
                            if (funcionarioCount > 0) {
                                // É funcionário
                                Globals.EhFuncionario = true;
                            }
                           
                            else {
                                // É cliente
                                Globals.EhFuncionario = false;
                            }
                            Form1 form = new Form1();
                            this.Hide();
                            form.Show();
                        }
                        else {
                            MessageBox.Show("Usuário Inválido", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }

                    conn.Close();


                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Erro ao conectar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            RegistroCliente form = new RegistroCliente();
            this.Hide();
            form.Show();
        }
    }
}
