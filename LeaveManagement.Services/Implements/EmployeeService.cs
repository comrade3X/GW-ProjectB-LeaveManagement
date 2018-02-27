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

    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
        {
            this._employeeRepository = employeeRepository;
            this._unitOfWork = unitOfWork;
        }

        public void SaveEmployee()
        {
            _unitOfWork.Comit();
        }

        public void Add(Employee entity)
        {
            _employeeRepository.Add(entity);
        }

        public void Update(Employee entity)
        {
            _employeeRepository.Update(entity);
        }

        public void Delete(Employee entity)
        {
            _employeeRepository.Delete(entity);
        }

        public Employee GetById(int id)
        {
            var model = _employeeRepository.GetById(id);
            return model;
        }

        public IEnumerable<Employee> GetAll()
        {
            var res = _employeeRepository.GetAll();
            return res;
        }
    }
}
