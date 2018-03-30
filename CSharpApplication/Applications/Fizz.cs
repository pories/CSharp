using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    public class Fizz
    {
        public static void buzz()
        {
            Console.Clear();
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Fizzbuzz!");
                Console.WriteLine("If a number is divisable by 3 write fizz, by 5 write buzz, and 7 write fizzbuzz.");
                Console.WriteLine("Please enter a number to have fizzbuzz goto!");
                Console.Write("Enter a whole number here: ");

                try
                {
                    int dave = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= dave; i++)
                    {

                        if (i % 3 == 0)
                        {

                            Console.WriteLine("{0} fizz", i);
                        }
                        else if (i % 5 == 0)
                        {

                            Console.WriteLine("{0} buzz", i);
                        }
                        else if (i % 7 == 0)
                        {
                            Console.WriteLine("{0} fizzbuzz", i);
                        }
                        else
                        {
                            Console.WriteLine("{0}", i);

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Did you not put numbers in? The program will only accept numbers.");
                    Console.WriteLine("Here is what went wrong.");
                    Console.WriteLine(ex);
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
