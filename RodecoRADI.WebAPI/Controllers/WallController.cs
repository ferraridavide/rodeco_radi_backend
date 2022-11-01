using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RodecoRADI.Core.Persistance.Models;
using RodecoRADI.Core.Persistance;

namespace RodecoRADI.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WallController : ControllerBase
    {
        private readonly ILogger<WallController> logger;
        private readonly RodecoContext rodecoContext;

        public WallController(ILogger<WallController> logger, RodecoContext rodecoContext)
        {
            this.logger = logger;
            this.rodecoContext = rodecoContext;
        }

        [HttpGet("{id}")]
        [Produces(typeof(Wall))]
        public IActionResult Get(Guid id)
        {
            var wall = rodecoContext.Walls.FirstOrDefault(x => x.Id == id);
            if (wall is null)
            {
                return NotFound();
            }
            return Ok(wall);
        }

        [HttpPost("post")]
        public Guid Post([FromBody] Wall wall)
        {
            if (rodecoContext.Walls.Any(x => x.Id == wall.Id))
            {
                rodecoContext.Walls.Update(wall);
            }
            else
            {
                rodecoContext.Walls.Add(wall);
            }

            rodecoContext.SaveChanges();
            return wall.Id;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var wall = rodecoContext.Walls.FirstOrDefault(x => x.Id == id);
            if (wall is null)
            {
                return NotFound();
            }
            rodecoContext.Walls.Remove(wall);
            rodecoContext.SaveChanges();
            return NoContent();
        }
    }
}
