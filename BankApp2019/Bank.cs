using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BankApp2019
{
    static class Bank
    {
        private static List<Account> accounts = new List<Account>();
        public static Account CreateAccount(string accountName, string emailAddress, TypeOfAccount accountType = TypeOfAccount.Checking, decimal initialDeposit = 0)
        {
            var account = new Account
            {
                AccountName = accountName,
                EmailAddress = emailAddress,
                AccountType = accountType
            };

            if (initialDeposit > 0)
            {
                account.Deposit(initialDeposit);
            }

            accounts.Add(account);
            return account;
        }

        public static IEnumerable<Account> GetAllAccountsByEmailAddress(string emailAddress)
        {
            return accounts.Where(a => a.EmailAddress == emailAddress);
        }
        
    }
}
