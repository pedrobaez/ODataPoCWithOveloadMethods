using ODataExample.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ODataExample.Repository
{
    public class BaseRepository<TBusiness> : IBaseRepository<TBusiness>,
                                             IRepostoryAdd<TBusiness>,
                                             IRepositoryGet<TBusiness>,
                                             IRepositoryGetAll<TBusiness>,
                                             IRepositoryUpdate<TBusiness>,
                                             IRepositoryDelete

        where TBusiness : class, new()
    {
        public DbContext _dbContext { get; set; }
        public DbSet<TBusiness> _entities { get; set; }
        public BaseRepository()
        {
            _dbContext = new AdventureWorks2014Entities(); 
            _entities = _dbContext.Set<TBusiness>();
        }
        public virtual TBusiness Add(TBusiness obj)
        {
            _entities.Add(obj);
            return obj;
        }

        public virtual IQueryable<TBusiness> GetAll()
        {
            return _entities.AsQueryable();
        }

        public virtual TBusiness Get(int Id)
        {
            return _entities.Find(Id);
        }

        public virtual void Update(TBusiness model)
        {
            _dbContext.Entry(model).State = EntityState.Modified;
        }

        public virtual void Delete(int Id)
        {
            TBusiness model = _entities.Find(Id);
            _entities.Remove(model);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}