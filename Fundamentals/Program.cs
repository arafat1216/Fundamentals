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
            Console.WriteLine("Enter Marks Between 0 And 100");           
            double marks = double.Parse(Console.ReadLine());
            string grade;

            if(marks >= 80 && marks<=100)
            {
                grade = "A+";
            }
            else if(marks >= 70 && marks <=79)
            {
                grade = "A";
            }
            else if(marks >= 60 && marks <=69)
            {
                grade ="A-";
            }
            else if (marks >= 50 && marks <= 59)
            {
                grade = "B";
            }
            else if (marks >= 40 && marks <= 49)
            {
                grade = "C";
            }
            else if (marks >= 33 && marks <= 39)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }
            Console.WriteLine($"Grade: {grade}");
        }
    }
}
