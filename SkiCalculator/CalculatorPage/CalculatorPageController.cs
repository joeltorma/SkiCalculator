using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SkiCalculator.CalculatorPage
{
    [Produces("application/json")]
    [Route("api/CalculatorPage")]
    public class CalculatorPageController : Controller
    {
        [HttpGet("GetSkiLenght/{height}/{age}/{style}")]
        public List<int> Get(int height, int age, string style)
        {
            List<int> resultSpan = new List<int>();
            int fromSpan;
            int toSpan;
            if (age < 0 || height < 0)
                throw new ArgumentException("Age and height must be greater than 0");
            if (age < 5)
            {
                fromSpan = height;
                toSpan = height;
            }
            else if (age < 9)
            {
                fromSpan = height+10;
                toSpan = height+20;
            }
            else if (style.ToLower() == "classic")
            {
                fromSpan = height + 20;
                toSpan = height + 20;
                
            }
            else if (style.ToLower() == "skate")
            {
                fromSpan = height + 10;
                toSpan = height + 15;

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
