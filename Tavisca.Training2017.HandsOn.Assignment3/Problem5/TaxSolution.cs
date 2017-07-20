using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    public class TaxSolution
    {
        double amount;
        public TaxSolution()
        {
            GetAmountFromConsole();
            DisplayTaxableAmount();
        }
        public void GetAmountFromConsole()
        {
            Console.WriteLine("Enter Money Earned:");
            double.TryParse(Console.ReadLine(), out amount);
        }
        public void DisplayTaxableAmount()
        {
            Console.WriteLine("Tax Amount: {0}",ComputeTaxAmount());
        }
        public double ComputeTaxAmount()
        {
            return amount*Tax.TaxRate(amount)/100;
        }
    }
}
