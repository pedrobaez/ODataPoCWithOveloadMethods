using ODataExample.EF;
using ODataExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataExample.Repository
{
    public interface IShiftRepository : IBaseRepository<Shift>, 
                                        IRepositoryGetAll<Shift>
    {
        Shift GetById(int key);
    }
}
