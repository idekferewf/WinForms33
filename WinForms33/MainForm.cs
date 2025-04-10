using System;
using System.Collections.Generic;
using System.Linq;
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

                    // добавляем данные в таблицу
                    SetCsvGridView(csvData);

                    // скрываем ошибки
                    errorsPanel.Visible = false;

                    // выводим сообщение об успехе
                    MessageBox.Show("Данные успешно загружены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // отключаем возможность конвертации
                    if (csvData == null)
                    {
                        convertToHtmlToolStripMenuItem.Enabled = false;
                    }

                    // выводим сообщение об ошибке
                    errorsPanel.Visible = true;
                    errorsTextBox.Text = errors;
                }
            }
        }

        private void SetCsvGridView(List<List<string>> csvData)
        {
            // очищаем таблицу
            csvGridView.Columns.Clear();
            csvGridView.Rows.Clear();
            
            // устанавливаем количество столбцов
            csvGridView.ColumnCount = csvData[0].Count;

            // устанавливаем заголовки столбцов
            for (int i = 0; i < csvData[0].Count; i++)
            {
                csvGridView.Columns[i].Name = csvData[0][i];
            }

            // добавляем строки данных (начиная со второй строки)
            for (int i = 1; i < csvData.Count; i++)
            {
                csvGridView.Rows.Add(csvData[i].ToArray());
            }

            // расширяем последний столбец
            csvGridView.Columns[csvGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private List<List<string>> GetCsvGridView()
        {
            List<List<string>> result = new List<List<string>>();

            // добавляем заголовки
            List<string> headers = new List<string>();
            for (int i = 0; i < csvGridView.Columns.Count; i++)
            {
                headers.Add(csvGridView.Columns[i].Name);
            }
            result.Add(headers);

            // добавляем строки
            foreach (DataGridViewRow r in csvGridView.Rows)
            {
                List<string> row = new List<string>();
                foreach (DataGridViewCell cell in r.Cells)
                {
                    if (cell.Value != null)
                    {
                        row.Add(cell.Value.ToString().Trim());
                    }
                }
                if (row.Count != 0)
                {
                    result.Add(row);
                }
            }
            
            return result;
        }

        private void convertToHtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // получаем данные из таблицы
            List<List<string>> resultData = GetCsvGridView();

            // сохраняем данные
            CsvToHtml csv = new CsvToHtml(resultData);
            if (saveHtmlFileDialog.ShowDialog() == DialogResult.OK)
            {
                // получаем путь до сохранения
                string filePath = saveHtmlFileDialog.FileName;

                // сохраняем файл
                string themeName = GetThemeName();
                string fontName = GetFontName();
                string errors = csv.SaveToHtml(filePath, fontName, themeName);

                if (string.IsNullOrWhiteSpace(errors))
                {
                    // выводим сообщение об успехе
                    MessageBox.Show($"Файл успешно сохранен! Путь до файла: {filePath}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorsPanel.Visible = true;
                    errorsTextBox.Text = errors;
                }
            }
        }

        private void hideErrorsButton_Click(object sender, EventArgs e)
        {
            errorsPanel.Visible = false;
        }

        private string GetThemeName()
        {
            return themeGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
        }

        private string GetFontName()
        {
            return fontGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
        }
    }
}
