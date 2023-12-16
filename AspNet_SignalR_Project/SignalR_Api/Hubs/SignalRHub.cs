using Microsoft.AspNetCore.SignalR;
using SignalR_DataAccessLayer.Concrete;

namespace SignalR_Api.Hubs
{
	//The server of the application 
	public class SignalRHub : Hub
	{
		SignalRContext context = new SignalRContext();

		public async Task SendCategoryCount()
		{
			var value = context.Categories.Count();

			await Clients.All.SendAsync("ReceiveCategoryCount", value); 
		}
	}
}
