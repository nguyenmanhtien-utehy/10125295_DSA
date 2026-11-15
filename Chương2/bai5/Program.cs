using System;
//bài 5 / chương 2
class Program
{
    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;

        if (n == 1)
            return 1;

        int a = 0;
        int b = 1;
        int c = 0;

        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c;
    }

    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Fibonacci = " + Fibonacci(n));

        Console.ReadKey();
    }
}



///bài 6 / chương 2

using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so phan tu: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] = ");
            a[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Mang sau khi sap xep:");

        for (int i = 0; i < n; i++)
            Console.Write(a[i] + " ");

        Console.ReadKey();
    }
}