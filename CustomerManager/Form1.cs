using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerManager
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //(txtUser.Text == "Mi chanchi" && txtPassword.Text == "teamo")
            if (txtUser.Text == "" && txtPassword.Text == "")
            {
                FrmOptionsCustomers frmOptionsCustomers = new FrmOptionsCustomers();
                frmOptionsCustomers.Show();
                

            }
        }
    }
}
