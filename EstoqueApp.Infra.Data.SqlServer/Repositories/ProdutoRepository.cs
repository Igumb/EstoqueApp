using EstoqueApp.Domain.Interfaces.Repositories;
using EstoqueApp.Domain.Models;
using EstoqueApp.Infra.Data.SqlServer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Infra.Data.SqlServer.Repositories
{
    public class ProdutoRepository
        : BaseRepository<Produto, Guid>, IProdutoRepository
    {
        private readonly DataContext? _dataContext;

        public ProdutoRepository(DataContext? dataContext)
            : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}

