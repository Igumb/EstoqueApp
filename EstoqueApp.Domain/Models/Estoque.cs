using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Domain.Models
{
    public class Estoque
    {
        #region Propriedades

        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }

        #endregion

        #region Relacionamentos

        public ICollection<Produto>? Produtos { get; set; }

        #endregion
    }
}



