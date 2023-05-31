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
    public class ProdutoPersistence : IProdutoPersistence
    {
        private readonly MongoDbContext? _mongoDbContext;

        public ProdutoPersistence(MongoDbContext? mongoDbContext)
        {
            _mongoDbContext = mongoDbContext;
        }

        public void Add(ProdutoQuery model)
        {
            _mongoDbContext.Produtos.InsertOne(model);
        }

        public void Update(ProdutoQuery model)
        {
            var filter = Builders<ProdutoQuery>.Filter.Eq(e => e.Id, model.Id);
            _mongoDbContext.Produtos.ReplaceOne(filter, model);
        }

        public void Delete(ProdutoQuery model)
        {
            var filter = Builders<ProdutoQuery>.Filter.Eq(e => e.Id, model.Id);
            _mongoDbContext.Produtos.DeleteOne(filter);
        }

        public List<ProdutoQuery> GetAll()
        {
            var filter = Builders<ProdutoQuery>.Filter.Where(e => true);
            return _mongoDbContext.Produtos.Find(filter).ToList();
        }

        public ProdutoQuery? GetById(Guid id)
        {
            var filter = Builders<ProdutoQuery>.Filter.Eq(e => e.Id, id);
            return _mongoDbContext.Produtos.Find(filter).FirstOrDefault();
        }
    }
}


