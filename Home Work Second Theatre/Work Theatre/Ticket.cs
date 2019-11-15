using System;

namespace Work_Theatre
{
    public class Ticket
    {
        public string Name;
        public string Hall;
        public DateTime Time;
        public decimal Price;
        public int FreePlace;

        public Ticket(string name, string hall, DateTime time, decimal price)
        {
            Name = name;
            Hall = hall;
            Time = time;
            Price = price;
            if (hall == "small scene")
            { 
                FreePlace = 72;
            }
            if (hall == "big scene")
            { 
                FreePlace = 324;
            }
        }
    }
}