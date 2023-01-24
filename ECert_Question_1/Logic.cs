using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECert_Question_1
{
    public  class Logic
    {
        public string GetDateOfBirth(string idNumber)
        {
            //fetch date of birth from ID number string
            var dob = idNumber.Substring(0, 6);
            // write it out to console
            return $"The date of birth is: {dob.ToString()}";
        }

        public string GetGender(string idNumber)
        {
            //fetch next 4 digits from ID number string to determine gender
            int genderDigits = int.Parse(idNumber.Substring(6, 4));
            var gender = string.Empty;

            // check if between range for female
            if (genderDigits >= 0000 && genderDigits <= 4999)
            {
                gender = "female";
            }
            // check if between range for male
            else if (genderDigits >= 5000 && genderDigits <= 9999)
            {
                gender = "male";
            }

            // write it out to console
            if (string.IsNullOrEmpty(gender))
            {
                return "The gender cannot be determined.";
            }
            else
            {
                return $"The gender is: {gender}";
            }
        }

        public string GetCitizenship(string idNumber)
        {
            //fetch citizen digit from ID number string
            int cDigit = int.Parse(idNumber.Substring(10, 1));
            // write it out to console
            if (cDigit == 0)
            {
                return "This is a South African citizen.";
            }
            else if (cDigit == 1)
            {
                return "This is a Foreign citizen.";
            }
            else
            {
                return "Citizenship cannot be determined";
            }
        }

        public string CheckValidation(string idNumber)
        {
            //fetch citizen digit from ID number string
            //var validationDigits = idNumber.Substring(11, 2);
            //Console.WriteLine($"Checksum digits: {validationDigits}");

            // validate entire ID number using Luhn algorithm 
            LuhnHelper luhnHelper = new LuhnHelper();
            var pass = luhnHelper.LuhnCheck(idNumber);

            // write it out to console
            if (pass)
            {
                return "The ID Number passes validation";
            }
            else
            {
                return "The ID Number does not pass validation";
            }
        }

        public bool IsNumber(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return s.Any();
        }
    }
}
