using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Priscilla", 10000);
            Console.WriteLine(
                $"Account {account.Number} was created for {account.Owner} with {account.Balance}"
                );

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine($"Account balance is {account.Balance}");

            account.MakeWithdrawal(300, DateTime.Now, "Hair");
            Console.WriteLine($"Account balance is {account.Balance}");


            // test for a negative balance

            try
            {
                account.MakeWithdrawal(75000, DateTime.Now, "Negative deposit");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }
            

            // test that initial balance is positive
            try
            {
                var invalidAccount = new BankAccount("invalid", -499);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }
            
        }
    }
}