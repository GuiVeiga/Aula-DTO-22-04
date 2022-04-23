using Aula_20_04_Projeto_Assistido.Models;

namespace Aula_20_04_Projeto_Assistido.DTOs
{
    public class ClienteDTO
    {
        public string Nome { get; set; }
        public string Estado { get; set; }

        public static explicit operator ClienteDTO(Cliente cliente)
        {
            if (cliente == null)
                return null;


            return new ClienteDTO()
            {
                Nome = cliente.Nome,
                Estado = cliente.Endereco?.Estado == null ? "Sem Estado" : cliente.Endereco.Estado
            };
        }
    }
}
