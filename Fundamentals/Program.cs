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
           while(true)
            {
                Console.WriteLine("Press '+' For Addition\n '-' For Subtraction\n '*' For Multiplication\n '/' For Division\n 'q' For Exit");

                string choice = Console.ReadLine();

                if (choice == "q")
                {
                    break;
                }
                switch(choice)
                {
                    case "+":
                        Add();
                        break;
                    
                    case "-":
                        Sub();
                        break;

                    case "*":
                        Multiply();
                        break;

                    case "/":
                        Divide();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice, Please Try Again");
                        break;
                }
            }
        }
        
        

        static void Add()
        {
            Console.WriteLine("-----ADDITION-----");
            
            Console.WriteLine("Enter 1st Number");
            double number1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter 2nd Number");
            double number2 = int.Parse(Console.ReadLine());
            
            double result = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {result}");
        }

        static void Sub()
        {
            Console.WriteLine("-----SUBTRACT-----");

            Console.WriteLine("Enter 1st Number");
            double number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number");
            double number2 = int.Parse(Console.ReadLine());

            double result = number1 - number2;
            Console.WriteLine($"{number1} - {number2} = {result}");
        }

        static void Multiply()
        {
            Console.WriteLine("-----Multiplication-----");

            Console.WriteLine("Enter 1st Number");
            double number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number");
            double number2 = int.Parse(Console.ReadLine());

            double result = number1 * number2;
            Console.WriteLine($"{number1} X {number2} = {result}");
        }

        static void Divide()
        {
            Console.WriteLine("-----Division-----");

            Console.WriteLine("Enter 1st Number");
            double number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number");
            double number2 = int.Parse(Console.ReadLine());

            double result = number1 / number2;
            Console.WriteLine($"{number1} / {number2} = {result:N2}");
        }
    }
}
