using Aula_20_04_Projeto_Assistido.Context;
using Aula_20_04_Projeto_Assistido.DTOs;
using Aula_20_04_Projeto_Assistido.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aula_20_04_Projeto_Assistido.Controllers
{
    [Route("api/conta")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private readonly SqlContext _sqlContext;

        public ContaController(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        [HttpGet]
        public IEnumerable<ContaDTO> Get()
        {
            var contas = _sqlContext.Contas.Include(x => x.Cliente).ThenInclude(x => x.Endereco).ToList();

            List<ContaDTO> contaDTO = contas.Select(x => (ContaDTO)x).ToList();

            return contaDTO;
        }

        [HttpPost]
        public void Post([FromBody] Conta conta)
        {
            _sqlContext.Contas.Add(conta);
            _sqlContext.SaveChanges();
        }
    }
}
