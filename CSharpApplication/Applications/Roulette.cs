using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    public class Roulette
    {

        public static void roulettePlay()
        { 
            Console.Clear();
            bool repeat = true;
            Random myRandom = new Random();
            while (repeat)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Want to play Roulette?");                   
                    Console.Write("Enter a whole number to bet on: 0 - 37: ");
                    string bet = Console.ReadLine();
                    int bet2 = int.Parse(bet);
                    if (bet2 >= 0 && bet2 <= 37)
                    {
                        string color;
                        int myint = myRandom.Next(0, 37); 
                        if (myint % 2 == 0)
                        {
                            Console.WriteLine("Roulette roll is: {0}, which is black.", myint.ToString());
                            color = "black";
                        }
                        else if (myint % 3 == 0 || myint == 5 || myint == 7 || myint == 11 || myint == 13 || myint == 17 || myint == 19 || myint == 23 || myint == 29 || myint == 31 || myint == 37)
                        {
                            Console.WriteLine("Roulette roll is: {0}, which is red", myint.ToString());
                            color = "Red";
                        }

                        else if (myint == 0 || myint == 37)
                        {
                            Console.WriteLine("Roulette roll is: {0}, which is green!", myint.ToString());
                            color = "Green";
                        }
                        else
                        {
                            Console.WriteLine("Roulette roll is: {0}, which is Red", myint.ToString());
                            color = "Red";
                        }
                        if (myint == bet2)
                        {
                            Console.WriteLine("You won!!");
                            Console.WriteLine("{0} pays out", color);
                        }
                        else
                        {
                            Console.WriteLine("You lost. ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Bet must be between 0 and 37. ");
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
                }
                else
                {
                    repeat = false;
                }

            }

        }
    }
}