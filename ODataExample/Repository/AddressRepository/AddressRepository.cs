using ODataExample.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ODataExample.Repository.AddressRepository
{
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
       
    }
}