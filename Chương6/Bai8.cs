using System;

namespace Chuong6
{
    public class Bai8
    {
        static void DuyetTruoc_NLR(TreeNode node)
        {
            if (node == null) return;
            Console.Write(node.Value + " ");
            DuyetTruoc_NLR(node.Left);
            DuyetTruoc_NLR(node.Right);
        }

        static void DuyetGiua_LNR(TreeNode node)
        {
            if (node == null) return;
            DuyetGiua_LNR(node.Left);
            Console.Write(node.Value + " ");
            DuyetGiua_LNR(node.Right);
        }

        static void DuyetSau_LRN(TreeNode node)
        {
            if (node == null) return;
            DuyetSau_LRN(node.Left);
            DuyetSau_LRN(node.Right);
            Console.Write(node.Value + " ");
        }

        public static void Run()
        {
            TreeNode root = CayMau.TaoCay();

            Console.Write("Bai 8a - Tien thu tu (NLR): ");
            DuyetTruoc_NLR(root);
            Console.WriteLine();

            Console.Write("Bai 8b - Trung thu tu (LNR): ");
            DuyetGiua_LNR(root);
            Console.WriteLine();

            Console.Write("Bai 8c - Hau thu tu (LRN): ");
            DuyetSau_LRN(root);
            Console.WriteLine();
        }
    }
}