using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fifth_HomeWork.Models; // пространство имен моделей и контекста данных
 
namespace Fifth_HomeWork.Controllers
{
    public class HomeController : Controller
    {
        DataContext db;
        public HomeController(DataContext context)
        {
            this.db = context;
            if (db.Types.Count() == 0)
            {
                St_type balet = new St_type{Type = "Balet"};
                St_type theater = new St_type{Type = "Theater"};
                St_type opera = new St_type{Type = "Opera"};
                
                Staging staging1 = new Staging {Name = "Three masks of the king", St_type = opera, Tickets = 100, Price = 1700, CreationDate = DateTime.Now};
                Staging staging2 = new Staging {Name = "Prince Vladimir", St_type = balet, Tickets = 100, Price = 1900, CreationDate = DateTime.Now};
                Staging staging3 = new Staging {Name = "The Wedding of Figaro", St_type = opera, Tickets = 100, Price = 1500, CreationDate = DateTime.Now};
                Staging staging4 = new Staging {Name = "Aida", St_type = theater, Tickets = 100, Price = 1700, CreationDate = DateTime.Now};
                Staging staging5 = new Staging {Name = "Anna Karenina", St_type = theater, Tickets = 100, Price = 2000, CreationDate = DateTime.Now};
                Staging staging6 = new Staging {Name = "Swan Lake", St_type = balet, Tickets = 100, Price = 2000, CreationDate = DateTime.Now};   
                
                db.Types.AddRange(balet, theater, opera);
                db.Stagings.AddRange(staging1, staging2, staging3, staging4, staging5, staging6);
                db.SaveChanges();
            }
        }

        public async Task<IActionResult> Index(SortState sortOrder = SortState.NameAsc)
        {
            IQueryable<Staging> stagings = db.Stagings.Include(x=>x.St_type);
            switch (sortOrder)
            {
                case SortState.NameDesc:
                    stagings = stagings.OrderByDescending(s => s.Name);
                    break;
                case SortState.TicketsAsc:
                    stagings = stagings.OrderBy(s => s.Tickets);
                    break;
                case SortState.TicketsDesc:
                    stagings = stagings.OrderByDescending(s => s.Tickets);
                    break;
                case SortState.PriceAsc:
                    stagings = stagings.OrderBy(s => s.Price);
                    break;
                case SortState.PriceDesc:
                    stagings = stagings.OrderByDescending(s => s.Price);
                    break;
                default:
                    stagings = stagings.OrderBy(s => s.Name);
                    break;
            }
            
            IndexViewModel viewModel = new IndexViewModel
            {
                Stagings = await stagings.AsNoTracking().ToListAsync(),
                SortViewModel = new SortViewModel(sortOrder),
            };
            return View(viewModel);
        }

        /*public async Task<IActionResult> Index()
        {
            return View(await db.Stagings.ToListAsync());
        }
        
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(Staging _staging)
        {
            db.Stagings.Add(_staging);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }*/
    }
}