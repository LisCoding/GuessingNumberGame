using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void WelcomeMessage() 
        {
           Console.WriteLine("Welcome to guessing number!");
        }
        static string UserInput()
        {
            Console.WriteLine("Guess a number between 1 to 100");
            string userGuess = Console.ReadLine();
            return userGuess;
        }
        static void Results(int number)
        {

        }
        static int RandomNumber()
        {
            return 1; 
        }

    }
}
