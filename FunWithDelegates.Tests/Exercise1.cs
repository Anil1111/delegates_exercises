using System.Linq;
using NUnit.Framework;

namespace FunWithDelegates.Tests
{
    [TestFixture]
    public class Exercise1
    {
        [Test]
        public void Exercise()
        {
            var myCollection = new PrettyLameCollection<int> {5, 1, 4, 8, 2};

            myCollection.Sort(); // TODO: Sort the collection in descending order. Try to add a delegate to PrettyLameCollection that is accepted as a parameter to an overload of the Sort method.  Use a Named Method to satisfy the delegate.

            CollectionAssert.AreEqual(new[] { 8, 5, 4, 2, 1 }, myCollection);
        }
    }
}