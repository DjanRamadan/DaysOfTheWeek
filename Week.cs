using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week
{
    internal class Week
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a day (Please pick a number 1-7!):");
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day = int.Parse(Console.ReadLine());

            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(days[day - 1]);
            }
            else
                Console.WriteLine("Invalid Day");
        }
    }
}
