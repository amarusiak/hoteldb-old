using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Runtime.Serialization;

namespace HotelService.DTOs
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

    [DataContract]
    public class RoomTypeDTO
    {
        [DataMember]
        public int Id { get; set; }
        
        [DataMember]
        public string Name { get; set; }

        //[DataMember]
        public RoomTypeDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}