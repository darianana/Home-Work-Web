﻿using System;
using System.Linq;
namespace MyEntity
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем два объекта User
                St_type balet = new St_type{Type = "Balet"};
                St_type theater = new St_type{Type = "Theater"};
                St_type opera = new St_type{Type = "Opera"};
                
                Staging staging1 = new Staging {Name = "Three masks of the king", St_type = opera, Tickets = 100, Price = 1700};
                Staging staging2 = new Staging {Name = "Prince Vladimir", St_type = balet, Tickets = 100, Price = 1900};
                Staging staging3 = new Staging {Name = "The Wedding of Figaro", St_type = opera, Tickets = 100, Price = 1500};
                Staging staging4 = new Staging {Name = "Aida", St_type = theater, Tickets = 100, Price = 1700};
                Staging staging5 = new Staging {Name = "Anna Karenina", St_type = theater, Tickets = 100, Price = 2000};
                Staging staging6 = new Staging {Name = "Swan Lake", St_type = balet, Tickets = 100, Price = 2000};
 
                // добавляем их в бд
                db.Types.AddRange(balet, theater, opera);
                
                db.Stagings.AddRange(staging1, staging2, staging3, staging4, staging5, staging6);

                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");
 
                // получаем объекты из бд и выводим на консоль
                var stagings = db.Stagings.ToList();
                Console.WriteLine("Список объектов:");
                foreach (Staging u in stagings)
                {
                    Console.WriteLine($"{u.Id}){u.Name} - {u.St_type.Type} |||||| Price - {u.Price} |||||| Quantity free place - {u.Tickets}");
                }
            }
            Console.Read();
        }
    }
}