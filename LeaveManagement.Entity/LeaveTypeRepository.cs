using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Entity
{
    using Implements;
    using Interfaces;

    public class LeaveTypeRepository : RepositoryBase<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
