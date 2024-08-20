using CircleConnect.Data;
using CircleConnect.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CircleConnect.Controllers
{
    [Route("api/event")]
    [ApiController]
    public class EventController : BaseController<Event>
    {
        // Dependency Injection (DI)
        public EventController(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        
    }
}
