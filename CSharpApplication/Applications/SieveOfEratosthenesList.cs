using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    public class SieveOfEratosthenesList
    {
        public static void PrimesList()
        {
            Console.Clear();
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Welcome to the Sieve of Eratosthenes as a list function.");
                Console.WriteLine("A way to find all the primes below any number.");
                try
                {
                    Console.Write("Please imput a whole postive number: ");
                    int userinput = int.Parse(Console.ReadLine());

                    List<int> NoPrime = new List<int>();

                    for (int x = 2; x < userinput; x++)
                    {
                        for (int y = x * 2; y < userinput; y = y + x)
                        {
                            if (!NoPrime.Contains(y))
                            {
                                NoPrime.Add(y);
                            }
                        }
                    }

                    for (int z = 2; z < userinput; z++)
                    {
                        if (!NoPrime.Contains(z))
                        {
                            Console.WriteLine(z);
                        }
                    }

                }

                catch (Exception ex)
                {
                    Console.WriteLine("Well that didn't go well, here is what went wrong.");
                    Console.WriteLine(ex);
                    Console.WriteLine("Hit any key to continue.");
                    Console.ReadKey(true);
                }

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