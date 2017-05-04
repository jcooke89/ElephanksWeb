using System;
using System.Linq;
using System.Threading.Tasks;
using ElephanksWeb.Repository;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ElephanksWeb.Controllers
{
    [Route("api")]
    public class TrunksController : Controller
    {
        private TrunkContext _context;
        public TrunksController(TrunkContext Context)
        {
            _context = Context;
        }

        [HttpGet("Trunks", Name = "GetAllTrunks")]
        public IActionResult GetTrunks()
        {
            var trunks = _context.Trunks;
            if (trunks.Count() < 1) return Ok("There are currently no trunks stored");
            return Ok(trunks);
        }

        [HttpGet("Trunk/{trunkId}", Name = "GetTrunk")]
        [ProducesAttribute(typeof(Trunk))]
        [SwaggerResponse(200, Type = typeof(Trunk))]
        [SwaggerResponse(404)]
        public IActionResult GetTrunk(int trunkId)
        {
            var trunk = _context.Trunks.Where(t => t.Id == trunkId).FirstOrDefault();
            if (trunk == null) return NotFound();
            return new ObjectResult(trunk);
        }

        [HttpPost("Trunk", Name = "AddNewTrunk")]
        [SwaggerResponse(201, Description = "New Trunk Created")]
        [SwaggerResponse(400)]
        public async Task<IActionResult> AddTrunk([FromBody] Trunk trunk)
        {
            try
            {
                await _context.Trunks.AddAsync(trunk);
                await _context.SaveChangesAsync();
                var Uri = Url.Link("GetTrunk", new { trunkId = trunk.Id });
                return Created(Uri, trunk);
            }
            catch (ArgumentException ex)
            {

            }
            catch (Exception ex)
            {

            }
            return BadRequest();
        }
    }
}