using ODataExample.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataExample.Repository
{
    public interface IBaseRepository<TBusiness> where TBusiness : class
    {
        DbContext _dbContext { get; set; }
        DbSet<TBusiness> _entities { get; set; }

        void SaveChanges();
    }
}
