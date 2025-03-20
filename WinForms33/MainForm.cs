using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MyLib;

namespace WinForms33
{
    public partial class MainForm: Form
    {
        public List<List<string>> csvData;

        public MainForm()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // вызывает диалог
            if (openCsvFileDialog.ShowDialog() == DialogResult.OK)
            {
                // получаем путь к файлу
                string filePath = openCsvFileDialog.FileName;

                // получаем данные
                CsvLoader csvLoader = new CsvLoader();
                bool isLoaded = csvLoader.LoadFromCsv(filePath);
               
                if (isLoaded)
                {
                    // сохраняем результат
                    csvData = csvLoader.csvData;
                    convertToHtmlToolStripMenuItem.Enabled = true;

                    // выводим сообщение об успехе
                    MessageBox.Show("Данные успешно загружены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // сбрасываем данные
                    csvData = null;
                    convertToHtmlToolStripMenuItem.Enabled = false;

                    // выводим сообщение об ошибке
                    MessageBox.Show("Загрузить данные не удалось.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void convertToHtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // сохраняем данные
            Csv csv = new Csv(csvData);
            if (saveHtmlFileDialog.ShowDialog() == DialogResult.OK)
            {
                // получаем путь до сохранения
                string filePath = saveHtmlFileDialog.FileName;

                // сохраняем файл
                bool isSaved = csv.SaveToHtml(filePath);

                if (isSaved)
                {
                    // выводим сообщение об успехе
                    MessageBox.Show($"Файл успешно сохранен! Путь до файла: {filePath}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Сохранить данные не удалось.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
