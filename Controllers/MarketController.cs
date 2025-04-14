using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MarketController: ControllerBase{
    [HttpGet("status")]
    public IActionResult GetStatus(){
        return Ok(new {Status = "Trading Simulator Running"});
    }
}