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
    public partial class FrmOptionsCustomers : Form
    {
        public FrmOptionsCustomers()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmSearch frmSearch = new FrmSearch();
            frmSearch.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CustomerControl customerControl = new CustomerControl();
            dataGridView1.DataSource = customerControl.ListCustomers();
        }
    }
}
