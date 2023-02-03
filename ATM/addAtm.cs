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
    public partial class addAtm : Form
    {
        List<string[]> banks;

        string[] atmInfo;

        public addAtm(int atmID = -1)
        {
            InitializeComponent();
            banks = db.Select($"SELECT * FROM Банки " +
                $"WHERE is_archived != 1");
            WSLib.utils.UpdateCB(banksCB, banks, 1);

            atmInfo = new string[] { };

            if (atmID != -1)
            {
                atmInfo = db.Select($"SELECT Банкоматы.ID, Банкоматы.Адрес, Банки.Название " +
                $"FROM Банкоматы " +
                $"INNER JOIN Банки ON Банкоматы.ID_банка = Банки.ID " +
                $"WHERE Банкоматы.ID = {atmID}")[0];

                Text = "Изменение банкомата";
                addAtmBTN.Text = "Изменить банкомат";
                addressTB.Text = atmInfo[1];
                banksCB.Text = atmInfo[2];
            }
        }

        private void addAtmBTN_Click(object sender, EventArgs e)
        {
            if (addressTB.Text == "" || banksCB.Text == "")
            {
                MessageBox.Show(
                    "Не все данные банкомата введены!",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (atmInfo.Length == 0)
            {
                db.Select($"INSERT INTO Банкоматы (Адрес, ID_банка, is_archived) " +
                    $"VALUES ('{addressTB.Text}', {banks[banksCB.SelectedIndex][0]}, 0)");
                this.Hide();
                atms newForm = new atms();
                newForm.Show();
            }
            else
            {
                db.Select($"UPDATE Банкоматы SET Адрес = '{addressTB.Text}', ID_банка = {banks[banksCB.SelectedIndex][0]} " +
                    $"WHERE ID = {atmInfo[0]}");
                this.Hide();
                atms newForm = new atms();
                newForm.Show();
            }
        }

        private void addAtm_FormClosed(object sender, FormClosedEventArgs e)
        {
            atms newForm = new atms();
            newForm.Show();
        }
    }
}
