using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLoop2
{
    class FruitLoop2
    {
        static void Main(string[] args)
        {
            //Declare and initialize an array of any six fruit names (as text). 
            //Set up a FOR loop and iterate through them (displaying each value in the console.)

            //Declares and Initializes an array called FRUITS with 6 string values.
            string[] fruits = { "Apple", "Pear", "Banana", "Peach", "Orange", "Strawberry" };
            string[] period = { "", ".", "..", "...", "....", "....." };

            for (int i = 0; i <= fruits.Length - 1; i++)
            {
                Console.WriteLine(fruits[i]);
                Console.WriteLine(period[i]);
            }
        }
    }
}
