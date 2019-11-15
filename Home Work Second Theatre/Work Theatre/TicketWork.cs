using System;
using System.Collections.Generic;

namespace Work_Theatre
{
    public class TicketWork : StangingWork
    {
        public static List<Ticket> tickets = new List<Ticket>();
        
        public static void AddTicets(string name, string hall, DateTime time, decimal price) // Добавляет концерт
        {
            if (hall == "small scene" || hall == "big scene")
            {
                tickets.Add(new Ticket(name, hall, time, price));
                return;
            }
            Console.WriteLine("Sorry, you wrote the wrong hall");
        }
    }
}