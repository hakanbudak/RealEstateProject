using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class House:IEntity
    {
        public int HouseId { get; set; }
        public int RoomId { get; set; }
        public int RegionId { get; set; }
        public string PropertyType{ get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
