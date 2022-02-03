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
            return a + b;
        }

        public double Subtract(double a, double b)
        { 
            return a - b;
        }

        public double Multiply(double a, double b)
        { 
            return a * b; 
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
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

    }
}
