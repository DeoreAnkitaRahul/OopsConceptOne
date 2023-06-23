using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptHm
{
   public class Overloading
    {
       public void Totalsum(int a, int b)
        {
            Console.WriteLine("The sum of numbers is " +(a + b));
        }

        public void Totalsum(double a, double b)
        {
            Console.WriteLine("The sum of numbers is " +(a + b));
        }
    }
}
