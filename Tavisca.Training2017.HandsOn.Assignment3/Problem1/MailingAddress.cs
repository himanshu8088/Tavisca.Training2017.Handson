using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{

    /*
                                                       Problem Statement 1.
   Write a program to display user’s complete mailing address. Accept user’s name, city, street, pin and house no. and store it in a variable and display it.
   */

    public class MailingAddress
    {
        private Address mailingAddress;
        public MailingAddress()
        {
            mailingAddress = new Address();
            InputInformation();
            DisplayMailingAddress();
        }

        private void InputInformation()
        {            
            mailingAddress.Name = GetConsoleInput("Enter User Name:");
            mailingAddress.City = GetConsoleInput("Enter City:");
            mailingAddress.Street = GetConsoleInput("Enter Street:");
            mailingAddress.PinCode = GetConsoleInput("Pin:");
            mailingAddress.HouseNumber = GetConsoleInput("House Number:");
        }
        private void DisplayMailingAddress()
        {
            GetConsoleInput(mailingAddress.ToString());
        }
        private string GetConsoleInput(string info)
        {
            Console.WriteLine("\n"+info);
            return Console.ReadLine();
        }    
    }
}
