using CircleConnect.Data;
using CircleConnect.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CircleConnect.Controllers
{
    [Route("api/notification")]
    [ApiController]
    public class NotificationController : BaseController<Notification>
    {
        // Dependency Injection (DI)
        public NotificationController(AppDbContext appDbContext) : base(appDbContext)
        {
        }

    }
}
