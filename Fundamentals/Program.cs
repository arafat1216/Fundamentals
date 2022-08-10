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
            
            for (int i = 1; i <= 100; i++)
            {
                if (i == 95)
                {
                    continue;
                }

                Console.WriteLine(i);
                
                if (i == 99)
                {
                    break;
                }

                
            }
            

        }
    }
}
