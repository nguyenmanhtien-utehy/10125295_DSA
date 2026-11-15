using System;
//Bài 2 / chương 2

class Program
{
    static int BinarySearch(int[] a, int x)
    {
        int left = 0;
        int right = a.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (a[mid] == x)
                return mid;

            if (a[mid] < x)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    static void Main()
    {
        int[] a = { 2, 4, 6, 8, 10, 12, 14 };

        Console.Write("Nhap so can tim: ");
        int x = int.Parse(Console.ReadLine());

        int kq = BinarySearch(a, x);

        if (kq == -1)
            Console.WriteLine("Khong tim thay");
        else
            Console.WriteLine("Tim thay tai vi tri " + kq);

        Console.ReadKey();
    }
}