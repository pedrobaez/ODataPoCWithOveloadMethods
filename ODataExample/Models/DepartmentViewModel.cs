using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODataExample.Models
{
    public class DepartmentViewModel
    {
        public short DepartmentID { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<EmployeeDepartmentHistoryViewModel> EmployeeDepartmentHistories { get; set; }
    }
}