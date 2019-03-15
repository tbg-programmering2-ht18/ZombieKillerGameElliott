using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        public static List<Customer> customerbalance = new List<Customer>();


        static void Main(string[] args)
        {
            string answer;

            /*
           Customer customerbalance1 = new Customer();
           Customer customerbalance2 = new Customer();
           Customer customerbalance3 = new Customer(); */

            Console.WriteLine("Welcome to JorreCapitalBank!");
            Console.WriteLine("");
            Console.WriteLine("Choose one of the following options.");
            Console.WriteLine("");
            while (true)
            {
                Console.WriteLine("1 : Add customer");
                Console.WriteLine("2 : Show customer");
                Console.WriteLine("3 : Remove idiets from bank");
                Console.WriteLine("4 : Add money to account");
                Console.WriteLine("5 : Show transactions for users");
                Console.Write("Skriv ditt val: ");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Add customer");
                        addCustomer();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        foreach (var Customer in customerbalance)
                        {
                            Console.WriteLine("User: {0}", Customer.name);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Customer.showCustomer();
                        int retrieve = 1; // What number are you looking to delete
                        retrieve = Convert.ToInt32(Console.ReadLine()); // converting readline method tov accept integer
                        int countIndex = 1;
                        int indexDelete = -1;

                        foreach (var customer in customerbalance)
                        {
                            if (retrieve == countIndex)
                            {
                                indexDelete = countIndex; // The current elements index number is stored in "indexDelete" 
                                break;
                            }
                            countIndex++;
                        }
                        if (indexDelete != -1)
                        {
                            customerbalance.RemoveAt(indexDelete);
                        }

                        Console.Clear();
                        break;

                    case "4":
                        Customer transaction = new Customer(); // Creat an object that can be sent to a list later on
                        // Save the name of the user making an transaction
                        Console.WriteLine("In which account would you like to make an transaction?");
                        answer = Console.ReadLine();
                        transaction.name = answer;

                        // save the time of the current transaction
                        Console.WriteLine("what time is it");
                        answer = Console.ReadLine();
                        transaction.time = answer;

                        // Save the amount of money
                        Console.WriteLine("how much money");
                        answer = Console.ReadLine();
                        transactions.money = answer;
                        Console.Clear();
                        break;

                    case "5":
                        customerbalance.ShowTransactions();
                        break;


                }


            }




            Console.ReadKey();

        }


        public static void addCustomer()
        {
            Console.WriteLine("");
            Console.Write("Name of customer: ");
            string name = Console.ReadLine();
            Customer customer = new Customer();
            customer.name = name;
            customerbalance.Add(customer);


        }






    }
}
