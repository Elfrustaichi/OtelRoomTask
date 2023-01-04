using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTaskNewYear.Services
{
    internal interface IRoomService
    {
        public void AddRoom(int price);
        public void GetAllRoom();

        public void RezervationRoom(int id);

    }
}
