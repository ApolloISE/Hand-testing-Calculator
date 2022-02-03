
namespace Hand_testing_Calculator
{
    public class Program
    {
        public static void Main()
        {
            Calculator c = new Calculator();
            double a = 5;
            double b = 2;
            Console.WriteLine("If we have a as 5 and b as 2, we can call functions as follows:");
            Console.WriteLine("Add " + c.Add(a, b));
            Console.WriteLine("Subtract " + c.Subtract(a, b));
            Console.WriteLine("Multiply " + c.Multiply(a, b));
            Console.WriteLine("Power " + c.Power(a, b));
            
        }

    }
}