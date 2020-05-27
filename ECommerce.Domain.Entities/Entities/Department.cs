using System;
using System.Collections.Generic;

namespace ECommerce.Domain.Entities.Entities
{
    public partial class Department : BaseEntity
    {
        public Department()
        {
            EmployeeDepartmentHistory = new HashSet<EmployeeDepartmentHistory>();
        }

        public string Name { get; set; }
        public string GroupName { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
    }
}
