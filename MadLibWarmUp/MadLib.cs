using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class Program
    {
        static void madlib(string[] args)
        {
            //Create a "mad lib" that asks the user for various pieces of information. Store the information as strings. 
            //Once they information has been collected, output a story using the stored information

            //Introduction strings
            Console.WriteLine("MAD LIBS");
            Console.WriteLine("CALLING CUSTOMER\nSERVICE SUPPORT");

            Console.WriteLine("Please give me a number (1-9");
            string number1 = Console.ReadLine();
            Console.WriteLine("Please give me another number (1-9");
            string number2 = Console.ReadLine();
            Console.WriteLine("Please give me a final number (1-9");
            string number3 = Console.ReadLine();
            Console.WriteLine("Please give me a verb");
            string verb1 = Console.ReadLine();
            Console.WriteLine("Please give me another verb");
            string verb2 = Console.ReadLine();
            Console.WriteLine("Please give me one more verb");
            string verb3 = Console.ReadLine();
            Console.WriteLine("Please give me the lyrics to a song (just a few words)");
            string lyricsToSong = Console.ReadLine();
            Console.WriteLine("Please give me a noun");
            string noun1 = Console.ReadLine();
            Console.WriteLine("Please give me a final verb");
            string verb4 = Console.ReadLine();
            Console.WriteLine("Please give me a first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please give me another noun");
            string noun2 = Console.ReadLine();
            Console.WriteLine("Please give me an adejective");
            string adjective = Console.ReadLine();



            //Outputs the madlib with the captured input from the user
            Console.WriteLine($"[Press {number1}] [Press{number2}] [Press {number3}]\n" +
                $"Hi, I'm {verb1} about the {verb2}. Sure, I'll {verb3}.\n" +
                $"{lyricsToSong}. Hello, I'm calling about the {noun1}. Yes, I can\n" +
                $"{verb4}. {lyricsToSong}." +
                $"Sorry. {firstName}, I didn't realize the music has stopped playing. \n" +
                $"No, I haven't tried turning the {noun2} off and turning it back on again. \n" +
                $"I'll give it a try but--well, that was {adjective} ");
        }
    }
}
