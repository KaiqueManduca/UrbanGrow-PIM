using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanGrow {
    public static class ConexaoDB {
        private static readonly string _connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=kaique8523;Database=urbangrow;";

        public static NpgsqlConnection AbrirConexao() {
            var conexao = new NpgsqlConnection(_connectionString);
            conexao.Open();
            return conexao;
        }

        public static void FecharConexao(NpgsqlConnection conexao) {
            conexao.Close();
        }
    }
}
