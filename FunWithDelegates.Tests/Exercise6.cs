using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace FunWithDelegates.Tests
{
    [TestFixture]
    public class Exercise6
    {
        [Test]
        public void LargeProvincialCaptials()
        {
            var largeProvincialCaptials =
                from c in AllCities
                where c.Population > 500000 && c.CapitalCity
                select c.Name;

            CollectionAssert.AreEquivalent(new[] { "Edmonton", "Winnipeg", "Toronto", "Quebec City" }, largeProvincialCaptials);
        }

        [Test]
        public void Exercise()
        {
            var largeProvincialCaptials = AllCities; // TODO: Use the IEnumerable<T> extension methods Where and Select to write the equivalent statement to the Linq expression above.

            CollectionAssert.AreEquivalent(new[] { "Edmonton", "Winnipeg", "Toronto", "Quebec City" }, largeProvincialCaptials);
        }

        private readonly List<City> AllCities = new List<City>
            {
                new City {Name = "Calgary", Population = 1096833, CapitalCity = false},
                new City {Name = "Edmonton", Population = 812291, CapitalCity = true},
                new City {Name = "Vancouver", Population = 578041, CapitalCity = false},
                new City {Name = "Victoria", Population = 78057, CapitalCity = true},
                new City {Name = "Winnipeg", Population = 663617, CapitalCity = true},
                new City {Name = "Fredericton", Population = 50535, CapitalCity = true},
                new City {Name = "St. John's", Population = 100646, CapitalCity = true},
                new City {Name = "Toronto", Population = 2503281, CapitalCity = true},
                new City {Name = "Ottwa", Population = 812129, CapitalCity = false},
                new City {Name = "Montreal", Population = 1620693, CapitalCity = false},
                new City {Name = "Quebec City", Population = 659545, CapitalCity = true},
                new City {Name = "Regina", Population = 179246, CapitalCity = true},
                new City {Name = "Saskatoon", Population = 202340, CapitalCity = false}
            };
    }

    public class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public bool CapitalCity { get; set; }
    }
}