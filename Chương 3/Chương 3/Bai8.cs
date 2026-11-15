using System;

namespace Chương_3
{
    internal class Bai8
    {
        static double Can(int i, int n)
        {
            if (i == n)
                return Math.Sqrt(n);

            return Math.Sqrt(i + Can(i + 1, n));
        }

        static double S(int n)
        {
            return Can(1, n);
        }

        public static void Run()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("S = " + S(n));
        }
    }
}