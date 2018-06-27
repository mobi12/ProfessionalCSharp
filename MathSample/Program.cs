using static System.Console;

namespace MathSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WriteLine($"Pi is {Math.GetPi()}");

            int x = Math.GetSquareOf(5);
            WriteLine($"Square of 5 is {x}");

            var math = new Math();
            math.Value = 30;
            WriteLine($"Value field of math variable contains {math.Value}");
            WriteLine($"Square of 30 is {math.GetSquare()}");
        }
    }
}