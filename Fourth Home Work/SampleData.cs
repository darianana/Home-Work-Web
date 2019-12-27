using System.Linq;
using Fourth_Home_Work.Models;

namespace Fourth_Home_Work
{
    public class SampleData
    {
         public static void Initialize(Database context)
        { 
           // context.Database.EnsureDeleted();
            if (!context.Films.Any())
            {
                context.Films.Add(
                    new Film()
                    {
                        Name = "Черное рождество",
                        Tickets = 100,
                        Type = "Театральная постановка",
                        Date = "07.01.2020 18:30",
                        Price = "1700"
                    }
                );
                context.Films.Add(
                    new Film()
                    {
                        Name = "Юдифь",
                        Tickets = 100,
                        Type = "Балет",
                        Date = "17.01.2020 18:30",
                        Price = "2000"
                    }
                );   
                context.Films.Add(
                    new Film()
                    {
                        Name = "Заир",
                        Tickets = 100,
                        Type = "Опера в 3-х действиях",
                        Date = "03.01.2020 18:30",
                        Price = "1500"
                    }
                );
            }

            if (!context.Directors.Any())
            {
                context.Directors.Add(
                    new Director()
                    {
                        Name = "Ксандер Париш",
                        Type = "Балет"
                    });
                context.Directors.Add(
                    new Director()
                    {
                        Name = "Наталия Энтелис",
                        Type = "Режиссер"
                    });
                context.Directors.Add(
                    new Director()
                    {
                        Name = "Юрий Смекалов",
                        Type = "Композитор"
                    });
            }
            context.SaveChanges();
        }
    }
}