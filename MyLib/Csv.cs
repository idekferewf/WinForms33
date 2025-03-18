using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyLib
{
    public class Csv
    {
        List<List<string>> data_ { get; set; }

        public Csv(List<List<string>> data)
        {
            data_ = data;
        }

        public bool SaveToHtml(string outputPath)
        {
            // проверяем на существование данных
            if (data_ == null || data_.Count == 0)
            {
                return false;
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
            html += "</tbody>";
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
                return false;
            }
            return true;
        }
    }
}
