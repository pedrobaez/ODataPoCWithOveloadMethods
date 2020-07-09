using ODataExample.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ODataExample.Repository
{
    public class BaseRepository<TBusiness> : IRepostoryAdd<TBusiness> ,
                                             IRepositoryGetAll<TBusiness>
        
        where TBusiness : class, new()
    {
        protected AdventureWorks2014Entities _dbContext { get; set; }
        protected DbSet<TBusiness> _entities { get; set; }
        public BaseRepository()
        {
            _dbContext = new AdventureWorks2014Entities();
            _entities = _dbContext.Set<TBusiness>();
        }
        public virtual TBusiness Add(TBusiness obj)
        {
            _entities.Add(obj);

            _dbContext.SaveChanges();

            return obj;
        }

        public virtual IQueryable<TBusiness> GetAll()
        {
            return _entities.AsQueryable();
        }
    }
}