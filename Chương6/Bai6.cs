using System;

namespace Chuong6
{
    public class Bai6
    {
        // So con truc tiep (0, 1 hoac 2)
        static int DemConTrucTiep(TreeNode node)
        {
            if (node == null) return 0;
            int soCon = 0;
            if (node.Left != null) soCon++;
            if (node.Right != null) soCon++;
            return soCon;
        }

        // Tong so nut con chau (khong tinh chinh nut do)
        static int DemTatCaConChau(TreeNode node)
        {
            if (node == null) return 0;
            int trai = node.Left == null ? 0 : 1 + DemTatCaConChau(node.Left);
            int phai = node.Right == null ? 0 : 1 + DemTatCaConChau(node.Right);
            return trai + phai;
        }

        public static void Run()
        {
            TreeNode root = CayMau.TaoCay();
            Console.WriteLine($"Bai 6 - So con truc tiep cua nut goc ({root.Value}): {DemConTrucTiep(root)}");
            Console.WriteLine($"Bai 6 - Tong so con chau cua nut goc ({root.Value}): {DemTatCaConChau(root)}");
            Console.WriteLine($"Bai 6 - So con truc tiep cua nut ({root.Left.Right.Value}): {DemConTrucTiep(root.Left.Right)}");
        }
    }
}