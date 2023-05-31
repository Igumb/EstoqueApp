using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Infra.Data.MongoDB.Settings
{
    public class MongoDbSettings
    {
        public string? Host { get; set; }
        public string? Name { get; set; }
        public bool IsSSL { get; set; }
    }
}



