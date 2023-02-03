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
    public partial class administrator : Form
    {
        public administrator()
        {
            InitializeComponent();
            userNameLB.Text = $"login: {db.userInfo[1]}";
            string[] role = db.Select($"SELECT * FROM Роли WHERE ID = {db.userInfo[3]}")[0];
            int roleId = Convert.ToInt32(role[0]);
            userRoleLB.Text = role[1];
        }

        private void banksBTN_Click(object sender, EventArgs e)
        {
            banks newForm = new banks();
            newForm.Show();
            this.Hide();
        }

        private void atmsBTN_Click(object sender, EventArgs e)
        {
            atms newForm = new atms();
            newForm.Show();
            this.Hide();
        }

        private void administrator_FormClosed(object sender, FormClosedEventArgs e)
        {
            login newForm = new login();
            newForm.Show();
            this.Hide();
        }
    }
}