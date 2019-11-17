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
            try
            {
                tickets.RemoveAt(FindId(name));
            }
            catch 
            {
                Console.Write("Sorry, couldn't delete the staging, maybe you're mistake in name, try again!");
            }
        }
        public static void ShowAll() // Выводит все билеты
        {
            for (int i = 0; i < stagings.Count; i++)
            {
                Console.WriteLine( $"Name {stagings[FindId(tickets[i].Name)].Type} is: {tickets[i].Name} \r\n" +
                                   $"Director {stagings[FindId(tickets[i].Name)].Type} is: {stagings[FindId(tickets[i].Name)].Director} \r\n" +
                                   $"Hall is: {tickets[i].Hall} \r\n" +
                                   $"Price is: {tickets[i].Price} \r\n" +
                                   $"Date {stagings[FindId(tickets[i].Name)].Type} is: {tickets[i].Time}\r\n");
            }
        }

        public static decimal SaleTicket(int quant, string name) // Возвращает сумму // если 0, то (Sorry, we have less free place than you need)
        {
            decimal result = 0;
            if (quant < tickets[FindId(name)].FreePlace)
            {
                result = quant * tickets[FindId(name)].Price;
                tickets[FindId(name)].FreePlace -= quant;
            }
            return result;
        }

        public static decimal SaleTicket(int quant, string stname, string vipname) 
        {
            decimal result = 0;
            if (VipWork.ThereIs(vipname))
            {
                if (quant < tickets[FindId(stname)].FreePlace)
                {
                    result = quant * tickets[FindId(stname)].Price;
                    result -= (result / 100) * VipWork.SizeSale(vipname);
                    tickets[FindId(stname)].FreePlace -= quant;
                    VipWork.AddPurchases(vipname, quant);
                }
            }
            return result;
        }
    }
}