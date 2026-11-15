using System;

namespace Chương_3
{
    internal class Bai4
    {
        static double LuyThua(double x, int n)
        {
            if (n == 0)
                return 1;

            return LuyThua(x, n - 1) * x;
        }

        public static void Run()
        {
            Console.Write("Nhap x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 0)
                Console.WriteLine("Ket qua = " + LuyThua(x, n));
            else
                Console.WriteLine("Ket qua = " + 1 / LuyThua(x, -n));
        }
    }
}