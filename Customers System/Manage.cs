using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Customers_System.OrderData;

namespace Customers_System
{
    public class Manage
    {
        const int MaxCustomers = 50;
        const int MaxProducts = 50;

        const int MaxLinesPerOrder = 20;

        //Flaw: anyone can access it and change the entire data. ( violate encapsulation )
        public static List<Customer> Customers = new List<Customer>();
        public static List<Line> Products = new List<Line>();




            void printCustomers() { }
        void printProducts() { }
        void printAllOrders() { }
        double totalSalesPaidOnly() { return 0.0; }


        }

    }
}
