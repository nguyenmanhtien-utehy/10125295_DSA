using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] mangSo = new int[1000];

        for (int i = 0; i < mangSo.Length; i++)
        {
            mangSo[i] = rand.Next(0, 10000);
        }

        int soLonNhat = mangSo[0];
        int soNhoNhat = mangSo[0];

        foreach (int so in mangSo)
        {
            if (so > soLonNhat) soLonNhat = so;
            if (so < soNhoNhat) soNhoNhat = so;
        }

        Console.WriteLine("So lon nhat trong mang la: " + soLonNhat);
        Console.WriteLine("So nho nhat trong mang la: " + soNhoNhat);
        Console.ReadKey();
    }
}