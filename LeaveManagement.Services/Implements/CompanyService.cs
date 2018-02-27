using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Services.Implements
{
    using Interfaces;
    using Entity;
    using Entity.Interfaces;

    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CompanyService(ICompanyRepository companyRepository, IUnitOfWork unitOfWork)
        {
            this._companyRepository = companyRepository;
            this._unitOfWork = unitOfWork;
        }

        public void SaveCompany()
        {
            _unitOfWork.Comit();
        }

        public void Add(Company entity)
        {
            _companyRepository.Add(entity);
        }

        public void Update(Company entity)
        {
            _companyRepository.Update(entity);
        }

        public void Delete(Company entity)
        {
            _companyRepository.Delete(entity);
        }

        public Company GetById(int id)
        {
            var model = _companyRepository.GetById(id);
            return model;
        }

        public IEnumerable<Company> GetAll()
        {
            var res = _companyRepository.GetAll();
            return res;
        }
    }
}
