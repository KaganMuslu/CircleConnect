using CircleConnect.Data;
using Microsoft.AspNetCore.Mvc;

namespace CircleConnect.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        // Set AppDbContext
        protected readonly AppDbContext _context;
        public BaseController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

    }
}
