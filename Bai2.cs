using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chương4
{
    public struct NhanVien
    {
        public string MaNV;
        public string HoTen;
        public int NamSinh;
        public string PhongBan;
        public int LuongCB;
        public int Thuong;

        public int ThucLinh()
        {
            return LuongCB + Thuong;
        }

        public void HienThi(bool tangLuong5PhanTram = false)
        {
            double luongHienTai = tangLuong5PhanTram ? LuongCB * 1.05 : LuongCB;
            Console.WriteLine($"Ma: {MaNV} | Ten: {HoTen} | NS: {NamSinh} | Phong: {PhongBan} | Luong CB: {luongHienTai:0} | Thuong: {Thuong}");
        }
    }

    public class Bai2
    {
        public static void Run()
        {
            NhanVien[] ds =
            {
                new NhanVien { MaNV = "NV01", HoTen = "Nguyen Van An", NamSinh = 1998, PhongBan = "IT", LuongCB = 10000000, Thuong = 1500000 },
                new NhanVien { MaNV = "NV03", HoTen = "Tran Thi Binh", NamSinh = 1996, PhongBan = "HR", LuongCB = 8000000, Thuong = 1200000 },
                new NhanVien { MaNV = "NV02", HoTen = "Le Van Cuong", NamSinh = 2000, PhongBan = "IT", LuongCB = 8000000, Thuong = 900000 }
            };

            // a. Tong thuc linh thang
            long tongThucLinh = 0;
            foreach (var nv in ds)
                tongThucLinh += nv.ThucLinh();
            Console.WriteLine($"a. Tong thuc linh: {tongThucLinh}");

            // b. Nhan vien co luong co ban thap nhat
            int minLuongCB = ds[0].LuongCB;
            foreach (var nv in ds)
                if (nv.LuongCB < minLuongCB) minLuongCB = nv.LuongCB;

            Console.WriteLine("b. Nhan vien co luong co ban thap nhat:");
            foreach (var nv in ds)
                if (nv.LuongCB == minLuongCB) nv.HienThi();

            // c. Dem so nhan vien co thuong >= 1200000
            int demThuongCao = 0;
            foreach (var nv in ds)
                if (nv.Thuong >= 1200000) demThuongCao++;
            Console.WriteLine($"c. So nhan vien co thuong >= 1.200.000: {demThuongCao}");

            // d. Sap xep tang dan theo phong ban, neu trung thi giam dan theo ma NV
            for (int i = 0; i < ds.Length - 1; i++)
            {
                for (int j = i + 1; j < ds.Length; j++)
                {
                    int soSanhPhong = string.Compare(ds[i].PhongBan, ds[j].PhongBan, StringComparison.OrdinalIgnoreCase);
                    bool canDoi = soSanhPhong > 0 ||
                                  (soSanhPhong == 0 && string.Compare(ds[i].MaNV, ds[j].MaNV, StringComparison.OrdinalIgnoreCase) < 0);

                    if (canDoi)
                    {
                        NhanVien tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
            }

            Console.WriteLine("d. Danh sach sau khi sap xep:");
            foreach (var nv in ds) nv.HienThi();

            // e. Hien thi thong tin va luong tang them 5%
            Console.WriteLine("e. Danh sach voi muc luong co ban tang 5%:");
            foreach (var nv in ds) nv.HienThi(tangLuong5PhanTram: true);
        }
    }
}