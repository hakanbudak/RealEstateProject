using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfHouseDal : IHouseDal
    {
        public void Add(House entity)
        {
            using (RealStateContext context = new RealStateContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(House entity)
        {
            using (RealStateContext context = new RealStateContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public House Get(Expression<Func<House, bool>> filter)
        {
            using (RealStateContext context = new RealStateContext())
            {
                return context.Set<House>().SingleOrDefault(filter);
            }
        }

        public List<House> GetAll(Expression<Func<House, bool>> filter = null)
        {
            using (RealStateContext context = new RealStateContext())
            {
                return filter == null ? context.Set<House>().ToList() : context.Set<House>().Where(filter).ToList();
            }
        }

        public void Update(House entity)
        {
            using (RealStateContext context = new RealStateContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
