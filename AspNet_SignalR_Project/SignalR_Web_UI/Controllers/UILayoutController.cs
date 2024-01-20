using Microsoft.AspNetCore.Mvc;

namespace SignalR_Web_UI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
