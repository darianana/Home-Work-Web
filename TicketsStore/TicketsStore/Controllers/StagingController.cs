using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TicketsStore.Models;
using Microsoft.EntityFrameworkCore;

namespace TicketsStore.Controllers
{
    public class StagingController : Controller
    {
        DataContext db;

        public StagingController(DataContext context)
        {
            this.db = context;
            if (db.Theaters.Count() == 0)
            {
                Theater theater1 = new Theater
                    {Name = "Mariinsky Theater", OpenTime = new TimeSpan(12, 0, 0), CloseTime = new TimeSpan(21, 0, 0)};
                Theater theater2 = new Theater
                {
                    Name = "Pushkinsky Theater", OpenTime = new TimeSpan(11, 0, 0), CloseTime = new TimeSpan(21, 0, 0)
                };
                Theater theater3 = new Theater
                    {Name = "Modern Theater", OpenTime = new TimeSpan(16, 0, 0), CloseTime = new TimeSpan(22, 0, 0)};

                Staging staging1 = new Staging
                {
                    Name = "Three masks of the king", Price = 1700, StartTime = new DateTime(2020, 03, 20, 19, 0, 0),
                    Theater = theater1
                };
                Staging staging2 = new Staging
                {
                    Name = "Prince Vladimir", Price = 1800, StartTime = new DateTime(2021, 03, 21, 19, 0, 0),
                    Theater = theater2
                };
                Staging staging3 = new Staging
                {
                    Name = "The Wedding of Figaro", Price = 100, StartTime = new DateTime(2020, 02, 2, 19, 0, 0),
                    Theater = theater3
                };
                Staging staging4 = new Staging
                    {Name = "Aida", Price = 1700, StartTime = new DateTime(2020, 03, 3, 19, 0, 0), Theater = theater1};
                Staging staging5 = new Staging
                {
                    Name = "Anna Karenina", Price = 1900, StartTime = new DateTime(2020, 02, 18, 19, 0, 0),
                    Theater = theater2
                };
                Staging staging6 = new Staging
                {
                    Name = "Swan Lake", Price = 2000, StartTime = new DateTime(2020, 03, 1, 19, 0, 0),
                    Theater = theater3
                };

                db.Theaters.AddRange(theater1, theater2, theater3);
                db.Stagings.AddRange(staging1, staging2, staging3, staging4, staging5, staging6);
                db.SaveChanges();
            }
        }

        public async Task<IActionResult> Index(int? type, string name, int page = 1,
            SortState sortOrder = SortState.NameAsc)
        {
            int pageSize = 3;

            IQueryable<Staging> stagings = db.Stagings.Include(x => x.Theater);
            //filtrathion
            if (type != null && type != 0)
            {
                stagings = stagings.Where(p => p.TheaterId == type);
            }

            if (!String.IsNullOrEmpty(name))
            {
                stagings = stagings.Where(p => p.Name.Contains(name));
            }

            switch (sortOrder)
            {
                case SortState.NameDesc:
                    stagings = stagings.OrderByDescending(s => s.Name);
                    break;
                case SortState.PriceAsc:
                    stagings = stagings.OrderBy(s => s.Price);
                    break;
                case SortState.PriceDesc:
                    stagings = stagings.OrderByDescending(s => s.Price);
                    break;
                case SortState.TheaterAsc:
                    stagings = stagings.OrderBy(s => s.Theater.Name);
                    break;
                case SortState.TheaterDesc:
                    stagings = stagings.OrderByDescending(s => s.Theater.Name);
                    break;
                default:
                    stagings = stagings.OrderBy(s => s.Name);
                    break;
            }

            var count = await stagings.CountAsync();
            var items = await stagings.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(db.Theaters.ToList(), type, name),
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
        public IActionResult AddNew(string name, string theatername, int price, DateTime start, TimeSpan open, TimeSpan close)
        {
            var theater1 = new Theater()
            {
                Name = theatername,
                OpenTime = open,
                CloseTime = close
            };
            
            var staging = new Staging()
            {
                Name = name,
                Price = price,
                Theater = theater1,
                StartTime = start
            };

            if (staging.Name == null && staging.Price < 0)
            {
                return BadRequest();
            }
            db.Stagings.Add(staging);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}