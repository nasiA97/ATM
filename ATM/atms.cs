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
    public partial class atms : Form
    {
        List<string[]> atmsList;

        public atms()
        {
            InitializeComponent();
            UpdateAll();
        }

        private void UpdateAll()
        {
            atmsList = db.Select($"SELECT Банкоматы.ID, Банкоматы.Адрес, Банки.Название " +
                $"FROM Банкоматы INNER JOIN Банки ON Банкоматы.ID_банка = Банки.ID " +
                $"WHERE Банкоматы.is_archived != 1");
            WSLib.utils.UpdateTable(dataGridView1, atmsList, new string[] { "ID", "Адрес", "Банк" });
        }

        private void addAtmBTN_Click(object sender, EventArgs e)
        {
            addAtm newForm = new addAtm();
            newForm.Show();
            this.Hide();
        }

        private void updateAtmBTN_Click(object sender, EventArgs e)
        {
            addAtm newForm = new addAtm(Convert.ToInt32(atmsList[dataGridView1.CurrentCell.RowIndex][0]));
            newForm.Show();
            this.Hide();
        }

        private void deleteAtmBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    $"Удалить банкомат: {atmsList[dataGridView1.CurrentCell.RowIndex][1]}?",
                    "Подтверждение",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly) == DialogResult.OK)
            {
                MessageBox.Show(
                    $"Банкомат {atmsList[dataGridView1.CurrentCell.RowIndex][1]} удален!",
                    "Подтверждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                db.Select($"UPDATE Банкоматы SET is_archived = 1 " +
                    $"WHERE ID = {atmsList[dataGridView1.CurrentCell.RowIndex][0]}");
                UpdateAll();
            }
        }

        private void atms_FormClosed(object sender, FormClosedEventArgs e)
        {
            administrator newForm = new administrator();
            newForm.Show();
        }
    }
}
