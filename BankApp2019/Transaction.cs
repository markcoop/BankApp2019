﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp2019
{
    public enum TypeOfTransaction
    {
        Credit,
        Debit
    }
    public class Transaction
    {
        public int Id { get; set; }

        public DateTime TransactionDate { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }

        public TypeOfTransaction TransactionType { get; set; }

        public int AccountNumber { get; set; }
        public virtual Account Account { get; set; }

        public decimal Balance { get; set; }
        
    }
}
