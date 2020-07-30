using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataExample.Repository
{
   public interface IRepositoryUpdate<TBusiness> where TBusiness :class 
   {
        void Update(TBusiness model);
   }
}
