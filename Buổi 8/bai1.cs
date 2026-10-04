using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buổi_8
{
    internal class bai1
    {
        //Tạo một mảng răng cưa (jagged array) và khởi tạo nó với các giá trị cụ thể cho các hàng và cột; sau đó, hiển thị mảng này.
        static void JaggedArray()
        {
            int[][] a = new int[4][];

            a[0] = new int[] { 1, 1, 1, 1, 1 };
            a[1] = new int[] { 2, 2 };
            a[2] = new int[] { 3, 3, 3, 3 };
            a[3] = new int[] { 4, 4 };

            Console.WriteLine("Mảng răng cưa:");

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }

                Console.WriteLine();
            }
        }

        static void Main1(string[] args)
        {
            JaggedArray();
        }
    }
}
