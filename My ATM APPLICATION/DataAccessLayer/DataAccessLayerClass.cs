using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataAccessLayerClass
    {

        static string connString = "Data Source=APHELELE;Initial Catalog=ATMDB;Integrated Security=True";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand command;
        SqlDataAdapter dbAdapter;
        DataTable dt;
        // inserting a user to the database
        public int AddAccount(Accounts account)
        {
            dbConn.Open();

            command = new SqlCommand("sp_AddAccount", dbConn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@AccNumber", account.AccNumber);
            command.Parameters.AddWithValue("@Name", account.Name);
            command.Parameters.AddWithValue("@Surname", account.Surname);
            command.Parameters.AddWithValue("@Address", account.Address);
            command.Parameters.AddWithValue("@Phone", account.Phone);
            command.Parameters.AddWithValue("@Pin", account.Pin);
            command.Parameters.AddWithValue("@Balance", account.Balance);
            command.Parameters.AddWithValue("@Education", account.Education);
            command.Parameters.AddWithValue("@Occupation", account.Occupation);
            command.Parameters.AddWithValue("@DOB", account.DOB);

            int x = command.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public bool ValidateLogin(int accNumber, int pin)
        {
            dbConn.Open();

            command = new SqlCommand("sp_Login", dbConn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@AccNumber", accNumber);
            command.Parameters.AddWithValue("@Pin", pin);

            SqlDataReader reader = command.ExecuteReader();

            bool loginSuccess = reader.HasRows;

            reader.Close();
            dbConn.Close();

            return loginSuccess;
        }

        public decimal GetBalance(int accNumber)
        {
            decimal balance = 0;

            try
            {
                // Assuming dbConn is a SqlConnection object declared and initialized elsewhere in your code
                if (dbConn.State == ConnectionState.Closed)
                {
                    dbConn.Open();
                }

                using (command = new SqlCommand("sp_GetBalance", dbConn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccNumber", accNumber);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            balance = reader.GetDecimal(reader.GetOrdinal("Balance"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately, e.g., log the error
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (dbConn.State == ConnectionState.Open)
                {
                    dbConn.Close();
                }
            }

            return balance;
        }

        public bool Deposit(int accNumber, decimal amount)
        {
            dbConn.Open();

            command = new SqlCommand("sp_Deposit", dbConn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@AccNumber", accNumber);
            command.Parameters.AddWithValue("@Amount", amount);

            // Execute the update procedure
            int result = command.ExecuteNonQuery();

            dbConn.Close();

            // Return true if the update was successful, false otherwise
            return result > 0;
        }

        public int UpdatePin(int accNumber, int newPin)
        {
            dbConn.Open();

            command = new SqlCommand("sp_UpdatePin", dbConn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@AccNumber", accNumber);
            command.Parameters.AddWithValue("@NewPin", newPin);

            int result = command.ExecuteNonQuery();

            dbConn.Close();

            return result;
        }

        public bool WithDraw(int accNumber, decimal amount)
        {
            dbConn.Open();

            command = new SqlCommand("sp_WithDraw", dbConn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@AccNumber", accNumber);
            command.Parameters.AddWithValue("@Amount", amount);

            // Execute the update procedure
            int result = command.ExecuteNonQuery();

            dbConn.Close();

            // Return true if the update was successful, false otherwise
            return result > 0;
        }

        public bool FastCashProcedure(int accNumber, decimal amount)
        {

            dbConn.Open();

            SqlCommand command = new SqlCommand("sp_FastCash", dbConn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@AccNumber", accNumber);
            command.Parameters.AddWithValue("@Amount", amount);
           

            int result = command.ExecuteNonQuery();
            dbConn.Close();
            return result > 0;

        }

        public bool transactions(Transaction transaction)
        {
            // Assume your connection and command objects are set up
            dbConn.Open();

            command = new SqlCommand("sp_InsertTransaction", dbConn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@AccNumber", transaction.AccNumber);
            command.Parameters.AddWithValue("@Description", transaction.Description);
            command.Parameters.AddWithValue("@Amount", transaction.Amount);
            command.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            // Execute the stored procedure
            int result = command.ExecuteNonQuery();

            dbConn.Close();

            // Return true if the update was successful, false otherwise
            return result > 0;
        }
        public DataTable GetTransactionsByAccNumber(int accNumber)
        {
            DataTable transactionTable = new DataTable();

            try
            {
                dbConn.Open();

                command = new SqlCommand("sp_GetTransactionsByAccNumbers", dbConn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@AccNumber", accNumber);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(transactionTable);
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (e.g., log or throw)
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dbConn.Close();
            }

            return transactionTable;
        }

        public bool CheckAccountNumberExists(int accNumber)
        {

            dbConn.Open();
            SqlCommand command = new SqlCommand("sp_CheckAccountNumberExists", dbConn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@AccNumber", accNumber);

            int result = Convert.ToInt32(command.ExecuteScalar());
            dbConn.Close();
            return result == 1;

        }
    }
}