using System;

namespace Chuong6
{
    public class Bai7
    {
        static void HienThiCayCon(TreeNode node)
        {
            if (node == null) return;
            HienThiCayCon(node.Left);
            Console.Write(node.Value + " ");
            HienThiCayCon(node.Right);
        }

        public static void Run()
        {
            TreeNode root = CayMau.TaoCay();
            Console.Write("Bai 7 - Cac nut tren cay con trai: ");
            if (root.Left == null)
                Console.WriteLine("Cay con trai rong");
            else
            {
                HienThiCayCon(root.Left);
                Console.WriteLine();
            }
        }
    }
}