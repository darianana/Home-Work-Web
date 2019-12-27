using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Fourth_Home_Work.Models;

namespace Fourth_Home_Work.Controllers
{
    public class HomeController : Controller
    {
        Database _database;
        public HomeController(Database context)
        {
            _database = context;
        }

        public IActionResult Main()
        {
            return View();
        }
        
        public IActionResult Index(string searchString)
        {
            if (searchString == null)
            {
                return View(_database.Films.ToList());
            }
           List<Film> films = _database.Films.Where(item =>
                item.Name.Contains(searchString) ||
                item.Tickets.ToString().Contains(searchString) ||
                item.Type.Contains(searchString) ||
                item.Price.Contains(searchString) ||
                item.Date.ToString().Contains(searchString)).ToList();
            return View(films);
        }
        
        public IActionResult Index1(string searchString)
        {
            if (searchString == null)
            {
                return View(_database.Directors.ToList());
            }
            List<Director> directors = _database.Directors.Where(item =>
                item.Name.Contains(searchString)||
                item.Type.Contains(searchString)).ToList();
            return View(directors);
        }

        [HttpGet]
        public IActionResult AddNewFilm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewFilm(string name, int tickets, string type, string date, string price)
        {
            var film = new Film
            {
                Name = name,
                Tickets = tickets,
                Type = type,
                Date = date,
                Price = price
            };
            if ((film.Type == null && film.Price == null) || (film.Tickets == 0))
            {
                return BadRequest();
            }
            _database.Films.Add(film);
            _database.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult FilmInfo(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            var film = _database.Films.FirstOrDefault(item => item.Id == id);
            if (film == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Film = film;
            return View();
        }
        
        [HttpGet]  
        public IActionResult DeleteFilm(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            } 
            var film = _database.Films.FirstOrDefault(item => item.Id == id);
            ViewBag.Film = film;
            return View();
        }

        [HttpPost]
        public IActionResult DeleteFilm(Film film)
        {
            _database.Films.Remove(film);
            _database.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditFilm(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            } 
            var film = _database.Films.FirstOrDefault(item => item.Id == id);
            ViewBag.Film = film;
            return View();
        }
        [HttpPost]
        public IActionResult EditFilm(Film film)
        {
            _database.Films.Update(film);
            _database.SaveChanges();
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult AddNewDirector()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewDirector(string name, string type)
        {
            var director = new Director
            {
                Name = name,
                Type = type
            };
            _database.Directors.Add(director);
            _database.SaveChanges();
            return RedirectToAction("Index1");
        }
        
        public IActionResult DirectorInfo(int? id)
        {
            if (id == null) return RedirectToAction("Index1");
            var director = _database.Directors.FirstOrDefault(item => item.Id == id);
            if (director == null)
            {
                return RedirectToAction("Index1");
            }
            ViewBag.Director = director;
            return View();
        }
        
        [HttpGet]  
        public IActionResult DeleteDirector(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index1");
            } 
            var director = _database.Directors.FirstOrDefault(item => item.Id == id);
            ViewBag.Director = director;
            return View();
        }

        [HttpPost]
        public IActionResult DeleteDirector(Director director)
        {
            _database.Directors.Remove(director);
            _database.SaveChanges();
            return RedirectToAction("Index1");
        }
        
        [HttpGet]
        public IActionResult EditDirector(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index1");
            } 
            var director = _database.Directors.FirstOrDefault(item => item.Id == id);
            ViewBag.Director = director;
            return View();
        }
        [HttpPost]
        public IActionResult EditDirector(Director director)
        {
            _database.Directors.Update(director);
            _database.SaveChanges();
            return RedirectToAction("Index1");
        }
    }
}