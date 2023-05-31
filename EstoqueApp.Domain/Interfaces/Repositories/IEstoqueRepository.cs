using EstoqueApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Domain.Interfaces.Repositories
{
    public interface IEstoqueRepository : IBaseRepository<Estoque, Guid>
    {

    }
}



