using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hand_testing_Calculator
{
    public class Calculator
    {
        public Calculator()
        { 

        }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Add(double b)
        {
            Accumulator += b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }
        public double Subtract(double b)
        {
            Accumulator -= b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator; 
        }

        public double Multiply(double b)
        {
            Accumulator *= b;
            return Accumulator;
        }

        public double Power(double a, double b)
        {
            Accumulator = Math.Pow(a, b);
            return Accumulator;
        }

        public double Power(double b)
        {
            Accumulator = Math.Pow(Accumulator, b);
            return Accumulator;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor != 0)
            {
                Accumulator = dividend / divisor;
                return Accumulator;
            }
            else
            {
                throw new DivideByZeroException();
            }
        }
        public double Divide(double divisor)
        {
            if (divisor != 0)
            {
                Accumulator = Accumulator / divisor;
                return Accumulator;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void Clear()
        {
            Accumulator = 0;
        }
        public double Accumulator { get; private set; }
    }
}
