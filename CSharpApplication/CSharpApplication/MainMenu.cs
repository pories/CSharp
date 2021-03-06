﻿using Applications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApplication
{
    public class MainMenu
    {
        public static bool userMainMenu()
        {
            Console.Title = "Fun with C#!";
            Console.Clear();
            Console.WriteLine("Welcome to my fun with console window app!");
            Console.WriteLine("1)  Check the DNS address of any website!");
            Console.WriteLine("2)  Lets play some music!");
            Console.WriteLine("3)  Have your computer speak for you!");
            Console.WriteLine("4)  Find your exact age and your lucky numbers!");
            Console.WriteLine("5)  Guess what number I am thinking of!");
            Console.WriteLine("6)  Play Roulette for fun!");
            Console.WriteLine("7)  Play Craps for fun!");
            Console.WriteLine("8)  Two sum! The array game of fun!");
            Console.WriteLine("9)  Need some dice? Here you go!");
            Console.WriteLine("10) Different types of sorts, find out their sort times!");
            Console.WriteLine("11) Lets play FizzBuzz!");
            Console.WriteLine("12) Sieve of Eratosthenes as a list.");
            Console.WriteLine("13) Nothing here! 13 is Unlucky!!");
            Console.WriteLine("14) Sieve of Eratosthenes as a hash!");
            Console.WriteLine("15) Calculator! That is cool!");
            Console.WriteLine("16) How does the swap method rearrange values?");
            Console.WriteLine("17) ++Variable, or Variable++, what is the difference?");
            Console.WriteLine("18) Lets talk about collections!");
            Console.WriteLine("19) Lets talk about synchronous vs asynchronous!");
            Console.WriteLine("20) MD5 Hash password crack!");
            Console.WriteLine("21) How does temp swap work?");
            Console.WriteLine("Or hit any other key for end program prompt.");
            Console.Write("Choose here: ");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Address.check();
                return true;
            }
            else if (result == "2")
            {
                Music.playMusic();
                return true;
            }
            else if (result == "3")
            {
                Speak.talking();
                return true;
            }
            else if (result == "4")
            {
                Age.agePlay();
                return true;
            }
            else if (result == "5")
            {
                Guessing.guessingPlay();
                return true;
            }
            else if (result == "6")
            {
                Roulette.roulettePlay();
                return true;
            }
            else if (result == "7")
            {
                Crapps.crappsPlay();
                return true;
            }
            else if (result == "8")
            {
                TwoSum.doesitadd();
                return true;
            }
            else if (result == "9")
            {
                Dice.rollem();
                return true;
            }
            else if (result == "10")
            {
                ArraySearch.searchtime();
                return true;
            }
            else if (result == "11")
            {
                Fizz.buzz();
                return true;
            }
            else if (result == "12")
            {
                SieveOfEratosthenesList.PrimesList();
                return true;
            }
            else if (result == "14")
            {
                Sieve_of_EratosthenesHash.primehash();
                return true;
            }
            else if (result == "15")
            {
                calculator.numbers();
                return true;
            }
            else if (result == "16")
            {
                int a = 20;
                int b = 30;
                Swap.SwapNum(ref a, ref b);
                Console.ReadLine();
                return true;
            }
            else if (result == "17")
            {
                AssignmentThenOperation.Execute();
                return true;
            }
            else if (result == "18")
            {
                Collections.Execute();
                return true;
            }
            else if (result == "19")
            {
                SyncVsASync.Execute();
                return true;
            }
            else if (result == "20")
            {
                MD5HashCrack.Execute();
                return true;
            }
            else if (result == "21")
            {
                TempSwap.Execute();
                return true;
            }
            else
            {
                Null.Object();
                return false;
            }

        }
    }
}
