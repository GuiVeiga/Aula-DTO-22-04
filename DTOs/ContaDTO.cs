using Aula_20_04_Projeto_Assistido.Models;

namespace Aula_20_04_Projeto_Assistido.DTOs
{
    public class ContaDTO
    {
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public static explicit operator ContaDTO(Conta conta)
        {
            if (conta == null)
                return null;

            return new ContaDTO
            {
                Nome = conta.Cliente.Nome,
                Saldo = conta.Saldo,
            };
        }
    }
}
