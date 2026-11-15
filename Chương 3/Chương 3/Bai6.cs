using System;

namespace Chương_3
{
    internal class Bai6
    {
        static int UCLN(int a, int b)
        {
            if (a % b == 0)
                return b;

            return UCLN(b, a % b);
        }

        public static void Run()
        {
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("UCLN = " + UCLN(a, b));
        }
    }
}