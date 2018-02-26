using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Services.Implements
{
    using Interfaces;
    using LeaveManagement.Entity;
    using LeaveManagement.Entity.Interfaces;

    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository companyRepository;
        private readonly IUnitOfWork unitOfWork;

        public CompanyService(ICompanyRepository companyRepository, IUnitOfWork unitOfWork)
        {
            this.companyRepository = companyRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Company> GetAllCompanies()
        {
            var res = companyRepository.GetAll();
            return res;
        }

        public void SaveCompany()
        {
            unitOfWork.Comit();
        }
    }
}
