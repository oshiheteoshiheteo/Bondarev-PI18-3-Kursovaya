using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList
{
    public class Hotel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Room> Rooms { get; set; }
    // Вычисляемое свойство.
    public int Count
    {

        get
        {
            if (Rooms == null)
                return 0;
            else return Rooms.Count;
        }
    }
    // Конструкторы.
    public Hotel(string name, string address, string email,
    string phone, List<Room> rooms)
    {
        Name = name; Address = address; Email = email;
        Phone = phone; Rooms = rooms;
    }
    public Hotel()
    {
        // Для добавления через интерфейс сетки.
        Rooms = new List<Room>();
    }
    }
}
