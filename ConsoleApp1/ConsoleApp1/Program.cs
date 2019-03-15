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
                Console.WriteLine("");
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
                        int retrieve = 1;
                        retrieve = Convert.ToInt32(Console.ReadLine());
                        int count = 1;
                        foreach(var customer in customerbalance)
                        {
                            if(retrieve == count)
                            {
                                customerbalance.Remove(customer);
                                break;
                            }
                            count++;
                        }
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("would you like to see a list of users? [Y]es or [N]o");
                        answer = Console.ReadLine();
                        if(answer == "Y" && answer == "y")
                        {
                            Customer.showCustomer();
                        }
                        else if(answer == "N" && answer == "n")
                        {
                            Console.WriteLine("Then simply write the users ID");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("please enter correctly");
                        }

                        Console.WriteLine("In which account would you like to make an transaction?");
                        Console.WriteLine("srry we have technical problems");
                        Console.Clear();
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