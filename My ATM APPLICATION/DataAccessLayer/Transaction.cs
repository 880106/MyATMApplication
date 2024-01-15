using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Transaction
    {
        // Properties
        public int TransactionID { get; set; }
        public int AccNumber { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        // Default constructor
        public Transaction()
        {
        }

        // Parameterized constructor
        public Transaction(int transactionID, int accNumber, string description, decimal amount, DateTime date)
        {
            TransactionID = transactionID;
            AccNumber = accNumber;
            Description = description;
            Amount = amount;
            Date = date;
        }

        // Additional constructor if you want to create a Transaction without TransactionID
        public Transaction(int accNumber, string description, decimal amount, DateTime date)
        {
            AccNumber = accNumber;
            Description = description;
            Amount = amount;
            Date = date;
        }
    }
}
