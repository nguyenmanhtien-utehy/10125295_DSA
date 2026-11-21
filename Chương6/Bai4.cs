using System;

namespace Chuong6
{
    public class Bai4
    {
        static void HienThiChan(TreeNode node)
        {
            if (node == null) return;
            if (node.Value % 2 == 0)
                Console.Write(node.Value + " ");
            HienThiChan(node.Left);
            HienThiChan(node.Right);
        }

        public static void Run()
        {
            TreeNode root = CayMau.TaoCay();
            Console.Write("Bai 4 - Cac nut co gia tri chan: ");
            HienThiChan(root);
            Console.WriteLine();
        }
    }
}