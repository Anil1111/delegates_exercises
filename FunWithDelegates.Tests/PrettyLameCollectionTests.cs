using NUnit.Framework;
using System.Linq;

namespace FunWithDelegates.Tests
{
    [TestFixture]
    public class PrettyLameCollectionTests
    {
        [Test]
        public void sorts_integers()
        {
            var myCollection = new PrettyLameCollection<int>();
            myCollection.Add(5, 1, 4, 8, 2);

            myCollection.Sort();

            CollectionAssert.AreEqual(new[] {1, 2, 4, 5, 8}, myCollection);
        }

        [Test]
        public void sorts_string()
        {
            var myCollection = new PrettyLameCollection<string>();
            myCollection.Add("Chris", "Kelly", "Scott", "Ron", "Eric");

            myCollection.Sort();

            CollectionAssert.AreEqual(new[] {"Chris", "Eric", "Kelly", "Ron", "Scott"}, myCollection);
        }

        /*[Test]
        public void exercise_2()
        {
            var myCollection = CreateAPrettyLameCollectionOfThingamabobs();

            myCollection.Sort();

            VerifyThatTheThingamabobsAreSortedByTheirDoohickeysInDescendingOrder(myCollection);
        }*/

        /*[Test]
        public void exercise_3()
        {
            var myCollection = CreateAPrettyLameCollectionOfThingamabobs();

            myCollection.Sort();

            VerifyThatTheThingamabobsAreSortedByTheirDoohickeysInDescendingOrder(myCollection);
        }*/

        /*[Test]
        public void exercise_4()
        {
            var myCollection = CreateAPrettyLameCollectionOfThingamabobs();

            myCollection.Sort();

            VerifyThatTheThingamabobsAreSortedByTheirDoohickeysInDescendingOrder(myCollection);
        }*/

        private static PrettyLameCollection<Thingamabob> CreateAPrettyLameCollectionOfThingamabobs()
        {
            var myCollection = new PrettyLameCollection<Thingamabob>
                {
                    new Thingamabob {Doohickey = 5, Whatchamacallit = "Chris"}, 
                    new Thingamabob {Doohickey = 1, Whatchamacallit = "Kelly"}, 
                    new Thingamabob {Doohickey = 4, Whatchamacallit = "Scott"},
                    new Thingamabob {Doohickey = 8, Whatchamacallit = "Ron"}, 
                    new Thingamabob {Doohickey = 2, Whatchamacallit = "Eric"}
                };
            return myCollection;
        }

        private static void VerifyThatTheThingamabobsAreSortedByTheirDoohickeysInDescendingOrder(PrettyLameCollection<Thingamabob> myCollection)
        {
            CollectionAssert.AreEqual(new[] { 8, 5, 4, 2, 1 }, myCollection.Select(t => t.Doohickey));
        }
    }
}