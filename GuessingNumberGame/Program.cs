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

        public void WelcomeMessage() 
        {
           Console.WriteLine("Welcome to guessing number!");
        }
        public string UserInput()
        {
            Console.WriteLine("Guess a number between 1 to 100");
            string userGuess = Console.ReadLine();
            return userGuess;
        }
        public void Results(int number)
        {

        }
        public int RandomNumber()
        {
            return 1; 
        }

    }
}
