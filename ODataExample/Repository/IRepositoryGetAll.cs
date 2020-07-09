using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataExample.Repository
{
    public interface IRepositoryGetAll<TBusiness> 
    {
        IQueryable<TBusiness> GetAll();
    }
}
