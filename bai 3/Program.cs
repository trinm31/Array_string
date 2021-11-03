using System;

namespace bai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So phan tư trong mang la: ");
            var spt = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[spt];
            
            Console.WriteLine($"Nhap {spt} vao mang");
            for (int i = 0; i < spt; i++)
            {
                Console.Write($"Phan tu {i} - ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            // in tất cả phần tử đã nhập ra
            Console.WriteLine("Du lieu trong mang là");
            foreach (var x in arr1)
            {
                Console.Write(x + " ");
            }
            
            Console.WriteLine("\nNhap vao phan tu can xoa:");
            var xoa_element = Convert.ToInt32(Console.ReadLine()); 
            
            int xoalocation = Array.IndexOf(arr1,xoa_element);

            arr1[xoalocation] = 0;
            
            Console.WriteLine("Du lieu sau khi xoa");
            foreach (var x in arr1)
            {
                Console.Write(x + " ");
            }
        }
    }
}