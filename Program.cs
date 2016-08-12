using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_days_of_age
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("your date of birth is ");
            DateTime dob = new DateTime(1992, 07, 29);
            DateTime today = DateTime.Today;
            TimeSpan ts = today.Subtract(dob);
            int totalDays = (int)Math.Ceiling(ts.TotalDays);
            int years = Convert.ToInt32(totalDays / 365.25);
            int months = (int)((totalDays % 365.25) / 30);
            int remainingdays = (int)((totalDays % 365.25) % 30);
            Console.WriteLine("years = {0} , months = {1} , days = {2}", years, months, remainingdays);
           
            Console.ReadLine();
        }
    }
}
