using Investments.Core.Entities;

namespace Investments.Application.ViewModels
{
    public class CarteiraViewModel
    {       

        public int Id { get; private set; }
        public string Ativo { get; private set; }
        public decimal Saldo { get; private set; }

        public static explicit operator CarteiraViewModel(Carteira c)
        {
            return new CarteiraViewModel()
            {
                Id = c.Id,
                Ativo = c.Ativo.Nome,
                Saldo = c.Saldo
            };
        }
    }
}