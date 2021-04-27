using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHouseService
    {
        List<House> GetAll();
        List<House> GetAllByRegionId(int id);
        List<House> GetByPrice(int min,int max);
    }
}
