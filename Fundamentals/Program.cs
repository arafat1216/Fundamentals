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
            int number1 = int.Parse(Console.ReadLine()); // Converts User Input Into Integer Type
            Console.WriteLine("Enter 2nd Number");
            int number2 = int.Parse(Console.ReadLine()); // Converts User Input Into Integer Type
            var result = Add(number1, number2);

            Console.WriteLine($"SUM of {number1} and {number2} = {result}"); // Prints Result on Console

            

           
            var product = Multiply(number1, number2);

            Console.WriteLine($"PRODUCT of {number1} and {number2} = {product}"); // Prints Product on Console

        }

        //TODO: Change Arguments Type From Integer To Double
        /// <summary>
        ///     Returns sum of two numbers
        /// </summary>
        /// <param name="number1">First non negative integer. </param>
        /// <param name="number2">Second non negative integer.</param>
        /// <returns>return an integer that represents the sum of two given integers.</returns>
        #region Add Two Numbers
        static int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        #endregion




        
        /// <summary>
        ///     Returns product of two numbers
        /// </summary>
        /// <param name="number1">First non negative integer.</param>
        /// <param name="number2">Second non negative integer.</param>
        /// <returns></returns>
        #region Multiply Two Numbers
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        #endregion
    }

}
