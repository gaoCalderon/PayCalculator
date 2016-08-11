using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double gross;
            double hours;
            double wage;

            Console.WriteLine("Enter hours worked: ");
            string hoursWorked = Console.ReadLine();
            Console.WriteLine("Enter hourly wage ");
            string hourlyWage = Console.ReadLine();

            hours = Double.Parse(hoursWorked);
            wage = Double.Parse(hourlyWage);
            gross = wage * hours;
            Console.WriteLine("total amount gross: " + gross);
            Console.ReadLine();
        }
    }
}
