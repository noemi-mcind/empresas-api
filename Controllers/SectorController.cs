using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using empresasAPi.Data;
using empresasAPi.Models;

namespace empresasAPi.Controllers
{
    [ApiController]
    [Route ("v1/sectors")]

    public class SectorController : ControllerBase
    {
        // Verbo HTTP ou Método HTTP, são: GET, POST, PUT, DELETE 
        // Atributo ou Annotation
        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<Sector>>> Get([FromServices] DataContext context)
        {
            var sector = await context.Sectors.Include(x => x.User).ToListAsync();
            return sector;
        }

        // Atributo ou Annotation
        [HttpGet]
        [Route("{id:int}")]

        public async Task<ActionResult<Sector>> GetById([FromServices] DataContext context, int id)
        {
            var sector = await context.Sectors.Include(x => x.User)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
            return sector;
        }

        // Atributo ou Annotation
        [HttpGet]
        [Route("sectors/{id:int}")]

        public async Task<ActionResult<List<Sector>>> GetBySector([FromServices] DataContext context, int id) 
        {
            var sectors = await context.Sectors
                .Include(x => x.User)
                .AsNoTracking()
                .Where(x => x.UserId == id)
                .ToListAsync();
            return sectors;
        }   

        // Atributo ou Annotation
        [HttpPost]
        [Route("")]

        public async Task<ActionResult<Sector>> Post(
            [FromServices] DataContext context,
            [FromBody] Sector model)
        {
            if (ModelState.IsValid)
            {
                context.Sectors.Add(model);
                await context.SaveChangesAsync();
                return Ok(model);
            }
            else 
            {
                return BadRequest(ModelState);
            }
        }  
    }
}
