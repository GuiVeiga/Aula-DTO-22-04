using Aula_20_04_Projeto_Assistido.Context;
using Aula_20_04_Projeto_Assistido.DTOs;
using Aula_20_04_Projeto_Assistido.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aula_20_04_Projeto_Assistido.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly SqlContext _sqlContext;

        public ClienteController(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        [HttpGet]
        public IEnumerable<ClienteDTO> Get()
        {
            return _sqlContext.Clientes.Include(x => x.Endereco).Select(x => (ClienteDTO)x).ToList();
        }

        [HttpPost]
        public void Post([FromBody] Cliente cliente)
        {
            _sqlContext.Clientes.Add(cliente);
            _sqlContext.SaveChanges();
        }

        [HttpPut]
        public void Put([FromBody] Cliente cliente)
        {
            var clienteDB = _sqlContext.Clientes.FirstOrDefault(x => x.Id == cliente.Id);

            if (clienteDB != null) 
            { 
                _sqlContext.Clientes.Update(cliente);
                _sqlContext.SaveChanges();
            }
        }
    }
}
