using Aula_20_04_Projeto_Assistido.Enums;

namespace Aula_20_04_Projeto_Assistido.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public TipoContaEnum TipoConta { get; set; }
        public double Saldo { get; set; }
        public AgenciaEnum Agencia { get; set; }
        public int NumeroConta { get; set; }
        public Cliente Cliente { get; set; }
    }
}
