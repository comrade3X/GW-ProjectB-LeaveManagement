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
        private readonly IDbFactory dbFactory;
        private LeaveManagementEntities dbEntities;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public LeaveManagementEntities DbEntities
        {
            get { return dbEntities ?? (dbEntities = dbFactory.Init()); }
        }

        public void Comit()
        {
            DbEntities.SaveChanges();
        }
    }
}
