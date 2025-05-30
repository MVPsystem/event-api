using EventAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EventAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private static List<Event> events = new List<Event>
        {
            new Event { Id = 1, Name = "Tech Conference 2023", Description = "Annual technology conference", Date = DateTime.Parse("2023-11-15"), Location = "Stockholm", ImageUrl = "https://example.com/tech-conf.jpg" },
            new Event { Id = 2, Name = "Developer Workshop", Description = "Hands-on coding workshop", Date = DateTime.Parse("2023-12-05"), Location = "Gothenburg", ImageUrl = "https://example.com/dev-workshop.jpg" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Event>> GetEvents()
        {
            return Ok(events);
        }

        [HttpGet("{id}")]
        public ActionResult<Event> GetEvent(int id)
        {
            var eventItem = events.FirstOrDefault(e => e.Id == id);
            if (eventItem == null)
            {
                return NotFound();
            }
            return Ok(eventItem);
        }
    }
}