using EstoqueApp.Application.Models.Queries;
using EstoqueApp.Infra.Data.MongoDB.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Infra.Data.MongoDB.Contexts
{
    public class MongoDbContext
    {
        private readonly MongoDbSettings? _mongoDbSettings;
        private IMongoDatabase? _mongoDatabase;

        public MongoDbContext(IOptions<MongoDbSettings>? mongoDbSettings)
        {
            _mongoDbSettings = mongoDbSettings.Value;

            #region Conexão com o banco de dados

            var client = MongoClientSettings.FromUrl(new MongoUrl(_mongoDbSettings.Host));
            if (_mongoDbSettings.IsSSL)
                client.SslSettings = new SslSettings
                {
                    EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12
                };

            _mongoDatabase = new MongoClient(client)
                .GetDatabase(_mongoDbSettings.Name);

            #endregion
        }

        public IMongoCollection<EstoqueQuery> Estoques
            => _mongoDatabase.GetCollection<EstoqueQuery>("estoques");

        public IMongoCollection<ProdutoQuery> Produtos
            => _mongoDatabase.GetCollection<ProdutoQuery>("produtos");
    }
}



