//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeaveManagement.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class LeaveRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LeaveRequest()
        {
            this.LeaveRequestHistories = new HashSet<LeaveRequestHistory>();
        }
    
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public decimal TotalDays { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public int Approver { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual LeaveType LeaveType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveRequestHistory> LeaveRequestHistories { get; set; }
    }
}