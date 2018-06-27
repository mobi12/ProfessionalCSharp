using System;

namespace StructsSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dimensions point1 = Dimensions.SetEmpty();
            point1.Width = 5;
            point1.Length = 3;

            Dimensions point = new Dimensions(5, 3);
            double D = point.Length;

            Console.WriteLine(point1.ToString());
            Console.WriteLine(point.Diagonal);
        }
    }
}