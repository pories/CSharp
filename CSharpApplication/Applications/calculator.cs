using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    public class calculator
    {
        public static void numbers()
        {
            double Number1 = 0, Number2 = 0, result;
            int opt = 0;
            bool repeat = true;
            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("Calculator Main Menu");
                Console.WriteLine("Enter the Number of the operation you wish to perform.");
                Console.WriteLine("1. Addition.");
                Console.WriteLine("2. Subtraction.");
                Console.WriteLine("3. Multiplication.");
                Console.WriteLine("4. Division.");
                Console.WriteLine("5. Raise X to power Y.");
                Console.WriteLine("6. Square root of: X.");
                Console.WriteLine("7. Area of a circle: pie R squared.");
                Console.WriteLine("8. Circumference of a circle: 2 Pie R.");
                Console.WriteLine("9. Surface area of sphere: 4 pie R squared.");
                Console.WriteLine("Any silly input will be changed to a 0.");
                Console.Write("Please enter your choice: ");
                try
                {
                    opt = Convert.ToInt32(Console.ReadLine());

                    if (opt >= 1 && opt <= 5)
                    {
                        Console.WriteLine("Please use numbers: 0-9. Any letters will be changed to 0!");
                        Console.Write("Enter the first number: ");

                        string NumberInput1 = Console.ReadLine();
                        double.TryParse(NumberInput1, out Number1);                       

                        Console.Write("Enter the second number: ");

                        string NumberInput2 = Console.ReadLine();
                        double.TryParse(NumberInput2, out Number2); 
                    }
                    else if (opt == 6)  
                    {
                        Console.Write("Enter the number to find it's square root: ");

                        string NumberInput1 = Console.ReadLine();
                        double.TryParse(NumberInput1, out Number1);                  
                    }
                    else if (opt >= 7 && opt <= 9)
                    {
                        Console.Write("Enter the first number: ");
                        string NumberInput1 = Console.ReadLine();
                        double.TryParse(NumberInput1, out Number1);

                    }

                    switch (opt)
                    {

                        case 1:
                            result = Number1 + Number2;
                            if (Number1 == 0 || Number2 == 0)
                            {
                                Console.WriteLine($"If you add {Number1} to {Number2} you get {result:#.##} rounded to two decimal places for accuracy!");
                                break;
                            }

                            else
                            {
                                Console.WriteLine($"If you add {Number1:#.##} to {Number2:#.##} you get {result:#.##} rounded to two decimal places for accuracy!");

                                break;
                            }

                        case 2:

                            result = Number1 - Number2;
                            Console.WriteLine("If you subtract {1} from {0} you get {2:#.##} rounded to two decimal places for accuracy!", Number1, Number2, result);


                            break;


                        case 3:
                            if (Number1 == 0 || Number2 == 0)
                            {

                                Console.WriteLine("Anytime you multiply {0} times {1} you get 0! Anything multiplied by Zero = Zero!!", Number1, Number2);

                                break;
                            }
                            else
                            {
                                result = Number1 * Number2;
                                Console.WriteLine("If you multiply {0} times {1} you get {2:#.##} rounded to two decimal places for accuracy!", Number1, Number2, result);


                                break;
                            }
                        case 4:
                            if (Number1 == 0 || Number2 == 0)
                            {

                                Console.WriteLine("Anytime you devide {0} by {1} you get 0! Anything devided Zero = Zero!!", Number1, Number2);

                                break;
                            }
                            else
                            {
                                result = Number1 / Number2;

                                Console.WriteLine("If you divide {0} by {1} you get {2:#.##} rounded to two decimal places for accuracy!", Number1, Number2, result);

                                break;
                            }


                        case 5:

                            if (Number1 == 0 || Number2 == 0)
                            {

                                Console.WriteLine("If you raise {0} to the power of {1} it is 0! Anytime there is a zero in a powers equation it is zero.", Number1, Number2); //Cheating and hard coded the response. 

                                break;
                            }
                            else
                            {
                                Console.WriteLine("Raise {0} to power {1} is {2:#.##} rounded to two decimal places for accuracy!", Number1, Number2, (Math.Pow(Number1, Number2)));

                                break;
                            }

                        case 6:
                            if (Number1 == 0)
                            {

                                Console.WriteLine("The square root of 0, is zero.");

                                break;
                            }
                            else
                            {

                                Console.WriteLine("The square root of {0} is {1:#.##} rounded to two decimal places for accuracy!", Number1, (Math.Sqrt(Number1)));

                                break;
                            }
                        case 7:
                            if (Number1 == 0)
                            {

                                Console.WriteLine("The area of a circle (pieR2) with a R of 0, is zero.");

                                break;
                            }
                            else
                            {

                                result = Math.PI * (Number1 * Number1);
                                Console.WriteLine("The area of a circle (pieR2) wih a radius of {0} is {1:#.##} rounded to two decimal places for accuracy!", Number1, result);

                                break;
                            }

                        case 8:
                            if (Number1 == 0)
                            {

                                Console.WriteLine("Circumference of a circle with a radius of 0 is zero!");

                                break;
                            }
                            else
                            {
                                result = 2 * Math.PI * Number1;
                                Console.WriteLine("Circumference of a circle with a radius of {0} is: {1:#.##} rounded to two decimal places for accuracy! ", Number1, result);
                                break;
                            }
                        case 9:
                            if (Number1 == 0)
                            {

                                Console.WriteLine("Surface area of sphere with a radius of 0 is zero!");
                                break;
                            }
                            else
                            {

                                result = 4 * Math.PI * (Number1 * Number1);
                                Console.WriteLine("Surface area of sphere with a radius of {0} is {1:#.##} rounded to two decimal places for accuracy!", Number1, result);
                                break;
                            }




                        default: 
                            if (opt != 0)

                            {
                                Console.WriteLine("Invalid option.");

                            }
                            else
                            {
                                Console.WriteLine("End of the program.");

                            }

                            break;
                    }


                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format. Did you use the number keys?");
                    Console.WriteLine("Hit any key to continue.");
                    Console.ReadKey(true);

                }
                catch (OverflowException)
                {
                    Console.WriteLine("Way too large of a number!");
                    Console.WriteLine("Hit any key to continue.");
                    Console.ReadKey(true);
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
                }
                else
                {
                    repeat = false;
                }
            }


        }
    }
}
