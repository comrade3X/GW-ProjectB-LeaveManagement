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

    public class CompanyRoleService : ICompanyRoleService
    {
        private readonly ICompanyRoleRepository _companyRoleRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CompanyRoleService(ICompanyRoleRepository companyRoleRepository, IUnitOfWork unitOfWork)
        {
            this._companyRoleRepository = companyRoleRepository;
            this._unitOfWork = unitOfWork;
        }

        public void SaveCompanyRole()
        {
            _unitOfWork.Comit();
        }

        public void Add(CompanyRole entity)
        {
            _companyRoleRepository.Add(entity);
        }

        public void Update(CompanyRole entity)
        {
            _companyRoleRepository.Update(entity);
        }

        public void Delete(CompanyRole entity)
        {
            _companyRoleRepository.Delete(entity);
        }

        public CompanyRole GetById(int id)
        {
            var model = _companyRoleRepository.GetById(id);
            return model;
        }

        public IEnumerable<CompanyRole> GetAll()
        {
            var res = _companyRoleRepository.GetAll();
            return res;
        }
    }
}
