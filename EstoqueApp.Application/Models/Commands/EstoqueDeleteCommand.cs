using EstoqueApp.Application.Models.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Application.Models.Commands
{
    public class EstoqueDeleteCommand : IRequest<EstoqueQuery>
    {
        public Guid? Id { get; set; }
    }
}
