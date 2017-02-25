using MathMagician.Numbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician
{
    class Program
    {

        static void Main(string[] args)
        {
            string prompt = ">"; //prompt for user to input choice
            Console.WriteLine("What would you like for me to do?");
            Console.WriteLine("I can print the following number types: natural, even, odd, or fibonacci."); //user enters choice.
            Console.Write(prompt);
            //Prompt for user
            string command = Console.ReadLine().ToLower(); //converts string to lowercase to prevent casing errors during user input

            if (command == "even" || command == "odd" || command == "natural" || command == "fibonacci")
            {
                Console.WriteLine("How many should I print?");
                Console.Write(prompt); //Another prompt.
            }
            else
            {
                Console.WriteLine("I'm sorry, that's not a number type I recognize. Press any key to exit."); //Displays message to user
                Console.ReadKey();
                Environment.Exit(0);
            }
           

            int how_many = Convert.ToInt32(Console.ReadLine());
            //converts input to an int
            if (how_many <= 0 || how_many > 30) //evaluates if input is between 1 and 30
            {
                Console.WriteLine("I'm sorry, I can only print between 1 and 30 numbers. Press any key to exit."); //Displays message to user
                Console.ReadKey();
                Environment.Exit(0);
            }
           



            Console.WriteLine($"Cool, I'm going to print {how_many} {command} numbers.");
            //Okay, print some stuff. 

            if (command == "natural")
            {
                NaturalNumber naturalNumber = new NaturalNumber();
                Console.WriteLine(naturalNumber.PrintNumbers(naturalNumber.GetSequence(how_many)));  
                    
            }
            else if (command == "even")
            {
                Even even = new Even();
                Console.WriteLine(even.PrintNumbers(even.GetSequence(how_many)));
            }
            else if (command == "odd")
            {
                Odd odd = new Odd();
                Console.WriteLine(odd.PrintNumbers(odd.GetSequence(how_many)));
            }
            else if (command == "fibonacci")
            {
                Fibonacci fibonacci = new Fibonacci();
                Console.WriteLine(fibonacci.PrintNumbers(fibonacci.GetSequence(how_many)));
                //Console.WriteLine("Well, this is awkward.  I'm not quite ready for public viewing yet.");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
