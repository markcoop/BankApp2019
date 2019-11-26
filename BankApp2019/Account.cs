using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp2019
{

    public enum TypeOfAccount
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
    public class Account
    {

        #region Properties
        /// <summary>
        /// Name of the account
        /// </summary>
        public String AccountName { get; set; }
        public decimal Balance { get; set; }
        public string EmailAddress { get; set; }
        public TypeOfAccount AccountType { get; set; }
        public int AccountNumber { get; set; }
        public DateTime CreatedDate { get; set; }
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
            CreatedDate = DateTime.Now;
        }

        #endregion
    }
}
