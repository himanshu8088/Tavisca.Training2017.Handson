using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.HandsOn.Assignment3
{

    /*
                                                       Problem Statement 1.
   Write a program to display user’s complete mailing address. Accept user’s name, city, street, pin and house no. and store it in a variable and display it.
   */

    class Solution1
    {
        Address mailingAddress;
        public Solution1()
        {
            mailingAddress = new Address();
        }

        public void InputInformation()
        {            
            mailingAddress.Name = InputType<String>("Enter User Name:");
            mailingAddress.City = InputType<String>("Enter City:");
            mailingAddress.Street = InputType<String>("Enter Street:");
            mailingAddress.Pin = InputType<String>("Pin:");
            mailingAddress.HouseNo = InputType<String>("House No.:");
        }

        public void DisplayMailingAddress()
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
