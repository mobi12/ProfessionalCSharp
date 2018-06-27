using System;

namespace EnumSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DaysOfWeek days = DaysOfWeek.Wednesday | DaysOfWeek.Monday;
            Console.WriteLine(days);
            bool test = (DaysOfWeek.Monday & DaysOfWeek.Wednesday) == DaysOfWeek.Wednesday;
            Console.WriteLine(test);
        }
    }
}