using EstoqueApp.Domain.Interfaces.Repositories;
using EstoqueApp.Domain.Interfaces.Services;
using EstoqueApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Domain.Services
{
    public class ProdutoDomainService : IProdutoDomainService
    {
        private readonly IUnitOfWork? _unitOfWork;

        public ProdutoDomainService(IUnitOfWork? unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Produto model)
        {
            _unitOfWork?.ProdutoRepository.Add(model);
            _unitOfWork?.SaveChanges();
        }

        public void Update(Produto model)
        {
            _unitOfWork?.ProdutoRepository.Update(model);
            _unitOfWork?.SaveChanges();
        }

        public void Delete(Produto model)
        {
            _unitOfWork?.ProdutoRepository.Delete(model);
            _unitOfWork?.SaveChanges();
        }

        public List<Produto> GetAll()
        {
            return _unitOfWork.ProdutoRepository.GetAll();
        }

        public Produto? GetById(Guid id)
        {
            return _unitOfWork.ProdutoRepository.GetById(id);
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}



