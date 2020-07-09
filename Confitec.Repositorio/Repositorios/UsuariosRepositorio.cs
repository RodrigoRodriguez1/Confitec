using Confitec.Dominio.BaseRepositorio;
using Confitec.Dominio.Entidade;
using Confitec.Repositorio.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Confitec.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuarios>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(ConfitecContext confitecContext) : base(confitecContext)
        {
        }
        public Usuarios Obter(string email)
        {
            return ConfitecContext.Usuario.FirstOrDefault(u => u.Email == email);
        }
    }
}
