

using Confitec.Dominio.Entidade;
using Confitec.Dominio.Entidade;
using Microsoft.EntityFrameworkCore;

namespace Confitec.Repositorio.Context
{
    public class ConfitecContext : DbContext
    {
        public DbSet<Usuarios> Usuario { get; set; }
        public ConfitecContext(DbContextOptions options)
        : base(options) { }
    }
}
