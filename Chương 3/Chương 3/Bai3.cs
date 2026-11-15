using System;

namespace Chương_3
{
    internal class Bai3
    {
        static double Tong(int n)
        {
            if (n == 1)
                return 1;

            return Tong(n - 1) + 1.0 / n;
        }

        public static void Run()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Tong = " + Tong(n));
        }
    }
}