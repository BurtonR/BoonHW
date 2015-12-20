using FizzyBuzzer;
using NUnit.Framework;

namespace HomeworkTester
{
    [TestFixture]
    public class FizzyBuzzerTester
    {
        [Test]
        public void ShouldReturn_Fizz()
        {
            var fizz = new FizzBuzzer();
            var result = fizz.Buzz(3,3);

            Assert.AreEqual("Fizz\r\n", result);
        }

        [Test]
        public void ShouldReturn_Buzz()
        {
            var fizz = new FizzBuzzer();
            var result = fizz.Buzz(5, 5);

            Assert.AreEqual("Buzz\r\n", result);
        }

        [Test]
        public void ShouldReturn_FizzBuzz()
        {
            var fizz = new FizzBuzzer();
            var result = fizz.Buzz(15, 15);

            Assert.AreEqual("FizzBuzz\r\n", result);
        }

        [Test]
        public void ShouldReturn_Number()
        {
            var fizz = new FizzBuzzer();
            var result = fizz.Buzz(2, 2);

            Assert.AreEqual("2\r\n", result);
        }

        [Test]
        public void ShouldBeValidValue()
        {
            var fizz = new FizzBuzzer();
            var conf = new FBConfig() {InputValue = 5, ValidationValue = 5};

            var result = fizz.Buzz(conf);

            Assert.AreEqual("Valid Value!\r\n", result);
        }

        [Test]
        public void ShouldNotBeValidValue()
        {
            var fizz = new FizzBuzzer();
            var conf = new FBConfig() { InputValue = 4, ValidationValue = 5 };

            var result = fizz.Buzz(conf);

            Assert.AreEqual("\r\n", result);
        }

        [Test]
        public void ShouldBeMultipleValidValues()
        {
            var fizz = new FizzBuzzer();
            var conf = new[]{new FBConfig() { InputValue = 5, ValidationValue = 5 }, new FBConfig() { InputValue = 1, ValidationValue = 1 }};

            var result = fizz.Buzz(conf);

            Assert.AreEqual("Valid Value!\r\nValid Value!\r\n", result);
        }

        [Test]
        public void ShouldBeSingleValidValues()
        {
            var fizz = new FizzBuzzer();
            var conf = new [] {new FBConfig() { InputValue = 1, ValidationValue = 5 }, new FBConfig() { InputValue = 1, ValidationValue = 1 } };

            var result = fizz.Buzz(conf);

            Assert.AreEqual("\r\nValid Value!\r\n", result);
        }

        [Test]
        public void ShouldBeNoValidValues()
        {
            var fizz = new FizzBuzzer();
            var conf = new [] { new FBConfig() { InputValue = 1, ValidationValue = 5 }, new FBConfig() { InputValue = 5, ValidationValue = 6 } };

            var result = fizz.Buzz(conf);

            Assert.AreEqual("\r\n\r\n", result);
        }
    }
}
