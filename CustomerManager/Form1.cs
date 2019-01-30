using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            if (txtUser.Text == "admin" && txtPassword.Text == "admin")
            {
                FrmOptionsCustomers frmOptionsCustomers = new FrmOptionsCustomers();
                frmOptionsCustomers.Show();

                Hide();
            }
            if (txtUser.Text == "" && txtPassword.Text == "")
            {
                var handle = GetConsoleWindow();

                ShowWindow(handle, SW_SHOW);

                FrmOptionsCustomers frmOptionsCustomers = new FrmOptionsCustomers();
                frmOptionsCustomers.Show();

                Hide();
            }
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

    }
}
