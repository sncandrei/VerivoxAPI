using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Verivox.Contracts;

namespace VerivoxAPI.Controllers;

[Route("api/consumption")]
public class ConsumptionController : Controller
{
    private readonly IConsumptionService _consumptionService;

    public ConsumptionController(IConsumptionService consumptionService)
    {
        _consumptionService = consumptionService;
    }

    // GET: api/consumption/products?kwhOverYear={number}
    [HttpGet ("products", Name = "GetProductsAsync")]
    public IActionResult GetProductsAsync(
        [FromQuery]
        [Range(1,double.MaxValue)]
        double kwhOverYear)
    {
        if (kwhOverYear == 0)
        {
            return BadRequest();
        }

        return Ok(_consumptionService.GetProducts(kwhOverYear));
    }
}

