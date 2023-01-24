using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECert_Question_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a South African ID number");
            // read in the ID number from the console.
            var idNumber = Console.ReadLine();
            // instantiate logic class for ID number rules 
            Logic logic = new Logic();
            if (!string.IsNullOrEmpty(idNumber) && logic.IsNumber(idNumber))
            {
                // get date of birth and display to screen
                var dob = logic.GetDateOfBirth(idNumber);
                Console.WriteLine(dob);

                // get gender from id number string and display to screen
                var gender = logic.GetGender(idNumber);
                Console.WriteLine(gender);

                // get citizenship from ID number string
                var citizen = logic.GetCitizenship(idNumber);
                Console.WriteLine(citizen);

                // check if the ID number validates using Luhn algorithm
                var validation = logic.CheckValidation(idNumber);
                Console.WriteLine(validation);
            }
            Console.ReadLine();
        }

        
    }
}
