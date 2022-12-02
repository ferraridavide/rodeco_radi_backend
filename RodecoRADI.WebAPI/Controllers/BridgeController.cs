using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RodecoRADI.Core;
using RodecoRADI.Core.Persistance;
using RodecoRADI.Core.Persistance.Models;

namespace RodecoRADI.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BridgeController : ControllerBase
    {
        private readonly ILogger<BridgeController> logger;
        private readonly RodecoContext rodecoContext;

        public BridgeController(ILogger<BridgeController> logger, RodecoContext rodecoContext)
        {
            this.logger = logger;
            this.rodecoContext = rodecoContext;
        }

        [HttpGet("{id}")]
        [Produces(typeof(Bridge))]
        public IActionResult Get(Guid id)
        {
            var bridge = rodecoContext.Bridges.Include(x => x.Photos).FirstOrDefault(x => x.Id == id);
            if (bridge is null)
            {
                return NotFound();
            }
            return Ok(bridge);
        }

        [HttpPost("post")]
        public Guid Post([FromBody] Bridge bridge)
        {
            var source = rodecoContext.Bridges.FirstOrDefault(x => x.Id == bridge.Id);
            if (source is not null)
            {
                source.Overlay(bridge);
                if (bridge.Photos is not null) foreach (var photo in bridge.Photos) rodecoContext.ProcessPhoto(photo);
            }
            else
            {
                rodecoContext.Bridges.Add(bridge);
            }

            rodecoContext.SaveChanges();
            return bridge.Id;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var bridge = rodecoContext.Bridges.FirstOrDefault(x => x.Id == id);
            if (bridge is null)
            {
                return NotFound();
            }
            bridge.MarkAsDeleted = true;
            rodecoContext.SaveChanges();
            return NoContent();
        }
    }
}