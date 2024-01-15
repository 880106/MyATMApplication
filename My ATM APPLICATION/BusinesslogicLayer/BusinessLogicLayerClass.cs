using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using System.Globalization;

namespace BusinessLogicLayer
{
    public class BusinessLogicLayerClass
    {

        DataAccessLayerClass dal = new DataAccessLayerClass();

        public int AddAccount(Accounts account)
        {
            return dal.AddAccount(account);
        }

        public bool ValidateLogin(int accNumber, int pin)
        {
            return dal.ValidateLogin(accNumber, pin);
        }

        public decimal GetBalance(int accNumber)
        {
            return dal.GetBalance(accNumber);
        }
        public bool DepositAmount(int accNumber, decimal depositAmount)
        {
            if (depositAmount <= 0)
                return false;

            // Get the current balance
            decimal currentBalance = dal.GetBalance(accNumber);

            // Call the stored procedure to handle the deposit and update the balance
            if (dal.Deposit(accNumber, depositAmount))
            {
                // Log the deposit transaction
                Transaction depositTransaction = new Transaction
                {
                    AccNumber = accNumber,
                    Description = "Deposit", //adds the text with deposited to the table when ever a user deposit
                    Amount = depositAmount,
                    Date = DateTime.Now
                };

                // Call the method to log the transaction
                return dal.transactions(depositTransaction);
            }
            else
            {
                return false;
            }
        }


        public bool UpdatePin(int accNumber, int newPin)
        {

            int result = dal.UpdatePin(accNumber, newPin);


            return result > 0;
        }
        public bool withDrawal(int accNumber, decimal withDrawAmount)
        {
            return dal.WithDraw(accNumber, withDrawAmount);
        }

        public bool ProcessFastCashTransaction(int accNumber, decimal amount)
        {

            return dal.FastCashProcedure(accNumber, amount);
        }



        public DataTable GetTransactionsByAccNumber1(int accNumber)
        {
            return dal.GetTransactionsByAccNumber(accNumber);
        }


        public bool IsAccountNumberUnique(int accNumber)
        {
            

            // Check if the account number exists in the database
            return !dal.CheckAccountNumberExists(accNumber);
        }
    }
}
