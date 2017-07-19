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
            mailingAddress.Name = InputType<String>("Enter User Name:");
            mailingAddress.City = InputType<String>("Enter City:");
            mailingAddress.Street = InputType<String>("Enter Street:");
            mailingAddress.Pin = InputType<String>("Pin:");
            mailingAddress.HouseNo = InputType<String>("House No.:");
        }

        private void DisplayMailingAddress()
        {
            InputType<String>(mailingAddress.ToString());
        }

        private string InputType<T>(T type)
        {
            Console.WriteLine("\n"+type);
            return Console.ReadLine();
        }    
    }
}
