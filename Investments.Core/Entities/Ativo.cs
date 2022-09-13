using Investments.Core.Enums;

namespace Investments.Core.Entities
{
    public class Ativo : EntidadeBase
    {
        public Ativo(string nome, TipoAtivoEnum tipo)
        {
            Nome = nome;
            Tipo = tipo;
        }

        public string Nome { get; private set; }
        public TipoAtivoEnum Tipo { get; private set; }
    }
}