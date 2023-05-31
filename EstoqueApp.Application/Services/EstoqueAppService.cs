using EstoqueApp.Application.Interfaces.Services;
using EstoqueApp.Application.Models.Commands;
using EstoqueApp.Application.Models.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Application.Services
{
    public class EstoqueAppService : IEstoqueAppService
    {
        private readonly IMediator? _mediator;

        public EstoqueAppService(IMediator? mediator)
        {
            _mediator = mediator;
        }

        public async Task<EstoqueQuery> Create(EstoqueCreateCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<EstoqueQuery> Update(EstoqueUpdateCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<EstoqueQuery> Delete(EstoqueDeleteCommand command)
        {
            return await _mediator.Send(command);
        }

        public List<EstoqueQuery> GetAll()
        {
            throw new NotImplementedException();
        }

        public EstoqueQuery GetById(Guid? id)
        {
            throw new NotImplementedException();
        }
    }
}