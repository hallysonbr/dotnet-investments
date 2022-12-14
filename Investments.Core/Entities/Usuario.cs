using System;
using System.Collections.Generic;
using Investments.Core.Enums;

namespace Investments.Core.Entities
{
    public class Usuario : EntidadeBase
    {
        public Usuario(string nome, string email, string password, DateTime dataNascimento, UsuarioTipoEnum tipo)
        {
            Nome = nome;
            Email = email;
            Password = password;
            DataNascimento = dataNascimento;
            Tipo = tipo;
            Ativos = new List<Carteira>();            
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public UsuarioTipoEnum Tipo { get; private set; }
        public virtual List<Carteira> Ativos { get; private set; }


        public void DefinirAdmin()
        {
            Tipo = UsuarioTipoEnum.Admin;
        }

        public void DefinirGerente()
        {
            Tipo = UsuarioTipoEnum.Gerente;
        }

        public void DefinirCliente()
        {
            Tipo = UsuarioTipoEnum.Cliente;
        }

        public int CalcularIdade()
        {
            int idade = DateTime.Now.Year - DataNascimento.Year;

            return (DataNascimento.Month > DateTime.Now.Month) 
                   || (DataNascimento.Month == DateTime.Now.Month 
                       && DataNascimento.Day > DateTime.Now.Day) 
                   ? idade-- : idade;
        }
    }
}