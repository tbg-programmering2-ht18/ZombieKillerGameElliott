using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElliottSocialistBank

{
    class Program
    {
        public static List<Customer> customerbalance = new List<Customer>();


        static void Main(string[] args)
        {
            string stringAnswer;
            int intAnswer = 0;

            /*
           Customer customerbalance1 = new Customer();
           Customer customerbalance2 = new Customer();
           Customer customerbalance3 = new Customer(); */

            Console.WriteLine("Welcome to ElliottSocialistBank!");
            Console.WriteLine("");

            while (true)
            {
                Console.WriteLine("Choose one of the following options.");
                Console.WriteLine("");
                Console.WriteLine("1 : Add customer");
                Console.WriteLine("2 : Show customer");
                Console.WriteLine("3 : Remove idiets from bank");
                Console.WriteLine("4 : Show transactions for users");
                Console.WriteLine("5 : Add money to account");
                Console.WriteLine("6 : Show customer balance");
                Console.WriteLine("7 : Exit bank");
                Console.Write("Write your chooice: ");
                stringAnswer = Console.ReadLine();
                Console.Clear();

                switch (stringAnswer)
                {
                    case "1":
                        while(stringAnswer !="N" && stringAnswer != "n")
                        {
                            Console.WriteLine("Add customer");
                            addCustomer();
                            Console.WriteLine("Add Another one? [Y]es or [N]o");
                            stringAnswer = Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case "2":
                        foreach (var Customer in customerbalance)
                        {
                            Console.WriteLine("User: {0}", Customer.name);
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        int i = 1;
                        foreach (var Customer in customerbalance)
                        {
                            Console.WriteLine("User " + i +": " + Customer.name);
                            i++;
                        }

                        // What number are you looking to delete
                        stringAnswer = Console.ReadLine();
                        // make sure the user a writen a numerical answer and not some letter
                        bool isInteger = CheckForInteger(stringAnswer);
                        // if the function return the string "true" then stringAnswer truly was a numerical
                        if (isInteger == true)
                        {
                            intAnswer = Int32.Parse(stringAnswer);
                        }

                        else if(isInteger == false)
                        {
                            Console.WriteLine("pleas enter a numerical answer");
                        }

                        customerbalance.RemoveAt(intAnswer-1);                

                        break;

                    case "4":
                        Console.WriteLine("What customer!");
                        intAnswer = Convert.ToInt32(Console.ReadLine());
                        i = 0;
                        foreach(var customer in customerbalance)
                        {
                            if ((intAnswer-1) == i)
                            {
                                Customer.ShowTransactions(i);

                            }
                            i++;
                        }

                        break;

                    case "5":
                        i = 1;
                        foreach (var Customer in customerbalance)
                        {
                            Console.WriteLine("User " + i+ ": " + Customer.name);
                            i++;
                        }
                        Console.Write("What customer would you like to make an transaction to: ");
                        intAnswer = Convert.ToInt32(Console.ReadLine());
                        int iCount = 0;
                        foreach(var Customer in customerbalance)
                        {
                            if ((intAnswer-1) == iCount)
                            { 
                                Console.Write("How much money: ");
                                intAnswer = Convert.ToInt32(Console.ReadLine());
                                Console.Write("what is time? ");
                                string transactionTime = Console.ReadLine();
                                Customer.RegisterTransaction(intAnswer, transactionTime);
                                break;
                            }
                            iCount++;
                        }
                            
                        break;
                
                        

                    case "6":
                        for(i = 1; i<=customerbalance.Count; i++)
                        {
                            Customer.ShowCustomer(i);
                        }
                        Console.WriteLine("For what customer would you like to see the balance");
                        intAnswer = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(customerbalance[intAnswer-1].balance);


                        break;

                }

                Console.Clear();
            }





        }


        // checks if the user input truly is a numeric answer
        public static bool CheckForInteger(string stringAnswer)
        {
            int value; 
            bool isNumeric;
            isNumeric = int.TryParse(stringAnswer, out value);
            return isNumeric;

        }
        

        // for case 1
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
