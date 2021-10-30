using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Array_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // String 
            
            // 1. Chuỗi kí tự
                // string Example = "Xin Chao";  // xin chao
                // Example += " Cac ban"; // xin chao cac ban
                // Example = Example + "!"; // xin chao cac ban!

                //Console.WriteLine(Example);
                // char a = Example[2];
                // Console.WriteLine(a);
                
            // 2. Chuỗi nguyên bản với @
            
                // C:\ABC\XYZ
                // string s = "C:\\ABC\\XYZ";
                // Console.WriteLine(s);

                // string s = @"ký tự \ được dùng để chèn ký kí tự đặc biệt\n";
                // Console.WriteLine(s);
                
                // Anh ay noi, "Hello em"

                // string s = "Anh ay noi, \"Hello em\"";
                // Console.WriteLine(s);
                //
                // string s = "fsdafasdfdasf" +
                //            "Fasfdsafdsf";
                //
                // string s2 = @"xin chao các ban
                //                 du là lady killer";
                //
                // Console.WriteLine(s2);
            // 3. Chèn them biểu thức vào chuỗi với dấu $

                // int a = 10;
                // string s = $"fdasfdsf {a}";
                // Console.WriteLine(s);
                
                // Console.WriteLine($"{"VongLap",10} {"Chẵn/lẽ",-5}");
                //
                // for (int i = 8; i < 15; i++)
                // {
                //     string chanle = (i % 2) == 0 ? "Chan" : "le";
                //     Console.WriteLine($"{i,10} {chanle, -5}");
                // }
                
            // 4. Một số phương thức với string
                
                // string a = "Xin Chao";
                // string b = " Cac bạn";
                // concat
                
                // string s = String.Concat(a, b);
                // Console.WriteLine(s);
                
                // String.Format(string, arg0, arg1,...)

                // string s = String.Format("Chao {0}, {0} ơi, hom nay là ngày {1}", "Tuan", DateTime.Today);
                // Console.WriteLine(s);

                //Console.WriteLine(a.IndexOf('o'));
                //Console.WriteLine(a.LastIndexOf('o'));

                //string s1 = "Abc";
                //string s2 = s1.PadLeft(6,'g');
                //Console.WriteLine(s2);

                //var s = a.Replace("Chao", "Chao Thu");
                //Console.WriteLine(s);


                // var s = "Nguyen Minh Tri".Split(' ');
                // var s2 = s[0];
                // var s3 = s[1];
                // var s4 = s[2];


                // var s = "   DASdfs   ";
                // var s2 = s.Trim();
                // Console.WriteLine(s);

                // " a" "a"


                // var g = a.Substring(3);
                // var h = a.Substring(1, 2);
                // Console.WriteLine(h);

                // 5. StringBuilder

                // StringBuilder stringBuilder = new StringBuilder();
                // stringBuilder.Append("Xin chao may dua");
                // stringBuilder.Replace("Xin chao", "XIN CHAO");
                // stringBuilder.Remove(3, 5);
                // Console.WriteLine(stringBuilder);
                
                // 6. Sử dụng biểu thức chính quy

                    // string text = @"Đây là địa chỉ
                    //     email userabcguest@net.vn và
                    //     xyz@gmail.com cần trích xuất";
                    //
                    // string pattern = @"(([^\s.]+)@((.[^\s]+)(\..[^\s]+)))";
                    //
                    // Regex rx = new Regex(pattern);
                    //
                    // //tim kiem
                    //
                    // MatchCollection match = rx.Matches(text);
                    //
                    // // In ra thong bao sau khi tim ra
                    //
                    // Console.WriteLine($"Tim thay {match.Count} email trong \n {text}");
                    //
                    // foreach (Match email in match)
                    // {
                    //     GroupCollection groups = email.Groups;
                    //     Console.WriteLine($"{groups[0].Value}");
                    // }

                // ------------- Mang (Array) ------------------
                // 1. Khai bao mang
                    // int[] mangint;
                    // string[] mangString;
                    // double[] mangDouble;
                // 2. Khoi tao mang
                    //cach 1
                    // int[] mang;
                    // mang = new int[5];
                    //
                    // string[] StudentName = new string[5];
                    //
                    // double[] mangDouble = new double[10];

                    //string[] productName = new string[3] { "Iphone", "SamSung", "Nokia" };
                    //string[] productName = new string[] { "Iphone", "SamSung", "Nokia" };
                    //string[] productName = { "Iphone", "SamSung", "Nokia" };

                // 3. Truy cap cac phan tu mang
                    // int[] myArray = { 1, 3, 5, 19 };
                    // myArray[3] = 100;
                    // int a = myArray[3];
                    // Console.WriteLine(a);
                    
                // 4. Thuoc tinh vs phuong thuc doi voi mang
                    //int[] myArray = { 1, 5, 19, 7 };
                    // Console.WriteLine(myArray.Length);
                    // Console.WriteLine(myArray.Max());
                    // Console.WriteLine(myArray.Min());
                    // Console.WriteLine(myArray.Sum());

                    // Array.Sort(myArray);
                    // foreach (var element in myArray)
                    // {
                    //     Console.WriteLine(element);
                    // }
                    
                // 5. Duyet qua cac phan tu mang
                    //int[] myArray = { 1, 5, 19, 7 };
                    
                    // for (int i = 0; i < myArray.Length; i++)
                    // {
                    //     Console.WriteLine(myArray[i]);
                    // }

                    // int sum = 0;
                    // foreach (var element in myArray)
                    // {
                    //     sum += element;
                    // }
                    // Console.WriteLine(sum);
                // 6. Mang nhieu chieu

                int[,] mang = new int[3, 4] { { 1, 2, 3, 4 }, { 0, 3, 1, 3 }, { 4, 2, 3, 4 } };

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(mang[i,j] + " ");
                    }
                    Console.WriteLine();
                }
                
                

        }
    }
}