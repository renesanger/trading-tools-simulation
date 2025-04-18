using Microsoft.AspNetCore.Mvc;
using TradingApp.Simulation;

[ApiController]
[Route("api/[controller]")]
public class PriceController : ControllerBase
{
    private readonly Simulator _simulator;

    public PriceController(Simulator simulator)
    {
        _simulator = simulator;
        _simulator.PriceSimulator();
    }

    [HttpGet]
    public ActionResult<Price> Get()
    {
        return _simulator.GetPrice();
    }
}