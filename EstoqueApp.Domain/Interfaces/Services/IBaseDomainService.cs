using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Domain.Interfaces.Services
{
    public interface IBaseDomainService<TModel, TKey> : IDisposable
        where TModel : class
    {
        void Add(TModel model);
        void Update(TModel model);
        void Delete(TModel model);
        List<TModel> GetAll();
        TModel? GetById(TKey id);
    }
}




