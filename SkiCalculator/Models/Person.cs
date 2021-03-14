using System;
namespace SkiCalculator.Models
{
    public class Person
    {
        public int height { get; set; }
        public int age { get; set; }
        public string requestedStyle { get; set; }

        public Person(int height, int age, string requestedStyle)
        {
            if (ValidatePersonParams(height, age, requestedStyle))
            {
                this.height = height;
                this.age = age;
                this.requestedStyle = requestedStyle;
            }
            else
                throw new ArgumentException("Height must be greater than 0(cm), age greater than 0 and requestedStyle equal to classic or skate");
        }

        public bool ValidatePersonParams(int height, int age, string requestedStyle)
        {
            if (age < 0 || height < 0 && (requestedStyle != "skate" || requestedStyle != "classic"))
                return false;
            return true;
        }
    }
}