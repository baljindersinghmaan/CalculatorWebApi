using Microsoft.AspNetCore.Mvc;

namespace CalculatorWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CalulatorController : ControllerBase
{
   

    private readonly ILogger<CalulatorController> _logger;

    public CalulatorController(ILogger<CalulatorController> logger)
    {
        _logger = logger;
    }

    // [HttpGet(Name = "GetSum")]
    // public IEnumerable<WeatherForecast> Get()
    // {
    //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //     {
    //         Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
    //         TemperatureC = Random.Shared.Next(-20, 55),
    //         Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //     })
    //     .ToArray();
    // }

    
    [HttpGet("add")]
    public decimal Add([FromQuery] decimal left, [FromQuery] decimal right)
    {
        return left + right;
    }

    [HttpGet("subtract")]
    public decimal Subtract([FromQuery] decimal left, [FromQuery] decimal right)
    {
        return left - right;
    }

    [HttpGet("multiply")]
    public decimal Multiply([FromQuery] decimal left, [FromQuery] decimal right)
    {
        return left * right;
    }

    [HttpGet("divide")]
    public decimal Divide([FromQuery] decimal left, [FromQuery] decimal right)
    {
        return left * right;
    }
    [HttpGet("modulo")]
    public decimal Modulo([FromQuery] decimal left, [FromQuery] decimal right)
    {
        return left % right;
    }

    
}
