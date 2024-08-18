using CircleConnect.Data;
using CircleConnect.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CircleConnect.Controllers
{
    [Route("api/community")]
    [ApiController]
    public class CommunityController : BaseController
    {
        // Dependency Injection (DI)
        public CommunityController(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        #region Get Requests

        [HttpGet]
        public IActionResult GetAllCommunities()
        {
            var communities = _context.Communities;

            return Ok(communities);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetOneCommunities([FromRoute(Name = "id")] int id)
        {
            var community = _context.Communities.Where(x => x.Id == id).SingleOrDefault();

            if (community == null)
                return NotFound(); // 404

            return Ok(community);
        }

        #endregion

        #region Post Requests

        [HttpPost]
        public IActionResult AddCommunity([FromBody] Community community)
        {
            if (community == null)
                return BadRequest(); // 400

            _context.Communities.Add(community);
            _context.SaveChanges();

            return StatusCode(201, community);
            
        }

        #endregion

        #region Put Requests

        [HttpPut("{id:int}")]
        public IActionResult UpdateCommunity([FromRoute] int id, [FromBody] Community community)
        {
            if (id == 0)
                return BadRequest(); // 400

            if (community == null)
                return BadRequest(); // 400

            var oldCommunity = _context.Communities.Where(x => x.Id == id).SingleOrDefault();

            if (oldCommunity == null)
                return NotFound();

            _context.Communities.Remove((Community)oldCommunity);
            _context.Communities.Add(community);
            _context.SaveChanges();

            return Ok(community); // 200
        }

        #endregion

        #region Patch Request

        [HttpPatch("{id:int}")]
        public IActionResult CommunityUpdate([FromRoute(Name = "id")] int id, [FromBody] JsonPatchDocument<Community> communityPatch)
        {
            if (id == 0)
                return BadRequest(); // 400

            var community = _context.Communities.Where(x => x.Id == id).SingleOrDefault();
            if (community == null) 
                return NotFound(); // 404

            communityPatch.ApplyTo(community);
            _context.SaveChanges();

            return Ok(); // 200 or could be 204 NoContent
        }

        #endregion

        #region Delete Requests

        [HttpDelete("{id:int}")]
        public IActionResult DeleteCommunity([FromRoute] int id)
        {
            if (id == 0)
                return BadRequest(); // 400

            var community = _context.Communities.Where(x => x.Id == id).SingleOrDefault();
            if (community == null)
                return NotFound(); // 404

            _context.Communities.Remove(community);
            _context.SaveChanges();
            return Ok(); // 200
        }

        #endregion
    }
}
