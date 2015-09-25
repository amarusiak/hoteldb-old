using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HotelService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HotelService.svc or HotelService.svc.cs at the Solution Explorer and start debugging.
    public class HotelService : IHotelService
    {
        enum RoomType
        {
            Econom,
            Standart,
            Luxury
        }

        class Room
        {
            public RoomType roomType { get; set; }
            public decimal roomPrice { get; set; }

            public Room(RoomType rt, decimal pr)
            {
                roomType = rt;
                roomPrice = pr;
            }
        }

        public string DoWork()
        {
            return "Hello, world!";
        }

        public List<string> RoomInfoString()
        {
            List<string> roomList = new List<string>
            {
                "room 1",
                "room2"
            };

            return roomList;
        }

        //public List<Room> RoomInfo()
        //{
        //    List<Room> roomList = new List<Room>
        //    {
        //        new Room (RoomType.Econom, 10),
        //        new Room (RoomType.Standart, 20)
        //    };

        //    return roomList;
        //}
    }
}
