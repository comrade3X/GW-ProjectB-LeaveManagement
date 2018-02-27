using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveManagement.ViewModels
{
    public class CompanyViewModel
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Contact { get; set; }
    }
}