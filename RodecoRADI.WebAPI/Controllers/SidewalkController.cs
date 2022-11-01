using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RodecoRADI.Core.Persistance.Models;
using RodecoRADI.Core.Persistance;

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
            var sidewalk = rodecoContext.Sidewalks.FirstOrDefault(x => x.Id == id);
            if (sidewalk is null)
            {
                return NotFound();
            }
            return Ok(sidewalk);
        }

        [HttpPost("post")]
        public Guid Post([FromBody] Sidewalk sidewalk)
        {
            if (rodecoContext.Sidewalks.Any(x => x.Id == sidewalk.Id))
            {
                rodecoContext.Sidewalks.Update(sidewalk);
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
            rodecoContext.Sidewalks.Remove(sidewalk);
            rodecoContext.SaveChanges();
            return NoContent();
        }
    }
}
