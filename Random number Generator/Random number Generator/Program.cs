using System;

namespace Random_number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RandomNumberAC! DO WHAT THE GAME SAYS!!!!");
            Console.WriteLine("PRESS THE KEY *Enter* TO START THE GAME!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();6
            
            Random random = new Random();

            int randomNumber = random.Next(1, 101);                     
            int attempts = 1;
            bool rnum = false;                  

            while (rnum == false)                    
            {
                try
                {
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("Guess a number between 1 and 100:");
                    int guessedNumber = int.Parse(Console.ReadLine());


                    if (guessedNumber > randomNumber && guessedNumber < 101)
                    {
                        attempts++;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Your number is too high! Guess a lower one...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (guessedNumber < randomNumber && guessedNumber > 0)
                    {
                        attempts++;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Your number is too low! Guess a higher one...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else if (guessedNumber == randomNumber)
                    {
                        attempts++;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine("YOU GUESSED THE NUMBER" + " " + guessedNumber + " " + "BOSS, BRAVO!!!!!");
                        Console.WriteLine("You only needed" + " " + attempts + " " + "guesses");
                        
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Press *Enter* to end the game");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        rnum = true;                    
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Guess a number between 1 and 100, not lower or higher!!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    


                    Console.WriteLine();

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    { Console.WriteLine("Invalid input! Write a NUMBER"); }
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }
        }
    }      
 
}
