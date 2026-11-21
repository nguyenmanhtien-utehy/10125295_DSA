using System;
using System.Collections.Generic;

namespace Chuong5
{
    public class Bai2
    {
        public static void Run()
        {
            Stack<string> backStack = new Stack<string>();
            Stack<string> forwardStack = new Stack<string>();
            string current = "home.local";

            while (true)
            {
                Console.WriteLine($"\nTrang hien tai: {current}");
                Console.WriteLine("1. Truy cap URL moi | 2. Back | 3. Forward | 0. Thoat");
                Console.Write("Chon: ");
                string chon = Console.ReadLine();

                if (chon == "1")
                {
                    Console.Write("Nhap URL moi: ");
                    string url = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(url))
                    {
                        backStack.Push(current);
                        current = url.Trim();
                        forwardStack.Clear();
                    }
                }
                else if (chon == "2")
                {
                    if (backStack.Count > 0)
                    {
                        forwardStack.Push(current);
                        current = backStack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Khong co trang nao de Back!");
                    }
                }
                else if (chon == "3")
                {
                    if (forwardStack.Count > 0)
                    {
                        backStack.Push(current);
                        current = forwardStack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Khong co trang nao de Forward!");
                    }
                }
                else if (chon == "0")
                {
                    break;
                }
            }
        }
    }
}