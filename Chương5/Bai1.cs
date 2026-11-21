using System;
using System.Collections.Generic;

namespace Chuong5
{
    public class Bai1
    {
        public static void Run()
        {
            Console.Write("Nhap bieu thuc toan hoc: ");
            string expr = Console.ReadLine() ?? "";

            bool hopLe = KiemTraNgoac(expr);
            Console.WriteLine(hopLe ? "Bieu thuc HOP LE." : "Bieu thuc KHONG HOP LE.");
        }

        private static bool KiemTraNgoac(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}