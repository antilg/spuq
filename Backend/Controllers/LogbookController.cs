using EinzelaufageB.DAL;
using EinzelaufageB.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EinzelaufageB.Controllers
{
    [ApiController]
    [Route("logbook/journeys")]
    public class LogbookController : Controller
    {
        private readonly LogbookContext _context;
        public LogbookController(LogbookContext context)
        {
            _context = context;
        }

        // GET: journeys
        [HttpGet]

        public async Task<ActionResult<Journey>> Index()
        {
            Journey journeys = new Journey();
            List<Logbook> logbooks = await _context.Journeys.ToListAsync();
            
            foreach (Logbook logbook in logbooks)
            {
                journeys.Journeys.Add(logbook);
                journeys.DistanceTotal += logbook.Distance.Value;
            }
            return journeys;
        }
        //public async Task<IEnumerable<Logbook>> Index()
        //{
        //   return await _context.Journeys.ToListAsync();
        //}


        // POST: LogbookController/Create
        [HttpPost]
        public async Task<ActionResult<Logbook>> Post(Logbook logbook)
        {
            _context.Journeys.Add(logbook);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Index", new { id = logbook.Id }, logbook);
        }
    }
}
