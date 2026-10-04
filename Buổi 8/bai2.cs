using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buổi_8
{
    internal class bai2
    {
        static void XuatMang(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + "\t");
                }

                Console.WriteLine();
            }
        }
        //1. In ra số lớn nhất của mỗi hàng và số lớn nhất của toàn bộ mảng.

        static void TimMax(int[][] a)
        {
            int maxToanMang = a[0][0];

            for (int i = 0; i < a.Length; i++)
            {
                int maxDong = a[i][0];

                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] > maxDong)
                        maxDong = a[i][j];

                    if (a[i][j] > maxToanMang)
                        maxToanMang = a[i][j];
                }

                Console.WriteLine(
                    $"Số lớn nhất dòng {i + 1}: {maxDong}"
                );
            }

            Console.WriteLine(
                $"Số lớn nhất toàn mảng: {maxToanMang}"
            );
        }
        //2. Sắp xếp các phần tử trong mỗi hàng theo thứ tự tăng dần.
        static void SapXep(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Array.Sort(a[i]);
            }

            Console.WriteLine("Mảng sau khi sắp xếp:");

            XuatMang(a);
        }
        //3. In ra các số nguyên tố có trong mảng.
        static bool LaSoNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
        static void InSoNguyenTo(int[][] a)
        {
            Console.WriteLine("Các số nguyên tố:");

            bool coSoNguyenTo = false;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (LaSoNguyenTo(a[i][j]))
                    {
                        Console.Write(a[i][j] + " ");
                        coSoNguyenTo = true;
                    }
                }
            }

            if (!coSoNguyenTo)
                Console.Write("Không có số nguyên tố.");

            Console.WriteLine();
        }
        //4. Tìm và in ra các số chính phương có trong mảng.
        static void TimViTri(int[][] a)
        {
            Console.Write("Nhập số cần tìm: ");
            int x = int.Parse(Console.ReadLine());

            bool timThay = false;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] == x)
                    {
                        Console.WriteLine(
                            $"Tìm thấy {x} tại dòng {i + 1}, cột {j + 1}"
                        );

                        timThay = true;
                    }
                }
            }

            if (!timThay)
                Console.WriteLine("Không tìm thấy!");
        }


        static void Main2(string[] args)
        {
            Console.Write("Nhập số dòng: ");
            int rows = int.Parse(Console.ReadLine());

            int[][] a = new int[rows][];
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Nhập số cột của dòng {i + 1}: ");
                int cols = int.Parse(Console.ReadLine());

                a[i] = new int[cols];

                for (int j = 0; j < cols; j++)
                {
                    a[i][j] = random.Next(1, 101);
                }
            }

            Console.WriteLine("\nMảng vừa tạo:");
            XuatMang(a);
            Console.WriteLine();
            TimMax(a);
            Console.WriteLine();
            SapXep(a);
            Console.WriteLine();
            InSoNguyenTo(a);
            Console.WriteLine();
            TimViTri(a);    

        }

    }
}
