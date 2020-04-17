using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertStringToDateTime();
            Console.ReadLine();
        }

        private static void ConvertStringToDateTime()
        {
            //Chuyển từ string sang DateTime
            DateTime dtDateTime = DateTime.ParseExact("17/04/2020 20:48:01", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            //Hiển thị DateTime theo format dd/MM/yyyy
            Console.WriteLine(dtDateTime.ToString("dd/MM/yyyy"));

            //Kiểm tra kết quả
            Console.WriteLine(string.Format("Day: {0}", dtDateTime.Day));
            Console.WriteLine(string.Format("Month: {0}", dtDateTime.Month));
            Console.WriteLine(string.Format("Year: {0}", dtDateTime.Year));
            Console.WriteLine(string.Format("Hour: {0}", dtDateTime.Hour));
            Console.WriteLine(string.Format("Minute: {0}", dtDateTime.Minute));
            Console.WriteLine(string.Format("Second: {0}", dtDateTime.Second));
        }
    }
}
