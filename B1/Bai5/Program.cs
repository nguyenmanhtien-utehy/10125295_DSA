using System;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c = 0;

            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else if (n == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }

                Console.WriteLine("So Fibonacci thu " + n + " la: " + c);
            }

            Console.ReadKey();
        }
    }
}