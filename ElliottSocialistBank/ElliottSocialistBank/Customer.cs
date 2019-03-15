using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElliottSocialistBank
{

    class Customer
    {
        
        Transactions transaction = new Transactions();

        public string name { get; set; }
        public int balance = SumOfTransactions(); // customers balance is equal to the sum of the customers transactions
        public List<Transactions> transactionList = new List<Transactions>();
        
        



        public void RegisterTransaction(int intAnswer, string transactionTime)
        {

            transaction.name = name;
            Transactions.transactionMoney.Add(intAnswer);
            Transactions.transacitionTime.Add(transactionTime);
            
        }

        public static int SumOfTransactions()
        {
            int sumOfTransactionMoney = 0;
            for (int i = 0; i < Transactions.transactionMoney.Count; i++)
            {
                sumOfTransactionMoney += Transactions.transactionMoney[i];
            }
            return sumOfTransactionMoney;
        }

        public static void ShowTransactions(int i)
        {

            Console.WriteLine("Customer " + Program.customerbalance[i].name + " Put in an amount of : " + Transactions.transactionMoney[i] + " $ at time: " + Transactions.transacitionTime);

            Console.ReadLine();
        }


        public static void ShowCustomer(int i)
        {
            Console.WriteLine("Customer " + i + ": " + Program.customerbalance[i-1].name);
        }





    }
}


