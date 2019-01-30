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
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lastName_tb.Text != "")
            {
                CustomerControl customerControl = new CustomerControl();
                dataGridView1.DataSource = customerControl.SearchCustomer(lastName_tb.Text);
            }
            else
            {
                MessageBox.Show("Must enter last name", "Error");
            }
            
        }
    }
}
