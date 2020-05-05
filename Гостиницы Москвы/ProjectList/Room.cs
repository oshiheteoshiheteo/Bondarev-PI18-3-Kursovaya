using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList
{
    public class Room
    {
        public int Roomnumber { get; set; }
        public int Price { get; set; }
        public string Roomtype { get; set; }
        public int Person { get; set; }
        public bool Reservation { get; set; }

        // Конструкторы.
        public Room(int roomnumber, int price, string roomtype,
        int person, bool reservation)
        {
            Roomnumber = roomnumber; Price = price;
            Roomtype = roomtype; Person = person; Reservation = reservation;
        }
        public Room()
        { }
    }
}
