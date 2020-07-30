using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODataExample.Models
{
    public class EmployeeDepartmentHistoryViewModel
    {
        public int BusinessEntityID { get; set; }
        public short DepartmentID { get; set; }
        public byte ShiftID { get; set; }
        public DateTime StartDate { get; set; }
        public Nullable<DateTime> EndDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual DepartmentViewModel Department { get; set; }
        public virtual EmployeeViewModel Employee { get; set; }
        public virtual ShiftViewModel Shift { get; set; }
    }
}