using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp2019
{

    enum TypeOfAccount
    {
        Checking,
        Savings,
        CD,
        Loan
    }


    /// <summary>
    /// This is the definition
    /// of an account for a bank
    /// </summary>
    class Account
    {
        private static int lastAccountNumber = 0;

        #region Properties
        /// <summary>
        /// Name of the account
        /// </summary>
        public String AccountName { get; set; }

        public decimal Balance { get; private set; }

        public string EmailAddress { get; set; }

        public TypeOfAccount AccountType { get; set; }

        public int AccountNumber { get; private set; }

        public DateTime CreatedDate { get; private set; }
        #endregion

        #region Methods

        public void Deposit(decimal amount)
        {
            Balance += amount;
            //Balance = Balance + amount
        }

        /// <summary>
        /// Withdraw money from yor account
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>New Balance</returns>
        public decimal Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }

        #endregion


        #region Constructor

        public Account()
        {
            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.Now;
        }

        #endregion
    }
}
