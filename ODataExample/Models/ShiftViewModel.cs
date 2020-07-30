using Mapster;
using ODataExample.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ODataExample.Models
{
    public class ShiftViewModel
    {
        public byte ShiftID { get; set; }
        public string Name { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime ModifiedDate { get; set; }
        public virtual IQueryable<EmployeeDepartmentHistoryViewModel> EmployeeDepartmentHistories { get; set; }

        private void ConfigMapster()
        {

            TypeAdapterConfig.GlobalSettings.Default.PreserveReference(true);

            TypeAdapterConfig<ShiftViewModel, Shift>
                .NewConfig()
                .NameMatchingStrategy(NameMatchingStrategy.Flexible);

            // BLL -> DLL
            TypeAdapterConfig<ShiftViewModel, Shift>
                .NewConfig()
                .NameMatchingStrategy(NameMatchingStrategy.Flexible);

        }

        protected virtual ShiftViewModel Map(Shift obj)
        {

            ConfigMapster();

            var destObject = new ShiftViewModel();
            destObject = obj.Adapt(destObject);

            return destObject;

        }
        protected virtual Shift Map(ShiftViewModel obj)
        {

            ConfigMapster();

            var destObject = new EF.Shift();
            destObject = obj.Adapt(destObject);

            return destObject;

        }
    }
}