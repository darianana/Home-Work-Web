using System;
using System.Collections.Generic;

namespace Work_Theatre
{
    public class TicketWork : StangingWork
    {
        public static List<Ticket> tickets = new List<Ticket>();
        
        
        public static void AddTicets(string name, string hall, int day, int month, int year, int hour, int min, decimal price, int s = 0) // Добавляет концерт
        {
            if ((hall == "small scene" || hall == "big scene") && (StangingWork.FindId(name) != -1))
            {
                DateTime time = new DateTime(year, month, day, hour, min, s);
                tickets.Add(new Ticket(name, hall, time, price));
               // Console.Write("Success!\r\n");
            }
            else
            {
                Console.WriteLine("Sorry, you wrote wrong parameters, try again");
            }
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
            for (int i = 0; i < tickets.Count; i++)
            {
                Console.WriteLine( $"{i+1}) Name {stagings[FindId(tickets[i].Name)].Type} is: {tickets[i].Name} \r\n" +
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
                
                if (tickets[FindId(name)].FreePlace == 0)
                {
                    Delete(name);
                }
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
                    
                    if (tickets[FindId(stname)].FreePlace == 0)
                    {
                        Delete(stname);
                    }
                }
            }
            return result;
        }
    }
}