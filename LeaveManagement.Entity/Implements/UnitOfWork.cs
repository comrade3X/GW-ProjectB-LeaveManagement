using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Entity.Implements
{
    using Interfaces;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private LeaveManagementEntities _dbEntities;

        public UnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public LeaveManagementEntities DbEntities => _dbEntities ?? (_dbEntities = _dbFactory.Init());

        public void Comit()
        {
            DbEntities.SaveChanges();
        }
    }
}
