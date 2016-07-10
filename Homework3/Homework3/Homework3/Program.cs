using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your seconds: ");
            String strSec = Console.ReadLine();
            int intSec = int.Parse(strSec);
            int min = intSec / 60;
            intSec = intSec % 60;
            int hour = min / 60;
            min = min % 60;
            int day = hour / 24;
            hour = hour % 24;
            if (day > 0)
            {
                Console.Write(day + " day(s) ");
            }
            if (hour > 0)
            {
                Console.Write(hour + " hour(s) ");
            }
            if (min > 0)
            {
                Console.Write(min + " minute(s) ");
            }
            if (intSec > 0)
            {
                Console.Write(intSec + " second(s)");
            }
            Console.ReadLine();
        }
    }
}
