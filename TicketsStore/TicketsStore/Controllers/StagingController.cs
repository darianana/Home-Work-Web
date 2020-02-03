using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicketsStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore.Internal;

namespace TicketsStore.Controllers
{
    public class StagingController: Controller
    {
        DataContext db;

        public StagingController(DataContext context)
        {
            this.db = context;
            if (!EnumerableExtensions.Any(db.Theaters))
            {
                Theater theater1 = new Theater{
                    Name = "Mariinsky Theater", OpenTime = new TimeSpan(12, 0, 0), CloseTime = new TimeSpan(21, 0, 0)
                };
                Theater theater2 = new Theater
                {
                    Name = "Pushkinsky Theater", OpenTime = new TimeSpan(11, 0, 0), CloseTime = new TimeSpan(21, 0, 0)
                };
                Theater theater3 = new Theater
                    {Name = "Modern Theater", OpenTime = new TimeSpan(16, 0, 0), CloseTime = new TimeSpan(22, 0, 0)};

                Staging staging1 = new Staging
                {
                    Name = "Three masks of the king", Price = 1700, StartTime = "19.02.2020 19:00",
                    Theater = theater1
                };
                Staging staging2 = new Staging
                {
                    Name = "Prince Vladimir", Price = 1800, StartTime = "15.03.2020 19:00",
                    Theater = theater2
                };
                Staging staging3 = new Staging
                {
                    Name = "The Wedding of Figaro", Price = 100, StartTime = "21.02.2020 19:00",
                    Theater = theater3
                };
                Staging staging4 = new Staging
                    {Name = "Aida", Price = 1700, StartTime = "19.03.2020 19:00", Theater = theater1};
                Staging staging5 = new Staging
                {
                    Name = "Anna Karenina", Price = 1900, StartTime = "29.02.2020 19:00",
                    Theater = theater2
                };
                Staging staging6 = new Staging
                {
                    Name = "Swan Lake", Price = 2000, StartTime ="19.02.2020 19:00",
                    Theater = theater3
                };

                db.Theaters.AddRange(theater1, theater2, theater3);
                db.Stagings.AddRange(staging1, staging2, staging3, staging4, staging5, staging6);
                db.SaveChanges();
            }
        }
        [Authorize(Roles = "admin,moderator, consultant, customer")]
        public async Task<IActionResult> SimpleView(int? type, string name, int page = 1,
            SortState sortOrder = SortState.NameAsc)
        {
            int pageSize = 4;

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
                case SortState.StartTimeAsc:
                    stagings = stagings.OrderBy(s => s.StartTime);
                    break;
                case SortState.StartTimeDesc:
                    stagings = stagings.OrderByDescending(s => s.StartTime);
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
        public IActionResult AddNew(string name, string theatername, int price, string starttime)
        {
            var theater1 = new Theater()
            {
                Name = theatername,
            };
            
            var staging = new Staging()
            {
                Name = name,
                Price = price,
                StartTime = starttime,
                Theater = theater1
            };

            if (staging.Name == null && staging.Price < 0)
            {
                return BadRequest();
            }
            db.Stagings.Add(staging);
            db.SaveChanges();
            return RedirectToAction("SimpleView");
        }
        [HttpGet]  
        public IActionResult DeleteStaging(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("SimpleView");
            } 
            var Staging = db.Stagings.FirstOrDefault(item => item.Id == id);
            ViewBag.Staging = Staging;
            return View();
        }

        [HttpPost]
        public IActionResult DeleteStaging(Staging Staging)
        {
            db.Stagings.Remove(Staging);
            db.SaveChanges();
            return RedirectToAction("SimpleView");
        }
        
        [HttpGet]
        public IActionResult EditStaging(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("SimpleView");
            } 
            var Staging = db.Stagings.FirstOrDefault(item => item.Id == id);
            ViewBag.Staging = Staging;
            return View();
        }
        [HttpPost]
        public IActionResult EditStaging(Staging staging)
        {
            db.Stagings.Update(staging);
            db.SaveChanges();
            return RedirectToAction("SimpleView");
        }
    }
}