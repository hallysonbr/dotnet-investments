using MediatR;

namespace Investments.Application.Commands.CadastrarCarteira
{
    public class CadastrarCarteiraCommand : IRequest<int>
    {
        public int UsuarioId { get; set; }
        public int AtivoId { get; set; }
        public decimal Saldo { get; set; }        
    }
}