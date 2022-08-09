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
            Console.WriteLine("Enter 1st Number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number");
            int number2 = int.Parse(Console.ReadLine());

            int max = number1>number2 ? number1 : number2;

            Console.WriteLine($"Max: {max}");
          
           
        }
    }
}
