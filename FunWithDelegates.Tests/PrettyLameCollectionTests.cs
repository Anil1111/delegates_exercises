using NUnit.Framework;

namespace FunWithDelegates.Tests
{
    [TestFixture]
    public class PrettyLameCollectionTests
    {
        [Test]
        public void sorts_integers()
        {
            var myCollection = new PrettyLameCollection<int>();
            myCollection.Add(5, 1, 4, 2, 8);

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
    }
}