using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Customer
    {
        private  List<CustomerTransactions> transactions = new List<CustomerTransactions>();

        public string name { get; set; }
        public int balance { get; set; }
        


        public int balance()
        {
           
        }
        public void ShowTransactions()
        {
            if(answer == "1") // show al users
            {
                int i = 1;
                foreach (var customer in transactions)
                {
                    Console.WriteLine("User " + i + transactions.name + transactions.money + transactions.time+ transaction.);
                    i++;
                }
            }

            else if(answer = "2") // show only one
            {

            }
        }

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
