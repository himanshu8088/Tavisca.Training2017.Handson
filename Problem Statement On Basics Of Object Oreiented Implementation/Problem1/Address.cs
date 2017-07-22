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
    public class Address
    {
        public String Name { get; set; }
        public String City { get; set; }
        public String Street { get; set; }
        public String PinCode { get; set; }
        public String HouseNumber { get; set; }

        public override string ToString()
        {
            return string.Format("Mailing Address:\n{0}\n{1}\n{2}\n{3}\n{4}",Name,HouseNumber,Street,City,PinCode);         
        }        
    }    

}
