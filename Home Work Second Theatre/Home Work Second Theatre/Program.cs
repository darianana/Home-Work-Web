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
       
           string role = "";
               while (role != "Exit")
               {
                   Console.Write("Choose your role:\r\n" +
                                 "1. Worker\r\n" +
                                 "2. Visitor\r\n" +
                                 "3. Exit\r\n" +
                                 "\r\n");
                   role = Console.ReadLine();
                   if (role == "Worker")
                   {
                       string mode = "";
                       while (mode != "Exit")
                       {
                           Console.Write("Choose your mode: \r\n" +
                                         "1. Seller\r\n" +
                                         "2. Director\r\n" +
                                         "3. Barmaid\r\n");
                           mode = Console.ReadLine();
                           if (mode == "Seller")
                           {
                               int action = 0;
                               while (action != 4)
                               {
                                   Console.Write("What you need to do? (Choose number) \r\n" +
                                                 "1. Add new staging\r\n" +
                                                 "2. Sale ticket for VIP\r\n" +
                                                 "3. Sale ticket\r\n" +
                                                 "4. That's all\r\n");
                                   action = Convert.ToInt16(Console.ReadLine());
                                   if (action == 1)
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
    
                                   else if (action == 2) // ДОБАВИТь ПРОВЕРКИ
                                   {
                                       Console.Write("Ask customer his or her name, and input:\r\n");
                                       string vip = Console.ReadLine();
                                       Console.Write("Name staging:\r\n");
                                       string name = Console.ReadLine();
                                       Console.Write("Quantity ticket:\r\n");
                                       int quan = Convert.ToInt16(Console.ReadLine());
                                       decimal price = TicketWork.SaleTicket(quan, name, vip);
                                       Console.Write($"Your purchase amount amounted to: {price}P.\r\n");
                                   }

                                   else if (action == 3)
                                   {
                                       Console.Write("Name staging:\r\n");
                                       string name = Console.ReadLine();
                                       Console.Write("Quantity ticket:\r\n");
                                       int quan = Convert.ToInt16(Console.ReadLine());
                                       decimal price = TicketWork.SaleTicket(quan, name);
                                       Console.Write($"Your purchase amount amounted to: {price}P.\r\n");
                                   }
                                   else if(action == 4)
                                   {
                                       Console.Write("Goodbye!\r\n");
                                   }
                               }
                           }
                       }
                   }
           } 
           
        }
    }
}