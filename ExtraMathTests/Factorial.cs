using ExtraMath; // namespace in which Factorial function is defined

namespace ExtraMathTests
{
    [TestClass]
    public class Factorial
    {
        [TestMethod]
        public void FactorialReturns1ForArgument1()
        {
            Assert.AreEqual(1, Functions.Factorial(1));
        }

        [TestMethod]
        public void FactorialReturns2ForArgument2()
        {
            Assert.AreEqual(2, Functions.Factorial(2));
        }

        [TestMethod]
        public void FactorialReturns6ForArgument3()
        {
            Assert.AreEqual(6, Functions.Factorial(3));
        }

        [TestMethod]
        public void FactorialReturns24ForArgument4()
        {
            Assert.AreEqual(24, Functions.Factorial(4));
        }

        [TestMethod]
        public void FactorialReturns5040ForArgument7()
        {
            Assert.AreEqual(5040, Functions.Factorial(7));
        }

        [TestMethod]
        public void FactorialReturns1ForArgument0()
        {
            Assert.AreEqual(1, Functions.Factorial(0));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Function didn't throw for negative argument")]
        public void FactorialThrowsExceptionForNegativeArgument()
        {
            Functions.Factorial(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Function didn't throw for argument larger than 20")]
        public void FactorialThrowsExceptionForArgumetLargerThan20()
        {
            Functions.Factorial(21);
        }
    }
}