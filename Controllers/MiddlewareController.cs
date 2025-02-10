using Microsoft.AspNetCore.Mvc;
using support_task4.middlewares;

namespace support_task4.Controllers
{
    public class MiddlewareController : Controller
    {
        public IActionResult Index()
        {
            return View(Middleware.Paths);
        }
    }
}
