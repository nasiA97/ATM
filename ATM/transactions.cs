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
    public partial class transactions : Form
    {
        List<string[]> transactionsList;
        List<string[]> diagramData;
        List<string[]> banks;

        public transactions()
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
            string request = $"SELECT Операции.ID, Клиенты.ФИО, Банкоматы.Адрес, Операции.Дата_время, Операции.Сумма " +
                $"FROM Операции INNER JOIN Клиенты ON Операции.ID_клиента = Клиенты.ID " +
                $"INNER JOIN Банкоматы ON Операции.ID_банкомата = Банкоматы.ID ";
            string diagramRequest = $"SELECT COUNT(Операции.ID), Операции.Дата_время " +
                $"FROM Операции INNER JOIN Клиенты ON Операции.ID_клиента = Клиенты.ID " +
                $"INNER JOIN Банкоматы ON Операции.ID_банкомата = Банкоматы.ID ";
            if (banksCB.SelectedIndex != 0)
            {
                request += $"INNER JOIN Банки ON Клиенты.ID_банка = Банки.ID " +
                    $"WHERE Банки.ID = {banks[banksCB.SelectedIndex - 1][0]} " +
                    $"AND Дата_время BETWEEN '{fromDTP.Value.ToString("yyyy-MM-dd hh:mm:ss")}' AND '{toDTP.Value.ToString("yyyy-MM-dd hh:mm:ss")}'";
                diagramRequest += $"INNER JOIN Банки ON Клиенты.ID_банка = Банки.ID " +
                    $"WHERE Банки.ID = {banks[banksCB.SelectedIndex - 1][0]} " +
                    $"AND Дата_время BETWEEN '{fromDTP.Value.ToString("yyyy-MM-dd hh:mm:ss")}' AND '{toDTP.Value.ToString("yyyy-MM-dd hh:mm:ss")}'";
            }
            else
            {
                request += $"WHERE Дата_время BETWEEN '{fromDTP.Value.ToString("yyyy-MM-dd hh:mm:ss")}' AND '{toDTP.Value.ToString("yyyy-MM-dd hh:mm:ss")}' ";
                diagramRequest += $"WHERE Дата_время BETWEEN '{fromDTP.Value.ToString("yyyy-MM-dd hh:mm:ss")}' AND '{toDTP.Value.ToString("yyyy-MM-dd hh:mm:ss")}' ";
            }
            transactionsList = db.Select(request);
            WSLib.utils.UpdateTable(dataGridView1, transactionsList, new string[] { "ID", "Клиент", "Адрес банкомата", "Дата", "Сумма" });

            diagramRequest += $"GROUP BY Операции.Дата_время";
            diagramData = db.Select(diagramRequest);
            WSLib.utils.UpdateTable(dataGridView2, diagramData, new string[] { "Количество операций", "Дата" });
            WSLib.utils.GenerateDiagram(chart1, dataGridView2, 1, 0, "Количество операций");
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
            string fileName = $"report_transactions__{now.ToString("MM_dd__hh_mm_ss")}";
            string[] pdfTablesNames = { "Статистика по банкоматам" };
            string[][] pdfTablesColumns = { new string[] { "ID", "Клиент", "Адрес банкомата", "Дата", "Сумма" } };
            List<string[]>[] pdfData = {
                    new List<string[]> { new string[] { $"{now.ToString("yyyy-MM-dd")}" } },
                    new List<string[]> { new string[] { $"Банк: {pdfBank}" } },
                    transactionsList,
                };
            WSLib.utils.pdfWriter(fileName, pdfTablesNames, pdfData, pdfTablesColumns);
        }

        private void saveReportCSV_Click(object sender, EventArgs e)
        {
            string pdfBank = "Все банки";
            if (banksCB.SelectedIndex != 0) pdfBank = banks[banksCB.SelectedIndex - 1][0];
            DateTime now = DateTime.Now;
            string fileName = $"report_transactions__{now.ToString("MM_dd__hh_mm_ss")}";
            WSLib.utils.csvWriter(fileName, transactionsList, new string[] { "ID", "Клиент", "Адрес банкомата", "Дата", "Сумма" });
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
