using System;

namespace Chuong6
{
    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public static class CayMau
    {
        public static TreeNode TaoCay()
        {
            TreeNode root = new TreeNode(10);
            root.Left = new TreeNode(5);
            root.Right = new TreeNode(15);

            root.Left.Left = new TreeNode(2);
            root.Left.Right = new TreeNode(8);
            root.Left.Right.Left = new TreeNode(6);

            root.Right.Left = new TreeNode(12);
            root.Right.Right = new TreeNode(20);
            return root;
        }
    }

    public class Bai1
    {
        static int DemSoNut(TreeNode node)
        {
            if (node == null) return 0;
            return 1 + DemSoNut(node.Left) + DemSoNut(node.Right);
        }

        public static void Run()
        {
            TreeNode root = CayMau.TaoCay();
            Console.WriteLine($"Bai 1 - Tong so nut tren cay: {DemSoNut(root)}");
        }
    }
}