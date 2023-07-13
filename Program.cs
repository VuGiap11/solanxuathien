using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xuathienphantu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = NhapMang();
            bool[] b = PhanLoai(arr);
            HienThiMang(arr);
            KetQua(arr, b);
        }

        private static void KetQua(int[] arr, bool[] b)
        {
            Console.WriteLine("ket qua:");
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (b[i])
                {
                    int dem = Dem(arr, arr[i]);
                    Console.WriteLine($"{arr[i]} xuat hien {dem} lan");
                }
            }
        }

        static int Dem(int[] arr, int x)
        {
            int Dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (x == arr[i])
                {
                    Dem++;
                }
            }
            return Dem;
        }

        private static void HienThiMang(int[] arr)
        {
            Console.WriteLine("cac phan tu trong mang: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine();
        }

        private static bool[] PhanLoai(int[] arr)
        {
            bool[] a = new bool[arr.Length];
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                bool x = true;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        x = false;
                        break;
                    }
                }
                a[i] = x;
            }
            return a;
        }

        private static int[] NhapMang()
        {
            int n = 0;
            while (n <= 0)
            {
                Console.WriteLine(" nhap so phan tu mang : " );
                n = Convert.ToInt32( Console.ReadLine() );
            }
            int[] arr = new int[n]; 
            for (int i = 1; i < n;  i++)
            {
                Console.WriteLine($" phan tu thu {i}: ");
                arr[i] = Convert.ToInt32( Console.ReadLine() );
            }
            return arr;
        }
    }
}
