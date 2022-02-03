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

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator; 
        }

        public double Power(double a, double b)
        {
            Accumulator = Math.Pow(a, b);
            return Accumulator;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor != 0)
            {
                return dividend / divisor;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public double Accumulator { get; private set; }
    }
}
