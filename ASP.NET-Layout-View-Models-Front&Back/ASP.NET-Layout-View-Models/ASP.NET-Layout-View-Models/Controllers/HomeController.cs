using Microsoft.AspNetCore.Mvc;


namespace ASP.NET_Layout_View_Models.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
