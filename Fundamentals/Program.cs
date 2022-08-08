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
            // Implicit Type Conversion

            byte numberInByte = 250;
            int numberInInt = numberInByte;  // byte to int
            double numberInDouble = numberInInt; // int to double
            Console.WriteLine($"Byte To Int: {numberInInt}");
            Console.WriteLine($"Int To Double: {numberInDouble}");

            // Explicit Type Conversion

            // string to int
            string number1InString = "123";
            int number1InInt = int.Parse(number1InString);
            Console.WriteLine($"String To Int: {number1InInt}");

            // int to string
            int number2InInt = 1234;
            string number2InString = number2InInt.ToString();
            Console.WriteLine($"Int To String: {number2InString}");

            // string to long
            string number3InString = "78654534567";
            long number3InLong = long.Parse(number3InString);
            Console.WriteLine($"String To Long: {number3InLong}");

            // long to string
            long number4InLong = 78898876532;
            string number4InString = number4InLong.ToString();
            Console.WriteLine($"Long To String: {number4InString}");

            // string to double
            string number5InString = "120.5";
            double number5inDouble = double.Parse(number5InString);
            Console.WriteLine($"String To Double: {number5inDouble}");

            // double to string
            double number6InDouble = 33.5;
            string number6InString = number6InDouble.ToString();
            Console.WriteLine($"Double To String: {number6InString}");

            // string to float
            string number7InString = "55.35";
            float number7inFloat = float.Parse(number7InString);
            Console.WriteLine($"String To Float: {number7inFloat}");

            // float to string
            float number8InFloat = 65.135f;
            string number8InString = number8InFloat.ToString();
            Console.WriteLine($"Float To String: {number8InString}");

            // string to bool
            string booleanInString = "false";
            bool stringToBoolean = bool.Parse(booleanInString);
            Console.WriteLine($"String To Boolean: {stringToBoolean}");

            // bool to string
            bool hasAccess = true;
            string booleanToString = hasAccess.ToString();
            Console.WriteLine($"Boolean To String: {booleanToString}");

            // Int To Long
            int number9InInt = 25000;
            long number9InLong = number9InInt;
            Console.WriteLine($"Int To Long: {number9InLong}");

            // Long To Int
            long numberInLong = 78876545;
            int longToInt = Convert.ToInt32(numberInLong);
            Console.WriteLine($"Long To Int: {longToInt}");

            //char to ASCII
            char letter = 'a';
            int charToASCII = (int)letter;
            Console.WriteLine($"Char To ASCII: {charToASCII}");

            // ASCII To Char
            int asciiCode = 65;
            char asciiToChar = (char)asciiCode;
            Console.WriteLine($"ASCII To Char: {asciiToChar}");
        }
    }
}
