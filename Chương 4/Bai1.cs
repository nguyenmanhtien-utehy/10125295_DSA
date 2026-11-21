using System;

namespace Chương4
{
    public class Bai1
    {
        public static void Run()
        {
            Console.Write("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Danh sach:");
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();

            Console.Write("Nhap x can chen: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write($"Nhap vi tri k (0..{a.Length}): ");
            int k = int.Parse(Console.ReadLine());

            if (k >= 0 && k <= a.Length)
            {
                int[] tmp = new int[a.Length + 1];
                for (int i = 0; i < k; i++) tmp[i] = a[i];
                tmp[k] = x;
                for (int i = k; i < a.Length; i++) tmp[i + 1] = a[i];
                a = tmp;

                Console.WriteLine("Sau khi chen:");
                for (int i = 0; i < a.Length; i++)
                    Console.Write(a[i] + " ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Vi tri k khong hop le!");
            }
        }
    }
}