using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    public class Dice
    {
        public static void rollem()
        {
            Console.Clear();
            bool repeat = true;
            Random myRandom = new Random();
            Console.Clear();
            Console.WriteLine("Need some dice? 20 is the max according to wiki, but that doesn't sound right.");
            while (repeat)
            {
                Console.Write("How many sides do you want on the dice: ");
                try
                {

                    int myInt = int.Parse(Console.ReadLine());
                    if (myInt >= 3 && myInt <= 20)
                    {
                        Console.Write("How many times do you want to roll: ");
                        int numberOfRolls = int.Parse(Console.ReadLine());
                        for (int i = 1; i < numberOfRolls + 1; i++)
                        {
                            int myRoll = myRandom.Next(1, myInt);
                            string result = myRoll.ToString();
                            Console.WriteLine($"{i}) Dice roll is: {result}!");
                            System.Threading.Thread.Sleep(3); 
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dice must have between 3-20 sides. ");
                    }
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
                    Console.Clear();
                }
                else
                {
                    repeat = false;
                }
            }

        }
    }
}
