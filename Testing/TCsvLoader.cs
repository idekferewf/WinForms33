﻿using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLib;

namespace Testing
{
	[TestClass]
	public class TCsvLoader
	{
        [TestMethod]
        public void TLoadFromCsv()
        {
            // init
            string filePath = "data.csv";
            string csvFile = "Имя,Возраст\nАртём,12\nАлексей,19\nДаниил,20\nИлья,16";
            File.WriteAllText(filePath, csvFile, Encoding.UTF8);

            CsvLoader csvLoader = new CsvLoader();
            string errors = csvLoader.LoadFromCsv(filePath);
            Assert.IsTrue(string.IsNullOrWhiteSpace(errors));

            // actual
            List<List<string>> actual = csvLoader.csvData;

            // expected
            List<List<string>> expected = new List<List<string>>()
            {
                new List<string>() { "Имя", "Возраст" },
                new List<string>() { "Артём", "12" },
                new List<string>() { "Алексей", "19" },
                new List<string>() { "Даниил", "20" },
                new List<string>() { "Илья", "16" }
            };

            // assert
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < actual.Count; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        [DataRow("Имя,Возраст\n", "Данные отсутствуют.")]
        [DataRow("", "Файл пустой.")]
        [DataRow("Имя,Возраст\nАндрей", "Данные в строке 2 отсутствуют или заполнены не полностью.")]
        public void TLoadFromCsvWithErrors(string csvFile, string expected)
        {
            // init
            string filePath = "data.csv";
            File.WriteAllText(filePath, csvFile, Encoding.UTF8);
            CsvLoader csvLoader = new CsvLoader();

            // actual
            string actual = csvLoader.LoadFromCsv(filePath);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
