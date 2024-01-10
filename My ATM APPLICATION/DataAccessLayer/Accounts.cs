using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Accounts
    { // Properties
        public int AccNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Pin { get; set; }
        public decimal Balance { get; set; }
        public string Education { get; set; }
        public string Occupation { get; set; }
        public string DOB { get; set; }

        // Default constructor
        public Accounts()
        {
        }

        // Parameterized constructor
        public Accounts(int accNumber, string name, string surname, string address, string phone, int pin, decimal balance, string education, string occupation, string dob)
        {
            AccNumber = accNumber;
            Name = name;
            Surname = surname;
            Address = address;
            Phone = phone;
            Pin = pin;
            Balance = balance;
            Education = education;
            Occupation = occupation;
            DOB = dob;
        }



    }
}
