using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using MyLib;

namespace Testing
{
    [TestClass]
    public class TCsvToHtml
    {
        [TestMethod]
        public void TSaveToHtml()
        {
            // init
            string outputPath = "data.html";
            List<List<string>> data = new List<List<string>>()
            {
                new List<string>() { "Имя", "Возраст" },
                new List<string>() { "Артём", "18" },
                new List<string>() { "Григорий", "17" },
                new List<string>() { "Кирилл", "15" },
            };

            CsvToHtml csv = new CsvToHtml(data);
            string errors = csv.SaveToHtml(outputPath, "Arial", "Тёмная");

            // assert (is saved)
            Assert.IsTrue(string.IsNullOrWhiteSpace(errors));

            // actual
            string actual = File.ReadAllText(outputPath, Encoding.UTF8);

            // expected
            string expected = "<html><head>" +
                "<title>CSVData</title>" +
                "<meta name='viewport' content='width=device-width, initial-scale=1.0'/><style>body,table{color:#e0e0e0}*{margin:0;padding:0}body{background-color:#121212;margin:25px}.table-wrapper{border-radius:8px;display:block;border-radius:8px;overflow-x:auto;box-shadow:0 4px 8px rgba(0,0,0,.2)}table{width:100%;border-collapse:collapse;}thead{background-color:#333;border-bottom:1px solid #555}th{padding:14px 16px;text-align:left;font-weight:500;letter-spacing:.5px;text-transform:uppercase}tbody{background-color:#222}td{padding:12px 16px;border-bottom:1px solid #444}tbody tr:nth-child(2n){background-color:#282828}tbody tr:hover{background-color:#3a3a3a;transition:background-color .2s}tbody tr:first-child td{border-top:1px solid #444}tbody tr:last-child td{border-bottom:none}th:hover{background-color:#444;cursor:pointer}@media(max-width:768px){body{margin:20px}}@media(max-width:480px){body{margin:15px}}</style></head>" +
                "<body><div class='table-wrapper'><table style='font-family:Arial'><thead>" +
                "<tr><th>Имя</th><th>Возраст</th></tr>" +
                "</thead><tbody>" +
                "<tr><td>Артём</td><td>18</td></tr>" +
                "<tr><td>Григорий</td><td>17</td></tr>" +
                "<tr><td>Кирилл</td><td>15</td></tr>" +
                "</tbody></table></div></body></html>";

            // assert (html)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("..\\invalid\\")]
        [DataRow("C:\\Windows\\System32\\data.html")]
        public void TSaveToHtmlWithInvalidPath(string outputPath)
        {
            // init
            List<List<string>> data = new List<List<string>>()
            {
                new List<string>() { "Имя", "Возраст" },
                new List<string>() { "Артём", "18" },
            };

            CsvToHtml csv = new CsvToHtml(data);
            string errors = csv.SaveToHtml(outputPath, "Arial", "Без темы");

            // assert
            Assert.IsFalse(string.IsNullOrWhiteSpace(errors));
            Assert.IsFalse(File.Exists(outputPath));
        }

        [TestMethod]
        public void TSaveToHtmlWithInvalidData()
        {
            // init
            string outputPath = "invalid.html";
            List<List<string>> emptyData = new List<List<string>>();
            List<List<string>> nullData = null;

            CsvToHtml csvEmpty = new CsvToHtml(emptyData);
            CsvToHtml csvNull = new CsvToHtml(nullData);

            // assert
            Assert.IsFalse(string.IsNullOrWhiteSpace(csvEmpty.SaveToHtml(outputPath, "Arial", "Без темы")));
            Assert.IsFalse(string.IsNullOrWhiteSpace(csvNull.SaveToHtml(outputPath, "Arial", "Без темы")));
            Assert.IsFalse(File.Exists(outputPath));
        }
    }
}
