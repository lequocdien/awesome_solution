using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFileExcel();
        }

        private static void ReadFileExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage package = new ExcelPackage(new System.IO.FileInfo("test.xlsx"));
            ExcelWorksheet sheet = package.Workbook.Worksheets[0];

            string strRes = sheet.Cells[1, 1].Value.ToString();

            Console.WriteLine(strRes);
            Console.ReadLine();
        }

        private static void WriteFileExcel()
        {
            //The same Read
        }
    }
}
