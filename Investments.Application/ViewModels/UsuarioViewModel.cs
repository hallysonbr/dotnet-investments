using System.Collections.Generic;
using System.Linq;
using Investments.Core.Entities;
using Investments.Core.Enums;

namespace Investments.Application.ViewModels
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel(int id, string nome, string email, int idade, UsuarioTipoEnum tipo, List<Carteira> carteira = null)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Idade = idade;
            Tipo = tipo;

            Carteira = carteira is not null ? carteira.Select(a => (CarteiraViewModel)a).ToList() 
                                        : new List<CarteiraViewModel>();

            Total = Carteira.Sum(c => c.Saldo);
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }        
        public string Email { get; private set; }
        public int Idade { get; private set; }
        public UsuarioTipoEnum Tipo { get; private set; }
        public decimal Total { get; private set; }
        public List<CarteiraViewModel> Carteira { get; private set; }      
    }
}