using MyCustomCalculator;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Calculator calculator = new Calculator();

            double x = calculator.Add(3, 6);
            Console.WriteLine(x);
        }
    }
}
