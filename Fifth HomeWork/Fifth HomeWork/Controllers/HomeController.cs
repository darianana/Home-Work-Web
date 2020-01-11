using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fifth_HomeWork.Models; // пространство имен моделей и контекста данных
 
namespace Fifth_HomeWork.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db;
        public HomeController(DataContext context)
        {
            db = context;
        }
        
        public async Task<IActionResult> Index()
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
        }
    }
}