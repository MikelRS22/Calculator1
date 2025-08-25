using Microsoft.AspNetCore.Http.HttpResults;
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
    [HttpGet(template: "substract")]
    public IActionResult GetSubstract(int a, int b)
    {
        var result = a - b;
        return Ok(new {a, b, result});
    }
    [HttpGet(template: "product")]
    public IActionResult Getproduct(int a, int b)
    {
        var result = a * b;
        return Ok(new {a, b, result});
    }
    [HttpGet(template: "Division")]
    public IActionResult GetDivision(int a, int b)
    {
        var result = a / b;
        return Ok(new {a, b, result});
    }
}
