using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buổi_8
{
    internal class bai3
    {
        // 1. Khởi tạo mảng với các giá trị được gán sẵn hoặc giá trị nhập từ bàn phím.
        static void KhoiTao(string[][,] nhom)
        {
            // Nhóm 1: 5 thành viên, 3 thông tin
            nhom[0] = new string[5, 3]
            {
                { "101", "Nguyen Van An", "15" },
                { "102", "Tran Thi Binh", "20" },
                { "103", "Le Van Cuong", "12" },
                { "104", "Pham Thi Dung", "25" },
                { "105", "Hoang Van Em", "18" }
            };

            // Nhóm 2: 3 thành viên
            nhom[1] = new string[3, 3]
            {
                { "106", "Nguyen Van Phuc", "30" },
                { "107", "Tran Van Giang", "22" },
                { "108", "Le Thi Hoa", "17" }
            };

            // Nhóm 3: 6 thành viên
            nhom[2] = new string[6, 3]
            {
                { "109", "Pham Van Hai", "19" },
                { "110", "Nguyen Thi Lan", "28" },
                { "111", "Tran Van Minh", "14" },
                { "112", "Le Thi Nga", "35" },
                { "113", "Hoang Van Son", "21" },
                { "114", "Pham Thi Thuy", "26" }
            };
        }
        // 2. In ra danh sách các thành viên của từng nhóm.
        static void InDanhSach(string[][,] members)
        {
            for (int i = 0; i < members.Length; i++)
            {
                Console.WriteLine($"\n--- Nhóm {i + 1} ---");

                for (int j = 0; j < members[i].GetLength(0); j++)
                {
                    Console.WriteLine(
                        $"ID: {members[i][j, 0]} | " +
                        $"Tên: {members[i][j, 1]} | " +
                        $"Công việc: {members[i][j, 2]}"
                    );
                }
            }
        }
        // 3. Tìm kiếm thành viên theo ID và in ra thông tin của thành viên đó.
        static void TimTheoID(string[][,] members)
        {
            Console.Write("Nhập ID cần tìm: ");
            string id = Console.ReadLine();

            for (int i = 0; i < members.Length; i++)
            {
                for (int j = 0; j < members[i].GetLength(0); j++)
                {
                    if (members[i][j, 0] == id)
                    {
                        Console.WriteLine("\nThành viên tìm thấy:");
                        Console.WriteLine($"Nhóm: {i + 1}");
                        Console.WriteLine($"ID: {members[i][j, 0]}");
                        Console.WriteLine($"Tên: {members[i][j, 1]}");
                        Console.WriteLine($"Công việc: {members[i][j, 2]}");
                        return;
                    }
                }
            }

            Console.WriteLine("Không tìm thấy!");
        }
        // 4. Tìm thành viên có số lượng công việc nhiều nhất và in ra thông tin của thành viên đó.
        static void TimMax(string[][,] members)
        {
            int max = -1;
            int nhomMax = 0;
            int dongMax = 0;

            for (int i = 0; i < members.Length; i++)
            {
                for (int j = 0; j < members[i].GetLength(0); j++)
                {
                    int congViec = int.Parse(members[i][j, 2]);

                    if (congViec > max)
                    {
                        max = congViec;
                        nhomMax = i;
                        dongMax = j;
                    }
                }
            }

            Console.WriteLine("\nThành viên nhiều công việc nhất:");
            Console.WriteLine($"Nhóm: {nhomMax + 1}");
            Console.WriteLine($"ID: {members[nhomMax][dongMax, 0]}");
            Console.WriteLine($"Tên: {members[nhomMax][dongMax, 1]}");
            Console.WriteLine($"Công việc: {members[nhomMax][dongMax, 2]}");
        }


        public static void Main(string[] args)
        {
            string[][,] nhom = new string[3][,];
            KhoiTao(nhom);
            while (true)
            {
                Console.WriteLine("\nMENU:");
                Console.WriteLine("1. In danh sách tất cả thành viên");
                Console.WriteLine("2. Tìm thành viên theo ID");
                Console.WriteLine("3. Tìm thành viên có nhiều công việc nhất");
                Console.WriteLine("0. Thoát");
                Console.WriteLine();

                Console.Write("Nhập lựa chọn: ");
                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        InDanhSach(nhom);
                        break;

                    case "2":
                        TimTheoID(nhom);
                        break;

                    case "3":
                        TimMax(nhom);
                        break;

                    case "0":
                        Console.WriteLine("Đã thoát chương trình!");
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}
