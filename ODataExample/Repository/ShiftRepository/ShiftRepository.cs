using ODataExample.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODataExample.Repository
{
    public class ShiftRepository : BaseRepository<Shift>, IShiftRepository
    {
        public ShiftRepository() : base()
        {

        }
        public override IQueryable<Shift> GetAll()
        {
            return base.GetAll();
        }
    }
}