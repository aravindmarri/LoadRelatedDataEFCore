using LoadRelatedDataEFCore.Data;
using LoadRelatedDataEFCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoadRelatedDataEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComicController : ControllerBase
    {
        private readonly DataContext _context;

        public ComicController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Comic>>> GetAll()
        {
            var comics = await _context.Comics
                .ToListAsync();
            return Ok(comics);
        }

        //[HttpGet]
        //public async Task<ActionResult<List<Comic>>> IgnoreAutoIncludesAll()
        //{
        //    var comics = await _context.Comics
        //        .IgnoreAutoIncludes()
        //        .ToListAsync();
        //    return Ok(comics);
        //}

        //[HttpGet]
        //public async Task<ActionResult<List<Comic>>> Includes()
        //{
        //    var comics = await _context.Comics
        //        .Include(c => c.Teams)
        //        .ToListAsync();
        //    return Ok(comics);
        //}

        //[HttpGet]
        //public async Task<ActionResult<List<Comic>>> ThenInclude()
        //{
        //    var comics = await _context.Comics
        //        .Include(c => c.Teams)
        //            .ThenInclude(c => c.SuperHeroes)
        //        .ToListAsync();
        //    return Ok(comics);
        //}
    }
}
