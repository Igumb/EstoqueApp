using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Application.Models.Queries
{
    public class ProdutoQuery
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }
        public Guid? EstoqueId { get; set; }
        public EstoqueQuery? Estoque { get; set; }
    }
}

