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
            int number1 = 10, number2 = 3;

            int sum = number1 + number2;
            int sub = number1 - number2;
            int product = number1 * number2;
            double division = (double)number1/number2;
            int remainder = number1 % number2;
            var bitWiseOR = number1 | number2;
            var bitWiseAND = number1 % number2;
            var bitWiseXOR = number1 ^ number2;

            Console.WriteLine($"{number1} + {number2} = {sum}");
            Console.WriteLine($"{number1} - {number2} = {sub}");
            Console.WriteLine($"{number1} * {number2} = {product}");
            Console.WriteLine($"{number1} / {number2} = {division:N2}");
            Console.WriteLine($"{number1} % {number2} = {remainder}");
            Console.WriteLine($"{number1} | {number2} = {bitWiseOR}");
            Console.WriteLine($"{number1} & {number2} = {bitWiseAND}");
            Console.WriteLine($"{number1} ^ {number2} = {bitWiseXOR}");
        }
    }
}
