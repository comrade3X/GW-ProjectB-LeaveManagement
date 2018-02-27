using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Services.Interfaces
{
    using Entity;

    public interface ILeaveRequestService : IServiceBase<LeaveRequest>
    {
        void SaveLeaveRequest();
    }
}
