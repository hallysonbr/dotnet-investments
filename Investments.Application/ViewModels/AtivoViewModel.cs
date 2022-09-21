using Investments.Core.Enums;
using Investments.Core.Extensions;

namespace Investments.Application.ViewModels
{
    public class AtivoViewModel
    {
        public AtivoViewModel(int id, string nome, TipoAtivoEnum tipo)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
            
            Grupo = ((TipoAtivoEnum)Tipo).DescriptionAttr();
            NomeCompleto = $"{Grupo} | {Nome}";
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public TipoAtivoEnum Tipo { get; private set; } 
        public string Grupo { get; private set; }
        public string NomeCompleto { get; private set; }      
    }
}