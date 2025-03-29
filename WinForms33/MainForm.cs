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
                string errors = csvLoader.LoadFromCsv(filePath);
               
                if (string.IsNullOrWhiteSpace(errors))
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
                    errorsPanel.Visible = true;
                    errorsTextBox.Text = errors;
                }
            }
        }

        private void convertToHtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // сохраняем данные
            CsvToHtml csv = new CsvToHtml(csvData);
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
                    errorsPanel.Visible = true;
                    errorsTextBox.Text = "Сохранить данные не удалось.";
                }
            }
        }

        private void hideErrorsButton_Click(object sender, EventArgs e)
        {
            errorsPanel.Visible = false;
        }
    }
}
