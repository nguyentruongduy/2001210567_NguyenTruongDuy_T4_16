using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NhanHaiSoNguyenLon
{
    class Program
    {
        static void Main()
        {
            // Khai báo hai số nguyên lớn
            BigInteger num1 = BigInteger.Parse("123456789012345678901234567890");

            BigInteger num2 = BigInteger.Parse("987654321098765432109876543210");

            // Nhân hai số nguyên lớn
            BigInteger result = num1 * num2;

            // In kết quả
            Console.WriteLine("Kết quả của phép nhân là: " + result);
            Console.ReadKey();
        }
    }
}
