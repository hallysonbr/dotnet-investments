using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Investments.Application.ViewModels;
using Investments.Core.Enums;
using Investments.Core.Extensions;
using MediatR;

namespace Investments.Application.Queries.GetAllTipoAtivo
{
    public class GetAllTipoAtivoQueryHandler : IRequestHandler<GetAllTipoAtivoQuery, List<TipoAtivoViewModel>>
    {
        public async Task<List<TipoAtivoViewModel>> Handle(GetAllTipoAtivoQuery request, CancellationToken cancellationToken)
        {
            var tiposAtivos =  await Task.Run( () => Enum.GetValues<TipoAtivoEnum>()
                                                         .Select(a => new TipoAtivoViewModel(
                                                                          ((int)a), 
                                                                          ((TipoAtivoEnum)a)
                                                                           .DescriptionAttr()
                                                                )).ToList()
                                            );
          
            return tiposAtivos;
        }
    }
}