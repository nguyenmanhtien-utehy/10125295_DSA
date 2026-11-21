using System;

namespace Chương4
{
    public class Bai3
    {
        public static void Run()
        {
            Console.Write("Nhap cap ma tran n (0 <= n < 100): ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }

            int tong = 0, minDuong = int.MaxValue, tongCheoPhu = 0;
            for (int i = 0; i < n; i++)
            {
                tongCheoPhu += a[i, n - 1 - i];
                for (int j = 0; j < n; j++)
                {
                    tong += a[i, j];
                    if (a[i, j] > 0 && a[i, j] < minDuong)
                        minDuong = a[i, j];
                }
            }

            bool tangDan = true;
            for (int i = 0; i < n - 1; i++)
                if (a[i + 1, i + 1] <= a[i, i]) tangDan = false;

            Console.WriteLine($"a. Tong ma tran: {tong}");
            Console.WriteLine($"b. Duong nho nhat: {(minDuong == int.MaxValue ? -1 : minDuong)}");
            Console.WriteLine($"c. Tong duong cheo phu: {tongCheoPhu}");
            Console.WriteLine($"d. Duong cheo chinh tang dan? {tangDan}");
        }
    }
}