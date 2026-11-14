using System;
using System.Text;
namespace Bai2
{
    class Program
    {

        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz ( chia het cho 3 & 5 )");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz ( chia het cho 3 )");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz ( chia het cho 5 )");
                }
                else
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}