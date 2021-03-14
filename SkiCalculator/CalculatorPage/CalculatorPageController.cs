using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SkiCalculator.Models;

namespace SkiCalculator.CalculatorPage
{
    [Produces("application/json")]
    [Route("api/CalculatorPage")]
    public class CalculatorPageController : Controller
    {
        [HttpGet("GetSkiLenght/{height}/{age}/{style}")]
        public List<int> Get(int height, int age, string style)
        {
            Person person = new Person(height, age, style);
            Ski recommendedSkis = new Ski(person);
            return recommendedSkis.lengthSpan;
        }
    }
}
