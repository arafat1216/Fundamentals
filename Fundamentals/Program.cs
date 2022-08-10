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
            Console.WriteLine("Enter A Number");
            int number = int.Parse(Console.ReadLine());

            
            SumofDigits(number);
        }

        /// <summary>
        ///     Returns Sum of Digits of A Given Number.
        /// </summary>
        /// <param name="number"> Takes An Integer. </param>
        static void SumofDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine($"SUM OF Digits: {sum}");
        }
    }
}
