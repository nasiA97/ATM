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
    public partial class manager : Form
    {
        List<string[]> clients;

        public manager()
        {
            InitializeComponent();
            userNameLB.Text = $"login: {db.userInfo[1]}";
            string[] role = db.Select($"SELECT * FROM Роли WHERE ID = {db.userInfo[3]}")[0];
            int roleId = Convert.ToInt32(role[0]);
            userRoleLB.Text = role[1];
            UpdateAll();
        }

        private void UpdateAll()
        {
            clients = db.Select($"SELECT Клиенты.ID, ФИО, Номер_карты, Адрес, Банки.Название AS Банк " +
                $"FROM Клиенты INNER JOIN Банки ON Клиенты.ID_банка = Банки.ID " +
                $"WHERE Клиенты.is_archived != 1");
            WSLib.utils.UpdateTable(dataGridView1, clients, new string[] { "ID", "ФИО", "Номер карты", "Адрес", "Банк" });
        }

        private void addClientBTN_Click(object sender, EventArgs e)
        {
            addClient newForm = new addClient();
            newForm.Show();
            this.Hide();
        }

        private void updateClientBTN_Click(object sender, EventArgs e)
        {
            addClient newForm = new addClient(Convert.ToInt32(clients[dataGridView1.CurrentCell.RowIndex][0]));
            newForm.Show();
            this.Hide();
        }

        private void deleteClientBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    $"Удалить клиента: {clients[dataGridView1.CurrentCell.RowIndex][1]}?",
                    "Подтверждение",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly) == DialogResult.OK)
            {
                MessageBox.Show(
                    $"Клиент {clients[dataGridView1.CurrentCell.RowIndex][1]} удален!",
                    "Подтверждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                db.Select($"UPDATE Клиенты SET is_archived = 1 " +
                    $"WHERE ID = {clients[dataGridView1.CurrentCell.RowIndex][0]}");
                UpdateAll();
            }
        }

        private void manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            login newForm = new login();
            newForm.Show();
            this.Hide();
        }
    }
}
