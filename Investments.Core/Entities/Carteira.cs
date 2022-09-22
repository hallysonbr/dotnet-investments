using System;

namespace Investments.Core.Entities
{
    public class Carteira : EntidadeBase
    {
        public Carteira(int usuarioId, int ativoId, decimal saldo)
        {
            UsuarioId = usuarioId;
            AtivoId = ativoId;
            Saldo = saldo;
        }

        public int UsuarioId { get; private set; }
        public int AtivoId { get; private set; }
        public decimal Saldo { get; private set; }

        public virtual Usuario Usuario { get; private set; }
        public virtual Ativo Ativo { get; private set; }

        public void Comprar(decimal valor)
        {
            Saldo += valor;
             Round();
        }

        public void Vender(decimal valor)
        {
            Saldo -= valor;
            Round();
        }

        public void Round()
        {
            Saldo = Math.Round(Saldo, 2);           
        }
    }
}