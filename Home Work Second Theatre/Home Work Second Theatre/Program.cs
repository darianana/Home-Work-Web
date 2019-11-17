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
            CafeteriaWork.AddProducts("Черепаха",25 ,250 );
            CafeteriaWork.AddProducts("Тирамису", 22,300 );
            CafeteriaWork.AddProducts("Медовик", 30,250 );
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
            
           TicketWork.AddTicets("Свадьба Фигаро", "small scene", "17.11.2019 19:00", 4700);
           TicketWork.AddTicets("Свадьба Фигаро", "big scene", "10.12.2019 18:00", 1700);
           TicketWork.AddTicets("Свадьба Фигаро", "small scene", "15.12.2019 18:00", 1700);
           TicketWork.AddTicets("Свадьба Фигаро", "big scene", "22.12.2019 18:30", 1700);
           
           TicketWork.AddTicets("Лебединое озеро", "small scene", "01.01.2020 12:00", 3500);
           TicketWork.AddTicets("Лебединое озеро", "big scene", "05.12.2019 18:00", 1900);
           TicketWork.AddTicets("Лебединое озеро", "small scene", "15.12.2019 18:00", 1700);
           TicketWork.AddTicets("Лебединое озеро", "big scene", "22.12.2019 18:30", 1700);
           
           TicketWork.AddTicets("Три маски короля", "small scene", "10.11.2019 19:00", 3700);
           TicketWork.AddTicets("Три маски короля", "big scene", "31.12.2019 18:00", 1700);
           TicketWork.AddTicets("Три маски короля", "small scene", "15.12.2019 18:00", 2500);
           TicketWork.AddTicets("Три маски короля", "big scene", "22.12.2019 18:30", 1700);
           TicketWork.ShowAll();
        }
    }
}