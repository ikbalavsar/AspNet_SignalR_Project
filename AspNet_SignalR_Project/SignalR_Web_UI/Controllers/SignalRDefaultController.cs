using Microsoft.AspNetCore.Mvc;

namespace SignalR_Web_UI.Controllers
{
	public class SignalRDefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

        public IActionResult Index2()
        {
            return View();
        }
    }
}
