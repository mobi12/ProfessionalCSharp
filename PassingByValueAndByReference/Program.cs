using System;

namespace PassingByValueAndByReference
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            A a1 = new A { X = 1 };
            ChangeA(a1);

            Console.WriteLine($"a1.X: {a1.X}");

            ChangeA(ref a1);
            Console.WriteLine($"ref a1.X: {a1.X}");
        }

        public static void ChangeA(A a)
        {
            a.X = 3; //标准的介绍引用的例子
        }

        public static void ChangeA(ref A a)
        {
            a.X = 2;
        }
    }
}