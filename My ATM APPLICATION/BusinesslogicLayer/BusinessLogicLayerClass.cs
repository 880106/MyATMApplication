using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

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
                    Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
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
        public bool withDrawal(int accNumber, decimal withDrawAmount, out string status)
        {
            // Initialize status variable

            if (withDrawAmount <= 0)
            {
                status = "Invalid withdrawal amount";
                return false;
            }

            // Get the current balance
            decimal currentBalance = dal.GetBalance(accNumber);

            // Check if the withdrawal amount is greater than the current balance
            if (withDrawAmount > currentBalance)
            {
                status = "Insufficient funds for withdrawal";
                return false;
            }

            // Update the balance in the database
            if (dal.WithDraw(accNumber, withDrawAmount))
            {
                // Log the withdrawal transaction
                Transaction withdrawalTransaction = new Transaction
                {
                    AccNumber = accNumber,
                    Description = "Withdrawal", // adds the text withdrawal to the table when ever a user withdraws
                    Amount = withDrawAmount,
                    Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                };

                if (dal.transactions(withdrawalTransaction))
                {
                    // Set status to success
                    status = "Withdrawal successful";
                    return true;
                }
                else
                {
                    // Set status to transaction logging failure
                    status = "Failed to log withdrawal transaction";
                    return false;
                }
            }
            else
            {
                // Set status to database update failure
                status = "Failed to update balance";
                return false;
            }
        }

        public DataTable GetTransactionsByAccNumber1(int accNumber)
        {
            return dal.GetTransactionsByAccNumber(accNumber);
        }
    }
}
