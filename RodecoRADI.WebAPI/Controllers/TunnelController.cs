using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RodecoRADI.Core;
using RodecoRADI.Core.Persistance;
using RodecoRADI.Core.Persistance.Models;

namespace RodecoRADI.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TunnelController : ControllerBase
    {
        private readonly ILogger<TunnelController> logger;
        private readonly RodecoContext rodecoContext;

        public TunnelController(ILogger<TunnelController> logger, RodecoContext rodecoContext)
        {
            this.logger = logger;
            this.rodecoContext = rodecoContext;
        }

        [HttpGet("{id}")]
        [Produces(typeof(Tunnel))]
        public IActionResult Get(Guid id)
        {
            var tunnel = rodecoContext.Tunnels.Include(x => x.Photos).FirstOrDefault(x => x.Id == id);
            if (tunnel is null)
            {
                return NotFound();
            }
            return Ok(tunnel);
        }

        [HttpPost("post")]
        public Guid Post([FromBody] Tunnel tunnel)
        {
            var source = rodecoContext.Tunnels.FirstOrDefault(x => x.Id == tunnel.Id);
            if (source is not null)
            {
                source.Overlay(tunnel);
                if (tunnel.Photos is not null) foreach (var photo in tunnel.Photos) rodecoContext.ProcessPhoto(photo);
            }
            else
            {
                rodecoContext.Tunnels.Add(tunnel);
            }

            rodecoContext.SaveChanges();
            return tunnel.Id;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var tunnel = rodecoContext.Tunnels.FirstOrDefault(x => x.Id == id);
            if (tunnel is null)
            {
                return NotFound();
            }
            tunnel.MarkAsDeleted = true;
            rodecoContext.SaveChanges();
            return NoContent();
        }
    }
}