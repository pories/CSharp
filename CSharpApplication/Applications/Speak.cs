using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    public class Speak
    {
        public static void talking()
        {
            Console.Clear();
            SpeechSynthesizer speakerfortheMachine = new SpeechSynthesizer();
            bool repeat = true;
            while (repeat)
            {

                Console.WriteLine("Would you like a Male voice, or a Female voice?");
                Console.Write("M for male, F for female: ");
                string voicesex = Console.ReadLine();
                if (voicesex == "M" || voicesex == "m")
                {
                    Console.WriteLine("You chose a male voice.");
                    speakerfortheMachine.SelectVoiceByHints(VoiceGender.Male);
                }
                else if (voicesex == "F" || voicesex == "f")
                {
                    Console.WriteLine("You chose a female voice.");
                    speakerfortheMachine.SelectVoiceByHints(VoiceGender.Female);
                }
                else
                {
                    Console.WriteLine("I didn't understand so I will pick neutral. It sounds very female.");
                    speakerfortheMachine.SelectVoiceByHints(VoiceGender.Neutral);
                }

                Console.Write("Now type in something you want the computer to say: ");


                try
                {
                    string PreachIt = Console.ReadLine();
                    speakerfortheMachine.Speak(PreachIt);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Did you not put numbers in? The program will only accept numbers.");
                    Console.WriteLine("Here is what went wrong.");
                    Console.WriteLine(ex);
                }

                Console.WriteLine("Done listening? Hit any key!");
                Console.ReadKey(true);
                Console.Write("Go again? Y/N:");
                string go = Console.ReadLine();
                if (go == "y" || go == "Y")
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