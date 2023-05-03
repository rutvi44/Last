using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last
{
    internal class Class1
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;

        //Default Constructor
        public Class1()
        {
            firstName = "John";
            lastName = "Brown";
            phoneNumber = "5192223333";
        }

        //Overloaded Constructor
        public Class1(string firstName, string lastName, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
        }

        // created a method to show concatenate value
        public void ProgramDetails()
        {
            string concatenateName, concatenateValue;

            concatenateName = firstName.Substring(0, 1) + lastName;

            concatenateValue = concatenateName + "-" + phoneNumber;

            Console.WriteLine($"\nConcatenate Value: {concatenateValue}");

        }
    }
}
