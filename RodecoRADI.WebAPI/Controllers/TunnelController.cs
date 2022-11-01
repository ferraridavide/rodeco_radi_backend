using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RodecoRADI.Core.Persistance.Models;
using RodecoRADI.Core.Persistance;

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
            var tunnel = rodecoContext.Tunnels.FirstOrDefault(x => x.Id == id);
            if (tunnel is null)
            {
                return NotFound();
            }
            return Ok(tunnel);
        }

        [HttpPost("post")]
        public Guid Post([FromBody] Tunnel tunnel)
        {
            if (rodecoContext.Tunnels.Any(x => x.Id == tunnel.Id))
            {
                rodecoContext.Tunnels.Update(tunnel);
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
            var wall = rodecoContext.Tunnels.FirstOrDefault(x => x.Id == id);
            if (wall is null)
            {
                return NotFound();
            }
            rodecoContext.Tunnels.Remove(wall);
            rodecoContext.SaveChanges();
            return NoContent();
        }
    }
}
