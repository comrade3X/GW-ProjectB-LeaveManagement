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

    public class LeaveRequestHistoryService : ILeaveRequestHistoryService
    {
        private readonly ILeaveRequestHistoryRepository _leaveRequestHistoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public LeaveRequestHistoryService(ILeaveRequestHistoryRepository leaveRequestHistoryRepository, IUnitOfWork unitOfWork)
        {
            this._leaveRequestHistoryRepository = leaveRequestHistoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public void SaveLeaveRequestHistory()
        {
            _unitOfWork.Comit();
        }

        public void Add(LeaveRequestHistory entity)
        {
            _leaveRequestHistoryRepository.Add(entity);
        }

        public void Update(LeaveRequestHistory entity)
        {
            _leaveRequestHistoryRepository.Update(entity);
        }

        public void Delete(LeaveRequestHistory entity)
        {
            _leaveRequestHistoryRepository.Delete(entity);
        }

        public LeaveRequestHistory GetById(int id)
        {
            var model = _leaveRequestHistoryRepository.GetById(id);
            return model;
        }

        public IEnumerable<LeaveRequestHistory> GetAll()
        {
            var res = _leaveRequestHistoryRepository.GetAll();
            return res;
        }
    }
}
