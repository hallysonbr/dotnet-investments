using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Investments.Application.ViewModels
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel(string nome, string email, DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public string Nome { get; private set; }        
        public string Email { get; private set; }
        public DateTime DataNascimento { get; private set; }      
    }
}