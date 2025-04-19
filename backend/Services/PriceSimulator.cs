using Microsoft.AspNetCore.SignalR;

namespace TradingApp.Simulation
{
public class Simulator 
{
    private Random _random = new Random();
    public decimal CurrentPrice { get; private set; }
    public Timer? _timer;
    private readonly IHubContext<MarketDataHub> _hubContext;

    public Simulator(IHubContext<MarketDataHub> hubContext) {
        _hubContext = hubContext;
        _timer = new Timer(async _ => await UpdatePrice(null), null, TimeSpan.Zero, TimeSpan.FromSeconds(2));
    }

    public async Task UpdatePrice(object? state)
    {
        var price = new Price { CurrentPrice = 100 + (decimal)(_random.NextDouble() * 10) };
        await _hubContext.Clients.All.SendAsync("RecieveUpdate", price);
    }
    public Price GetPrice()
    {
        return new Price{
            CurrentPrice = 100 + (decimal)(_random.NextDouble() * 10),
            LastUpdated = DateTime.UtcNow
        };
    }

    // public void PriceSimulator()
    // {
    //     _timer = new Timer(new TimerCallback(UpdatePrice), null, TimeSpan.Zero, TimeSpan.FromSeconds(2));
    // }


    // private void UpdatePrice(object state)
    // {
    //     CurrentPrice = 100 + (decimal)(_random.NextDouble() * 10);
    //     //Random Fluctuation
    // }

    public Price GetCurrentPrice()
    {
        return new Price(){
            CurrentPrice = CurrentPrice,
            LastUpdated = DateTime.UtcNow
        };
    }

}
}