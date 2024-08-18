using CircleConnect.Data;

namespace CircleConnect.Controllers
{
    public class EventController : BaseController
    {
        public EventController(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
