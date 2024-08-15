using CircleConnect.Data;
using CircleConnect.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CircleConnect.Controllers
{
    [Route("api/community")]
    [ApiController]
    public class CommunityController : ControllerBase
    {

        #region Get Requests

        [HttpGet]
        public IActionResult GetAllCommunities()
        {
            var communities = ApplicationContext.Communities;

            return Ok(communities);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetOneCommunities([FromRoute(Name = "id")] int id)
        {
            var community = ApplicationContext.Communities.Where(x => x.Id == id).SingleOrDefault();

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

            ApplicationContext.Communities.Add(community);
            return StatusCode(201, community);
            
        }

        #endregion

        #region Put Requests

        [HttpPut("{id:int}")]
        public IActionResult UpdateCommunity([FromRoute] int id, [FromBody] Community community)
        {
            if (community == null)
                return BadRequest();

            var oldCommunity =  ApplicationContext.Communities.Where(x => x.Id == id).SingleOrDefault();

            if (oldCommunity == null)
                return NotFound();

            ApplicationContext.Communities.Remove(oldCommunity);
            ApplicationContext.Communities.Add(community);
            return Ok(community);
        }

        #endregion

        #region Delete Requests

        [HttpDelete("{id:int}")]
        public IActionResult DeleteCommunity([FromRoute] int id)
        {
            if (id == 0)
                return BadRequest();

            var community = ApplicationContext.Communities.Where(x => x.Id == id).SingleOrDefault();
            if (community == null)
                return NotFound();

            ApplicationContext.Communities.Remove(community);
            return Ok();
        }

        #endregion
    }
}
