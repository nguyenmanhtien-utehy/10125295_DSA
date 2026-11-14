using System;
namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("nhap chuoi: ");
            string s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
            Console.ReadKey();
        }
    }
}