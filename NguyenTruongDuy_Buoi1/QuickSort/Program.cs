using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{

    class Program
    {
        static void Main()
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            QuickSort(arr, 0, n - 1);
            Console.WriteLine("Mảng sau khi sắp xếp:");
            PrintArray(arr);
            Console.ReadKey();
            
        }

        // Hàm QuickSort
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                // Đệ quy sắp xếp các phần tử trước và sau phân vùng
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        // Hàm phân vùng
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];  // Chọn phần tử chốt (pivot)
            int i = (low - 1);  // Chỉ số của phần tử nhỏ hơn

            for (int j = low; j < high; j++)
            {
                // Nếu phần tử hiện tại nhỏ hơn hoặc bằng phần tử chốt
                if (arr[j] <= pivot)
                {
                    i++;
                    // Đổi chỗ arr[i] và arr[j]
                    Swap(arr, i, j);
                }
            }

            // Đổi chỗ arr[i+1] và arr[high] (hoặc pivot)
            Swap(arr, i + 1, high);

            return i + 1;
        }

        // Hàm đổi chỗ hai phần tử
        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        // Hàm in mảng
        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }

}
