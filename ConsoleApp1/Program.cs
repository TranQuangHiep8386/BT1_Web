using System;
using System.Text;
using TuViLib;

namespace TuViConsole
{
    class Program
    {
        static void Main()
        {
            // Đặt encoding UTF-8 cho console
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("Họ tên: ");
            string name = Console.ReadLine();

            Console.Write("Ngày sinh (dd/MM/yyyy): ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Giới tính (Nam/Nữ/Khác): ");
            string gender = Console.ReadLine();

            string report = TuViCalculator.GetReport(name, dob, gender);
            Console.WriteLine("\n==== TỬ VI ====");
            Console.WriteLine(report);

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
