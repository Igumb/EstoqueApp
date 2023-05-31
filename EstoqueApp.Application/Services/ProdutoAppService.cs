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
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IMediator? _mediator;

        public ProdutoAppService(IMediator? mediator)
        {
            _mediator = mediator;
        }

        public async Task<ProdutoQuery> Create(ProdutoCreateCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<ProdutoQuery> Update(ProdutoUpdateCommand command)
        {
            return await _mediator.Send(command);
        }

        public async Task<ProdutoQuery> Delete(ProdutoDeleteCommand command)
        {
            return await _mediator.Send(command);
        }

        public List<ProdutoQuery> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProdutoQuery GetById(Guid? id)
        {
            throw new NotImplementedException();
        }
    }
}


