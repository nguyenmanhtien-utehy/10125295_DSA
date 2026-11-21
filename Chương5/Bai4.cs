using System;
using System.Collections.Generic;

namespace Chuong5
{
    public class Bai4
    {
        public static void Run()
        {
            Queue<string> printQueue = new Queue<string>();

            while (true)
            {
                Console.WriteLine("\n1. Them yeu cau in (Enqueue) | 2. In trang tiep theo (Dequeue) | 3. Xem hang doi | 0. Thoat");
                Console.Write("Chon: ");
                string chon = Console.ReadLine();

                if (chon == "1")
                {
                    Console.Write("Nhap ten tai lieu can in: ");
                    string doc = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(doc))
                    {
                        printQueue.Enqueue(doc.Trim());
                        Console.WriteLine($"Da them '{doc.Trim()}' vao hang doi in.");
                    }
                }
                else if (chon == "2")
                {
                    if (printQueue.Count > 0)
                    {
                        string nextDoc = printQueue.Dequeue();
                        Console.WriteLine($"Dang in: {nextDoc}");
                    }
                    else
                    {
                        Console.WriteLine("Khong con yeu cau in nao trong hang doi.");
                    }
                }
                else if (chon == "3")
                {
                    Console.WriteLine($"So yeu cau dang cho: {printQueue.Count}");
                    foreach (var item in printQueue)
                        Console.WriteLine("  - " + item);
                }
                else if (chon == "0")
                {
                    break;
                }
            }
        }
    }
}