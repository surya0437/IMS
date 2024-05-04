using Microsoft.AspNetCore.Mvc;

namespace IMS.web.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
