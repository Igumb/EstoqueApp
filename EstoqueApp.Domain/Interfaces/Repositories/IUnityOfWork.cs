using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IEstoqueRepository EstoqueRepository { get; }
        IProdutoRepository ProdutoRepository { get; }

        void SaveChanges();
    }
}



