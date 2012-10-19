using System.Linq;
using NUnit.Framework;

namespace FunWithDelegates.Tests
{
    [TestFixture]
    public class Exercise5
    {
        [Test]
        public void Exercise()
        {
            var myCollection = new PrettyLameCollection<Thingamabob>
                {
                    new Thingamabob {Doohickey = 5, Whatchamacallit = "Chris"}, 
                    new Thingamabob {Doohickey = 1, Whatchamacallit = "Kelly"}, 
                    new Thingamabob {Doohickey = 4, Whatchamacallit = "Scott"},
                    new Thingamabob {Doohickey = 8, Whatchamacallit = "Ron"}, 
                    new Thingamabob {Doohickey = 2, Whatchamacallit = "Eric"}
                };

            myCollection.Sort(); // TODO: Add an overload the Sort method on PrettyLameCollection that takes in the appropriate Func<> or Action<> and sort the collection of Thing-a-ma-bobs by their Doohickeys in descending order.

            CollectionAssert.AreEqual(new[] { 8, 5, 4, 2, 1 }, myCollection.Select(t => t.Doohickey));
        }
    }
}