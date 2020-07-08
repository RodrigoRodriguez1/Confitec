using System;
using System.Collections.Generic;
using System.Text;

namespace Confitec.Dominio.Entidade
{
    public class Usuarios : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }
        public int Escolariedade { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarMensagem("Email não informado");
        }

    }
}
