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
    public partial class login : Form
    {
        List<string[]> userInfo;

        public login()
        {
            InitializeComponent();
            passwordTB.UseSystemPasswordChar = !passwordTB.UseSystemPasswordChar;
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            if (loginTB.Text.Length == 0 || passwordTB.Text.Length == 0)
            {
                errorLB.Text = "Введите логин и пароль";
            }
            else
            {
                userInfo = db.Select($"SELECT * FROM Пользователи WHERE Логин = '{loginTB.Text}' AND Пароль = '{passwordTB.Text}'");
                if (userInfo.Count == 0)
                {
                    errorLB.Text = "Неверный логин или пароль";
                }
                else
                {
                    db.userInfo = userInfo[0];
                    if (db.userInfo[3] == "1")  // Бухгалтер    -   Отчеты
                    {
                        accountant newForm = new accountant();
                        newForm.Show();
                        this.Hide();
                    }
                    if (db.userInfo[3] == "2")  //  Менеджер    -   Клиенты
                    {
                        manager newForm = new manager();
                        newForm.Show();
                        this.Hide();
                    }
                    if (db.userInfo[3] == "3")  //  Администратор   -   Банки и банкоматы
                    {
                        administrator newForm = new administrator();
                        newForm.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void passwordTB_change_visibility(object sender, EventArgs e)
        {
            passwordTB.UseSystemPasswordChar = !passwordTB.UseSystemPasswordChar;
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}