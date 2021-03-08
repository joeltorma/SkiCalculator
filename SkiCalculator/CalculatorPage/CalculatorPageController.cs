using System;
using Microsoft.AspNetCore.Mvc;

namespace SkiCalculator.CalculatorPage
{
    [Produces("application/json")]
    [Route("api/CalculatorPage")]
    public class CalculatorPageController : Controller
    {
        [HttpGet("GetSkiLenght")]
        public int Get([FromBody] CalculatorInputParams inputParams)
        {
            var skiLength = inputParams.Age + inputParams.Length;
            return skiLength;
        }
    }
}
