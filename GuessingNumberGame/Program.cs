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
            WelcomeMessage();
            //gerating a random number using the Random Class
            Random random = new Random();
            int secretNumber = random.Next(1, 100);
            Results(secretNumber);
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
            bool guess = false;
         
            while(guess == false)
            {
                int userGuess = Int32.Parse(UserInput());    
                if (number == userGuess)
                {
                    Console.WriteLine("hey you are genious, you guess the right number");
                    guess = true;
                    Console.ReadLine();
                }
                else if (number > userGuess)
                {
                    Console.WriteLine("too low, try again");               
                }
                else
                {
                    Console.WriteLine("too High, try again");
                }

            }
         
        }

    }
}
