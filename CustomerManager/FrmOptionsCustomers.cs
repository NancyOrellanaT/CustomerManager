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

        private void btnCallToday_Click(object sender, EventArgs e)
        {
            CustomerControl customerControl = new CustomerControl();
            dataGridView1.DataSource = customerControl.ListCustomersToCallToday();
        }

        private void FrmOptionsCustomers_Load(object sender, EventArgs e)
        {
            CustomerControl customerControl = new CustomerControl();
            dataGridView1.DataSource = customerControl.ListCustomers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string firstName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string lastName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string email = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string phone = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string notes = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                DateTime currentDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value);
                DateTime callBack = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value.ToString());

                FrmEdit frmEdit = new FrmEdit();
                frmEdit.Show();     
                frmEdit.LoadData(new Customer(id, firstName, lastName, email, phone, notes, currentDate, callBack));
            }
            else
            {
                MessageBox.Show("You must select a row to edit customer data","Error!");
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DialogResult answer = MessageBox.Show("Are you sure delete data?", "important", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (answer == DialogResult.OK)
                {
                    CustomerControl customerControl = new CustomerControl();

                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                    customerControl.DeleteCustomer(id);
                }      
                    
            }
            else
            {
                MessageBox.Show("You must select a row to delete customer data","Error!");
            }
        }
    }
}
