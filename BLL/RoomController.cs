using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RoomController
    {
        RoomManagement roomManagement;

        public RoomController()
        {
            roomManagement = new RoomManagement();
        }

        public bool GetRoomAvailability(ReservationRooms reservationRooms)
        {

            
            return roomManagement.GetRoomAvailability(reservationRooms);
        }

        public bool RoomAdd(Room room)
        {
            return roomManagement.RoomAdd(room);
        }

        public int GetRoomId(Room room)
        {
            return roomManagement.GetRoom(room);
        }

        public List<int> GetRooms()
        {
            List<int> rooms;

            rooms = roomManagement.GetRooms();

            return rooms;
        }
    }
}
