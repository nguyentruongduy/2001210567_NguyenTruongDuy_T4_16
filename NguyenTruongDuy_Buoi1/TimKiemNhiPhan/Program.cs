using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiemNhiPhan
{

    class Program
    {
        static void Main()
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int x = 10;
            int result = BinarySearch(arr, x);

            if (result == -1)
                Console.WriteLine("Phần tử không có trong mảng");
            else
                Console.WriteLine("Phần tử có mặt tại chỉ số: " + result);
            Console.ReadKey();
        }

        // Hàm tìm kiếm nhị phân
        static int BinarySearch(int[] arr, int x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                // Kiểm tra nếu x là phần tử giữa
                if (arr[m] == x)
                    return m;

                // Nếu x lớn hơn, bỏ qua nửa bên trái
                if (arr[m] < x)
                    l = m + 1;

                // Nếu x nhỏ hơn, bỏ qua nửa bên phải
                else
                    r = m - 1;
            }

            // Nếu không tìm thấy
            return -1;
        }
    }
}
