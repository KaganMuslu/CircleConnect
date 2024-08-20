using CircleConnect.Data;
using CircleConnect.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CircleConnect.Controllers
{
    public abstract class BaseController<TEntity> : ControllerBase where TEntity : class
    {
        // Set AppDbContext
        protected readonly AppDbContext _context;
        public BaseController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        #region Get Requests

        [HttpGet]
        public IActionResult GetAll()
        {
            var entities = _context.Set<TEntity>().ToList();

            return Ok(entities);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetOne([FromRoute(Name = "id")] int id)
        {
            var entity = _context.Set<TEntity>().Find(id);

            if (entity == null)
                return NotFound(); // 404

            return Ok(entity);
        }

        #endregion

        #region Post Requests

        [HttpPost]
        public IActionResult Add([FromBody] TEntity entity)
        {
            if (entity == null)
                return BadRequest(); // 400

            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();

            return StatusCode(201, entity);

        }

        #endregion

        #region Put Requests

        [HttpPut("{id:int}")]
        public IActionResult UpdateEvent([FromRoute] int id, [FromBody] TEntity entity)
        {
            if (id == 0)
                return BadRequest(); // 400

            if (entity == null)
                return BadRequest(); // 400

            var oldEntity = _context.Set<TEntity>().Find(id);

            if (oldEntity == null)
                return NotFound();

            _context.Set<TEntity>().Remove(oldEntity);
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();

            return Ok(entity); // 200
        }

        #endregion

        #region Patch Request

        [HttpPatch("{id:int}")]
        public IActionResult PartialUpdateEvent([FromRoute(Name = "id")] int id, [FromBody] JsonPatchDocument<TEntity> entityPatch)
        {
            if (id == 0)
                return BadRequest(); // 400

            var entity = _context.Set<TEntity>().Find(id);
            if (entity == null)
                return NotFound(); // 404

            entityPatch.ApplyTo(entity);
            _context.SaveChanges();

            return Ok(); // 200 or could be 204 NoContent
        }

        #endregion

        #region Delete Requests

        [HttpDelete("{id:int}")]
        public IActionResult DeleteEvent([FromRoute] int id)
        {
            if (id == 0)
                return BadRequest(); // 400

            var entity = _context.Set<TEntity>().Find(id);
            if (entity == null)
                return NotFound(); // 404

            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
            return Ok(); // 200
        }

        #endregion

    }
}
