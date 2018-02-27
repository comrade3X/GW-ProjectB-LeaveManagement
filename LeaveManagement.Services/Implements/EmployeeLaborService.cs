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

    public class EmployeeLaborService : IEmployeeLaborService
    {
        private readonly IEmployeeLaborRepository _employeeLaborRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeLaborService(IEmployeeLaborRepository employeeLaborRepository, IUnitOfWork unitOfWork)
        {
            this._employeeLaborRepository = employeeLaborRepository;
            this._unitOfWork = unitOfWork;
        }

        public void SaveEmployeeLabor()
        {
            _unitOfWork.Comit();
        }

        public void Add(EmployeeLabor entity)
        {
            _employeeLaborRepository.Add(entity);
        }

        public void Update(EmployeeLabor entity)
        {
            _employeeLaborRepository.Update(entity);
        }

        public void Delete(EmployeeLabor entity)
        {
            _employeeLaborRepository.Delete(entity);
        }

        public EmployeeLabor GetById(int id)
        {
            var model = _employeeLaborRepository.GetById(id);
            return model;
        }

        public IEnumerable<EmployeeLabor> GetAll()
        {
            var res = _employeeLaborRepository.GetAll();
            return res;
        }
    }
}
