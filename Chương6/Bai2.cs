using System;

namespace Chuong6
{
    public class Bai2
    {
        static int TinhTong(TreeNode node)
        {
            if (node == null) return 0;
            return node.Value + TinhTong(node.Left) + TinhTong(node.Right);
        }

        public static void Run()
        {
            TreeNode root = CayMau.TaoCay();
            Console.WriteLine($"Bai 2 - Tong gia tri cac nut: {TinhTong(root)}");
        }
    }
}