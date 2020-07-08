

using Confitec.Dominio.Entidade;
using Confitec.Repositorio.Config;
using Microsoft.EntityFrameworkCore;
using System;

namespace Confitec.Repositorio.Context
{
    public class ConfitecContext : DbContext
    {
        public DbSet<Usuarios> Usuario { get; set; }
        public ConfitecContext(DbContextOptions options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

            modelBuilder.Entity<Usuarios>().HasData(new Usuarios() { Id = 1, Nome = "A",Email= "rodrigo@rodriguez.com",DataNascimento= DateTime.Now,Escolariedade= 1,SobreNome="Rodrigo" });
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios() { Id = 2, Nome = "b",Email= "rodrigo@teste.com",DataNascimento= DateTime.Now,Escolariedade= 1,SobreNome="Rodrigo" });
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios() { Id = 3, Nome = "v",Email= "rodrigo@asd.com",DataNascimento= DateTime.Now,Escolariedade= 1,SobreNome="Rodrigo" });

            base.OnModelCreating(modelBuilder);
        }
    }
}
