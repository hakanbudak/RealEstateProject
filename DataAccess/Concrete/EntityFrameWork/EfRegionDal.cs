using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfRegionDal : IRegionDal
    {
        public void Add(Region entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Region entity)
        {
            throw new NotImplementedException();
        }

        public Region Get(Expression<Func<Region, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Region> GetAll(Expression<Func<Region, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Region entity)
        {
            throw new NotImplementedException();
        }
    }
}
