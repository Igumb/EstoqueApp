using EstoqueApp.Application.Models.Commands;
using EstoqueApp.Application.Models.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Application.Interfaces.Services
{
    public interface IProdutoAppService
    {
        Task<ProdutoQuery> Create(ProdutoCreateCommand command);
        Task<ProdutoQuery> Update(ProdutoUpdateCommand command);
        Task<ProdutoQuery> Delete(ProdutoDeleteCommand command);

        List<ProdutoQuery> GetAll();
        ProdutoQuery GetById(Guid? id);
    }
}
