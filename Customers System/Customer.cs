using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Customers_System
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Governate { get; set; }
        public Boolean IsVip{ get; set; }
        /*
        int findCustomerIndexById(int id)
        void addCustomer(int id, string name, string email, string city, bool isVip)
        Check that Customers List not Full(50)
        Check that this Customer not in the list
        set cutomer data & increase Cutomers
        */

    }
}
