using EstoqueApp.Domain.Interfaces.Repositories;
using EstoqueApp.Infra.Data.SqlServer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Infra.Data.SqlServer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext? _dataContext;

        public UnitOfWork(DataContext? dataContext)
        {
            _dataContext = dataContext;
        }

        public IEstoqueRepository EstoqueRepository => new EstoqueRepository(_dataContext);

        public IProdutoRepository ProdutoRepository => new ProdutoRepository(_dataContext);

        public void SaveChanges()
        {
            _dataContext?.SaveChanges();
        }

        public void Dispose()
        {
            _dataContext?.Dispose();
        }
    }
}



