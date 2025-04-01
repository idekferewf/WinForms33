using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyLib
{
    public class CsvToHtml
    {
        private List<List<string>> data_;

        public CsvToHtml(List<List<string>> data)
        {
            data_ = data;
        }

        public string SaveToHtml(string outputPath)
        {
            // проверяем на существование данных
            if (data_ == null || data_.Count < 2)
            {
                return "Данные отсутствуют.";
            }

            // начало html
            string html = "<!DOCTYPE html><html><head><title>CSVData</title></head><body><table>";

            // добавляем заголовки
            html += "<thead><tr>";
            foreach (string header in data_[0])
            {
                html += $"<th>{header}</th>";
            }
            html += "</tr></thead>";

            // добавляем данные
            html += "<tbody>";
            for (int i = 1; i < data_.Count; i++)
            {
                html += "<tr>";
                foreach (string cell in data_[i])
                {
                    html += $"<td>{cell}</td>";
                }
                html += "</tr>";
            }
            html += "</tbody>";

            // конец html
            html += "</table></tbody></html>";

            // сохраняем файл
            try
            {
                File.WriteAllText(outputPath, html, Encoding.UTF8);
            } catch
            {
                return "Сохранить не удалось. Пожалуйста, проверьте наличие выходного файла или права на сохранение в указанную папку.";
            }

            return "";
        }
    }
}
