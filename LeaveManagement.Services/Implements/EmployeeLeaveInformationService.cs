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

    public class EmployeeLeaveInformationService : IEmployeeLeaveInformationService
    {
        private readonly IEmployeeLeaveInformationRepository _employeeLeaveInformationRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeLeaveInformationService(IEmployeeLeaveInformationRepository employeeLeaveInformationRepository, IUnitOfWork unitOfWork)
        {
            this._employeeLeaveInformationRepository = employeeLeaveInformationRepository;
            this._unitOfWork = unitOfWork;
        }

        public void SaveEmployeeLeaveInformation()
        {
            _unitOfWork.Comit();
        }

        public void Add(EmployeeLeaveInformation entity)
        {
            _employeeLeaveInformationRepository.Add(entity);
        }

        public void Update(EmployeeLeaveInformation entity)
        {
            _employeeLeaveInformationRepository.Update(entity);
        }

        public void Delete(EmployeeLeaveInformation entity)
        {
            _employeeLeaveInformationRepository.Delete(entity);
        }

        public EmployeeLeaveInformation GetById(int id)
        {
            var model = _employeeLeaveInformationRepository.GetById(id);
            return model;
        }

        public IEnumerable<EmployeeLeaveInformation> GetAll()
        {
            var res = _employeeLeaveInformationRepository.GetAll();
            return res;
        }
    }
}
