using Investments.Application.ViewModels;
using MediatR;

namespace Investments.Application.Queries.GetUsuarioById
{
    public class GetUsuarioByIdQuery : IRequest<UsuarioViewModel>
    {
        public GetUsuarioByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}