using ApiLider.ConnectBase;
using Microsoft.AspNetCore.Mvc;

namespace ApiLider.Controllers
{
    [Route("api/[controller]")]
    public class WEbController : Controller
    {
        ApplicationConnect _db = new ApplicationConnect();
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_db.web.ToList());
        }
    }
}
