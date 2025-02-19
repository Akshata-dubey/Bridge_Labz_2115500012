using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_VS
{
    class BankAccountSystem
    {
        private static string BankName = "Bank Of India";
        public string AccountHolderName;
        public readonly string AccountNumber;
        private static int TotalAccounts = 0;

        public static void GetTotalAccounts()
        {
            Console.WriteLine("Total Number of Accounts: " + TotalAccounts);
        }

        public BankAccountSystem(string AccountHolderName, string AccountNumber)
        {
            this.AccountHolderName = AccountHolderName;
            this.AccountNumber = AccountNumber;
            TotalAccounts++;
        }
        public void DisplayAccountDetails()
        {
            if (this is BankAccountSystem)
            {
                Console.WriteLine(BankName);
                Console.WriteLine("Account Holder Name: " + AccountHolderName);

                Console.WriteLine("Author Number: " + AccountNumber);

            }
            else
            {
                Console.WriteLine("Invalid Account Details!");
            }

        }

    }
    class BankAccount
    {
        static void Main(string[] agrs)
        {
            BankAccountSystem obj1 = new BankAccountSystem("Kashish", "23456789");
            BankAccountSystem obj2 = new BankAccountSystem("Aihwarya", "09876543");

            obj1.DisplayAccountDetails();
            Console.WriteLine();
            obj2.DisplayAccountDetails();
            Console.WriteLine();


            BankAccountSystem.GetTotalAccounts();

        }
    }
}
