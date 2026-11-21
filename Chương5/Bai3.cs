using System;
using System.Collections.Generic;

namespace Chuong5
{
    public class StackFrame
    {
        public string FunctionName { get; set; }
        public string ParamsInfo { get; set; }

        public StackFrame(string func, string paramsInfo)
        {
            FunctionName = func;
            ParamsInfo = paramsInfo;
        }

        public override string ToString() => $"{FunctionName}({ParamsInfo})";
    }

    public class Bai3
    {
        public static void Run()
        {
            Stack<StackFrame> callStack = new Stack<StackFrame>();
            callStack.Push(new StackFrame("Main", "args"));
            Console.WriteLine("Bat dau tai Main(args).");

            while (true)
            {
                Console.WriteLine("\n1. Goi ham moi (Push) | 2. Ket thuc ham hien tai (Pop) | 3. Xem Call Stack | 0. Thoat");
                Console.Write("Chon: ");
                string chon = Console.ReadLine();

                if (chon == "1")
                {
                    Console.Write("Ten ham: ");
                    string tenHam = Console.ReadLine();
                    Console.Write("Tham so: ");
                    string thamSo = Console.ReadLine();

                    var frame = new StackFrame(tenHam, thamSo);
                    callStack.Push(frame);
                    Console.WriteLine($"--> Da goi {frame}");
                }
                else if (chon == "2")
                {
                    if (callStack.Count > 0)
                    {
                        var finished = callStack.Pop();
                        Console.WriteLine($"<-- Da tra ve / ket thuc {finished}");
                    }
                    else
                    {
                        Console.WriteLine("Call Stack dang rong!");
                    }
                }
                else if (chon == "3")
                {
                    Console.WriteLine("Call Stack (tu dinh xuong day):");
                    foreach (var f in callStack)
                        Console.WriteLine("  " + f);
                }
                else if (chon == "0")
                {
                    break;
                }
            }
        }
    }
}