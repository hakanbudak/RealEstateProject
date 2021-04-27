using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Room:IEntity
    {
        public int RoomId { get; set; }
        public string NumberOfRooms { get; set; }
    }
}
