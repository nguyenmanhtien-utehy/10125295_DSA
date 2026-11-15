using System;

namespace Chương_3
{
    internal class Bai5
    {
        static int UocLeMax(int n)
        {
            if (n % 2 == 1)
                return n;

            return UocLeMax(n / 2);
        }

        public static void Run()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Uoc le lon nhat = " + UocLeMax(n));
        }
    }
}