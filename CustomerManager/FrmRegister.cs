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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            string firstName = first_name_tb.Text;
            string lastName = last_name_tb.Text;
            string email = email_tb.Text;
            string phone = phone_tb.Text;
            string notes = notes_tb.Text;
            DateTime currentCallDate = current_date.Value;
            DateTime callBack = call_back_date.Value;

            CustomerControl customerControl = new CustomerControl();
            customerControl.InsertCustomer(new Customer(firstName,lastName,email,phone,notes,currentCallDate,callBack));
        }
    }
}
