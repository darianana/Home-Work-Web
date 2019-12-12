using System;
using System.Collections.Generic;

namespace Work_Theatre
{
    public class CafeteriaWork
    {
        public static List<Cafeteria> Products = new List<Cafeteria>();

        public static void AddProducts(string product, int quantity, int price)
        {
            if (quantity != 0 && price != 0)
            {
                Products.Add(new Cafeteria(product, quantity, price));
             //   Console.Write("Success!\r\n");
            }
            else
            {
                Console.WriteLine("You enter wrong data.\r\n");
            }
        }

        public static int FindId(string product)
        {
            return Products.FindIndex(Products => Products.Product == product);
        }

        public static void Delete(string product)
        {
            Products.RemoveAt(FindId(product));
        }
        
        public static decimal Sale(string product, int quantity)
        {
            int i = FindId(product);
            decimal price = 0;
            if (i != -1)
            {
                if (Products[i].Quantity >= quantity)
                {
                    price = Products[i].Price * quantity;
                    Products[i].Quantity -= quantity;
                    if (Products[i].Quantity == 0)
                    {
                        Delete(product);
                    }
                }
            }
            return price;
        }

        public static void ShowAll()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine($"{i+1}) Product name: {Products[i].Product}\r\n" +
                              $"Price {Products[i].Product}: {Products[i].Price}\r\n" +
                              $"Quantity {Products[i].Product}: {Products[i].Quantity}");   
            }
        }

        public static void ShowAllProducts()
        {
            Console.WriteLine("All products:");
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine($"{i+1}) {Products[i].Product}");
            }
        }
        
    }
}