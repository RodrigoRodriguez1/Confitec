using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Confitec.Dominio.Entidade
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidaca { get; set; }
        private List<string> MensagemValidacao
        {
            get { return _mensagensValidaca ?? (_mensagensValidaca = new List<string>()); }
        }

        protected void LimparMensagemValidação()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarMensagem(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }
        public abstract void Validate();

        protected bool Validado
        {
            get { return !MensagemValidacao.Any(); }
        }
    }
}
