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

    public class LeaveRequestService : ILeaveRequestService
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IUnitOfWork _unitOfWork;

        public LeaveRequestService(ILeaveRequestRepository leaveRequestRepository, IUnitOfWork unitOfWork)
        {
            this._leaveRequestRepository = leaveRequestRepository;
            this._unitOfWork = unitOfWork;
        }

        public void SaveLeaveRequest()
        {
            _unitOfWork.Comit();
        }

        public void Add(LeaveRequest entity)
        {
            _leaveRequestRepository.Add(entity);
        }

        public void Update(LeaveRequest entity)
        {
            _leaveRequestRepository.Update(entity);
        }

        public void Delete(LeaveRequest entity)
        {
            _leaveRequestRepository.Delete(entity);
        }

        public LeaveRequest GetById(int id)
        {
            var model = _leaveRequestRepository.GetById(id);
            return model;
        }

        public IEnumerable<LeaveRequest> GetAll()
        {
            var res = _leaveRequestRepository.GetAll();
            return res;
        }
    }
}
