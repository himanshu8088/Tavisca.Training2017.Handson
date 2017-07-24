using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace StudentRecord
{
   public class Validation
    {
        public static bool IsValidLetter(string strLetter)
        {
            if (!Regex.IsMatch(strLetter, "^[A-Z][a-zA-Z]*$"))                            
                return false;            
            return true;
        }        
        public static bool IsValidNumber(long number)
        {
            if (!Regex.IsMatch(number.ToString(), "^[0-9]{10}$"))
                return false;
            return true;
        }       
        public static bool IsValidEmail(string email)
        {
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-z]{2,3}$"))
                return false;
            return true;
        }
    }
}
