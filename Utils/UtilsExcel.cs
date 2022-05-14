using dog_facts_bus.Model;
using IronXL;
using System.IO;
using System.Linq;

namespace dog_facts_bus.Utils
{
    public static class UtilsExcel
    {
        private static int numberOfSheets = 0;
        private static string outputFileName = "OutputDogFacts.xlsx";
        public static string outputPath { get; set; }
        public static string[] ReadExcel(string inputPath)
        {
            WorkBook workbook = WorkBook.Load(inputPath);
            WorkSheet sheet = workbook.WorkSheets.First();
            string[] cellValues = new string[sheet.Columns[0].Count()];
            int count = 0;
            foreach (var cell in sheet.Columns[0])
            {
                cellValues[count] = cell.Value.ToString();
                count++;
            }
            return cellValues;
        }

        public static void CreateExcel(DogFacts dogFacts)
        {
            numberOfSheets++;
            string sheetName = "Line " + numberOfSheets;
            WorkBook workbook = GetOrCreateWorkbook();
            var sheet = GetOrCreateWorkSheet(workbook.WorkSheets, sheetName, workbook);
            int count = 0;
            foreach (var fact in dogFacts.facts)
            {
                sheet.SetCellValue(count, 0, fact);
                count++;
            }
            workbook.SaveAs(outputPath + outputFileName);
        }

        private static WorkBook GetOrCreateWorkbook()
        {
            if (File.Exists(outputPath + outputFileName) == false)
            {
                return WorkBook.Create(ExcelFileFormat.XLSX);
            }
            else
            {
                return WorkBook.Load(outputPath + outputFileName);
            }
        }

        private static WorkSheet GetOrCreateWorkSheet(WorksheetsCollection sheets, string sheetName, WorkBook workBook)
        {
            foreach (var sheet in sheets)
            {
                if (sheet.Name == sheetName)
                {
                    return workBook.LoadWorkSheet(sheet.ToDataTable());
                }
            }
            return workBook.CreateWorkSheet(sheetName);
        }

        public static void SetOutputFileName(string fileName)
        {
            outputFileName = fileName;
            if (outputFileName.EndsWith(".xlsx") == false)
            {
                outputFileName += ".xlsx";
            }
        }
    }
}
