using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using HotelService.DTOs;

namespace HotelService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHotelService" in both code and config file together.
    [ServiceContract]
    public interface IHotelService
    {
        [OperationContract]
        string DoWork();
        [OperationContract]
        List<string> RoomInfoString();
        [OperationContract]
        List<RoomTypeDTO> RoomInfoRoomTypeDTO();
    }
}
