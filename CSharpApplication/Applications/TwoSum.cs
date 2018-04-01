using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    public class TwoSum
    {
        public static void doesitadd()
        {

            bool repeat = true;
            while (repeat)
            {
                Console.Clear();
                bool foundit = false;
                int[] myarray = { 1, 3, 5, 7, 11 };
                Console.WriteLine("Let's find a number's location in an array.");
                Console.WriteLine("Remember that an array's location starts at 0!");
                Console.WriteLine("Here are the numbers in the array:");
                foreach (int number in myarray)
                {
                    Console.WriteLine(number);
                }
                Console.WriteLine("Add any two of the numbers above and put their sum below.");
                Console.Write("Please imput the number: ");

                try
                {
                    int number1 = int.Parse(Console.ReadLine());
                    for (int i = 0; i < myarray.Length; i++)
                    {
                        for (int j = i + 1; j < myarray.Length; j++)
                        {
                            if (myarray[i] + myarray[j] == number1)
                            {
                                Console.Write("Found it ");
                                Console.WriteLine($"Found it! The coordinates are: {i} and {j}");
                                foundit = true;
                            }

                        }
                    }
                    if (!foundit)
                    {
                        Console.WriteLine("Couldn't find it! Are you sure you added two numbers together?");
                        Console.WriteLine("Guess it wasn't there!");
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
                }
                else
                {
                    repeat = false;
                }
            }

        }

    }
}

