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
    public partial class banks : Form
    {
        List<string[]> banksList;

        public banks()
        {
            InitializeComponent();
            UpdateAll();
        }

        private void UpdateAll()
        {
            banksList = db.Select($"SELECT ID, Название, Юридический_адрес FROM Банки " +
                $"WHERE Банки.is_archived != 1");
            WSLib.utils.UpdateTable(dataGridView1, banksList, new string[] { "ID", "Название", "Юридический адрес" });
        }

        private void addBankBTN_Click(object sender, EventArgs e)
        {
            addBank newForm = new addBank();
            newForm.Show();
            this.Hide();
        }

        private void updateBankBTN_Click(object sender, EventArgs e)
        {
            addBank newForm = new addBank(Convert.ToInt32(banksList[dataGridView1.CurrentCell.RowIndex][0]));
            newForm.Show();
            this.Hide();
        }

        private void deleteBankBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    $"Удалить банк: {banksList[dataGridView1.CurrentCell.RowIndex][1]}?",
                    "Подтверждение",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly) == DialogResult.OK)
            {
                MessageBox.Show(
                    $"Банк {banksList[dataGridView1.CurrentCell.RowIndex][1]} удален!",
                    "Подтверждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                db.Select($"UPDATE Банки SET is_archived = 1 " +
                    $"WHERE ID = {banksList[dataGridView1.CurrentCell.RowIndex][0]}");
                UpdateAll();
            }
        }

        private void banks_FormClosed(object sender, FormClosedEventArgs e)
        {
            administrator newForm = new administrator();
            newForm.Show();
        }
    }
}