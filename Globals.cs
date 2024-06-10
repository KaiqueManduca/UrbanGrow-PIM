using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanGrow {
    public static class Globals {
        public static bool EhFuncionario {  get; set; }
        public static bool EhSupervisor { get; set; }

        public static string usuario = "urbangrow";
        public static string senha = "123456";
  
        public static bool IsCnpj(string cnpj) {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma, resto;
            string digito, tempCnpj;

            cnpj = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14) {
                MessageBox.Show("CNPJ inválido! O CNPJ deve ter 14 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);
            resto = (resto < 2) ? 0 : 11 - resto;
            digito = resto.ToString();

            tempCnpj = tempCnpj + digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            resto = (resto < 2) ? 0 : 11 - resto;
            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        public static bool ValidateCpf(string cpf) {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11) {
                MessageBox.Show("CPF deve conter 11 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicadores1[i];

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            tempCpf += digito1;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicadores2[i];

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            bool isValid = cpf.EndsWith(digito1.ToString() + digito2.ToString());

            if (!isValid)
                MessageBox.Show("CPF inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return isValid;
        }



    }
}
