using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace FunWithDelegates.Tests
{
    [TestFixture]
    public class Exercise4
    {
        [Test]
        public void Exercise()
        {
            var myCollection = new List<Thingamabob>
                {
                    new Thingamabob {Doohickey = 5, Whatchamacallit = "Chris"}, 
                    new Thingamabob {Doohickey = 1, Whatchamacallit = "Kelly"}, 
                    new Thingamabob {Doohickey = 4, Whatchamacallit = "Scott"},
                    new Thingamabob {Doohickey = 8, Whatchamacallit = "Ron"}, 
                    new Thingamabob {Doohickey = 2, Whatchamacallit = "Eric"}
                };

            myCollection.Sort(); // TODO: Use overload that takes a Comparison<T> to sort the collection of Thing-a-ma-bobs by their Doohickeys in descending order.

            CollectionAssert.AreEqual(new[] { 8, 5, 4, 2, 1 }, myCollection.Select(t => t.Doohickey));
        }
    }
}