using System;
using Work_Theatre;

namespace Home_Work_Second_Theatre
{
    class Program
    {
        static void Main(string[] args)
        {
               // StangingWork.AddConcert("Gore ot uma", "Griboedov", "staging");
              //  StangingWork.SortType("staging");
              //  TicketWork.AddTicets("Gore ot uma", "big scene", "2019.12.12 18:30", 750);
               // TicketWork.ShowAll();
            CafeteriaWork.AddProducts("Сэндвич", 5, 50);
            CafeteriaWork.AddProducts("Пироженное черепаха",25 ,250 );
            CafeteriaWork.AddProducts("Тирамису", 22,300 );
            CafeteriaWork.AddProducts("Пироженное медовик", 30,250 );
            CafeteriaWork.AddProducts("Трубочка с заварным кремом",10 ,150 );
            CafeteriaWork.AddProducts("Трубочка с сырным кремом",12 , 150);
            CafeteriaWork.AddProducts("Красный Бархат", 15, 350);
            CafeteriaWork.AddProducts("Вода Aqua негаз",25 , 100);
            CafeteriaWork.AddProducts("Вода Aqua газ",25 , 100);
            CafeteriaWork.AddProducts("Капучино маленький 250ml", 100, 170);
            CafeteriaWork.AddProducts("Капучино большой 500ml", 100, 250);
            CafeteriaWork.AddProducts("Американо", 100,170);
            CafeteriaWork.AddProducts("Мокачино",100 ,200 );
            CafeteriaWork.AddProducts("Фраппе",100 ,200 );
            CafeteriaWork.AddProducts("Матча", 25, 200);
            CafeteriaWork.AddProducts("Вино Nebiollo, 125ml", 5,1200 );
            CafeteriaWork.AddProducts("Вино Sauvignon blanc, 125ml", 10, 1100 );
            CafeteriaWork.AddProducts("Вино Chardonnay, 125ml",5 , 500);
            
            StangingWork.AddConcert("Князь Владимир", "Илзе Лиепа", "staging");
            StangingWork.AddConcert("Петя и волк", "Валерий Гергиев", "staging");
            StangingWork.AddConcert("Три маски короля", "Вячеслав Заренков", "staging");
            StangingWork.AddConcert("Свадьба Фигаро", "Павел Шмулевич", "opera");
            StangingWork.AddConcert("Кащей Бессмертный", "Александра Иосифиди", "opera");
            StangingWork.AddConcert("Аида", "Владимир Феляуэр", "opera");
            StangingWork.AddConcert("Анна Каренина", "Андрей Петренко", "balet");
            StangingWork.AddConcert("Лебединое озеро", "Ярослав Байбордин", "balet");
            StangingWork.AddConcert("Богема", "Владислав Куприянов", "balet");
            
           VipWork.AddGuest("Ксандер Париш", 25);
           VipWork.AddGuest("Александр Никитин", 10);
           VipWork.AddGuest("Наталия Энтелис", 9);
           VipWork.AddGuest("Александр Михайлов", 7);
           VipWork.AddGuest("Ольга Пикколо", 5);
           VipWork.AddGuest("Владимир Феляуэр", 5);
           VipWork.AddGuest("Юрий Смекалов", 6);
           VipWork.AddGuest("Оксана Скорик", 3);
           VipWork.AddGuest("Марко Юусела", 15);
            
           TicketWork.AddTicets("Свадьба Фигаро", "small scene", 9, 11, 2019, 18,30, 4700);
           TicketWork.AddTicets("Лебединое озеро", "small scene", 2, 11, 2019, 18,30, 3500);
           TicketWork.AddTicets("Три маски короля", "small scene", 22, 11, 2019, 18,30, 3700);
           
           DirectorWork.AddAccount("Дарья Рыбка", "1350");
       
           string role = "";
               while (role != "Exit")
               {
                   Console.Write("Choose your role:\r\n" +
                                 "1. Worker\r\n" +
                                 "2. Visitor\r\n" +
                                 "3. Exit\r\n" );
                   role = Console.ReadLine();
                   if (role == "Worker")
                   {
                       string mode = "";
                       while (mode != "Exit")
                       {
                           Console.Write("Choose your mode: \r\n" +
                                         "1. Seller\r\n" +
                                         "2. Director\r\n" +
                                         "3. Barmaid\r\n" +
                                         "4. Exit\r\n");
                           mode = Console.ReadLine();
                           if (mode == "Seller")
                           {
                               string action = "0";
                               while (action != "4")
                               {
                                   Console.Write("What you need to do? (Choose number) \r\n" +
                                                 "1. Add new staging\r\n" +
                                                 "2. Sale ticket for VIP\r\n" +
                                                 "3. Sale ticket\r\n" +
                                                 "4. That's all\r\n");
                                   action = Console.ReadLine();
                                   if (action == "1")
                                   {
                                       Console.Write("Input staging name:\r\n"); //ДОБАВИТЬ ПРОВЕРКИ
                                       string staging_name = Console.ReadLine();
                                       Console.Write("Input type hall (big scene or small):\r\n");
                                       string hall_type = Console.ReadLine();
                                       Console.Write("Input data dd mm yy:\r\n");
                                       int dd = Convert.ToInt16(Console.ReadLine());
                                       int mm = Convert.ToInt16(Console.ReadLine());
                                       int yy = Convert.ToInt16(Console.ReadLine());
                                       Console.Write("Input input data time hh mm:\r\n");
                                       int hh = Convert.ToInt16(Console.ReadLine());
                                       int mi = Convert.ToInt16(Console.ReadLine());
                                       Console.Write("Input price:");
                                       decimal prise = Convert.ToDecimal(Console.ReadLine());
                                       TicketWork.AddTicets(staging_name, hall_type, dd, mm, yy, hh, mi, prise);
                                   }
    
                                   else if (action == "2") // ДОБАВИТь ПРОВЕРКИ
                                   {
                                       Console.Write("Ask customer his or her name, and input:\r\n");
                                       string vip = Console.ReadLine();
                                       Console.Write("Name staging:\r\n");
                                       string name = Console.ReadLine();
                                       Console.Write("Quantity ticket:\r\n");
                                       int quan = Convert.ToInt16(Console.ReadLine());
                                       decimal price = TicketWork.SaleTicket(quan, name, vip);
                                       if (VipWork.ThereIs(name))
                                       {
                                           Console.Write($"Your purchase amount amounted to: {price}P.\r\n");
                                       }
                                       else
                                       {
                                           Console.WriteLine("Sorry, you don't VIP person");
                                       }
                                   }

                                   else if (action == "3")
                                   {
                                       Console.Write("Name staging:\r\n");
                                       string name = Console.ReadLine();
                                       Console.Write("Quantity ticket:\r\n");
                                       int quan = Convert.ToInt16(Console.ReadLine());
                                       decimal price = TicketWork.SaleTicket(quan, name);
                                       Console.Write($"Your purchase amount amounted to: {price}P.\r\n");
                                   }
                                   
                                   else if (action == "4")
                                   {
                                       Console.Write("Goodbye!\r\n");
                                   }
                                   
                                   else
                                   {
                                       Console.Write("You entered a nonexistent command, try again\r\n");
                                   }
                                   
                               }
                           }

                           if (mode == "Director")
                           {
                               Console.Write("Hello! Please enter your login: \r\n");
                               string login = Console.ReadLine();
                               Console.Write("Please enter your password: \r\n");
                               string password = Console.ReadLine();
                               if (DirectorWork.IsDirector(login))
                               {
                                   string action = "0";
                                   while (action != "6")
                                   {
                                       Console.Write("What you need to do? (Choose number)\r\n" +
                                                     "1. Add some staging.\r\n" +
                                                     "2. See all the productions of one director.\r\n" +
                                                     "3. Add staging ticket.\r\n" +
                                                     "4. Add VIP guest.\r\n" +
                                                     "5. Delete some staging.\r\n" +
                                                     "6. That's all. \r\r");
                                       action = Console.ReadLine();
                                       if (action == "1")
                                       {
                                           Console.Write("Input staging name:\r\n");
                                           string staging_name = Console.ReadLine();
                                           Console.Write("Input staging director:\r\n");
                                           string staging_director = Console.ReadLine();
                                           Console.Write("Input staging type (balet, opera, staging): \r\n");
                                           string staging_type = Console.ReadLine();
                                           StangingWork.AddConcert(staging_name, staging_director, staging_type);
                                       }

                                       else if (action == "2")
                                       {
                                           Console.Write("Enter name director:\r\n"); //Добавить ситуацию, когда не найден режиссер
                                           string name = Console.ReadLine();
                                           StangingWork.SortName(name);
                                       }

                                       else if (action == "3")
                                       {
                                           Console.Write("Input staging name:\r\n");
                                           string staging_name = Console.ReadLine();
                                           Console.Write("Input type hall (big scene or small):\r\n");
                                           string hall_type = Console.ReadLine();
                                           Console.Write("Input data dd mm yy:\r\n");
                                           int dd = Convert.ToInt16(Console.ReadLine());
                                           int mm = Convert.ToInt16(Console.ReadLine());
                                           int yy = Convert.ToInt16(Console.ReadLine());
                                           Console.Write("Input input data time hh mm:\r\n");
                                           int hh = Convert.ToInt16(Console.ReadLine());
                                           int mi = Convert.ToInt16(Console.ReadLine());
                                           Console.Write("Input price:");
                                           decimal prise = Convert.ToDecimal(Console.ReadLine());
                                           TicketWork.AddTicets(staging_name, hall_type, dd, mm, yy, hh, mi, prise);
                                       }
                                       
                                       else if (action == "4")
                                       {
                                           Console.Write("Enter name:\r\n");
                                           string name = Console.ReadLine();
                                           int sale = 5;
                                           VipWork.AddGuest(name, 5);
                                       }
                                       
                                       else if (action == "5")
                                       {
                                           Console.Write("Enter staging, which you want delete:\r\n");
                                           string name = Console.ReadLine();
                                           StangingWork.Delete(name);
                                       }
                                       
                                       else if (action == "6")
                                       {
                                           Console.Write("Goodbye!\r\n");
                                       }
                                       
                                       else
                                       {
                                           Console.Write("You entered a nonexistent command, try again\r\n"); 
                                       }
                                   }
                               }
                               else
                               {
                                   Console.Write("Sorry, you don't director\r\n");
                               }
                           }

                           else if (mode == "Barmaid")
                           {
                               string action = "0";
                               while (action != "4")
                               {
                                   Console.Write("What you need to do? (Choose number)\r\n" +
                                                 "1. Add some product.\r\n" +
                                                 "2. Sale product.\r\n" +
                                                 "3. See all products in cafeteria.\r\n" +
                                                 "4. That's all. \r\r");
                                   action = Console.ReadLine();
                                   if (action == "1")
                                   {
                                       //Products.Add(new Cafeteria(product, quantity, price));
                                       Console.Write("Enter product name:\r\n");
                                       string name = Console.ReadLine();
                                       Console.Write("Enter quantity: \r\n");
                                       int quantity = Convert.ToInt16(Console.ReadLine());
                                       Console.Write("Enter price:\r\n");
                                       int price = Convert.ToInt16(Console.ReadLine());
                                       CafeteriaWork.AddProducts(name, quantity, price);
                                   }

                                   else if (action == "2")
                                   {
                                       //(string product, int quantity)
                                       Console.Write("Enter product name:\r\n");
                                       string name = Console.ReadLine();
                                       Console.Write("Enter quantity: \r\n");
                                       int quantity = Convert.ToInt16(Console.ReadLine());
                                       decimal price = CafeteriaWork.Sale(name, quantity);
                                       if (price != 0)
                                       {
                                           Console.Write($"Your purchase amount amounted to: {price}P.\r\n");
                                       }
                                       else
                                       {
                                           Console.Write("Something wrong");
                                       }
                                   }
                                   
                                   else if (action == "3")
                                   {
                                       CafeteriaWork.ShowAll();
                                   }
                                   
                                   else if (action == "4")
                                   {
                                       Console.Write("Goodbye!\r\n");
                                   }
                                   
                                   else
                                   {
                                       Console.Write("You entered a nonexistent command, try again\r\n"); 
                                   }
                                   
                               }
                           }

                           else if (mode == "Exit")
                           {
                               Console.Write("Goodbye!\r\n");
                           }

                           else
                           {
                               Console.Write("You entered a nonexistent command, try again\r\n"); 
                           }
                       }
                   } 
                   
                   else if (role == "Visitor")
                   {
                       
                   }
               } 
           
        }
    }
}