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
            int daysSinceLastLoggedIn = 12;
            double interestRate = 1.5;
            float yearsOfExperience = 2.5f;
            long productiveTimeInSeconds = 79349367648374;
            bool isLoggedIn = false;
            char symbol = 'y';
            string name = "Mohammad Arafat Hossain Anik";

            Console.WriteLine($"Type: Int, Value: {daysSinceLastLoggedIn}");
            Console.WriteLine($"Type: Double, Value: {interestRate}");
            Console.WriteLine($"Type: Float, Value: {yearsOfExperience}");
            Console.WriteLine($"Type: Long, Value: {productiveTimeInSeconds}");
          Console.WriteLine($"Type: Boolean, Value: {isLoggedIn}");
            Console.WriteLine($"Type: Char, Value: {symbol}");
            Console.WriteLine($"Type: String, Value: {name}");
        }
    }
}
