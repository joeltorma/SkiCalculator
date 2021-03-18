using System;
using SkiCalculator.Models;
using Xunit;
using static SkiCalculator.CalculatorPage.CalculatorPageController;

namespace SkiCalculatorTests
{
    public class SkiCalculatorTests
    {
        [Fact]
        public void Invalid_Age_Argument_Throws_Exception()
        {
            Assert.Throws<ArgumentException>(() => new Person(150, -1, "classic"));
        }

        [Fact]
        public void Invalid_Height_Argument_Throws_Exception()
        {
            Assert.Throws<ArgumentException>(() => new Person(-1, 30, "classic"));
        }

        [Fact]
        public void Invalid_RequestedStyle_Argument_Throws_Exception()
        {
            Assert.Throws<ArgumentException>(() => new Person(-1, 30, "blue"));
        }

        [Fact]
        public void L150_A3_Classic()
        {
            Person person = new Person(150, 3, "classic");
            Ski recommendedSkis = new Ski(person);
            Assert.Equal(150, recommendedSkis.lengthSpan[0]);
            Assert.Equal(150, recommendedSkis.lengthSpan[1]);
        }

        [Fact]
        public void L150_A3_Skate()
        {
            Person person = new Person(150, 3, "skate");
            Ski recommendedSkis = new Ski(person);
            Assert.Equal(150, recommendedSkis.lengthSpan[0]);
            Assert.Equal(150, recommendedSkis.lengthSpan[1]);
        }

        //[Fact]
        //public void L150_A3_Skate()
        //{
        //    Person person = new Person(150, 3, "skate");
        //    Ski recommendedSkis = new Ski(person);
        //    Assert.Equal(150, recommendedSkis.lengthSpan[0]);
        //    Assert.Equal(150, recommendedSkis.lengthSpan[1]);
        //}
    }
}
