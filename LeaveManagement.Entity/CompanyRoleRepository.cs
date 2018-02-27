using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Entity
{
    using Implements;
    using Interfaces;

    public class CompanyRoleRepository : RepositoryBase<CompanyRole>, ICompanyRoleRepository
    {
        public CompanyRoleRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
