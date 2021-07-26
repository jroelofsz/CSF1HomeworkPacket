using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declares and initializes variables to store the fibonacci numbers
            int previousNbr = 0;
            int nextNbr = 1;
            int currentNbr = 0;
            //Collects input from user and goes until that number has been reached (or gotten close to) using the fibonacci sequence.
            Console.WriteLine("What number would you like the fibonacci sequence to go to? ");
            int userNumber = int.Parse(Console.ReadLine());
            Console.Write("{0} \n{1}\n", previousNbr, nextNbr);
            while (userNumber > currentNbr)
            {
                currentNbr = previousNbr + nextNbr;
                Console.WriteLine("{0}", currentNbr);
                previousNbr = nextNbr;
                nextNbr = currentNbr;
            }
        }
    }
}
