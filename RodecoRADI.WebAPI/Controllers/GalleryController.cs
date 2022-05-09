using Microsoft.AspNetCore.Mvc;
using RodecoRADI.Core.Persistance;
using RodecoRADI.Core.Persistance.Models;

namespace RodecoRADI.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GalleryController : ControllerBase
    {
        private readonly ILogger<EntityController> logger;
        private readonly RodecoContext rodecoContext;

        public GalleryController(ILogger<EntityController> logger, RodecoContext rodecoContext)
        {
            this.logger = logger;
            this.rodecoContext = rodecoContext;
        }

        [HttpGet("{id}")]
        [Produces(typeof(Gallery))]
        public IActionResult Get(Guid id)
        {
            var galleria = rodecoContext.Galleries.FirstOrDefault(x => x.Id == id);
            if (galleria is null)
            {
                return NotFound();
            }
            return Ok(galleria);
        }

        [HttpPost("post")]
        public IActionResult Post([FromBody] Gallery gallery)
        {
            rodecoContext.Add(gallery);
            rodecoContext.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var galleria = rodecoContext.Galleries.FirstOrDefault(x => x.Id == id);
            if (galleria is null)
            {
                return NotFound();
            }
            rodecoContext.Galleries.Remove(galleria);
            rodecoContext.SaveChanges();
            return NoContent();
        }
    }
}
