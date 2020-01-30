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
                
                Staging staging1 = new Staging {Name = "Three masks of the king", Tickets = 100, Price = 1700, St_type = opera, CreationDate = DateTime.Now};
                Staging staging2 = new Staging {Name = "Prince Vladimir", Tickets = 100, Price = 1900, St_type = balet, CreationDate = DateTime.Now};
                Staging staging3 = new Staging {Name = "The Wedding of Figaro", Tickets = 100, Price = 1500, St_type = opera, CreationDate = DateTime.Now};
                Staging staging4 = new Staging {Name = "Aida", Tickets = 100, Price = 1700, St_type = theater, CreationDate = DateTime.Now};
                Staging staging5 = new Staging {Name = "Anna Karenina", Tickets = 100, Price = 2000, St_type = theater, CreationDate = DateTime.Now};
                Staging staging6 = new Staging {Name = "Swan Lake", Tickets = 100, Price = 2000, St_type = balet, CreationDate = DateTime.Now};   
                
                db.Types.AddRange(balet, theater, opera);
                db.Stagings.AddRange(staging1, staging2, staging3, staging4, staging5, staging6);
                db.SaveChanges();
            }
        }

        public async Task<IActionResult> Index(int? type, string name, int page = 1,
            SortState sortOrder = SortState.NameAsc)
        {
            int pageSize = 3;
            
            IQueryable<Staging> stagings = db.Stagings.Include(x=>x.St_type);
            //filtrathion
            if (type != null && type != 0)
            {
                stagings = stagings.Where(p => p.St_typeId == type);
            }
            if (!String.IsNullOrEmpty(name))
            {
                stagings = stagings.Where(p => p.Name.Contains(name));
            }
            //sorting
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
            
            //paginathion
            var count = await stagings.CountAsync();
            var items = await stagings.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(db.Types.ToList(), type, name),
                Stagings = items
            };
            return View(viewModel);
        }
        [HttpGet]
        public IActionResult AddNew()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNew(string name, string type, int tickets, int price)
        {
            var type1 = new St_type
            {
                Type = type
            };
            
            var staging = new Staging()
            {
                Name = name,
                St_type = type1,
                Tickets = tickets,
                Price = price,
                CreationDate = DateTime.Now
            };

            if (staging.Name == null && staging.Tickets < 0 && staging.Price < 0)
            {
                return BadRequest();
            }
            db.Stagings.Add(staging);
            db.SaveChanges();
            return RedirectToAction("Index");
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