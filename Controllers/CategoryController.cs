using CircleConnect.Data;
using CircleConnect.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CircleConnect.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : BaseController<Category>
    {
        // Dependency Injection (DI)
        public CategoryController(AppDbContext appDbContext) : base(appDbContext)
        {
        }

    }
}
