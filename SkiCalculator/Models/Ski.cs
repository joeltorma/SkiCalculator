using System;
using System.Collections.Generic;

namespace SkiCalculator.Models
{
    public class Ski
    {
        public List<int> lengthSpan { get; set; }
        public string style { get; set; }

        public Ski(Person person)
        {
            lengthSpan = getSkiLength(person);
            style = person.requestedStyle;
        }

        private List<int> getSkiLength(Person person)
        {
            List<int> result = new List<int>();
            int fromSpan;
            int toSpan;
            if (person.age < 5)
            {
                toSpan = fromSpan = person.height;
            }
            else if (person.age < 9)
            {
                fromSpan = person.height + 10;
                toSpan = person.height + 20;
            }
            else if (person.requestedStyle == "classic")
            {
                fromSpan = toSpan = person.height + 20;
            }
            else // person.requestedStyle == "skate" 
            {
                fromSpan = person.height + 10;
                toSpan = person.height + 15;
            }

            if (person.requestedStyle == "classic" && fromSpan > 207)
                fromSpan = 207;
            if (person.requestedStyle == "classic" && toSpan > 207)
                toSpan = 207;

            result.Add(fromSpan);
            result.Add(toSpan);
                
            return result;
        }
    }
}
