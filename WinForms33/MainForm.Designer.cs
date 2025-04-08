namespace WinForms33
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToHtmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCsvFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveHtmlFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.errorsTextBox = new System.Windows.Forms.RichTextBox();
            this.errorsLabel = new System.Windows.Forms.Label();
            this.errorsPanel = new System.Windows.Forms.Panel();
            this.hideErrorsButton = new System.Windows.Forms.Button();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.csvGridView = new System.Windows.Forms.DataGridView();
            this.themeGroupBox = new System.Windows.Forms.GroupBox();
            this.lightThemeRadioButton = new System.Windows.Forms.RadioButton();
            this.darkThemeRadioButton = new System.Windows.Forms.RadioButton();
            this.mainMenuStrip.SuspendLayout();
            this.errorsPanel.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csvGridView)).BeginInit();
            this.themeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(616, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.convertToHtmlToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.loadToolStripMenuItem.Text = "Загрузить";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // convertToHtmlToolStripMenuItem
            // 
            this.convertToHtmlToolStripMenuItem.Enabled = false;
            this.convertToHtmlToolStripMenuItem.Name = "convertToHtmlToolStripMenuItem";
            this.convertToHtmlToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.convertToHtmlToolStripMenuItem.Text = "Конвертировать в HTML";
            this.convertToHtmlToolStripMenuItem.Click += new System.EventHandler(this.convertToHtmlToolStripMenuItem_Click);
            // 
            // openCsvFileDialog
            // 
            this.openCsvFileDialog.Filter = "CSV files (*.csv)|*.csv";
            // 
            // saveHtmlFileDialog
            // 
            this.saveHtmlFileDialog.DefaultExt = "html";
            this.saveHtmlFileDialog.FileName = "data";
            this.saveHtmlFileDialog.Filter = "HTML files (*.html)|*.html";
            this.saveHtmlFileDialog.InitialDirectory = "./";
            this.saveHtmlFileDialog.Title = "Сохранение";
            // 
            // errorsTextBox
            // 
            this.errorsTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.errorsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorsTextBox.ForeColor = System.Drawing.Color.IndianRed;
            this.errorsTextBox.Location = new System.Drawing.Point(0, 28);
            this.errorsTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.errorsTextBox.Name = "errorsTextBox";
            this.errorsTextBox.ReadOnly = true;
            this.errorsTextBox.Size = new System.Drawing.Size(614, 106);
            this.errorsTextBox.TabIndex = 1;
            this.errorsTextBox.Text = "";
            // 
            // errorsLabel
            // 
            this.errorsLabel.AutoSize = true;
            this.errorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorsLabel.Location = new System.Drawing.Point(12, 7);
            this.errorsLabel.Name = "errorsLabel";
            this.errorsLabel.Size = new System.Drawing.Size(151, 16);
            this.errorsLabel.TabIndex = 2;
            this.errorsLabel.Text = "----- Список ошибок -----";
            // 
            // errorsPanel
            // 
            this.errorsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.errorsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorsPanel.Controls.Add(this.hideErrorsButton);
            this.errorsPanel.Controls.Add(this.errorsLabel);
            this.errorsPanel.Controls.Add(this.errorsTextBox);
            this.errorsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.errorsPanel.Location = new System.Drawing.Point(0, 360);
            this.errorsPanel.Name = "errorsPanel";
            this.errorsPanel.Size = new System.Drawing.Size(616, 136);
            this.errorsPanel.TabIndex = 3;
            this.errorsPanel.Visible = false;
            // 
            // hideErrorsButton
            // 
            this.hideErrorsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hideErrorsButton.Location = new System.Drawing.Point(530, 3);
            this.hideErrorsButton.Name = "hideErrorsButton";
            this.hideErrorsButton.Size = new System.Drawing.Size(81, 23);
            this.hideErrorsButton.TabIndex = 3;
            this.hideErrorsButton.Text = "Скрыть";
            this.hideErrorsButton.UseVisualStyleBackColor = true;
            this.hideErrorsButton.Click += new System.EventHandler(this.hideErrorsButton_Click);
            // 
            // toolsPanel
            // 
            this.toolsPanel.Controls.Add(this.themeGroupBox);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolsPanel.Location = new System.Drawing.Point(0, 292);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(616, 68);
            this.toolsPanel.TabIndex = 5;
            // 
            // csvGridView
            // 
            this.csvGridView.AllowUserToAddRows = false;
            this.csvGridView.AllowUserToDeleteRows = false;
            this.csvGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.csvGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.csvGridView.Location = new System.Drawing.Point(0, 24);
            this.csvGridView.Name = "csvGridView";
            this.csvGridView.Size = new System.Drawing.Size(616, 268);
            this.csvGridView.TabIndex = 0;
            // 
            // themeGroupBox
            // 
            this.themeGroupBox.Controls.Add(this.darkThemeRadioButton);
            this.themeGroupBox.Controls.Add(this.lightThemeRadioButton);
            this.themeGroupBox.Location = new System.Drawing.Point(8, 7);
            this.themeGroupBox.Name = "themeGroupBox";
            this.themeGroupBox.Size = new System.Drawing.Size(213, 55);
            this.themeGroupBox.TabIndex = 0;
            this.themeGroupBox.TabStop = false;
            this.themeGroupBox.Text = "Выберите тему";
            // 
            // lightThemeRadioButton
            // 
            this.lightThemeRadioButton.AutoSize = true;
            this.lightThemeRadioButton.Location = new System.Drawing.Point(9, 23);
            this.lightThemeRadioButton.Name = "lightThemeRadioButton";
            this.lightThemeRadioButton.Size = new System.Drawing.Size(95, 17);
            this.lightThemeRadioButton.TabIndex = 0;
            this.lightThemeRadioButton.TabStop = true;
            this.lightThemeRadioButton.Text = "Светлая тема";
            this.lightThemeRadioButton.UseVisualStyleBackColor = true;
            // 
            // darkThemeRadioButton
            // 
            this.darkThemeRadioButton.AutoSize = true;
            this.darkThemeRadioButton.Location = new System.Drawing.Point(110, 23);
            this.darkThemeRadioButton.Name = "darkThemeRadioButton";
            this.darkThemeRadioButton.Size = new System.Drawing.Size(92, 17);
            this.darkThemeRadioButton.TabIndex = 1;
            this.darkThemeRadioButton.TabStop = true;
            this.darkThemeRadioButton.Text = "Тёмная тема";
            this.darkThemeRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 496);
            this.Controls.Add(this.csvGridView);
            this.Controls.Add(this.toolsPanel);
            this.Controls.Add(this.errorsPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(290, 300);
            this.Name = "MainForm";
            this.Text = "CSV to HTML converter";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.errorsPanel.ResumeLayout(false);
            this.errorsPanel.PerformLayout();
            this.toolsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.csvGridView)).EndInit();
            this.themeGroupBox.ResumeLayout(false);
            this.themeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToHtmlToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openCsvFileDialog;
        private System.Windows.Forms.SaveFileDialog saveHtmlFileDialog;
        private System.Windows.Forms.RichTextBox errorsTextBox;
        private System.Windows.Forms.Label errorsLabel;
        private System.Windows.Forms.Panel errorsPanel;
        private System.Windows.Forms.Button hideErrorsButton;
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.DataGridView csvGridView;
        private System.Windows.Forms.GroupBox themeGroupBox;
        private System.Windows.Forms.RadioButton darkThemeRadioButton;
        private System.Windows.Forms.RadioButton lightThemeRadioButton;
    }
}

