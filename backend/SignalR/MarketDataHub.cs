using Microsoft.AspNetCore.SignalR;

public class MarketDataHub : Hub {
    public async Task SendPriceUpdate(Price price) {
        await Clients.All.SendAsync("RecievePrice", price);
    }
}