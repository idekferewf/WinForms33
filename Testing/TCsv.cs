using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            string outputPath = "D://Андреев Алексей";
            List<List<string>> data = new List<List<string>>()
            {
                new List<string>() { "Имя", "Возраст" },
                new List<string>() { "Артём", "18" },
                new List<string>() { "Григорий", "17" },
                new List<string>() { "Кирилл", "15" },
            };

            // сохраняем в HTML-файл
            Csv csv = new Csv(data);
            bool isSaved = csv.SaveToHtml(outputPath);
        }
    }
}
