using System;
using System.Collections.Generic;

using Excel = Microsoft.Office.Interop.Excel;

namespace ExportDataToOfficeApp
{
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Использование COM модели";
            Console.ForegroundColor = ConsoleColor.Green;
            var carList = new List<Car>
            {
                new Car{CarColor = "Желтый", CarMark = "BMW", DriverName = "Константин"},
                new Car{CarMark = "Nissan", CarColor = "Black", DriverName = "Igor"},
                new Car{CarColor = "빨간 - красный", CarMark = "캐딜락 - Кадиллак", DriverName = "세르게이 - Сергей"}
            };

            ExportToExcel(carList);
            ExportToExcelManual(carList);
            Console.ReadLine();
        }

        private static void ExportToExcel(IEnumerable<Car> carList)
        {
            var excelApplication = new Excel.Application();
            excelApplication.Workbooks.Add();
            Excel._Worksheet worksheet = excelApplication.ActiveSheet;
            worksheet.Cells[1, "A"] = "Mark";
            worksheet.Cells[1, "B"] = "Color";
            worksheet.Cells[1, "C"] = "Driver Name";
            var row = 1;
            foreach (var car in carList)
            {
                row++;
                worksheet.Cells[row, "A"] = car.CarMark;
                worksheet.Cells[row, "B"] = car.CarColor;
                worksheet.Cells[row, "C"] = car.DriverName;
            }

            worksheet.Range["A1"].AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);
            worksheet.SaveAs($@"{Environment.CurrentDirectory}\CarFile.xlsx");
            excelApplication.Quit();
            Console.WriteLine("Файл сохранен в папку приложения");
        }

        private static void ExportToExcelManual(IEnumerable<Car> carsInStock)
        {
            var excelApp = new Excel.Application();

            // Must mark missing params! 
            excelApp.Workbooks.Add(Type.Missing);

            // Must cast Object as _Worksheet! 
            var workSheet = (Excel._Worksheet)excelApp.ActiveSheet;

            // Must cast each Object as Range object then call low level Value2 property!
            ((Excel.Range)excelApp.Cells[1, "A"]).Value2 = "Make";
            ((Excel.Range)excelApp.Cells[1, "B"]).Value2 = "Color";
            ((Excel.Range)excelApp.Cells[1, "C"]).Value2 = "Pet Name";

            var row = 1;
            foreach (var c in carsInStock)
            {
                row++;
                // Must cast each Object as Range and call low level Value2 prop!
                ((Excel.Range)workSheet.Cells[row, "A"]).Value2 = c.CarMark;
                ((Excel.Range)workSheet.Cells[row, "B"]).Value2 = c.CarColor;
                ((Excel.Range)workSheet.Cells[row, "C"]).Value2 = c.DriverName;
            }

            // Must call get_Range method and then specify all missing args!. 
            excelApp.Range["A1", Type.Missing].AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2,
                Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing);

            // Must specify all missing optional args!  
            workSheet.SaveAs($@"{Environment.CurrentDirectory}\InventoryManual.xlsx",
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing);
            excelApp.Quit();
            Console.WriteLine("The InventoryManual.xslx file has been saved to your app folder");
        }
    }
}
