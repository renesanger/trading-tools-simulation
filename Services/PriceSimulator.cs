public class Simulator 
{
    private Random _random = new Random();
    public decimal CurrentPrice { get; private set; }
    public Timer? _timer;

    public Price GetPrice()
    {
        return new Price{
            CurrentPrice = 100 + (decimal)(_random.NextDouble() * 10),
            LastUpdated = DateTime.UtcNow
        };
    }

    public void PriceSimulator()
    {
        _timer = new Timer(new TimerCallback(UpdatePrice), null, TimeSpan.Zero, TimeSpan.FromSeconds(2));
    }

    private void UpdatePrice(object state)
    {
        CurrentPrice = 100 + (decimal)(_random.NextDouble() * 10);
        //Random Fluctuation
    }

    public Price GetCurrentPrice()
    {
        return new Price(){
            CurrentPrice = CurrentPrice,
            LastUpdated = DateTime.UtcNow
        };
    }

}