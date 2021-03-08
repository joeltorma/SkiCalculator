using System;
using Xunit;
using static SkiCalculator.CalculatorPage.CalculatorPageController;

namespace SkiCalculatorTests
{
    public class SkiCalculatorTests
    {
        [Fact]
        public void ValidAgeArgument()
        {
            int age = -1;
            int length = 150;
            string style = "classic";
            var calculator = new SkiCalculator.CalculatorPage.CalculatorPageController();
            Assert.Throws<ArgumentException>(() => calculator.Get(age, length, style));
        }
    }
}
