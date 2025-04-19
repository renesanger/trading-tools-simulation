
namespace TradingApp.Simulation
{
public class OrderBook 
{
    public Dictionary<int, Order> orders = new Dictionary<int, Order>();
    public void AddOrder(Order order){
        orders.Add(order.Id, order);
    }
    public IEnumerable<Order> GetAllOrders() => orders.Values;
}
}