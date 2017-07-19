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
        public String Pin { get; set; }
        public String HouseNo { get; set; }

        public override string ToString()
        {
            return "Mailing Address:\n"+Name+",\n"+HouseNo+",\n"+Street+ ",\n"+City+ ",\n" + Pin;
        }        
    }    

}
