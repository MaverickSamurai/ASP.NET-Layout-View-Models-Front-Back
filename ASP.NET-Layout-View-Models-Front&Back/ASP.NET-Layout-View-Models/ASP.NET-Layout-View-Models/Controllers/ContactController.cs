using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Layout_View_Models.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
