using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataExample.Repository
{
    public interface IRepositoryGet<TBusiness> where TBusiness :class
    {
        TBusiness Get(int Id);
    }
}
