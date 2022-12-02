using Microsoft.AspNetCore.Mvc;
using RodecoRADI.Core.Persistance;
using RodecoRADI.Core.Persistance.Models;
using System.Text;

namespace RodecoRADI.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntityController : ControllerBase
    {
        private readonly ILogger<EntityController> logger;
        private readonly RodecoContext rodecoContext;

        public EntityController(ILogger<EntityController> logger, RodecoContext rodecoContext)
        {
            this.logger = logger;
            this.rodecoContext = rodecoContext;
        }

        [HttpGet("find")]
        public IEnumerable<IBaseEntity> Find(Guid? from, int? take)
        {
            if (from is not null && take is not null)
            {
                throw new NotImplementedException();
            }
            return rodecoContext.Galleries      .Select(x => (IBaseEntity)x).ToList()
                .Concat(rodecoContext.Bridges   .Select(x => (IBaseEntity)x).ToList())
                .Concat(rodecoContext.Tunnels   .Select(x => (IBaseEntity)x).ToList())
                .Concat(rodecoContext.Walls     .Select(x => (IBaseEntity)x).ToList())
                .Concat(rodecoContext.Sidewalks .Select(x => (IBaseEntity)x).ToList())
                .Where(x => x.MarkAsDeleted == false);
        }

        [HttpPost("test")]
        public IActionResult PostTunnel()
        {
            rodecoContext.Add(new Tunnel
            {
                Name = "tunnel1",
                Code = "code1",
                CreationDate = DateTime.Now,
                Photos = new List<Photo> { new Photo() { Description = "desc1", Image = Encoding.ASCII.GetBytes("TEST") } }
            });
            rodecoContext.Add(new Gallery
            {
                Name = "gallery2",
                Code = "code2",
                CreationDate = DateTime.Now,
                Photos = new List<Photo> { new Photo() { Description = "desc2", Image = Encoding.ASCII.GetBytes("TEST") } }
            });

            rodecoContext.SaveChanges();
            return NoContent();
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> UploadAsync(IFormFile file, string associatedEntityGuid, string name)
        {
            if (file.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    await file.CopyToAsync(ms);
                    var photo = new Photo() { Description = name, Image = ms.ToArray() };

                    Func<IBaseEntity, bool> predicate = x => x.Id == Guid.Parse(associatedEntityGuid.Trim('"'));

                    var entity =
                        rodecoContext.Galleries.FirstOrDefault(predicate) ??
                        rodecoContext.Tunnels.FirstOrDefault(predicate) ??
                        rodecoContext.Bridges.FirstOrDefault(predicate) ??
                        rodecoContext.Walls.FirstOrDefault(predicate) ??
                        rodecoContext.Sidewalks.FirstOrDefault(predicate);
                    if (entity != null)
                    {
                        entity.Photos ??= new List<Photo>();
                        entity.Photos.Add(photo);
                    }
                    rodecoContext.SaveChanges();
                    return Ok(photo.Id);
                }
            }

            return StatusCode(500);
        }

        [HttpGet("pic/{id}")]
        [ProducesResponseType(typeof(FileContentResult), 200, "image/jpeg")]
        public FileContentResult Picture(Guid id)
        {
            var photo = rodecoContext.Photos.FirstOrDefault(x => x.Id == id);
            if (photo is not null)
            {
                return File(photo.Image, "image/jpeg");
            }
            return null;
        }


    }
}