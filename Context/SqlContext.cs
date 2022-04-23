using Aula_20_04_Projeto_Assistido.Models;
using Microsoft.EntityFrameworkCore;

namespace Aula_20_04_Projeto_Assistido.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}
