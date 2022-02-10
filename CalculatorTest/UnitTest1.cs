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

        [TestCase(1, 0, 1)]
        [TestCase(8, 3, 11)]
        public void Add_Positive_And_Positive_Result_Positive_Accumulation(int a, int b, int result)
        {
            uut.Add(a);
            uut.Add(b);
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(2, 5, -3)]
        [TestCase(2, 7, -5)]
        [TestCase(1, 0, 1)]
        [TestCase(7, 3, 4)]
        public void Subtract_Positive_And_Positive_Result(int a, int b, int result)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }

        [TestCase(2, 5, -8)]
        [TestCase(2, 7, -12)]
        [TestCase(1, 0, 1)]
        [TestCase(7, 3, 1)]
        public void Subtract_Positive_And_Positive_Result_Accumulation(int a, int b, int result)
        {
            uut.Subtract(a,b);
            uut.Subtract(b);
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(2, 5, 10)]
        [TestCase(2, 7, 14)]
        [TestCase(1, 0, 0)]
        [TestCase(7, 3, 21)]
        public void Multiply_Positive_And_Positive_Result_Positive(int a, int b, int result)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(2, 5, 50)]
        [TestCase(2, 7, 98)]
        [TestCase(1, 0, 0)]
        [TestCase(7, 3, 63)]
        public void Multiply_Positive_And_Positive_Result_Positive_Accumulation(int a, int b, int result)
        {
            uut.Multiply(a,b);
            uut.Multiply(b);
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(2, 5, 32)]
        [TestCase(2, 7, 128)]
        [TestCase(1, 0, 1)]
        [TestCase(7, 3, 343)]
        public void Power_Positive_And_Positive_Result_Positive(int a, int b, int result)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(result));
        }

        [TestCase(2, 5, 1024)]
        [TestCase(2, 7, 16384)]
        [TestCase(1, 0, 1)]
        [TestCase(2, 3, 64)]
        public void Power_Positive_And_Positive_Result_Positive_Accumulation(int a, int b, int result)
        {
            uut.Power(a,b);
            uut.Power(a);
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }


        [TestCase(1)]
        [TestCase(9)]
        [TestCase(-5)]
        [TestCase(10294)]

        public void Division_By_Zero(double a)
        {
            Assert.Throws<DivideByZeroException>(() => uut.Divide(a,0));
        }

        [TestCase(6,2,3)]
        [TestCase(100,10,10)]
        [TestCase(10,100,0.1)]
        [TestCase(12,3,4)]

        public void Division_Positive_And_Positive_Result_Positive(double a, double b, double result)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
        }

        [TestCase(6, 2, 1.5)]
        [TestCase(100, 10, 1)]
        [TestCase(10, 100, 0.001)]
        [TestCase(12, 4, 0.75)]

        public void Division_Positive_And_Positive_Result_Positive_Accumulation(double a, double b, double result)
        {
            uut.Divide(a,b);
            uut.Divide(b);
            Assert.That(uut.Accumulator, Is.EqualTo(result));
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

        [TestCase(5,2)]
        [TestCase(5.5,2.25)]
        [TestCase(100,100000)]
        public void Accumulator_Add_Two_Positive_Numbers_Get_Positive_Value(double a, double b)
        {
            //act
            double x = uut.Add(a, b);
            //Assert
            Assert.That(x,Is.EqualTo(uut.Accumulator));
        }


        [TestCase(2,5,10,7)]
        [TestCase(10,5,100,75)]
        [TestCase(2,5,50,25)]
        public void Accumulator_Do_Add_Operation_Then_Subtract_Operation_Happens_Then_Get_Accumulator_From_Last_Operation(double a, double b, double c, double d)
        {
            //act
            uut.Add(a, b);
            double result = uut.Subtract(c, d);

            //assert
            Assert.That(result,Is.EqualTo(uut.Accumulator));
        }

        [TestCase(5, 2)]
        [TestCase(-100, 15)]
        [TestCase(-7, -2.5)]
        public void ClearAccumulator(double a, double b)
        {
            uut.Multiply(a, b);
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }
    }
}