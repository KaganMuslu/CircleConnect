using CircleConnect.Data;
using CircleConnect.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CircleConnect.Controllers
{
    [Route("api/community")]
    [ApiController]
    public class CommunityController : BaseController<Community>
    {
        // Dependency Injection (DI)
        public CommunityController(AppDbContext appDbContext) : base(appDbContext)
        {
        }

    }
}
