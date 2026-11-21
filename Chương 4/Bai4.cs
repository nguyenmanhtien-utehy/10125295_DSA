using System;

namespace Chương4
{
    public class Node4
    {
        public int Data;
        public Node4 Next;
        public Node4(int d) { Data = d; Next = null; }
    }

    public class Bai4
    {
        public static void Run()
        {
            Node4 pHead = null;
            void ThemCuoi(int val)
            {
                Node4 m = new Node4(val);
                if (pHead == null) { pHead = m; return; }
                Node4 p = pHead;
                while (p.Next != null) p = p.Next;
                p.Next = m;
            }

            ThemCuoi(4); ThemCuoi(2); ThemCuoi(7); ThemCuoi(2); ThemCuoi(9);

            int x = 2, demX = 0, minDuong = int.MaxValue;
            for (Node4 p = pHead; p != null; p = p.Next)
            {
                if (p.Data == x) demX++;
                if (p.Data > 0 && p.Data < minDuong) minDuong = p.Data;
            }

            Console.WriteLine($"a. So luong bang {x}: {demX}");
            Console.WriteLine($"b. Duong nho nhat: {(minDuong == int.MaxValue ? -1 : minDuong)}");

            if (pHead != null)
            {
                if (pHead.Data == x) pHead = pHead.Next;
                else
                {
                    Node4 truoc = pHead, cur = pHead.Next;
                    while (cur != null)
                    {
                        if (cur.Data == x) { truoc.Next = cur.Next; break; }
                        truoc = cur;
                        cur = cur.Next;
                    }
                }
            }

            Console.Write("c. Sau khi xoa dau tien bang " + x + ": ");
            for (Node4 p = pHead; p != null; p = p.Next) Console.Write(p.Data + " -> ");
            Console.WriteLine("null");
        }
    }
}