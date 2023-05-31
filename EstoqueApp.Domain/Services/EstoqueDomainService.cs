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
    public class EstoqueDomainService : IEstoqueDomainService
    {
        private readonly IUnitOfWork? _unitOfWork;

        public EstoqueDomainService(IUnitOfWork? unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Estoque model)
        {
            _unitOfWork?.EstoqueRepository.Add(model);
            _unitOfWork?.SaveChanges();
        }

        public void Update(Estoque model)
        {
            _unitOfWork?.EstoqueRepository.Update(model);
            _unitOfWork?.SaveChanges();
        }

        public void Delete(Estoque model)
        {
            _unitOfWork?.EstoqueRepository.Delete(model);
            _unitOfWork?.SaveChanges();
        }

        public List<Estoque> GetAll()
        {
            return _unitOfWork.EstoqueRepository.GetAll();
        }

        public Estoque? GetById(Guid id)
        {
            return _unitOfWork.EstoqueRepository.GetById(id);
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}



