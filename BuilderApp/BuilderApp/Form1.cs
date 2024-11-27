using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuilderLibrary;

namespace BuilderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            // Використовуємо Builder для створення звіту
            var report = new ReportBuilder()
                .SetTitle("Звіт про виконану роботу")   // Встановлення заголовка
                .SetContent("У цьому розділі наводяться основні дані...") // Встановлення змісту
                .SetSummary("Звіт завершено успішно.")   // Встановлення підсумку
                .Build();  // Будуємо звіт

            // Виводимо звіт у TextBox
            textBoxReport.Text = $"Title: {report.Title}\nContent: {report.Content}\nSummary: {report.Summary}";
        }
    }
}
