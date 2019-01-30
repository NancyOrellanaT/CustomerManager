using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerManager
{
    class CustomerControl
    {

        private Connection connection;

        public CustomerControl()
        {
            connection = new Connection();
        }

        public void InsertCustomer(Customer customer)
        {
            string query = "INSERT INTO CUSTOMER(firstName, lastName, email, phone, notes, currentCallDate, callBack) VALUES('" + customer.FirstName + "','" + customer.LastName + "','" + customer.Email + "','" + customer.Phone + "','" + customer.Notes + "','" +customer.CurrentCallDate.ToString("s") + "','" + customer.CallBack.ToString("s") + "')";

            connection.ExecuteSQL(query);
        }

        public DataTable ListCustomers()
        {
            try
            {
                string sql = "SELECT * FROM CUSTOMER";

                return connection.QuerySQL(sql);
            }
            catch (Exception e)
            {
                MessageBox.Show("Can't list customers");
                Log.Print(e.ToString());
            }

            return null;
        }

    }
}
