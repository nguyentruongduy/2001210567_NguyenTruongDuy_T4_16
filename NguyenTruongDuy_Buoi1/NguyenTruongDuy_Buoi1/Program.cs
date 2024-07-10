using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NguyenTruongDuy_Buoi1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int[] arr = new int[] { 1, 2, 4, 5, 6, 7 };
            for (int i = 0; i < arr.Length; i++)
            {
                a = a + arr[i];
            }
            Console.Write("Tổng mảng la :" + a);
            Console.ReadKey();
        }

       
            
       
    }
}
