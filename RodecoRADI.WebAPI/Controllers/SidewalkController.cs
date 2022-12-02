using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RodecoRADI.Core;
using RodecoRADI.Core.Persistance;
using RodecoRADI.Core.Persistance.Models;

namespace RodecoRADI.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SidewalkController : ControllerBase
    {
        private readonly ILogger<SidewalkController> logger;
        private readonly RodecoContext rodecoContext;

        public SidewalkController(ILogger<SidewalkController> logger, RodecoContext rodecoContext)
        {
            this.logger = logger;
            this.rodecoContext = rodecoContext;
        }

        [HttpGet("{id}")]
        [Produces(typeof(Sidewalk))]
        public IActionResult Get(Guid id)
        {
            var sidewalk = rodecoContext.Sidewalks.Include(x => x.Photos).FirstOrDefault(x => x.Id == id);
            if (sidewalk is null)
            {
                return NotFound();
            }
            return Ok(sidewalk);
        }

        [HttpPost("post")]
        public Guid Post([FromBody] Sidewalk sidewalk)
        {
            var source = rodecoContext.Sidewalks.FirstOrDefault(x => x.Id == sidewalk.Id);
            if (source is not null)
            {
                source.Overlay(sidewalk);
                if (sidewalk.Photos is not null) foreach (var photo in sidewalk.Photos) rodecoContext.ProcessPhoto(photo);
            }
            else
            {
                rodecoContext.Sidewalks.Add(sidewalk);
            }

            rodecoContext.SaveChanges();
            return sidewalk.Id;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var sidewalk = rodecoContext.Sidewalks.FirstOrDefault(x => x.Id == id);
            if (sidewalk is null)
            {
                return NotFound();
            }
            sidewalk.MarkAsDeleted = true;
            rodecoContext.SaveChanges();
            return NoContent();
        }
    }
}