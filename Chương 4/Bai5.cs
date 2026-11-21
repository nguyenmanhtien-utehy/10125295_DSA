using System;

namespace Chương4
{
    public class Node5
    {
        public int Data;
        public Node5 Next;
        public Node5(int d) { Data = d; Next = null; }
    }

    public class Bai5
    {
        static bool LaNT(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }

        public static void Run()
        {
            Node5 head = null;
            void Them(int v)
            {
                Node5 m = new Node5(v);
                if (head == null) { head = m; return; }
                Node5 p = head;
                while (p.Next != null) p = p.Next;
                p.Next = m;
            }

            foreach (int v in new[] { -2, 0, 3, 5, 8, 5, 11 }) Them(v);

            int maxVal = int.MinValue, demNT = 0, am = 0, khong = 0, duong = 0, demX = 0, minDuong = int.MaxValue, x = 5;
            long tong = 0;

            for (Node5 p = head; p != null; p = p.Next)
            {
                int val = p.Data;
                if (val > maxVal) maxVal = val;
                tong += val;
                if (LaNT(val)) demNT++;
                if (val < 0) am++; else if (val == 0) khong++; else duong++;
                if (val == x) demX++;
                if (val > 0 && val < minDuong) minDuong = val;
            }

            Console.WriteLine($"a. Lon nhat: {maxVal}");
            Console.WriteLine($"b. Tong: {tong}");
            Console.WriteLine($"c. So nguyen to: {demNT}");
            Console.WriteLine($"d. Am: {am}, Bang 0: {khong}, Duong: {duong}");
            Console.WriteLine($"e. Bang {x}: {demX}");
            Console.WriteLine($"f. Duong nho nhat: {(minDuong == int.MaxValue ? -1 : minDuong)}");
        }
    }
}