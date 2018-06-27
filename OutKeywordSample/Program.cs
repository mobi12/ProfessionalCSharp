//这个小程序当作复习
using System;

namespace OutKeywordSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int result; //out类型不需要对参数初始化
            if (int.TryParse(input, out result))
            {
                Console.WriteLine($"n: {int.Parse(input)}");
            }
            else
            {
                Console.WriteLine("not a number");
            }
        }
    }
}