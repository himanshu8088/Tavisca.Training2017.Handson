using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    public class Tax
    {
        public static double TaxRate(double amount)
        {
            if (amount < 10000)
                return 5;
            else if (amount >= 10000 && amount <= 100000)
                return 8;
            else
                return 8.5;
        }
    }
}
