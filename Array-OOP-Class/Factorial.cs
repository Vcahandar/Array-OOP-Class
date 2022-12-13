using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_OOP_Class
{
    internal class Factorial
    {
        public Factorial()
        {
            Number();
            static void Number()
            {

                int n = 6;
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }
                Console.WriteLine(fact);
               
            }

        }
    }
}
