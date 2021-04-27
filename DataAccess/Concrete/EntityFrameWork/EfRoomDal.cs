using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfRoomDal : IRoomDal
    {
        public void Add(Room entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Room entity)
        {
            throw new NotImplementedException();
        }

        public Room Get(Expression<Func<Room, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Room> GetAll(Expression<Func<Room, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Room entity)
        {
            throw new NotImplementedException();
        }
    }
}
