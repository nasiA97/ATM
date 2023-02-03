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
    public partial class accountant : Form
    {
        public accountant()
        {
            InitializeComponent();
            userNameLB.Text = $"login: {db.userInfo[1]}";
            string[] role = db.Select($"SELECT * FROM Роли WHERE ID = {db.userInfo[3]}")[0];
            int roleId = Convert.ToInt32(role[0]);
            userRoleLB.Text = role[1];
        }

        private void transactionsBTN_Click(object sender, EventArgs e)
        {
            transactions newForm = new transactions();
            newForm.Show();
        }

        private void reportAtmsBTN_Click(object sender, EventArgs e)
        {
            reportAtms newForm = new reportAtms();
            newForm.Show();
        }

        private void reportFeesBTN_Click(object sender, EventArgs e)
        {
            reportFees newForm = new reportFees();
            newForm.Show();
        }

        private void accountant_FormClosed(object sender, FormClosedEventArgs e)
        {
            login newForm = new login();
            newForm.Show();
        }
    }
}