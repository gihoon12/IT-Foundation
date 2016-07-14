using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            String strnum = Console.ReadLine();
            int num = int.Parse(strnum);
            int x = 1;
            if (num > 0)
            {
                while (x <= num)
                {
                    int value = 1;
                    for (int y = x; y > 0; y--)
                    {
                        value = value * y;
                    }
                    Console.WriteLine("{0}!  =   {1}", x, value);
                    x++;
                }
            }
            else
            {
                Console.WriteLine("0!  = 0");
            }
            Console.ReadLine();
        }
    }
}