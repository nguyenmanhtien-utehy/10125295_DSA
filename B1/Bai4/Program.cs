using System;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[1000];
            Random rd = new Random();

            // Sinh ngẫu nhiên 1000 số
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rd.Next(100);
            }

            Console.WriteLine("Mang ban dau:");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();

            // Sắp xếp tăng dần
            Array.Sort(a);

            Console.WriteLine("\nMang sau khi sap xep:");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.ReadKey();
        }
    }
}