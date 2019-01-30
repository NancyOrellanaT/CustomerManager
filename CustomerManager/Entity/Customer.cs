using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Notes { get; set; }
        public DateTime CurrentCallDate { get; set; }
        public DateTime CallBack { get; set; }

        public Customer(int id, string firstName, string lastName, string email, string phone, string notes, DateTime currentCallDate, DateTime callBack)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Notes = notes;
            CurrentCallDate = currentCallDate;
            CallBack = callBack;
        }

        public Customer(string firstName, string lastName, string email, string phone, string notes, DateTime currentCallDate, DateTime callBack)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Notes = notes;
            CurrentCallDate = currentCallDate;
            CallBack = callBack;
        }

        public Customer() { }

    }
}
