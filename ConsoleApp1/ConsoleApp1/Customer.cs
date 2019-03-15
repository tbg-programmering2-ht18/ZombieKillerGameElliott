using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Customer
    {
        public string name { get; set; }
        public int balance { get; set; }


        public static void showCustomer()
        {
            int i = 1;
            foreach (var customer in Program.customerbalance)
            {
                Console.WriteLine("User " + i + ":" + customer.name);
                i++;
            }
        }
    }
}
