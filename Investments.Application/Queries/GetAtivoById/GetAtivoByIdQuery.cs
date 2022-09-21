using Investments.Application.ViewModels;
using MediatR;

namespace Investments.Application.Queries.GetAtivoById
{
    public class GetAtivoByIdQuery : IRequest<AtivoViewModel>
    {
        public GetAtivoByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}