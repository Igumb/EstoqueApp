using EstoqueApp.Application.Interfaces.Persistences;
using EstoqueApp.Application.Models.Queries;
using EstoqueApp.Infra.Data.MongoDB.Contexts;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Infra.Data.MongoDB.Persistences
{
    public class EstoquePersistence : IEstoquePersistence
    {
        private readonly MongoDbContext? _mongoDbContext;

        public EstoquePersistence(MongoDbContext? mongoDbContext)
        {
            _mongoDbContext = mongoDbContext;
        }

        public void Add(EstoqueQuery model)
        {
            _mongoDbContext.Estoques.InsertOne(model);
        }

        public void Update(EstoqueQuery model)
        {
            var filter = Builders<EstoqueQuery>.Filter.Eq(e => e.Id, model.Id);
            _mongoDbContext.Estoques.ReplaceOne(filter, model);
        }

        public void Delete(EstoqueQuery model)
        {
            var filter = Builders<EstoqueQuery>.Filter.Eq(e => e.Id, model.Id);
            _mongoDbContext.Estoques.DeleteOne(filter);
        }

        public List<EstoqueQuery> GetAll()
        {
            var filter = Builders<EstoqueQuery>.Filter.Where(e => true);
            return _mongoDbContext.Estoques.Find(filter).ToList();
        }

        public EstoqueQuery? GetById(Guid id)
        {
            var filter = Builders<EstoqueQuery>.Filter.Eq(e => e.Id, id);
            return _mongoDbContext.Estoques.Find(filter).FirstOrDefault();
        }
    }
}



