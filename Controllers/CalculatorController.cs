using Microsoft.AspNetCore.Mvc;

namespace Calculator1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CalculatorController: ControllerBase
{
    [HttpGet(template: "sum")]
    public IActionResult GetSum(int a, int b)
    {
        var result = a + b;
        return Ok(new {a, b, result});
    }
}
