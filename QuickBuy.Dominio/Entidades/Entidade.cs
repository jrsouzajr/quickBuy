using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
        protected List<string> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        public abstract void Validate();
        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }
        protected void AdicionarErro(string erro)
        {
            MensagemValidacao.Add(erro);
        }

        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }
    }
}
