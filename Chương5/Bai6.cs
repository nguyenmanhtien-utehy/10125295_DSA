using System;
using System.Collections.Generic;

namespace Chuong5
{
    public class KhachHang
    {
        public int SoThuTu { get; set; }
        public string HoTen { get; set; }
        public string LoaiDichVu { get; set; }
        public DateTime ThoiGianDen { get; set; }

        public override string ToString() =>
            $"STT {SoThuTu:00} | {HoTen} | Dich vu: {LoaiDichVu} | Den luc: {ThoiGianDen:HH:mm:ss}";
    }

    public class Bai6
    {
        public static void Run()
        {
            Queue<KhachHang> hangDoi = new Queue<KhachHang>();
            int stt = 1;

            while (true)
            {
                Console.WriteLine("\n1. Khach lay so vao hang doi (Enqueue) | 2. Goi khach tiep theo (Dequeue) | 3. Xem hang doi | 0. Thoat");
                Console.Write("Chon: ");
                string chon = Console.ReadLine();

                if (chon == "1")
                {
                    Console.Write("Ho ten khach: ");
                    string ten = Console.ReadLine();
                    Console.Write("Loai dich vu (Rut tien / Mo tai khoan / Tu van...): ");
                    string dv = Console.ReadLine();

                    var kh = new KhachHang
                    {
                        SoThuTu = stt++,
                        HoTen = string.IsNullOrWhiteSpace(ten) ? "Khach le" : ten.Trim(),
                        LoaiDichVu = string.IsNullOrWhiteSpace(dv) ? "Tong quat" : dv.Trim(),
                        ThoiGianDen = DateTime.Now
                    };

                    hangDoi.Enqueue(kh);
                    Console.WriteLine("Da them vao hang doi: " + kh);
                }
                else if (chon == "2")
                {
                    if (hangDoi.Count > 0)
                    {
                        var khPhucVu = hangDoi.Dequeue();
                        Console.WriteLine("Dang phuc vu: " + khPhucVu);
                    }
                    else
                    {
                        Console.WriteLine("Hien khong co khach cho.");
                    }
                }
                else if (chon == "3")
                {
                    Console.WriteLine($"Danh sach cho ({hangDoi.Count} khach):");
                    foreach (var kh in hangDoi)
                        Console.WriteLine("  " + kh);
                }
                else if (chon == "0")
                {
                    break;
                }
            }
        }
    }
}