using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODataExample.Repository
{
    public interface IRepostoryAdd<TBusiness>
    {
        TBusiness Add(TBusiness obj); 
    }
}