using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Entity
{
    using Implements;
    using Interfaces;

    public class CompayRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompayRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
