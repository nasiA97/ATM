using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class reportAtms : Form
    {
        List<string[]> atmsData;
        List<string[]> banks;

        public reportAtms()
        {
            InitializeComponent();
            banks = db.Select("SELECT * FROM Банки " +
                $"WHERE is_archived != 1");
            banksCB.Items.Add("Все банки");
            for (var i = 0; i < banks.Count; i++)
            {
                banksCB.Items.Add(banks[i][1]);
            }
            banksCB.SelectedIndex = 0;
            UpdateAll();
        }

        private void UpdateAll()
        {
            string request = $"SELECT Банкоматы.Адрес, COUNT(Операции.ID), SUM(Операции.Сумма) " +
                $"FROM Операции INNER JOIN Клиенты ON Операции.ID_клиента = Клиенты.ID " +
                $"INNER JOIN Банкоматы ON Операции.ID_банкомата = Банкоматы.ID " +
                $"INNER JOIN Банки ON Банкоматы.ID_банка = Банки.ID ";
            if (banksCB.SelectedIndex != 0)
            {
                request += $"WHERE Банки.ID = {banks[banksCB.SelectedIndex - 1][0]} " +
                    $"AND Дата_время BETWEEN '{fromDTP.Value.ToString("yyyy-MM-dd hh:mm:ss")}' AND '{toDTP.Value.ToString("yyyy-MM-dd hh:mm:ss")}' ";
            }
            else
            {
                request += $"WHERE Дата_время BETWEEN '{fromDTP.Value.ToString("yyyy-MM-dd hh:mm:ss")}' AND '{toDTP.Value.ToString("yyyy-MM-dd hh:mm:ss")}' ";
            }
            request += "AND Банкоматы.is_archived != 1";
            request += $"GROUP BY Банкоматы.Адрес ";
            atmsData = db.Select(request);
            WSLib.utils.UpdateTable(dataGridView1, atmsData, new string[] { "Банкомат", "Количество операций", "Сумма" });

            WSLib.utils.GenerateDiagram(chart1, dataGridView1, 0, 1, "Количество операций");
            WSLib.utils.GenerateDiagram(chart2, dataGridView1, 0, 2, "Сумма");
        }

        private void updateDGVs(object sender, EventArgs e)
        {
            UpdateAll();
        }

        private void saveReportPDF_Click(object sender, EventArgs e)
        {
            string pdfBank = "Все банки";
            if (banksCB.SelectedIndex != 0) pdfBank = banks[banksCB.SelectedIndex - 1][0];
            DateTime now = DateTime.Now;
            string fileName = $"report_atms__{now.ToString("MM_dd__hh_mm_ss")}";
            string[] pdfTablesNames = { "Статистика по банкоматам" };
            string[][] pdfTablesColumns = { new string[] { "Банкомат", "Количество операций", "Сумма" } };
            List<string[]>[] pdfData = {
                    new List<string[]> { new string[] { $"{now.ToString("yyyy-MM-dd")}" } },
                    new List<string[]> { new string[] { $"Банк: {pdfBank}" } },
                    atmsData,
                };
            WSLib.utils.pdfWriter(fileName, pdfTablesNames, pdfData, pdfTablesColumns);
        }

        private void saveReportCSV_Click(object sender, EventArgs e)
        {
            string pdfBank = "Все банки";
            if (banksCB.SelectedIndex != 0) pdfBank = banks[banksCB.SelectedIndex - 1][0];
            DateTime now = DateTime.Now;
            string fileName = $"report_atms__{now.ToString("MM_dd__hh_mm_ss")}";
            WSLib.utils.csvWriter(fileName, atmsData, new string[] { "Банкомат", "Количество операций", "Сумма" });
            MessageBox.Show(
                    $"Отчет {fileName} сохранен!",
                    "Подтверждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
