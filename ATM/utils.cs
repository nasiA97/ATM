using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using PdfSharp.Pdf;
using iTextSharp.text;
using iTextSharp.xmp;
using PdfSharp.Drawing;
using System.IO;
using iTextSharp.text.pdf;
using System.Windows.Forms.DataVisualization.Charting;

namespace ATM
{
    class utils
    {
        // Метод генерации диаграмм
        public static void GenerateDiagram(Chart chart, DataGridView table, int xIndex, int yIndex, string legend)
        {
            chart.Series.Clear();
            chart.Series.Add(new Series(legend) { ChartType = SeriesChartType.Column });

            string[] xValues = new string[table.Rows.Count];
            double[] yValues = new double[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                xValues[i] = table[xIndex, i].Value.ToString();
                yValues[i] = Convert.ToDouble(table[yIndex, i].Value);
            }
            chart.Series[legend].Points.DataBindXY(xValues, yValues);
        }

        // Метод обновления выпадающих списков
        public static int UpdateCB(ComboBox box, List<string[]> data, int index)
        {
            if (data.Count == 0) return 0;
            box.Items.Clear();
            for (var i = 0; i < data.Count; i++)
            {
                box.Items.Add(data[i][index]);
            }
            return 1;
        }

        // Обновление данных в таблице
        public static void UpdateTable(DataGridView table, List<string[]> data, string[] columns)
        {
            if (data.Count > 0)
            {
                string[] columnNames = columns;
                table.ColumnCount = data[0].Length;
                table.RowCount = data.Count;
                for (var i = 0; i < columnNames.Length; i++) { table.Columns[i].Name = columnNames[i]; }
                for (var i = 0; i < data.Count; i++)
                {
                    for (var j = 0; j < data[0].Length; j++)
                    {
                        table.Rows[i].Cells[j].Value = data[i][j];
                    }
                }
            }
            else { table.Rows.Clear(); }
        }

        // Запись данных в PDF
        public static void pdfWriter(string file, string[] tableNames, List<string[]>[] data, string[][] columns)
        {
            Document pdf = new Document();
            PdfWriter.GetInstance(pdf, new FileStream($"..\\..\\..\\pdfDocuments\\{file}.pdf", FileMode.Create));
            pdf.Open();
            BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

            int tablesCount = 0;
            for (int textTable = 0; textTable < data.Length; textTable++)
            {
                if (data[textTable].Count == 1 && data[textTable][0].Length == 1)
                {
                    pdf.Add(new Paragraph(data[textTable][0][0], font));
                }
                else
                {
                    PdfPTable table = new PdfPTable(data[textTable][0].Length);
                    PdfPCell cell = new PdfPCell(new Phrase(tableNames[tablesCount], font));

                    cell.Colspan = data[textTable][0].Length;
                    cell.HorizontalAlignment = 1;

                    cell.Border = 0;
                    table.AddCell(cell);

                    for (int i = 0; i < data[textTable][0].Length; i++)
                    {
                        cell = new PdfPCell(new Phrase(columns[tablesCount][i], font));
                        cell.BackgroundColor = BaseColor.YELLOW;
                        table.AddCell(cell);
                    }

                    for (int i = 0; i < data[textTable].Count; i++)
                    {
                        for (int j = 0; j < data[textTable][i].Length; j++)
                        {
                            cell = new PdfPCell(new Phrase(data[textTable][i][j], font));
                            table.AddCell(cell);
                        }
                    }
                    pdf.Add(table);
                    tablesCount++;
                }
            }
            pdf.Close();
            System.Diagnostics.Process.Start($"..\\..\\..\\Docs PDF\\{file}.pdf");
        }

        // Запись данных в CSV
        public static void csvWriter(string file, List<string[]> data, string[] columns)
        {
            string _data = "";
            for (int i = 0; i < data[0].Length; i++)
            {
                _data += $"{columns[i]};";
            }
            _data += "\t\n";
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    _data += $"{data[i][j]};";
                }
                _data += "\t\n";
            }
            StreamWriter sw = new StreamWriter($"..\\..\\..\\Docs CSV\\{file}.csv", false, Encoding.GetEncoding("windows-1251"));
            sw.Write(_data);
            sw.Close();
        }
    }
}