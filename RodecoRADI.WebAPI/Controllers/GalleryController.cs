using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RodecoRADI.Core.Persistance;
using RodecoRADI.Core.Persistance.Models;

namespace RodecoRADI.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GalleryController : ControllerBase
    {
        private readonly ILogger<GalleryController> logger;
        private readonly RodecoContext rodecoContext;

        public GalleryController(ILogger<GalleryController> logger, RodecoContext rodecoContext)
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
        public Guid Post([FromBody] Gallery gallery)
        {
            if (rodecoContext.Galleries.Any(x => x.Id == gallery.Id))
            {
                rodecoContext.Galleries.Update(gallery);
            } else
            {
                rodecoContext.Galleries.Add(gallery);
            }
            
            rodecoContext.SaveChanges();
            return gallery.Id;
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
