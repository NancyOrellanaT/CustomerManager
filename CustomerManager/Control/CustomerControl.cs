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

        public DataTable ListCustomersToCallToday()
        {
            try
            {
                string sql = "SELECT * FROM CUSTOMER WHERE CAST(callBack as date) = CAST(getdate() as date)";

                return connection.QuerySQL(sql);
            }
            catch (Exception e)
            {
                MessageBox.Show("Can't list customers");
                Log.Print(e.ToString());
            }

            return null;
        }

        public DataTable SearchCustomer(string lastName)
        {
            try
            {
                string sql = "SELECT * FROM CUSTOMER WHERE lastName = '" + lastName + "'";
                return connection.QuerySQL(sql);
            }
            catch (Exception e)
            {
                MessageBox.Show("Can't search the customer's data");
                Log.Print(e.ToString());
            }

            return null;
        }

        public void EditCustomer(Customer customer)
        {
            string sql = "UPDATE CUSTOMER SET firstName = '" + customer.FirstName + "', lastName = '" + customer.LastName + "', email = '" + customer.Email + "', phone = '" + customer.Phone + "', notes = '" + customer.Notes + "', currentCallDate = '" + customer.CurrentCallDate.ToString("s") + "', callBack = '" + customer.CallBack.ToString("s") + "' WHERE id = " + customer.ID + ";";
            connection.ExecuteSQL(sql);
        }

        public void DeleteCustomer(int id)
        {
            string sql = "DELETE FROM CUSTOMER WHERE id = " + id;
            connection.ExecuteSQL(sql);
        }
    }
}
