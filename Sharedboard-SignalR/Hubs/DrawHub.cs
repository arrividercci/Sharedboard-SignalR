using Microsoft.AspNetCore.SignalR;

namespace Sharedboard_SignalR.Hubs
{
    public class DrawHub : Hub
    {
        public async Task Clear()
        {
            await Clients.All.SendAsync("Clear");
        }

        public async Task Draw(string message)
        {
            await Clients.All.SendAsync("Draw", message);   
        }
    }
}
