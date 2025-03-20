using System.Collections.Generic;
using System.IO;

namespace MyLib
{
    public class CsvLoader
    {
        public List<List<string>> csvData { get; set; }
        
        public bool LoadFromCsv(string filePath)
        {
            // считываем файл
            string[] lines;
            try
            {
                lines = File.ReadAllLines(filePath);
            } catch
            {
                return false;
            }

            // добавляем данные
            csvData = new List<List<string>>();
            foreach (string line in lines)
            {
                // получаем ячейки строки
                string[] cells = line.Split(',');

                // создём строку
                List<string> row = new List<string>();

                // добавляем каждую ячейку в строку
                foreach (string cell in cells)
                {
                    row.Add(cell.Trim());
                }
                csvData.Add(row);
            }

            return true;
        }
    }
}
