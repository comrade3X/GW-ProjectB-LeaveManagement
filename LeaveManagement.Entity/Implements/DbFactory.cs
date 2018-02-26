using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Entity.Implements
{
    using Interfaces;

    public class DbFactory : Disposable, IDbFactory
    {
        LeaveManagementEntities dbEntities;

        public LeaveManagementEntities Init()
        {
            return dbEntities ?? (dbEntities = new LeaveManagementEntities());
        }

        protected override void DisposeCore()
        {
            if (dbEntities != null)
                dbEntities.Dispose();
        }
    }
}
