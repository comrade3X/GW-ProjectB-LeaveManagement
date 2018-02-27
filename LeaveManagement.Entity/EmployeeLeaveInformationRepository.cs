using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Entity
{
    using Implements;
    using Interfaces;

    public class EmployeeLeaveInformationRepository : RepositoryBase<EmployeeLeaveInformation>, IEmployeeLeaveInformationRepository
    {
        public EmployeeLeaveInformationRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
