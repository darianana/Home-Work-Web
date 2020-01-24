using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Seventh_HomeWork.Models;
using System.Threading.Tasks;

namespace WebAPIApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StagingsController : ControllerBase
    {
        StagingsContext db;
        public StagingsController(StagingsContext context)
        {
            db = context;
            if (!db.Stagings.Any())
            {
                db.Stagings.Add(new Staging { Name = "Three masks of the king", Tickets = 100, Price = 1700 });
                db.Stagings.Add(new Staging { Name = "Prince Vladimir", Tickets = 100, Price = 1900 });
                db.Stagings.Add(new Staging { Name = "The Wedding of Figaro", Tickets = 100, Price = 1500 });
                db.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Staging>>> Get()
        {
            return await db.Stagings.ToListAsync();
        }

        // GET api/stagings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Staging>> Get(int id)
        {
            Staging staging = await db.Stagings.FirstOrDefaultAsync(x => x.Id == id);
            if (staging == null)
                return NotFound();
            return new ObjectResult(staging);
        }

        // POST api/stagings
        [HttpPost]
        public async Task<ActionResult<Staging>> Post(Staging staging)
        {
            if (staging == null)
            {
                return BadRequest();
            }

            db.Stagings.Add(staging);
            await db.SaveChangesAsync();
            return Ok(staging);
        }

        // PUT api/stagings/
        [HttpPut]
        public async Task<ActionResult<Staging>> Put(Staging staging)
        {
            if (staging == null)
            {
                return BadRequest();
            }
            if (!db.Stagings.Any(x => x.Id == staging.Id))
            {
                return NotFound();
            }

            db.Update(staging);
            await db.SaveChangesAsync();
            return Ok(staging);
        }

        // DELETE api/stagings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Staging>> Delete(int id)
        {
            Staging staging = db.Stagings.FirstOrDefault(x => x.Id == id);
            if (staging == null)
            {
                return NotFound();
            }
            db.Stagings.Remove(staging);
            await db.SaveChangesAsync();
            return Ok(staging);
        }
    }
}