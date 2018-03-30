using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    public class Music
    {
        public static void playMusic()
        {
            bool repeat = true;

            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("Now for some music!");
                Console.WriteLine("Darth Vader's theme!");
                // Imperial March
                Console.Beep(440, 500);
                Console.Beep(440, 500);
                Console.Beep(440, 500);
                Console.Beep(349, 350);
                Console.Beep(523, 150);
                Console.Beep(440, 500);
                Console.Beep(349, 350);
                Console.Beep(523, 150);
                Console.Beep(440, 1000);
                Console.Beep(659, 500);
                Console.Beep(659, 500);
                Console.Beep(659, 500);
                Console.Beep(698, 350);
                Console.Beep(523, 150);
                Console.Beep(415, 500);
                Console.Beep(349, 350);
                Console.Beep(523, 150);
                Console.Beep(440, 1000);


                Console.WriteLine("Ready to hear Close Encounters? Hit any key!");
                Console.ReadKey(true);
                //Close Encounters.
                Console.Beep(900, 400);
                Console.Beep(1000, 400);
                Console.Beep(800, 400);
                Console.Beep(400, 400);
                Console.Beep(600, 1600);

                Console.WriteLine("Ready to hear Mission Impossible? Hit any key!");
                Console.ReadKey(true);
                //Mission Impossible
                Console.Beep(784, 150);
                Console.Beep(784, 150);
                Console.Beep(932, 150);
                Console.Beep(1047, 150);
                Console.Beep(784, 150);
                Console.Beep(784, 150);
                Console.Beep(699, 150);
                Console.Beep(740, 150);
                Console.Beep(784, 150);
                Console.Beep(784, 150);
                Console.Beep(932, 150);
                Console.Beep(1047, 150);
                Console.Beep(784, 150);
                Console.Beep(784, 150);
                Console.Beep(699, 150);
                Console.Beep(740, 150);
                Console.Beep(932, 150);
                Console.Beep(784, 150);
                Console.Beep(587, 1200);
                Console.Beep(932, 150);
                Console.Beep(784, 150);
                Console.Beep(554, 1200);
                Console.Beep(932, 150);
                Console.Beep(784, 150);
                Console.Beep(523, 1200);
                Console.Beep(466, 150);
                Console.Beep(523, 150);

                Console.WriteLine("Ready to hear Super Mario Brothers? Hit any key!");
                Console.ReadKey(true);
                //Super Mario Brothers
                Console.Beep(659, 250);
                Console.Beep(659, 250);
                Console.Beep(659, 300);
                Console.Beep(523, 250);
                Console.Beep(659, 250);
                Console.Beep(784, 300);
                Console.Beep(392, 300);
                Console.Beep(523, 275);
                Console.Beep(392, 275);
                Console.Beep(330, 275);
                Console.Beep(440, 250);
                Console.Beep(494, 250);
                Console.Beep(466, 275);
                Console.Beep(440, 275);
                Console.Beep(392, 275);
                Console.Beep(659, 250);
                Console.Beep(784, 250);
                Console.Beep(880, 275);
                Console.Beep(698, 275);
                Console.Beep(784, 225);
                Console.Beep(659, 250);
                Console.Beep(523, 250);
                Console.Beep(587, 225);
                Console.Beep(494, 225);

                Console.WriteLine("Hope you enjoyed the music! Hit any key!");
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
