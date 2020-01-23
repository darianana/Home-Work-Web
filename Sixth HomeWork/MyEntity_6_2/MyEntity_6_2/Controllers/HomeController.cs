using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyEntity_6_2.Models;
using Microsoft.EntityFrameworkCore;

namespace MyEntity_6_2.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            this.db = context;
            //context.Database.EnsureDeleted();
            if (!db.Types.Any())
            {
                St_type balet = new St_type { Type = "Balet" };
                St_type theater = new St_type { Type = "Theater" };
                St_type opera = new St_type { Type = "Opera" };

                Staging staging1 = new Staging { Name = "Three masks of the king", St_type = opera, Tickets = 100, Price = 1700 };
                Staging staging2 = new Staging { Name = "Prince Vladimir", St_type = balet, Tickets = 100, Price = 1900 };
                Staging staging3 = new Staging { Name = "The Wedding of Figaro", St_type = opera, Tickets = 100, Price = 1500 };
                Staging staging4 = new Staging { Name = "Aida", St_type = theater, Tickets = 100, Price = 1700 };
                Staging staging5 = new Staging { Name = "Anna Karenina", St_type = theater, Tickets = 100, Price = 2000 };
                Staging staging6 = new Staging { Name = "Swan Lake", St_type = balet, Tickets = 100, Price = 2000 };
                db.Types.AddRange(balet, theater, opera);
                db.Stagings.AddRange(staging1, staging2, staging3,
                    staging4, staging5, staging6);
                db.SaveChanges();
            }
        }
         public IActionResult Index()
        {
            return View();
        }

        public IActionResult Eager()
        {
            var guests = db.Stagings.Include(u => u.St_type).ToList();
            return View(guests);
        }

        public IActionResult Explicit()
        {
            St_type type = db.Types.FirstOrDefault();
            db.Stagings.Where(p => p.St_typeId == type.Id).Load();
            return View(db.Stagings.ToList());
        }

        public IActionResult Lazy()
        {
            var stagings = db.Stagings.ToList();
            return View(stagings);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
