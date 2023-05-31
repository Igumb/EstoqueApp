using EstoqueApp.Application.Handlers.Notifications;
using EstoqueApp.Application.Models.Commands;
using EstoqueApp.Application.Models.Queries;
using EstoqueApp.Application.Notifications;
using EstoqueApp.Domain.Interfaces.Services;
using EstoqueApp.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Application.Handlers.Requests
{
    public class EstoqueRequestHandler :
        IRequestHandler<EstoqueCreateCommand, EstoqueQuery>,
        IRequestHandler<EstoqueUpdateCommand, EstoqueQuery>,
        IRequestHandler<EstoqueDeleteCommand, EstoqueQuery>
    {
        private readonly IMediator? _mediator;
        private readonly IEstoqueDomainService? _estoqueDomainService;

        public EstoqueRequestHandler(IMediator? mediator, IEstoqueDomainService? estoqueDomainService)
        {
            _mediator = mediator;
            _estoqueDomainService = estoqueDomainService;
        }

        public async Task<EstoqueQuery> Handle(EstoqueCreateCommand request, CancellationToken cancellationToken)
        {
            var estoque = new Estoque
            {
                Id = Guid.NewGuid(),
                Nome = request.Nome,
                Descricao = request.Descricao
            };

            _estoqueDomainService.Add(estoque);

            var estoqueQuery = new EstoqueQuery
            {
                Id = estoque.Id,
                Nome = estoque.Nome,
                Descricao = estoque.Descricao
            };

            await _mediator.Publish(
                    new EstoqueNotification
                    {
                        Action = ActionNotification.Create,
                        Estoque = estoqueQuery
                    }
                );

            return estoqueQuery;
        }

        public async Task<EstoqueQuery> Handle(EstoqueUpdateCommand request, CancellationToken cancellationToken)
        {
            //TODO Realizar a atualização do estoque no domínio

            var estoqueQuery = new EstoqueQuery();
            await _mediator.Publish(
                    new EstoqueNotification
                    {
                        Action = ActionNotification.Update,
                        Estoque = estoqueQuery
                    }
                );

            return estoqueQuery;
        }

        public async Task<EstoqueQuery> Handle(EstoqueDeleteCommand request, CancellationToken cancellationToken)
        {
            //TODO Realizar a exclusão do estoque no domínio

            var estoqueQuery = new EstoqueQuery();
            await _mediator.Publish(
                    new EstoqueNotification
                    {
                        Action = ActionNotification.Delete,
                        Estoque = estoqueQuery
                    }
                );

            return estoqueQuery;
        }
    }
}



