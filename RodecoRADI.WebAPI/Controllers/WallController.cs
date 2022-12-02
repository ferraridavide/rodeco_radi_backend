using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RodecoRADI.Core;
using RodecoRADI.Core.Persistance;
using RodecoRADI.Core.Persistance.Models;

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
            var wall = rodecoContext.Walls.Include(x => x.Photos).FirstOrDefault(x => x.Id == id);
            if (wall is null)
            {
                return NotFound();
            }
            return Ok(wall);
        }

        [HttpPost("post")]
        public Guid Post([FromBody] Wall wall)
        {
            var source = rodecoContext.Walls.FirstOrDefault(x => x.Id == wall.Id);
            if (source is not null)
            {
                source.Overlay(wall);
                if (wall.Photos is not null) foreach (var photo in wall.Photos) rodecoContext.ProcessPhoto(photo);
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
            wall.MarkAsDeleted = true;
            rodecoContext.SaveChanges();
            return NoContent();
        }
    }
}