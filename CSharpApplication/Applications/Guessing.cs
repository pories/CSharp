using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    public class Guessing
    {
        public static void guessingPlay()
        {
            Console.Clear();
            bool repeat = true;
            Random myRandom = new Random();
            while (repeat)
            {
                try
                {
                    Console.Clear();
                    int randomNumber = myRandom.Next(1, 11);
                    int guess = 0;
                    bool incorrect = true;
                    Console.WriteLine("The Guessing Game!");
                    Console.Write("Guess a number between 1-10: ");
                    do
                    {
                        int result = int.Parse(Console.ReadLine());
                        guess++;
                        if (result == randomNumber)
                            incorrect = false;
                        else Console.Write("Wrong, guess again: ");
                    } while (incorrect == true);
                    Console.WriteLine("Correct");
                    Console.WriteLine("It took you {0} guesses.", guess);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Did you not put numbers in? The program will only accept numbers.");
                    Console.WriteLine("Here is what went wrong.");
                    Console.WriteLine(ex);
                }
                Console.WriteLine("Done reading? Hit any key!");
                Console.ReadKey(true);
                Console.Write("Go again? Y/N: ");
                string go = Console.ReadLine();
                if (go == "Y" || go == "y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
            }
        }
    }
}