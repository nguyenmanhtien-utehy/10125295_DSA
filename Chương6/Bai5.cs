using System;

namespace Chuong6
{
    public class Bai5
    {
        static int DemChan(TreeNode node)
        {
            if (node == null) return 0;
            int dem = (node.Value % 2 == 0) ? 1 : 0;
            return dem + DemChan(node.Left) + DemChan(node.Right);
        }

        public static void Run()
        {
            TreeNode root = CayMau.TaoCay();
            Console.WriteLine($"Bai 5 - So nut co gia tri chan: {DemChan(root)}");
        }
    }
}