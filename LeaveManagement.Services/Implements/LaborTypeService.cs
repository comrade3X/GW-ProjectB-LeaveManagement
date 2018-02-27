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

    public class LaborTypeService : ILaborTypeService
    {
        private readonly ILaborTypeRepository _laborTypeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public LaborTypeService(ILaborTypeRepository laborTypeRepository, IUnitOfWork unitOfWork)
        {
            this._laborTypeRepository = laborTypeRepository;
            this._unitOfWork = unitOfWork;
        }

        public void SaveLaborType()
        {
            _unitOfWork.Comit();
        }

        public void Add(LaborType entity)
        {
            _laborTypeRepository.Add(entity);
        }

        public void Update(LaborType entity)
        {
            _laborTypeRepository.Update(entity);
        }

        public void Delete(LaborType entity)
        {
            _laborTypeRepository.Delete(entity);
        }

        public LaborType GetById(int id)
        {
            var model = _laborTypeRepository.GetById(id);
            return model;
        }

        public IEnumerable<LaborType> GetAll()
        {
            var res = _laborTypeRepository.GetAll();
            return res;
        }
    }
}
