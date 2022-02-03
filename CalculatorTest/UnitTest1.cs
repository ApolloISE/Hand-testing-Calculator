using NUnit.Framework;
using Hand_testing_Calculator;

namespace CalculatorTest
{
    public class Tests
    {
        private Calculator c;
        [SetUp]
        public void Setup()
        {
            c = new Calculator();
        }

        [TestCase(1, 0, 1)]
        [TestCase(7, 3, 10)]
        public void Add_Positive_And_Positive_Result_Positive(int a, int b,int result)
        {
            Assert.That(c.Add(a,b),Is.EqualTo(result));
        }

        [TestCase(2, 5, -3)]
        [TestCase(2, 7, -5)]
        [TestCase(1, 0, 1)]
        [TestCase(7, 3, 4)]
        public void Subtract_Positive_And_Positive_Result(int a, int b, int result)
        {
            Assert.That(c.Subtract(a, b), Is.EqualTo(result));
        }

        [TestCase(2, 5, 10)]
        [TestCase(2, 7, 14)]
        [TestCase(1, 0, 0)]
        [TestCase(7, 3, 21)]
        public void Multiply_Positive_And_Positive_Result_Positive(int a, int b, int result)
        {
            Assert.That(c.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(2, 5, 32)]
        [TestCase(2, 7, 128)]
        [TestCase(1, 0, 1)]
        [TestCase(7, 3, 343)]
        public void Power_Positive_And_Positive_Result_Positive(int a, int b, int result)
        {
            Assert.That(c.Power(a, b), Is.EqualTo(result));
        }
    }
}