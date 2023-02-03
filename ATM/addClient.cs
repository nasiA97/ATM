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
    public partial class addClient : Form
    {
        List<string[]> banks;

        string[] clientInfo;

        public addClient(int clientID = -1)
        {
            InitializeComponent();
            banks = db.Select("SELECT * FROM Банки " +
                $"WHERE is_archived != 1");
            WSLib.utils.UpdateCB(banksCB, banks, 1);

            clientInfo = new string[] { };

            if (clientID != -1)
            {
                clientInfo = db.Select($"SELECT Клиенты.ID, ФИО, Номер_карты, Адрес, Банки.Название AS Банк " +
                    $"FROM Клиенты INNER JOIN Банки ON Клиенты.ID_банка = Банки.ID " +
                    $"WHERE Клиенты.ID = {clientID}")[0];

                Text = "Изменение клиента";
                addClientBTN.Text = "Изменить клиента";
                nameTB.Text = clientInfo[1];
                cardNUD.Value = Convert.ToInt64(clientInfo[2]);
                addressTB.Text = clientInfo[3];
                banksCB.Text = clientInfo[4];
            }
        }

        private void addClientBTN_Click(object sender, EventArgs e)
        {
            if (nameTB.Text == "" || cardNUD.Value == 1000000000000000 || addressTB.Text == "" || banksCB.Text == "")
            {
                MessageBox.Show(
                    "Не все данные клиента введены!",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (clientInfo.Length == 0)
            {
                db.Select($"INSERT INTO Клиенты (ФИО, Номер_карты, Адрес, ID_банка, is_archived) " +
                    $"VALUES ('{nameTB.Text}', {cardNUD.Value}, '{addressTB.Text}', {banks[banksCB.SelectedIndex][0]}, 0)");
                this.Hide();
                manager newForm = new manager();
                newForm.Show();
            }
            else
            {
                db.Select($"UPDATE Клиенты SET ФИО = '{nameTB.Text}', Номер_карты = {cardNUD.Value}, Адрес = '{addressTB.Text}', ID_банка = {banks[banksCB.SelectedIndex][0]} " +
                    $"WHERE ID = {clientInfo[0]}");
                this.Hide();
                manager newForm = new manager();
                newForm.Show();
            }
        }

        private void addClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager newForm = new manager();
            newForm.Show();
        }
    }
}