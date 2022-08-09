using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Year");
            int year = int.Parse(Console.ReadLine());

            if(year%400==0)
            {
                Console.WriteLine($"{year} Is A Leap Year");
            }
            else if(year%100==0)
            {
                Console.WriteLine($"{year} Is Not A Leap Year");
            }
            else if(year%4==0)
            {
                Console.WriteLine($"{year} Is A Leap Year");
            }
            else
            {
                Console.WriteLine($"{year} Is Not A Leap Year");
            }
        }
    }
}
