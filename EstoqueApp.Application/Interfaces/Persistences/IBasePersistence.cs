using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Application.Interfaces.Persistences
{
    public interface IBasePersistence<TModel, TKey>
        where TModel : class
    {
        void Add(TModel model);
        void Update(TModel model);
        void Delete(TModel model);
        List<TModel> GetAll();
        TModel? GetById(Guid id);
    }
}



