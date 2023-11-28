using Microsoft.AspNetCore.Mvc;

namespace SignalR_Web_UI.ViewComponents.LayoutComponents
{
	public class _LayoutNavbarPartialComponent : ViewComponent
	{
		public IViewComponentResult Invoke() { return View(); }
	}
}
