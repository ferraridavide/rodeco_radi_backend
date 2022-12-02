using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RodecoRADI.Core;
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
            var galleria = rodecoContext.Galleries.Include(x => x.Photos).FirstOrDefault(x => x.Id == id);
            if (galleria is null)
            {
                return NotFound();
            }
            return Ok(galleria);
        }

        [HttpPost("post")]
        public Guid Post([FromBody] Gallery gallery)
        {
            var source = rodecoContext.Galleries.FirstOrDefault(x => x.Id == gallery.Id);
            if (source is not null)
            {
                source.Overlay(gallery);
                if (gallery.Photos is not null) foreach (var photo in gallery.Photos) rodecoContext.ProcessPhoto(photo);
            }
            else
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
            galleria.MarkAsDeleted = true;
            rodecoContext.SaveChanges();
            return NoContent();
        }
    }
}