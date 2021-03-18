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
        public void Length150_Age3_Classic()
        {
            Person person = new Person(150, 3, "classic");
            Ski recommendedSkis = new Ski(person);
            Assert.Equal(150, recommendedSkis.lengthSpan[0]);
            Assert.Equal(150, recommendedSkis.lengthSpan[1]);
        }

        [Fact]
        public void Length150_Age3_Skate()
        {
            Person person = new Person(150, 3, "skate");
            Ski recommendedSkis = new Ski(person);
            Assert.Equal(150, recommendedSkis.lengthSpan[0]);
            Assert.Equal(150, recommendedSkis.lengthSpan[1]);
        }

        [Fact]
        public void Length150_Age5_Classic()
        {
            Person person = new Person(150, 5, "classic");
            Ski recommendedSkis = new Ski(person);
            Assert.Equal(160, recommendedSkis.lengthSpan[0]);
            Assert.Equal(170, recommendedSkis.lengthSpan[1]);
        }

        [Fact]
        public void Length150_Age5_Skate()
        {
            Person person = new Person(150, 5, "skate");
            Ski recommendedSkis = new Ski(person);
            Assert.Equal(160, recommendedSkis.lengthSpan[0]);
            Assert.Equal(170, recommendedSkis.lengthSpan[1]);
        }

        [Fact]
        public void Length170_Age10_Classic()
        {
            Person person = new Person(170, 10, "classic");
            Ski recommendedSkis = new Ski(person);
            Assert.Equal(190, recommendedSkis.lengthSpan[0]);
            Assert.Equal(190, recommendedSkis.lengthSpan[1]);
        }

        [Fact]
        public void Length170_Age10_Skate()
        {
            Person person = new Person(170, 10, "skate");
            Ski recommendedSkis = new Ski(person);
            Assert.Equal(180, recommendedSkis.lengthSpan[0]);
            Assert.Equal(185, recommendedSkis.lengthSpan[1]);
        }

        [Fact]
        public void Classic_MaxLength207()
        {
            Person person = new Person(200, 10, "classic");
            Ski recommendedSkis = new Ski(person);
            Assert.Equal(207, recommendedSkis.lengthSpan[0]);
            Assert.Equal(207, recommendedSkis.lengthSpan[1]);
        }
    }
}
