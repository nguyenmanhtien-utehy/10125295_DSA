using System;
// bài 1 Chương 2
class Program
{
    static void ThapHaNoi(int n, char A, char B, char C)
    {
        if (n == 1)
        {
            Console.WriteLine("Chuyen dia 1 tu " + A + " sang " + C);
            return;
        }

        ThapHaNoi(n - 1, A, C, B);

        Console.WriteLine("Chuyen dia " + n + " tu " + A + " sang " + C);

        ThapHaNoi(n - 1, B, A, C);
    }

    static void Main()
    {
        Console.Write("Nhap so dia: ");
        int n = int.Parse(Console.ReadLine());

        ThapHaNoi(n, 'A', 'B', 'C');

        Console.ReadKey();
    }
}