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
            int number = int.MaxValue;

            try
            {
                checked
                {
                    number = number * 100;
                }
            }
            catch (OverflowException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
