using System;
using System.Collections.Generic;

namespace Chuong5
{
    public class DataPacket
    {
        public int Id { get; set; }
        public string Payload { get; set; }
        public bool IsCorrupted { get; set; }

        public DataPacket(int id, string payload, bool isCorrupted = false)
        {
            Id = id;
            Payload = payload;
            IsCorrupted = isCorrupted;
        }

        public override string ToString() =>
            $"[Packet #{Id}] \"{Payload}\" {(IsCorrupted ? "(LOI DUONG TRUYEN)" : "(OK)")}";
    }

    public class Bai5
    {
        public static void Run()
        {
            Queue<DataPacket> networkQueue = new Queue<DataPacket>();
            Random rng = new Random();
            int nextId = 1;

            while (true)
            {
                Console.WriteLine("\n1. Gui goi tin (Enqueue) | 2. Nhan/Xu ly 1 goi tin (Dequeue) | 3. Xem hang doi | 0. Thoat");
                Console.Write("Chon: ");
                string chon = Console.ReadLine();

                if (chon == "1")
                {
                    Console.Write("Nhap noi dung goi tin: ");
                    string data = Console.ReadLine() ?? "";
                    bool loi = rng.Next(100) < 20; // 20% xac suat loi duong truyen mo phong
                    var packet = new DataPacket(nextId++, data, loi);
                    networkQueue.Enqueue(packet);
                    Console.WriteLine("Da dua vao duong truyen: " + packet);
                }
                else if (chon == "2")
                {
                    if (networkQueue.Count > 0)
                    {
                        var pkt = networkQueue.Dequeue();
                        Console.WriteLine(pkt.IsCorrupted
                            ? $"Canh bao: Goi tin #{pkt.Id} bi loi, yeu cau gui lai!"
                            : $"Da nhan thanh cong: {pkt}");
                    }
                    else
                    {
                        Console.WriteLine("Duong truyen dang trong.");
                    }
                }
                else if (chon == "3")
                {
                    Console.WriteLine($"Goi tin dang cho ({networkQueue.Count}):");
                    foreach (var p in networkQueue)
                        Console.WriteLine("  " + p);
                }
                else if (chon == "0")
                {
                    break;
                }
            }
        }
    }
}