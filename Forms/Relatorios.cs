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
    public partial class Relatorios : Form {

        string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=kaique8523;Database=urbangrow;";
        string strSql;
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=kaique8523;Database=urbangrow;");

        public Relatorios() {
            InitializeComponent();
            tabAudFornecedor.DataSource = List("fornecedor_auditoria");
            tabAudFuncionarios.DataSource = List("funcionario_auditoria");
            tabVendas.DataSource = List("itensvenda");
        }

        public System.Data.DataTable List(string tabela) {
            string query = $"SELECT * FROM {tabela}";
            NpgsqlCommand c2 = new NpgsqlCommand(query, conn);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(c2);

            System.Data.DataTable table = new System.Data.DataTable();
            da.Fill(table);
            return table;
        }

        private void btnAtt_Click(object sender, EventArgs e) {
            tabAudFornecedor.DataSource = List("fornecedor_auditoria");
            tabAudFuncionarios.DataSource = List("funcionario_auditoria");
            tabVendas.DataSource = List("itensvenda");

        }
    }
}
