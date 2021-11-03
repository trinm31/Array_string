using System;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So phan tư trong mang la: ");
            var spt = Convert.ToInt32(Console.ReadLine());
            spt += 1;
            int[] arr1 = new int[spt];
            
            Console.WriteLine($"Nhap {spt-1} vao mang");
            for (int i = 0; i < spt-1; i++)
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
            
            Console.WriteLine("\nNhap vao phan tu moi:");
            var new_element = Convert.ToInt32(Console.ReadLine());
            
            // xac định vị trí chèn
            int chenlocation = 0;

            for (int i = 0; i < spt-1; i++)
            {
                if (new_element < arr1[i])
                {
                    chenlocation = i;
                    break;
                }
            }
            
            // dời nhũng thằng cũ đi 1 bước

            for (int i = spt-2; i >= chenlocation; i--)
            {
                arr1[i+1] = arr1[i];
            }

            arr1[chenlocation] = new_element;

            Console.WriteLine("Du lieu trong mang sau chen là");
            foreach (var x in arr1)
            {
                Console.Write(x + " ");
            }
        }
    }
}