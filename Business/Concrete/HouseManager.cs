using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class HouseManager : IHouseService
    {
        IHouseDal _houseDal;
        public HouseManager(IHouseDal houseDal)
        {
            _houseDal = houseDal;
        }
        public List<House> GetAll()
        {
            return _houseDal.GetAll();
        }

        public List<House> GetAllByRegionId(int id)
        {
            return _houseDal.GetAll(p=>p.RegionId==id);
        }

        public List<House> GetByPrice(int min, int max)
        {
            return _houseDal.GetAll(p=>p.Price>=min && p.Price<=max);
        }
    }
}
