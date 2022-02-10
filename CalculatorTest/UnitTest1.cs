using System;
using NUnit.Framework;
using Hand_testing_Calculator;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace CalculatorTest
{
    public class Tests
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [TestCase(1, 0, 1)]
        [TestCase(8, 3, 11)]
        public void Add_Positive_And_Positive_Result_Positive(int a, int b, int result)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(2, 5, -3)]
        [TestCase(2, 7, -5)]
        [TestCase(1, 0, 1)]
        [TestCase(7, 3, 4)]
        public void Subtract_Positive_And_Positive_Result(int a, int b, int result)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }

        [TestCase(2, 5, 10)]
        [TestCase(2, 7, 14)]
        [TestCase(1, 0, 0)]
        [TestCase(7, 3, 21)]
        public void Multiply_Positive_And_Positive_Result_Positive(int a, int b, int result)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(2, 5, 32)]
        [TestCase(2, 7, 128)]
        [TestCase(1, 0, 1)]
        [TestCase(7, 3, 343)]
        public void Power_Positive_And_Positive_Result_Positive(int a, int b, int result)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(result));
        }

        

        [TestCase(1)]
        [TestCase(9)]
        [TestCase(-5)]
        [TestCase(10294)]

        public void Division_By_Zero(double a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => uut.Divide(a,0));
        }

        [TestCase(6,2,3)]
        [TestCase(100,10,10)]
        [TestCase(10,100,0.1)]
        [TestCase(12,3,4)]

        public void Division_Positive_And_Positive_Result_Positive(double a, double b, double result)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
        }

        [TestCase(-6, 2, -3)]
        [TestCase(-100, 10, -10)]
        [TestCase(-10, 100, -0.1)]
        [TestCase(-12, 3, -4)]
        [TestCase( -10.5,2, -5.25)]
        [TestCase(-1000,5,-200)]

        public void Division_Negative_And_Positive_Result_Negative(double a, double b, double result)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
        }

        [TestCase(5, 2)]
        [TestCase(-100, 15)]
        [TestCase(-7, -2.5)]
        public void ClearAccumulator(double a, double b)
        {
            c.Multiply(a, b);
            c.Clear();
            Assert.That(c.Accumulator, Is.EqualTo(0));
        }
    }
}