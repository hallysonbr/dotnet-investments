using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Investments.Application.DTOs
{
    public class UsuarioDTO
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}