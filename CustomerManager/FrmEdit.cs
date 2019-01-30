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
    public partial class FrmEdit : Form
    {
        private int idCustomerSelected;

        public FrmEdit()
        {
            InitializeComponent();
            idCustomerSelected = 0;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            string firstName = first_name_tb.Text;
            string lastName = last_name_tb.Text;
            string email = email_tb.Text;
            string phone = phone_tb.Text;
            string notes = notes_tb.Text;
            DateTime currentCallDate = current_date.Value;
            DateTime callBack = call_back_date.Value;

            CustomerControl customerControl = new CustomerControl();
            customerControl.EditCustomer(new Customer(idCustomerSelected, firstName, lastName, email, phone, notes, currentCallDate, callBack));

            MessageBox.Show("Successfully modified data");
            Close();
        }

        public void LoadData(Customer customer)
        {
            idCustomerSelected = customer.ID;
            first_name_tb.Text = customer.FirstName;
            last_name_tb.Text = customer.LastName;
            email_tb.Text = customer.Email;
            phone_tb.Text = customer.Phone;
            notes_tb.Text = customer.Notes;
            current_date.Value = customer.CurrentCallDate;
            call_back_date.Value = customer.CallBack;
        }
    }
}
