﻿using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using MyLib;

namespace Testing
{
    [TestClass]
    public class TCsv
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

            Csv csv = new Csv(data);
            bool isSaved = csv.SaveToHtml(outputPath);

            // assert (is saved)
            Assert.IsTrue(isSaved);

            // actual
            string actual = File.ReadAllText(outputPath, Encoding.UTF8);

            // expected
            string expected = "<!DOCTYPE html><html><head>" +
                "<title>CSVData</title>" +
                "</head>" +
                "<body><table><thead>" +
                "<tr><th>Имя</th><th>Возраст</th></tr>" +
                "</thead><tbody>" +
                "<tr><td>Артём</td><td>18</td></tr>" +
                "<tr><td>Григорий</td><td>17</td></tr>" +
                "<tr><td>Кирилл</td><td>15</td></tr>" +
                "</tbody></table></tbody></html>";

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

            Csv csv = new Csv(data);
            bool isSaved = csv.SaveToHtml(outputPath);

            // assert
            Assert.IsFalse(isSaved);
            Assert.IsFalse(File.Exists(outputPath));
        }

        [TestMethod]
        public void TSaveToHtmlWithInvalidData()
        {
            // init
            string outputPath = "data.html";
            List<List<string>> emptyData = new List<List<string>>();
            List<List<string>> nullData = null;

            Csv csvEmpty = new Csv(emptyData);
            Csv csvNull = new Csv(nullData);

            // assert
            Assert.IsFalse(csvEmpty.SaveToHtml(outputPath));
            Assert.IsFalse(csvNull.SaveToHtml(outputPath));
            Assert.IsFalse(File.Exists(outputPath));
        }
    }
}
