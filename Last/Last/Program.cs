using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last
{
    internal class Program
    {
        static List<Class1> rutviMistries = new List<Class1>();
        static void Main(string[] args)
        {
            
            // initialize string

            string testString = "21!,#June2,A,01#,12/7/20,#27Watt!,700# I am.";

            // call the method StringCheck

            string modifiedString = StringCheck(testString);

            // remove digits and punctuation from the substring

            string resultString = "";

            for (int i = 0; i < modifiedString.Length; i++)
            {
                if (!char.IsDigit(modifiedString[i]) && !char.IsWhiteSpace(modifiedString[i]))
                {
                    resultString += modifiedString[i];
                }
            }

            // remove digits and punctuation from the resulString and remove extra blank lines from output

            string[] token = resultString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            //to print the tokens without digits

            for (int i = 0; i < token.Length; i++)
            {
                Console.WriteLine(token[i]);
            }

            //Part 2:

            // Take the input from user such as firstname, lastname and phone number

            string firstname, lastname, phoneNumber;

            do
            {
                Console.Write("\nPlease enter your First Name: ");
                firstname = Console.ReadLine();

            } while (string.IsNullOrEmpty(firstname) || firstname.Length <= 3);

            do
            {
                Console.Write("\nPlease enter your Last Name: ");
                lastname = Console.ReadLine();

            } while (string.IsNullOrEmpty(lastname) || lastname.Length <= 3);

            do
            {
                Console.Write("\nPlease enter your Phone Number: ");
                phoneNumber = Console.ReadLine();

            } while (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length != 10);


            //Call the Programdetails methid from RutviMistry class to show the concatenate value

            Class1 newclass = new Class1(firstname,lastname, phoneNumber );
            newclass.ProgramDetails();

            Console.ReadKey();
        }
        //Create a method to remove("/", "!", "#")
        public static string StringCheck(string testString)
        {
            char[] punctuation = { '/', '#', '!' };
            string result = new string(testString.Where(c => !punctuation.Contains(c)).ToArray());
            Console.WriteLine(result);
            return result;
        }
    }
}
