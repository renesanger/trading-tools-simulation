using Microsoft.AspNetCore.Mvc;
using TradingApp.Simulation;

[ApiController]
[Route("api/[controller]")]
public class MarketController: ControllerBase{
    private readonly Simulator _simulator;
    private readonly OrderBook _orderBook;

    public MarketController(Simulator simulator, OrderBook orderBook){
        _simulator = simulator;
        _orderBook = orderBook;
    }

    [HttpGet("price")]
    public IActionResult GetPrice(){
        return Ok(_simulator.GetPrice());
        // return Ok(new {Status = "Hello"});
    }

    [HttpPost("order")]
    public IActionResult PlaceOrder(Order order){
        _orderBook.AddOrder(order);
        return Ok(order);
    }

    [HttpGet("orderbook")]
    public IActionResult GetAllOrders(){
        return Ok(_orderBook.GetAllOrders());
    }
}