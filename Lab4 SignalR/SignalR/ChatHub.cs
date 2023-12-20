using Microsoft.AspNetCore.SignalR;

namespace SignalR;

public class ChatHub : Hub
{
    public async Task Send(string word)
    {
        var a = word.ToUpper();
        var b = word.ToLower();

        await Clients.All.SendAsync("Receive", a, b);
    }
}