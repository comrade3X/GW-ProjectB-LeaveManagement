using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Entity
{
    using Implements;
    using Interfaces;

    public class LeaveRequestRepository : RepositoryBase<LeaveRequest>, ILeaveRequestRepository
    {
        public LeaveRequestRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
