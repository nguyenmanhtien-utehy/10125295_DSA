using System;

namespace Chuong6
{
    public class Bai3
    {
        static void HienThi(TreeNode node)
        {
            if (node == null) return;
            Console.Write(node.Value + " ");
            HienThi(node.Left);
            HienThi(node.Right);
        }

        public static void Run()
        {
            TreeNode root = CayMau.TaoCay();
            Console.Write("Bai 3 - Gia tri cac nut tren cay: ");
            HienThi(root);
            Console.WriteLine();
        }
    }
}