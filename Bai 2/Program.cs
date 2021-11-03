using System;

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So phan tư trong mang la: ");
            var spt = Convert.ToInt32(Console.ReadLine());
            //spt += 1;
            int[] arr1 = new int[spt];
            int[] arr2 = new int[spt+1];
            
            Console.WriteLine($"Nhap {spt} vao mang");
            for (int i = 0; i < spt; i++)
            {
                Console.Write($"Phan tu {i} - ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            // sort array
            Array.Sort(arr1);
            Array.Copy(arr1, arr2, arr1.Length);
            // in tất cả phần tử đã nhập ra
            Console.WriteLine("Du lieu trong mang là");
            foreach (var x in arr2)
            {
                Console.Write(x + " ");
            }
            
            Console.WriteLine("\nNhap vao phan tu moi:");
            var new_element = Convert.ToInt32(Console.ReadLine());
            
            // xac định vị trí chèn
            int chenlocation = 0;

            for (int i = 0; i < spt; i++)
            {
                if (new_element < arr1[i])
                {
                    chenlocation = i;
                    break;
                }
            }
            
            // dời nhũng thằng cũ đi 1 bước

            for (int i = spt-1; i >= chenlocation; i--)
            {
                arr2[i+1] = arr2[i];
            }

            arr2[chenlocation] = new_element;

            Console.WriteLine("Du lieu trong mang sau chen là");
            foreach (var x in arr2)
            {
                Console.Write(x + " ");
            }
        }
    }
}