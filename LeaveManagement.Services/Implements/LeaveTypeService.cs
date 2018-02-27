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

    public class LeaveTypeService : ILeaveTypeService
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public LeaveTypeService(ILeaveTypeRepository leaveTypeRepository, IUnitOfWork unitOfWork)
        {
            this._leaveTypeRepository = leaveTypeRepository;
            this._unitOfWork = unitOfWork;
        }

        public void SaveLeaveType()
        {
            _unitOfWork.Comit();
        }

        public void Add(LeaveType entity)
        {
            _leaveTypeRepository.Add(entity);
        }

        public void Update(LeaveType entity)
        {
            _leaveTypeRepository.Update(entity);
        }

        public void Delete(LeaveType entity)
        {
            _leaveTypeRepository.Delete(entity);
        }

        public LeaveType GetById(int id)
        {
            var model = _leaveTypeRepository.GetById(id);
            return model;
        }

        public IEnumerable<LeaveType> GetAll()
        {
            var res = _leaveTypeRepository.GetAll();
            return res;
        }
    }
}
