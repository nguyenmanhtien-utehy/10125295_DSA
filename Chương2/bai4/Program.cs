using System;
//bài 4 / chương 2
class Program
{
    static bool LaSoHoanHao(int n)
    {
        int tong = 0;

        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
                tong += i;
        }

        return tong == n;
    }

    static void Main()
    {
        Console.Write("Nhap N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Cac so hoan hao:");

        for (int i = 1; i <= N; i++)
        {
            if (LaSoHoanHao(i))
                Console.Write(i + " ");
        }

        Console.ReadKey();
    }
}