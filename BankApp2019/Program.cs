using System;

namespace BankApp2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Welcome the Bank **********");

            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create a new account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdrawl");
                Console.WriteLine("4. Display all accounts");


                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting the Bank.");
                        return;
                    case "1":
                        Console.Write("Enter your Email Address: ");
                        var email = Console.ReadLine();
                        Console.Write("Enter the desired account name: ");
                        var accountName = Console.ReadLine();
                        Console.WriteLine("Account Type: ");
                        var accountTypes = Enum.GetNames(typeof(TypeOfAccount));
                        for (var i = 0; i < accountTypes.Length; i++)
                        {
                            Console.WriteLine($"{i}. {accountTypes[i]}");
                        }
                        var accountType = Enum.Parse<TypeOfAccount>(Console.ReadLine());
                        var account = Bank.CreateAccount(accountName, email, accountType);
                        Console.WriteLine($"Account Number: {account.AccountNumber}, Account Name: {account.AccountName}, Email: {account.EmailAddress}, Account type: {account.AccountType}, Account Balance: {account.Balance:C}, Created Date: {account.CreatedDate}");
                        break;
                    case "2":
                        PrintAllAccounts();
                        Console.Write("Account Number: ");
                        var accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Amount to deposit: ");
                        var amount = Convert.ToDecimal(Console.ReadLine());
                        Bank.Deposit(accountNumber, amount);
                        Console.WriteLine("Deposit completed successfully!");


                        break;
                    case "3":
                        PrintAllAccounts();
                        Console.Write("Account Number: ");
                        accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Amount to withdraw: ");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        Bank.Withdraw(accountNumber, amount);
                        Console.WriteLine("Withdrawl completed successfully!");

                        break;
                    case "4":
                        PrintAllAccounts();

                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please use a number and try again.");
                        break;
                }
            }
        }

        private static void PrintAllAccounts()
        {
            
            Console.Write("Enter your Email Address: ");
            var email = Console.ReadLine();

            var accounts = Bank.GetAllAccountsByEmailAddress(email);
            foreach (var myAccount in accounts)
            {
                Console.WriteLine($"Account Number: {myAccount.AccountNumber}, Account Name: {myAccount.AccountName}, Email: {myAccount.EmailAddress}, Account type: {myAccount.AccountType}, Account Balance: {myAccount.Balance:C}, Created Date: {myAccount.CreatedDate}");
            }

            
        }
    }
}
