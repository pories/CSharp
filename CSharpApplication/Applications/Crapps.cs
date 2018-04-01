using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    public class Crapps
    {
        public static void crappsPlay()
        {
            Console.Clear();
            Random MyDice = new Random();
            bool repeat = true;
            while (repeat)
            {

                Console.WriteLine("Detroit Craps: A game for two players. Two six sided dice are rolled at the same time.");
                Console.WriteLine("Dice Shooter must put down cash, spectators may bet on: pass or no pass, but aren't playing against the house, only each other.");
                Console.WriteLine("To keep it simple the house is always the shooter");
                Console.WriteLine("Shooter rolls a 7 or 11, then they made the pass! Player has to pay their money to the house!");
                Console.WriteLine("Shooter rolls a 2, 3, or 12 don't pass, bets are paid out by the house!");

                try
                {
                    Console.Clear();
                    Console.WriteLine("Each bet is for one dollar only!");
                    Console.Write("How much money do you (the house) have: ");
                    int myCash = int.Parse(Console.ReadLine());
                    Console.Write("How much money does the other player (the shooter) have: ");
                    int TheirMoney = int.Parse(Console.ReadLine());
                    Console.Write("Enter the number of times you want the dice rolled: ");
                    int myNumber = int.Parse(Console.ReadLine());

                    for (int i = 0; i < myNumber; i++)
                    {
                        int mydice1 = MyDice.Next(1, 7);
                        int mydice2 = MyDice.Next(1, 7);

                        if (TheirMoney == 0)
                        {
                            Console.WriteLine("House won!");
                            break;
                        }

                        Console.WriteLine("{0}. Rolls were {1} and {2}!", i + 1, mydice1, mydice2);

                        if (mydice1 + mydice2 == 7)
                        {
                            Console.WriteLine("Made the pass! Bets are matched. House WINS!!");
                            myCash++;                    
                            TheirMoney--;
                            Console.WriteLine("Your money is {0:c} their money is {1:c}!!", myCash, TheirMoney);
                        }
                        else if (mydice1 + mydice2 == 11)
                        {
                            Console.WriteLine("Made the pass! Bets are matched. House WINS!!");
                            myCash++; 
                            TheirMoney--;
                            Console.WriteLine("Your money is {0:c} their money is {1:c}!!", myCash, TheirMoney);

                        }
                        else if (mydice1 + mydice2 == 2)
                        {
                            Console.WriteLine("No pass! House looses.....Bets are paid out!!! ");
                            TheirMoney++;
                            myCash--;
                            Console.WriteLine("Your money is {0:c} their money is {1:c}!!", myCash, TheirMoney);                             
                        }
                        else if (mydice1 + mydice2 == 3)
                        {
                            Console.WriteLine("No pass! House looses.....Bets are paid out!!! ");
                            TheirMoney++;
                            myCash--;
                            Console.WriteLine("Your money is {0:c} their money is {1:c}!!", myCash, TheirMoney);
                        }
                        else if (mydice1 + mydice2 == 12)
                        {
                            Console.WriteLine("No pass! House looses.....Bets are paid out!!! ");
                            TheirMoney++;
                            myCash--;
                            Console.WriteLine("Your money is {0:c} their money is {1:c}!!", myCash, TheirMoney);
                        }

                        else 
                        {
                            Console.WriteLine("Snake eyes!! Craped Out!, no one wins. Keep going!");
                        }

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

