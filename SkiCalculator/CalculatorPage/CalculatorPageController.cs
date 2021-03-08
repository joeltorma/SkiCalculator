using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SkiCalculator.CalculatorPage
{
    [Produces("application/json")]
    [Route("api/CalculatorPage")]
    public class CalculatorPageController : Controller
    {
        [HttpGet("GetSkiLenght/{length}/{age}/{style}")]
        public List<int> Get(int length, int age, string style)
        {
            List<int> resultSpan = new List<int>();
            int fromSpan;
            int toSpan;
            if (age < 0 || length < 0)
                throw new ArgumentException("Age and length must be greater than 0");
            if (age < 5)
            {
                fromSpan = length;
                toSpan = length;
            }
            else if (age < 9)
            {
                fromSpan = length+10;
                toSpan = length+20;
            }
            else if (style.ToLower() == "classic")
            {
                fromSpan = length + 20;
                toSpan = length + 20;
                
            }
            else if (style.ToLower() == "skate")
            {
                fromSpan = length + 10;
                toSpan = length + 15;

            }
            else
                throw new ArgumentException("Style must be classic or skate");
            if (style.ToLower() == "classic" && fromSpan > 207)
                fromSpan = 207;
            if (style.ToLower() == "classic" && toSpan > 207)
                toSpan = 207;
            resultSpan.Add(fromSpan);
            resultSpan.Add(toSpan);
            return resultSpan;
        }
    }
}
