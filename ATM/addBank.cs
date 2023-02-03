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
    public partial class addBank : Form
    {
        string[] bankInfo;

        public addBank(int bankID = -1)
        {
            InitializeComponent();

            bankInfo = new string[] { };

            if (bankID != -1)
            {
                bankInfo = db.Select($"SELECT * FROM Банки WHERE ID = {bankID}")[0];

                Text = "Изменение банка";
                addBankBTN.Text = "Изменить банк";
                nameTB.Text = bankInfo[1];
                addressTB.Text = bankInfo[2];
            }
        }

        private void addBankBTN_Click(object sender, EventArgs e)
        {
            if (nameTB.Text == "" || addressTB.Text == "")
            {
                MessageBox.Show(
                    "Не все данные банка введены!",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (bankInfo.Length == 0)
            {
                db.Select($"INSERT INTO Банки (Название, Юридический_адрес, is_archived) " +
                    $"VALUES ('{nameTB.Text}', '{addressTB.Text}', 0)");
                this.Hide();
                banks newForm = new banks();
                newForm.Show();
            }
            else
            {
                db.Select($"UPDATE Банки SET Название = '{nameTB.Text}', Юридический_адрес = '{addressTB.Text}' " +
                    $"WHERE ID = {bankInfo[0]}");
                this.Hide();
                banks newForm = new banks();
                newForm.Show();
            }
        }

        private void addBank_FormClosed(object sender, FormClosedEventArgs e)
        {
            banks newForm = new banks();
            newForm.Show();
        }
    }
}