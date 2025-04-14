public class Simulator 
{
    private Random _random = new Random();

    public Price GetPrice()
    {
        return new Price{
            CurrentPrice = 100 + (decimal)(_random.NextDouble() * 10),
            LastUpdated = DateTime.UtcNow
        };
    }
}