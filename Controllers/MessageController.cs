using CircleConnect.Data;
using CircleConnect.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CircleConnect.Controllers
{
    [Route("api/message")]
    [ApiController]
    public class MessageController : BaseController<Message>
    {
        // Dependency Injection (DI)
        public MessageController(AppDbContext appDbContext) : base(appDbContext)
        {
        }

    }
}
