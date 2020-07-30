using ODataExample.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataExample.Repository.AddressRepository
{
    public interface IAddressRepository: IBaseRepository<Address>,IRepositoryGetAll<Address>
    {
    }
}
