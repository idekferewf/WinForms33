using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyLib
{
    public class CsvLoader
    {
        public List<List<string>> csvData { get; set; }

        public string LoadFromCsv(string filePath)
        {
            // считываем файл
            string[] lines;
            try
            {
                lines = File.ReadAllLines(filePath);
            } catch
            {
                return "Файл не существует.";
            }

            if (lines.Length == 0)
            {
                return "Файл пустой.";
            }

            // добавляем данные
            csvData = new List<List<string>>();
            int headerLength = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                // проверяем строку из файла
                string line = lines[i].Trim();
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                // создаём строку
                List<string> row = new List<string>();

                // добавляем каждую ячейку в строку
                foreach (string cell in line.Split(','))
                {
                    row.Add(cell.Trim());
                }

                // валидация заголовка
                if (csvData.Count == 0)
                {
                    if (row.Count == 0)
                    {
                        return "Заголовки отсутствуют.";
                    }
                    headerLength = row.Count;
                } 
                // валидация данных
                else if (row.Count != headerLength)
                {
                    return $"Данные в строке {i + 1} отсутствуют или заполнены не полностью.";
                }

                csvData.Add(row);
            }

            if (lines.Length < 2)
            {
                return "Данные отсутствуют.";
            }

            return "";
        }
    }
}
