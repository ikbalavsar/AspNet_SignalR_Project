using Microsoft.AspNetCore.Mvc;

namespace SignalR_Web_UI.ViewComponents.LayoutComponents
{
	public class _LayoutScriptPartialComponent : ViewComponent
	{
		public IViewComponentResult Invoke() { return View(); }
	}
}
