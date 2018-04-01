using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    public class Age
    {
        public static void agePlay()
        {
            Console.Clear();
            DateTime TimeNow = DateTime.Now;
            bool repeat = true;
            while (repeat)
            {
                try
                {
                    Console.Write("Please input your birthday in MM/DD/YY format: ");
                    string MyString = Console.ReadLine();
                    DateTime MyDateTime = DateTime.Parse(MyString);
                    var answerOne = MyDateTime.DayOfWeek;
                    double answertwo = MyDateTime.DayOfYear;
                    double answerthree = (TimeNow - MyDateTime).TotalDays;
                    double answerfour = (TimeNow - MyDateTime).TotalHours;
                    double lucky1 = answertwo / 7;
                    double lucky2 = answerthree / 7;
                    double lucky3 = answerfour / 7;
                    double Unlucky1 = answertwo / 13;
                    double Unlucky2 = answerthree / 13;
                    double Unlucky3 = answerfour / 13;

                    Console.WriteLine("Today is: {0} ", TimeNow.ToLongDateString());
                    Console.WriteLine("You were born on a {0}!", MyDateTime.DayOfWeek);
                    Console.WriteLine("That was the {0} day of that year.", answertwo);
                    Console.WriteLine("Which would make you {0:##.} days old.", answerthree);
                    Console.WriteLine("Which would make you roughly {0:###,###.} hours old.", answerfour);
                    Console.WriteLine("Here is your luck breakdown.");
                    Console.WriteLine("Your lucky day is: {0}.", MyDateTime.DayOfWeek);
                    Console.WriteLine("Your lucky numbers are: ");
                    Console.WriteLine("{0:##.}", lucky1);
                    Console.WriteLine("{0:##.}", answertwo);
                    Console.WriteLine("{0:##.}", lucky2);
                    Console.WriteLine("{0:##.}", answerthree);
                    Console.WriteLine("{0:##.}", lucky3);
                    Console.WriteLine("{0:##.}", answerfour);
                    Console.WriteLine("Your unlucky numbers on a base 13 scale should be: ");
                    Console.WriteLine("{0:##.}", Unlucky1);
                    Console.WriteLine("{0:##.}", Unlucky2);
                    Console.WriteLine("{0:##.}", Unlucky3);
                    Console.WriteLine("Done reading? Hit any key!");
                    Console.ReadKey(true);
                }

                catch (Exception ex) //This is catch all exceptions.
                {
                    Console.WriteLine("If you try again, this time put input in format MM/DD/YY/");
                    Console.WriteLine("Here is what went wrong.");
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