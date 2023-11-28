using Microsoft.AspNetCore.Mvc;

namespace SignalR_Web_UI.ViewComponents.LayoutComponents
{
	public class _LayoutSidebarPartialComponent : ViewComponent
	{
		public IViewComponentResult Invoke() { return View(); }
	}
}
