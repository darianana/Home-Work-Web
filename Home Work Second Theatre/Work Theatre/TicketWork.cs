using System;
using System.Collections.Generic;

namespace Work_Theatre
{
    public class TicketWork : StangingWork
    {
        public static List<Ticket> tickets = new List<Ticket>();
        
        public static void AddTicets(string name, string hall, string time, decimal price) // Добавляет концерт
        {
            if (hall == "small scene" || hall == "big scene")
            {
                tickets.Add(new Ticket(name, hall, time, price));
                return;
            }
            Console.WriteLine("Sorry, you wrote the wrong hall");
        }
        
        public static int FindId(string name)
        {
            return(tickets.FindIndex(tickets => tickets.Name == name));
        }

        public static void Delete(string name)
        {
            tickets.RemoveAt(FindId(name));
        }

        public static void ShowAll()
        {
            for (int i = 0; i < stagings.Count; i++)
            {
                Console.WriteLine( $"Name {stagings[FindId(tickets[i].Name)].Type} is: {tickets[i].Name} \r\n" +
                                   $"Director {stagings[FindId(tickets[i].Name)].Type} is: {stagings[FindId(tickets[i].Name)].Director} \r\n" +
                                   $"Hall is: {tickets[i].Hall} \r\n" +
                                   $"Price is: {tickets[i].Price} \r\n" +
                                   $"Date {stagings[FindId(tickets[i].Name)].Type} is: {tickets[i].Time}");
            }
        }
    }
}