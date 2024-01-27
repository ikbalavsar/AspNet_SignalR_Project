using Microsoft.AspNetCore.Mvc;

namespace SignalR_Web_UI.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
