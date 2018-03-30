using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    public class Sieve_of_EratosthenesHash
    {
        public static void primehash()
        {
            Console.Clear();
            bool repeat = true;
            while (repeat)
            {

                Console.WriteLine("Welcome to the Sieve of Eratosthenes as a hash function.");
                Console.WriteLine("A way to find all the primes below any number.");
                try
                {
                    Console.Write("Please imput a whole postive number: ");
                    int userimput = int.Parse(Console.ReadLine());
                    HashSet<int> NoPrime = new HashSet<int>();
                    long count = 0;
                    int n = userimput;
                    for (int x = 2; x < n; x++)
                    {
                        for (int y = x * 2; y < n; y = y + x)
                        {

                            if (!NoPrime.Contains(y))
                            {
                                NoPrime.Add(y);
                            }

                        }

                    }

                    for (int z = 2; z < n; z++)
                    {
                        if (!NoPrime.Contains(z))
                        {
                            Console.WriteLine($"{z}");

                            count = count + z;
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
