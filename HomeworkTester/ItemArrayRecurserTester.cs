using ItemArrayRecurser;
using NUnit.Framework;

namespace HomeworkTester
{
    [TestFixture]
    public class ItemArrayRecurserTester
    {
        [Test]
        public void Round1ShouldReturnConcatString()
        {
            var array = new[] {"First", "Second", "Third"};

            var recurser = new ItemArray();

            var result = recurser.Recurse_Round1(array);

            Assert.AreEqual("FirstSecondThird", result);
        }

        [Test]
        public void Round2TestShouldReturnTotal()
        {
            var array = new object[] { 3, 6, 9 };

            var recurser = new ItemArray();

            var result = recurser.Recurse_Round2(array);

            Assert.AreEqual("18", result);
        }

        [Test]
        public void Round2TestShouldReturnConcatString()
        {
            var array = new object[] { "First", "Second", "Third" };

            var recurser = new ItemArray();

            var result = recurser.Recurse_Round2(array);

            Assert.AreEqual("FirstSecondThird", result);
        }

        [Test]
        public void Round3TestShouldReturnConcatString()
        {
            var array = new object[] { "First", "Second", "Third" };

            var recurser = new ItemArray();

            var result = recurser.Recurse_Round3(array);

            Assert.AreEqual("I don't know how", result);
        }
    }
}
