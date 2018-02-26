using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Entity.Interfaces
{
    public interface IDbFactory : IDisposable
    {
        LeaveManagementEntities Init();
    }
}
