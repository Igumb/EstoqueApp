using EstoqueApp.Application.Models.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Application.Models.Commands
{
    public class ProdutoUpdateCommand : IRequest<ProdutoQuery>
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        public Guid? Id { get; set; }

        [MinLength(8, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public decimal? Preco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public int? Quantidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public Guid? EstoqueId { get; set; }
    }
}
